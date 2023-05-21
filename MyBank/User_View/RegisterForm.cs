using MyBank.Model;
using MyBank.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyBank.User_View
{
    public partial class RegisterForm : UserControl
    {

        public static RegisterForm instance;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BTN_Log_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            MainForm.Instance.SetContent(loginform);
        }
        private void BTN_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                List<Deposite> deposits = new List<Deposite>();
                Guid id = Guid.NewGuid();
                User newUser = new User(
                    id,
                    TXB_Mail.Text,
                    TXB_Pass.Text,
                    deposits,
                    0.00,
                    TXB_Fname.Text,
                    TXB_Lname.Text,
                    TXB_Sname.Text,
                    Convert.ToDateTime(DTP.Text),
                    TXB_Phone.Text,
                    "user");
                UserRepository.GetInstance().Create(newUser);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
