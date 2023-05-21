using MyBank.Model;
using MyBank.Repository;
using System;
using MyBank.User_View;
using System.Collections.Generic;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Linq;
using System.Text.RegularExpressions;

namespace MyBank.User_View
{
    public partial class DepositeForm : UserControl
    {
        private Person currentUser;
        private Timer balanceUpdateTimer;

        public DepositeForm(Person user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            currentUser = user;
            balanceUpdateTimer = new Timer();
            balanceUpdateTimer.Interval = 1000;
            balanceUpdateTimer.Tick += BalanceUpdateTimer_Tick;
            balanceUpdateTimer.Start();

        }

        private void BalanceUpdateTimer_Tick(object sender, EventArgs e)
        {
            List<Deposite> deposits = (List<Deposite>)depositDataGridView.DataSource;

            foreach (Deposite deposit in deposits.ToList())
            {
                if (DateTime.Now >= deposit.DataEnd)
                {
                    double amountToAdd = deposit.Amount + (deposit.DepositeRate * (deposit.Amount / 100) * (deposit.DataEnd - deposit.DataStart).TotalDays / 365);

                    Person user = UserRepository.GetInstance().GetUserByDeposit(deposit, UserRepository.GetInstance().GetAll());

                    if (user != null)
                    {
                        user.Balance += amountToAdd;
                        UserRepository.GetInstance().Update(user);
                        UserRepository.GetInstance().Save();
                    }

                    UserRepository.GetInstance().DeleteDeposite(user, deposit.Id);
                    LoadDeposits();
                }
            }
        }

        public void SetupDataGridViews()
        {
            List<DepositeType> depositeTypes = DepositeTypeRepository.GetInstance().GetDepositeTypes();

            CB_TypeDeposite.DataSource = depositeTypes;
            CB_TypeDeposite.DisplayMember = "Name";
            CB_TypeDeposite.ValueMember = "Id";
        }

        private void CB_TypeDeposite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_TypeDeposite.SelectedItem is DepositeType selectedDepositeType)
            {
                TXB_DepositeRate.Text = selectedDepositeType.DepositRate.ToString();
                TXB_Currency.Text = selectedDepositeType.Currency;
            }

            if (!string.IsNullOrEmpty(TXB_Amount.Text) && !string.IsNullOrEmpty(TXB_CountMonths.Text))
            {
                if (IsValidDecimal(TXB_Amount.Text) && IsValidInteger(TXB_CountMonths.Text))
                {
                    double amount = Convert.ToDouble(TXB_Amount.Text);
                    int countMonths = Convert.ToInt32(TXB_CountMonths.Text);
                    double profit = amount + Convert.ToDouble(TXB_DepositeRate.Text) * (amount / 100) * (countMonths / 12);
                    TXB_Profit.Text = profit.ToString();
                }
                else
                {
                    MessageBox.Show("Неправильно введені значення суми або кількості місяців.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (!IsValidDecimal(TXB_Amount.Text))
            {
                MessageBox.Show("Неправильний формат суми.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!IsValidInteger(TXB_CountMonths.Text))
            {
                MessageBox.Show("Неправильний формат кількості місяців.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidDecimal(string input)
        {
            return Regex.IsMatch(input, @"^[0-9]+(\.[0-9]+)?$");
        }

        private bool IsValidInteger(string input)
        {
            return Regex.IsMatch(input, @"^[0-9]+$");
        }



        private void BTN_Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXB_Amount.Text != "" && TXB_DepositeRate.Text != "")
                {
                    UserRepository userRepository = UserRepository.GetInstance();
                    Model.User currentUser = (Model.User)userRepository.GetUserByEmail(this.currentUser.Email);

                    double amount;
                    if (!double.TryParse(TXB_Amount.Text, out amount))
                    {
                        MessageBox.Show("Неправильно введене значення суми.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (currentUser.Balance < amount)
                    {
                        MessageBox.Show("Недостатньо коштів на балансі. Створення депозиту неможливе.");
                        return;
                    }

                    int countMonths;
                    if (!int.TryParse(TXB_CountMonths.Text, out countMonths))
                    {
                        MessageBox.Show("Неправильно введене значення кількості місяців.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Deposite newDeposite = new Deposite
                    {
                        Id = Guid.NewGuid(),
                        DataStart = DateTime.Now,
                        DataEnd = DateTime.Now.AddMonths(countMonths),
                        Amount = amount,
                        Currency = TXB_Currency.Text,
                        DepositeRate = Convert.ToDouble(TXB_DepositeRate.Text)
                    };

                    currentUser.Balance -= amount;

                    userRepository.CreateDeposit(currentUser, newDeposite);
                    userRepository.Save();

                    MessageBox.Show("Депозит створено успішно.");

                }
                else
                {
                    MessageBox.Show("Поля не можуть бути порожніми.");
                }
                TXB_Balance.Text = currentUser.Balance.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при створенні депозиту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDeposits();
        }


        private void SetupDepositDataGridView()
        {
            depositDataGridView.AutoGenerateColumns = false;

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ID";

            DataGridViewColumn dataStartColumn = new DataGridViewTextBoxColumn();
            dataStartColumn.DataPropertyName = "DataStart";
            dataStartColumn.HeaderText = "Дата початку";

            DataGridViewColumn dataEndColumn = new DataGridViewTextBoxColumn();
            dataEndColumn.DataPropertyName = "DataEnd";
            dataEndColumn.HeaderText = "Дата закінчення";

            DataGridViewColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = "Amount";
            amountColumn.HeaderText = "Сума";

            DataGridViewColumn currencyColumn = new DataGridViewTextBoxColumn();
            currencyColumn.DataPropertyName = "Currency";
            currencyColumn.HeaderText = "Валюта";

            DataGridViewColumn depositRateColumn = new DataGridViewTextBoxColumn();
            depositRateColumn.DataPropertyName = "DepositeRate";
            depositRateColumn.HeaderText = "Ставка";

            depositDataGridView.Columns.AddRange(idColumn, dataStartColumn, dataEndColumn, amountColumn, currencyColumn, depositRateColumn);

            LoadDeposits();
        }

        private void LoadDeposits()
        {
            depositDataGridView.DataSource = null;

            UserRepository userRepository = UserRepository.GetInstance();
            Model.User currentUser = (Model.User)userRepository.GetUserByEmail(this.currentUser.Email);

            if (currentUser != null)
            {
                depositDataGridView.DataSource = currentUser.Deposits;
            }
            TXB_Balance.Text = currentUser.Balance.ToString();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            if (depositDataGridView.SelectedRows.Count > 0)
            {
                Deposite selectedDeposit = depositDataGridView.SelectedRows[0].DataBoundItem as Deposite;
                Person user = UserRepository.GetInstance().GetUserByDeposit(selectedDeposit, UserRepository.GetInstance().GetAll());

                if (user != null)
                {
                    user.Balance += selectedDeposit.Amount;
                    UserRepository.GetInstance().DeleteDeposite(user, selectedDeposit.Id);

                    LoadDeposits();

                    MessageBox.Show("Депозит успішно закрито. Сума була зарахована на баланс користувача.");
                }
                else
                {
                    MessageBox.Show("Не вдалося знайти пов'язаного користувача для вибраного депозиту.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть депозит для закриття.");
            }
            TXB_Balance.Text = currentUser.Balance.ToString();
        }

        private void DepositeForm_Load(object sender, EventArgs e)
        {
            SetupDepositDataGridView();
            TXB_Balance.Text = currentUser.Balance.ToString();
            SetupDataGridViews();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            MainForm.Instance.SetContent(loginform);
        }

        private void Ci_Click(object sender, EventArgs e)
        {
            UserChangeForm userChangeForm = new UserChangeForm(currentUser);
            MainForm.Instance.SetContent(userChangeForm);
        }
    }
}
