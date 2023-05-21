using MyBank.Model;
using MyBank.Repository;
using System.Windows.Forms;
using System;

namespace MyBank.User_View
{
    public partial class UserChangeForm : UserControl
    {
        private Person currentUser;

        public UserChangeForm(Person user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            currentUser = user;
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            currentUser.FirstName = TXB_Fname.Text;
            currentUser.LastName = TXB_Lname.Text;
            currentUser.Email = TXB_Mail.Text;
            currentUser.Password = TXB_Pass.Text;
            currentUser.MiddleName = TXB_Sname.Text;
            currentUser.Balance = Convert.ToDouble(TXB_Balance.Text);
            currentUser.Phone = TXB_Phone.Text;

            UserRepository.GetInstance().Update(currentUser);
            MessageBox.Show("Інформацію про користувача успішно оновлено.");
        }

        private void DC_Click(object sender, EventArgs e)
        {
            DepositeForm depositeForm = new DepositeForm(currentUser);
            MainForm.Instance.SetContent(depositeForm);
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            MainForm.Instance.SetContent(loginform);
        }
        private void UserChangeForm_Load(object sender, EventArgs e)
        {
            TXB_Fname.Text = currentUser.FirstName;
            TXB_Lname.Text = currentUser.LastName;
            TXB_Mail.Text = currentUser.Email;
            TXB_Pass.Text = currentUser.Password;
            TXB_Sname.Text = currentUser.MiddleName;
            TXB_Balance.Text = currentUser.Balance.ToString();
            TXB_Phone.Text = currentUser.Phone;
        }
    }
}

