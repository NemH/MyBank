using MyBank.Model;
using MyBank.Repository;
using MyBank.User_View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyBank.Admin_View
{
    public partial class DepositeTypeForm : UserControl
    {
        private Person currentUser;

        public DepositeTypeForm(Person user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            currentUser = user;
            SetupDataGridViews();
        }

        private BindingSource _depositeType;

        private void SetupDataGridViews()
        {
            depositDataGridView.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            depositDataGridView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.HeaderText = "Назва";
            nameColumn.DataPropertyName = "Name";
            depositDataGridView.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn depositRateColumn = new DataGridViewTextBoxColumn();
            depositRateColumn.Name = "DepositRate";
            depositRateColumn.HeaderText = "Ставка";
            depositRateColumn.DataPropertyName = "DepositRate";
            depositDataGridView.Columns.Add(depositRateColumn);

            DataGridViewTextBoxColumn currencyColumn = new DataGridViewTextBoxColumn();
            currencyColumn.Name = "Currency";
            currencyColumn.HeaderText = "Валюта";
            currencyColumn.DataPropertyName = "Currency";
            depositDataGridView.Columns.Add(currencyColumn);

            List<DepositeType> depositeTypes = DepositeTypeRepository.GetInstance().GetDepositeTypes();

            depositDataGridView.DataSource = depositeTypes;
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            string name = TXB_Name.Text.Trim();
            string depositRateText = TXB_DepositeRate.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Будь ласка, введіть дійсну назву типу депозиту.");
                return;
            }

            if (!double.TryParse(depositRateText, out double depositRate))
            {
                MessageBox.Show("Будь ласка, введіть дійсну ставку для типу депозиту.");
                return;
            }

            DepositeType newDepositeType = new DepositeType();
            newDepositeType.Id = Guid.NewGuid();
            newDepositeType.Name = name;
            newDepositeType.DepositRate = depositRate;
            newDepositeType.Currency = TXB_Currency.Text;

            DepositeTypeRepository depositeTypeRepository = DepositeTypeRepository.GetInstance();

            try
            {
                depositeTypeRepository.CreateDepositeType(newDepositeType);
                MessageBox.Show("Тип депозиту успішно створено.");
                SetupDataGridViews();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DepositeTypeForm_Load(object sender, EventArgs e)
        {
            SetupDataGridViews();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            MainForm.Instance.SetContent(loginform);
        }

        private void ARC_Click(object sender, EventArgs e)
        {
            AdministratorRightsForm administratorRightsForm = new AdministratorRightsForm(currentUser);
            MainForm.Instance.SetContent(administratorRightsForm);
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (depositDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = depositDataGridView.SelectedRows[0];

                string name = TXB_Name.Text.Trim();
                string depositRateText = TXB_DepositeRate.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Будь ласка, введіть дійсну назву типу депозиту.");
                    return;
                }

                if (!double.TryParse(depositRateText, out double depositRate))
                {
                    MessageBox.Show("Будь ласка, введіть дійсну ставку для типу депозиту.");
                    return;
                }

                DepositeType selectedDepositeType = (DepositeType)selectedRow.DataBoundItem;

                selectedDepositeType.Name = TXB_Name.Text;
                selectedDepositeType.DepositRate = Convert.ToDouble(TXB_DepositeRate.Text);
                selectedDepositeType.Currency = TXB_Currency.Text;

                DepositeTypeRepository.GetInstance().UpdateDepositeType(selectedDepositeType);

                MessageBox.Show("Тип депозиту успішно оновлено.");
                SetupDataGridViews();
            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (depositDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = depositDataGridView.SelectedRows[0];

                DepositeType selectedDepositeType = (DepositeType)selectedRow.DataBoundItem;

                DepositeTypeRepository.GetInstance().DeleteDepositeType(Convert.ToString(selectedDepositeType.Id));

                MessageBox.Show("Тип депозиту успішно видалено.");
                SetupDataGridViews();
            }
        }

        private void SelUpd(object sender, EventArgs e)
        {
            if (depositDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = depositDataGridView.SelectedRows[0];
                DepositeType selectedDepositeType = (DepositeType)selectedRow.DataBoundItem;

                TXB_Name.Text = selectedDepositeType.Name;
                TXB_DepositeRate.Text = selectedDepositeType.DepositRate.ToString();
                TXB_Currency.Text = selectedDepositeType.Currency;
            }
        }
    }
}
