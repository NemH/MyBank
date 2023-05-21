namespace MyBank.Model
{
    using System;
    using System.Collections.Generic;
    using MyBank.Model;
    using MyBank.Repository;
    using MyBank.User_View;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    public abstract class Person
    {
        public abstract Guid Id { get; set; }
        public abstract List<Deposite> Deposits { get; set; }
        public abstract double Balance { get; set; }
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract string MiddleName { get; set; }
        public abstract DateTime BirthDate { get; set; }
        public abstract string Phone { get; set; }
        public abstract string Email { get; set; }
        public abstract string Password { get; set; }
        public abstract string Role { get; set; }

        protected Person(Guid id, string email, string password, List<Deposite> deposits, double balance, string firstName, string lastName, string middleName, DateTime birthDate, string phone, string role)
        {
            Id = id;
            Email = email;
            Password = password;
            Deposits = deposits;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            BirthDate = birthDate;
            Phone = phone;
            Role = role;
        }
    }
}
