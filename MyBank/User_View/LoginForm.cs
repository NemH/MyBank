using MyBank.Admin_View;
using MyBank.Manager_View;
using MyBank.Model;
using MyBank.Repository;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyBank.User_View
{
    public partial class LoginForm : UserControl
    {
        public static LoginForm instance;

        public LoginForm()
        {
            InitializeComponent();
        }

        public static LoginForm GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginForm();
            }
            return instance;
        }

        private void BTN_Reg_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            MainForm.Instance.SetContent(registerForm);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Log_Click(object sender, EventArgs e)
        {
            try
            {
                Person user = UserRepository.GetInstance().GetUserByEmail(TXB_Email.Text);

                if (user != null && user.Password == TXB_Pass.Text)
                {
                    if (user.Role == "user")
                    {
                        DepositeForm depositForm = new DepositeForm(user);
                        MainForm.Instance.SetContent(depositForm);
                    }
                    else if (user.Role == "admin")
                    {
                        AdministratorRightsForm administratorRightsForm = new AdministratorRightsForm(user);
                        MainForm.Instance.SetContent(administratorRightsForm);
                    }
                    else
                    {
                        ManagerControlForm managerControlForm = new ManagerControlForm(user);
                        MainForm.Instance.SetContent(managerControlForm);
                    }
                }
                else
                {
                    Label.ForeColor = Color.Red;
                    Label.Text = "Невірний email або пароль";
                }
            }
            catch (Exception ex) { }
        }
    }
}
