using MyBank.Model;
using MyBank.Repository;
using MyBank.User_View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyBank.Admin_View
{
    public partial class AdministratorRightsForm : UserControl
    {
        private Person currentUser;

        public AdministratorRightsForm(Person user)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            currentUser = user;
        }

        private void AdministratorRightsForm_Load(object sender, EventArgs e)
        {
            LoadUsersWithRoles();
        }

        private void LoadUsersWithRoles()
        {
            List<Person> usersWithRoles = UserRepository.GetInstance().GetUsersWithRoles();

            rightsDataGrid.AutoGenerateColumns = false;

            DataGridViewColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "Email";
            emailColumn.HeaderText = "Email";

            DataGridViewColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.DataPropertyName = "Role";
            roleColumn.HeaderText = "Роль";

            rightsDataGrid.Columns.Add(emailColumn);
            rightsDataGrid.Columns.Add(roleColumn);

            rightsDataGrid.DataSource = usersWithRoles;
        }

        private void TXB_Delete_Click(object sender, EventArgs e)
        {
            if (rightsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = rightsDataGrid.SelectedRows[0];
                Person selectedUser = selectedRow.DataBoundItem as Person;

                UserRepository userRepository = UserRepository.GetInstance();

                try
                {
                    bool isLastAdmin = selectedUser.Role == "admin" && userRepository.GetAll().Count(u => u.Role == "admin") <= 1;

                    if (isLastAdmin)
                    {
                        MessageBox.Show("Останній адміністратор не може бути видалений.");
                        return;
                    }

                    userRepository.Delete(selectedUser.Email);

                    LoadUsersWithRoles();

                    MessageBox.Show("Користувача успішно видалено.");
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("Користувача не знайдено.");
                }
            }
            else
            {
                MessageBox.Show("Виберіть користувача для видалення.");
            }
        }

        private void BTN_GiveAdmin_Click(object sender, EventArgs e)
        {
            if (rightsDataGrid.SelectedRows.Count > 0)
            {
                Person selectedUser = rightsDataGrid.SelectedRows[0].DataBoundItem as Person;
                AddRoleToUser(selectedUser, "admin");
                MessageBox.Show("Роль адміністратора додано до обраного користувача.");
            }
        }

        private void BTN_GiveManager_Click(object sender, EventArgs e)
        {
            if (rightsDataGrid.SelectedRows.Count > 0)
            {
                Person selectedUser = rightsDataGrid.SelectedRows[0].DataBoundItem as Person;
                AddRoleToUser(selectedUser, "manager");
                MessageBox.Show("Роль менеджера додано до обраного користувача.");
            }
        }

        private void BTN_GiveUser_Click(object sender, EventArgs e)
        {
            if (rightsDataGrid.SelectedRows.Count > 0)
            {
                Person selectedUser = rightsDataGrid.SelectedRows[0].DataBoundItem as Person;
                AddRoleToUser(selectedUser, "user");
                MessageBox.Show("Роль користувача додано до обраного користувача.");
            }
        }

        private void AddRoleToUser(Person user, string role)
        {
            UserRepository userRepository = UserRepository.GetInstance();

            int adminCount = userRepository.GetAll().Count(u => u.Role == "admin");

            bool isUserAdmin = user.Role == "admin";

            if (isUserAdmin && adminCount <= 1)
            {
                MessageBox.Show("Повинен бути принаймні один адміністратор.");
                return;
            }

            if (!isUserAdmin && adminCount == 0)
            {
                user.Role = "admin";
            }
            else
            {
                user.Role = role;
            }

            userRepository.Update(user);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            MainForm.Instance.SetContent(loginform);
        }

        private void DTC_Click(object sender, EventArgs e)
        {
            DepositeTypeForm depositeTypeForm = new DepositeTypeForm(currentUser);
            MainForm.Instance.SetContent(depositeTypeForm);
        }
    }
}
