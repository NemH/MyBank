namespace MyBank.Model
{

    using System.Text.Json.Serialization;
    using System.Text.RegularExpressions;
    using MyBank.Model;
    using MyBank.Repository;
    using MyBank.User_View;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class User : Person
    {
        [JsonConstructor]
        public User(Guid id, string email, string password, List<Deposite> deposits, double balance, string firstName, string lastName, string middleName, DateTime birthDate, string phone, string role) : base(id, email, password, deposits, balance, firstName, lastName, middleName, birthDate, phone, role)
        {
        }

        private Guid _id;
        private List<Deposite> _deposits;
        private double _balance;
        private string _email;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private DateTime _birthDate;
        private string _phone;
        private string _role;

        public override Guid Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public override List<Deposite> Deposits
        {
            get { return _deposits; }
            set { _deposits = value; }
        }
        public override double Balance
        {
            get { return _balance; }
            set
            {
                if (Balance < 0)
                {
                    MessageBox.Show("Баланс не може бути від'ємним.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _balance = value;
                }
            }
        }
        public override string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@") || value.Contains("."))
                {
                    _email = value;
                }
                else
                {
                    MessageBox.Show("Електронна пошта повинна містити символ '@' та домен.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public override string Password
        {
            get { return _password; }
            set
            {
                if (!Regex.IsMatch(value, @"^(?=.*[a-zA-Z])(?=.*\d)") || value.Length < 6 || value.Length > 256)
                {
                    MessageBox.Show("Пароль повинен містити принаймні одну літеру і одну цифру, і бути від 6 до 256 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _password = value;
                }
            }
        }
        public override string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length < 2 || value.Length > 32)
                {
                    MessageBox.Show("Ім'я повинно містити від 2 до 32 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _firstName = value;
                }
            }
        }
        public override string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length < 2 || value.Length > 32)
                {
                    MessageBox.Show("Прізвище повинно містити від 2 до 32 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _lastName = value;
                }
            }
        }
        public override string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value.Length < 2 || value.Length > 32)
                {
                    MessageBox.Show("По Батькові повинно містити від 2 до 32 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _middleName = value;
                }
            }
        }
        public override DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public override string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
            }
        }
        public override string Role
        {
            get { return _role; }
            set
            {
                _role = value;
            }
        }
    }
}
