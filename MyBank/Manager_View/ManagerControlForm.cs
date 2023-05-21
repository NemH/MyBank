using MyBank.Model;
using MyBank.Repository;
using MyBank.User_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace MyBank.Manager_View
{
    public partial class ManagerControlForm : UserControl
    {
        private Timer balanceUpdateTimer;
        private Person currentUser;
        private UserRepository userRepository;

        public ManagerControlForm(Person user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            currentUser = user;
            userRepository = new UserRepository();

            SetupDataGridView();
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
                    UpLoad();
                }
            }
        }

        private void CB_DepositType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_TypeDeposite.SelectedItem is DepositeType selectedDepositeType)
            {
                TXB_DepositeRate.Text = selectedDepositeType.DepositRate.ToString();
                TXB_Currency.Text = selectedDepositeType.Currency;
            }
            if (!string.IsNullOrEmpty(TXB_Amount.Text) && !string.IsNullOrEmpty(TXB_CountMonths.Text))
            {
                double amount;
                int countMonths;

                if (double.TryParse(TXB_Amount.Text, out amount) && int.TryParse(TXB_CountMonths.Text, out countMonths))
                {
                    if (amount >= 0 && countMonths > 0)
                    {
                        amount = Convert.ToDouble(TXB_Amount.Text);
                        countMonths = Convert.ToInt32(TXB_CountMonths.Text);
                        double profit = (amount + Convert.ToDouble(TXB_DepositeRate.Text) * (amount / 100) * countMonths )/ 12;
                        TXB_Profit.Text = profit.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Неправильно введені значення суми або кількості місяців.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно введені значення суми або кількості місяців.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            if (TXB_Amount.Text != "" && TXB_DepositeRate.Text != "")
            {
                if (userGridView.CurrentRow?.DataBoundItem is Person selectedUser)
                {
                    double amount = Convert.ToDouble(TXB_Amount.Text);
                    if (selectedUser.Balance < amount)
                    {
                        MessageBox.Show("Недостатньо коштів. Створення депозиту не вдалося.");
                        return;
                    }

                    Deposite newDeposite = new Deposite
                    {
                        Id = Guid.NewGuid(),
                        DataStart = DateTime.Now,
                        DataEnd = DateTime.Now.AddMonths(Convert.ToInt32(TXB_CountMonths.Text)),
                        Amount = amount,
                        Currency = TXB_Currency.Text,
                        DepositeRate = Convert.ToDouble(TXB_DepositeRate.Text)
                    };

                    selectedUser.Balance -= amount;

                    UserRepository.GetInstance().CreateDeposit(selectedUser, newDeposite);
                    UserRepository.GetInstance().Save();

                    MessageBox.Show("Депозит створено успішно.");

                    UpLoad();
                }
                else
                {
                    MessageBox.Show("Будь ласка, виберіть користувача.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі обов'язкові поля.");
            }
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
                    UserRepository.GetInstance().Save();

                    MessageBox.Show("Депозит успішно закрито. Сума була зарахована на баланс користувача.");

                    UpLoad();
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

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (userGridView.SelectedRows.Count > 0)
            {
                Person selectedUser = userGridView.SelectedRows[0].DataBoundItem as Person;

                selectedUser.FirstName = TXB_Fname.Text;
                selectedUser.LastName = TXB_Lname.Text;
                selectedUser.Email = TXB_Mail.Text;
                selectedUser.Password = TXB_Pass.Text;
                selectedUser.MiddleName = TXB_Sname.Text;
                selectedUser.Balance = Convert.ToDouble(TXB_Balance.Text);
                selectedUser.Phone = TXB_Phone.Text;

                UserRepository.GetInstance().Update(selectedUser);

                UpLoad();

                MessageBox.Show("Інформацію про користувача оновлено успішно.");
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть користувача для оновлення.");
            }
        }

        private void userGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (userGridView.SelectedRows.Count > 0)
            {
                Person selectedUser = userGridView.SelectedRows[0].DataBoundItem as Person;

                TXB_Fname.Text = selectedUser.FirstName;
                TXB_Lname.Text = selectedUser.LastName;
                TXB_Mail.Text = selectedUser.Email;
                TXB_Pass.Text = selectedUser.Password;
                TXB_Sname.Text = selectedUser.MiddleName;
                TXB_Balance.Text = selectedUser.Balance.ToString();
                TXB_Phone.Text = selectedUser.Phone;
            }
            else
            {
                TXB_Fname.Text = string.Empty;
                TXB_Lname.Text = string.Empty;
                TXB_Mail.Text = string.Empty;
                TXB_Pass.Text = string.Empty;
                TXB_Sname.Text = string.Empty;
                TXB_Balance.Text = string.Empty;
                TXB_Phone.Text = string.Empty;
            }

        }

        private void depositDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (depositDataGridView.SelectedRows.Count > 0)
            {
                Deposite selectedDeposit = depositDataGridView.SelectedRows[0].DataBoundItem as Deposite;
                dateTimePickerS.Value = selectedDeposit.DataStart;
                dateTimePickerE.Value = selectedDeposit.DataEnd;
                textBoxDepositRate.Text = selectedDeposit.DepositeRate.ToString();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            MainForm.Instance.SetContent(loginform);
        }

        private void SetupDataGridView()
        {
            List<Deposite> deposits = UserRepository.GetInstance().GetAllDeposits();

            depositDataGridView.AutoGenerateColumns = false;

            DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ID";

            DataGridViewColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.DataPropertyName = "Amount";
            amountColumn.HeaderText = "Сума";

            DataGridViewColumn currencyColumn = new DataGridViewTextBoxColumn();
            currencyColumn.DataPropertyName = "Currency";
            currencyColumn.HeaderText = "Валюта";

            depositDataGridView.Columns.AddRange(idColumn, amountColumn, currencyColumn);

            depositDataGridView.DataSource = deposits;

            List<DepositeType> depositTypes = DepositeTypeRepository.GetInstance().GetDepositeTypes();

            CB_TypeDeposite.DataSource = depositTypes;
            CB_TypeDeposite.DisplayMember = "Name";
            CB_TypeDeposite.ValueMember = "Id";

            userGridView.AutoGenerateColumns = false;
            List<Person> musers = UserRepository.GetInstance().GetAll();

            DataGridViewColumn firstNameColumn = new DataGridViewTextBoxColumn();
            firstNameColumn.DataPropertyName = "FirstName";
            firstNameColumn.HeaderText = "Ім'я";

            DataGridViewColumn lastNameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn.DataPropertyName = "LastName";
            lastNameColumn.HeaderText = "Прізвище";

            DataGridViewColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Електронна пошта";

            DataGridViewColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.DataPropertyName = "Password";
            passwordColumn.HeaderText = "Пароль";

            DataGridViewColumn middleNameColumn = new DataGridViewTextBoxColumn();
            middleNameColumn.DataPropertyName = "MiddleName";
            middleNameColumn.HeaderText = "По-батькові";

            DataGridViewColumn balanceColumn = new DataGridViewTextBoxColumn();
            balanceColumn.DataPropertyName = "Balance";
            balanceColumn.HeaderText = "Баланс";

            DataGridViewColumn phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.DataPropertyName = "Phone";
            phoneColumn.HeaderText = "Телефон";

            userGridView.Columns.AddRange(firstNameColumn, lastNameColumn, emailColumn,
                                          passwordColumn, middleNameColumn, balanceColumn,
                                          phoneColumn);

            userGridView.DataSource = musers;
            depositDataGridView.SelectionChanged += depositDataGridView_SelectionChanged;

        }

        private void UpLoad()
        {
            List<Deposite> deposits = UserRepository.GetInstance().GetAllDeposits();

            depositDataGridView.DataSource = deposits;

            List<DepositeType> depositTypes = DepositeTypeRepository.GetInstance().GetDepositeTypes();

            CB_TypeDeposite.DataSource = depositTypes;
            CB_TypeDeposite.DisplayMember = "Name";
            CB_TypeDeposite.ValueMember = "Id";

            List<Person> musers = UserRepository.GetInstance().GetAll();

            userGridView.DataSource = musers;
            depositDataGridView.SelectionChanged += depositDataGridView_SelectionChanged;
        }
    }
}
