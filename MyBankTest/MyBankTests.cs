using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyBank.Model;
using MyBank.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyBankTest
{

    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestUserConstructor()
        {
            // Arrange
            Guid id = Guid.NewGuid();
            string email = "test@example.com";
            string password = "password1";
            List<Deposite> deposits = new List<Deposite>();
            double balance = 100.0;
            string firstName = "John";
            string lastName = "Doe";
            string middleName = "Middle";
            DateTime birthDate = new DateTime(1990, 1, 1);
            string phone = "1234567890";
            string role = "user";

            // Act
            User user = new User(id, email, password, deposits, balance, firstName, lastName, middleName, birthDate, phone, role);

            // Assert
            Assert.AreEqual(id, user.Id);
            Assert.AreEqual(email, user.Email);
            Assert.AreEqual(password, user.Password);
            Assert.AreEqual(deposits, user.Deposits);
            Assert.AreEqual(balance, user.Balance);
            Assert.AreEqual(firstName, user.FirstName);
            Assert.AreEqual(lastName, user.LastName);
            Assert.AreEqual(middleName, user.MiddleName);
            Assert.AreEqual(birthDate, user.BirthDate);
            Assert.AreEqual(phone, user.Phone);
            Assert.AreEqual(role, user.Role);
        }
    }
    [TestClass]
    public class DepositTests
    {
        [TestMethod]
        public void TestDepositeConstructor()
        {
            // Arrange
            Guid id = Guid.NewGuid();
            DateTime dataStart = DateTime.Now;
            DateTime dataEnd = DateTime.Now.AddDays(30);
            double amount = 1000.0;
            string currency = "USD";
            double depositRate = 0.05;

            // Act
            Deposite deposite = new Deposite
            {
                Id = id,
                DataStart = dataStart,
                DataEnd = dataEnd,
                Amount = amount,
                Currency = currency,
                DepositeRate = depositRate
            };

            // Assert
            Assert.AreEqual(id, deposite.Id);
            Assert.AreEqual(dataStart, deposite.DataStart);
            Assert.AreEqual(dataEnd, deposite.DataEnd);
            Assert.AreEqual(amount, deposite.Amount);
            Assert.AreEqual(currency, deposite.Currency);
            Assert.AreEqual(depositRate, deposite.DepositeRate);
        }
    }
    [TestClass]
    public class DepositTypeTests {

    [TestMethod]
    public void TestDepositeTypeConstructor()
    {
        // Arrange
        double depositRate = 0.05;
        string name = "Savings";
        string currency = "USD";
        Guid id = Guid.NewGuid();

        // Act
        DepositeType depositeType = new DepositeType(depositRate, name, currency, id);

        // Assert
        Assert.AreEqual(depositRate, depositeType.DepositRate);
        Assert.AreEqual(name, depositeType.Name);
        Assert.AreEqual(currency, depositeType.Currency);
        Assert.AreEqual(id, depositeType.Id);
    }

    [TestMethod]
    public void TestDepositeTypeRepository()
    {
        // Arrange
        DepositeTypeRepository repository = DepositeTypeRepository.GetInstance();

        double depositRate = 0.05;
        string name = "Savings";
        string currency = "USD";
        Guid id = Guid.NewGuid();
        DepositeType depositeType = new DepositeType(depositRate, name, currency, id);

        // Act
        repository.CreateDepositeType(depositeType);

        // Assert
        List<DepositeType> depositeTypes = repository.GetDepositeTypes();
        Assert.IsTrue(depositeTypes.Contains(depositeType));

        double newDepositRate = 0.06;
        depositeType.DepositRate = newDepositRate;
        repository.UpdateDepositeType(depositeType);

        // Assert
        depositeTypes = repository.GetDepositeTypes();
        DepositeType updatedDepositeType = depositeTypes.FirstOrDefault(dt => dt.Id == depositeType.Id);
        Assert.IsNotNull(updatedDepositeType);
        Assert.AreEqual(newDepositRate, updatedDepositeType.DepositRate);

        repository.DeleteDepositeType(depositeType.Id.ToString());

        // Assert
        depositeTypes = repository.GetDepositeTypes();
        Assert.IsFalse(depositeTypes.Contains(depositeType));
    }

    [TestMethod]
    public void TestDepositeTypeRepositoryCreateDepositeType()
    {
        // Arrange
        DepositeTypeRepository repository = DepositeTypeRepository.GetInstance();
        List<DepositeType> initialDepositeTypes = repository.GetDepositeTypes();

        double depositRate = 0.05;
        string name = "Savings";
        string currency = "USD";
        Guid id = Guid.NewGuid();
        DepositeType depositeType = new DepositeType(depositRate, name, currency, id);

        // Act
        repository.CreateDepositeType(depositeType);
        List<DepositeType> updatedDepositeTypes = repository.GetDepositeTypes();

        // Assert
        Assert.AreEqual(initialDepositeTypes.Count + 1, updatedDepositeTypes.Count);
        Assert.IsTrue(updatedDepositeTypes.Contains(depositeType));
    }

    [TestMethod]
    public void TestDepositeTypeRepositoryUpdateDepositeType()
    {
        // Arrange
        DepositeTypeRepository repository = DepositeTypeRepository.GetInstance();

        double depositRate = 0.05;
        string name = "Savings";
        string currency = "USD";
        Guid id = Guid.NewGuid();
        DepositeType depositeType = new DepositeType(depositRate, name, currency, id);
        repository.CreateDepositeType(depositeType);

        double updatedDepositRate = 0.06;
        string updatedName = "Fixed Deposit";
        string updatedCurrency = "EUR";
        DepositeType updatedDepositeType = new DepositeType(updatedDepositRate, updatedName, updatedCurrency, id);

        // Act
        repository.UpdateDepositeType(updatedDepositeType);
        List<DepositeType> depositeTypes = repository.GetDepositeTypes();

        // Assert
        Assert.IsTrue(depositeTypes.Contains(updatedDepositeType));
    }

    [TestMethod]
    public void TestDepositeTypeRepositoryDeleteDepositeType()
    {
        // Arrange
        DepositeTypeRepository repository = DepositeTypeRepository.GetInstance();

        double depositRate = 0.05;
        string name = "Savings";
        string currency = "USD";
        Guid id = Guid.NewGuid();
        DepositeType depositeType = new DepositeType(depositRate, name, currency, id);
        repository.CreateDepositeType(depositeType);

        // Act
        repository.DeleteDepositeType(depositeType.Id.ToString());
        List<DepositeType> depositeTypes = repository.GetDepositeTypes();

        // Assert
        Assert.IsFalse(depositeTypes.Contains(depositeType));
    }


}
    [TestClass]
    public class UserRepoTests {

        [TestMethod]
        public void TestUserRepositoryGetUserByEmail()
        {
            // Arrange
            UserRepository repository = UserRepository.GetInstance();
            string email = "user@example4.com";
            Person user = new User(Guid.NewGuid(), email, "password1", new List<Deposite>(), 0, "1234qwerty", "1234qwerty", "1234qwerty", DateTime.Now, "1234qwerty", "1234qwerty");
            repository.Create(user);

            // Act
            Person retrievedUser = repository.GetUserByEmail(email);

            // Assert
            Assert.AreEqual(user, retrievedUser);
        }

        [TestMethod]
        public void TestUserRepositoryCreate()
        {
            // Arrange
            UserRepository repository = UserRepository.GetInstance();
            string email = "user@example.com";
            Person user = new User(Guid.NewGuid(), email, "password1", new List<Deposite>(), 0, "1234qwerty", "1234qwerty", "1234qwerty", DateTime.Now, "1234qwerty", "1234qwetry");

            // Act
            repository.Create(user);
            Person retrievedUser = repository.GetUserByEmail(email);

            // Assert
            Assert.IsNotNull(retrievedUser);
            Assert.AreEqual(email, retrievedUser.Email);
        }

        [TestMethod]
        public void TestUserRepositoryCreateDuplicateUser()
        {
            // Arrange
            UserRepository repository = UserRepository.GetInstance();
            string email = "user@example.com";
            Person user = new User(Guid.NewGuid(), email, "password1", new List<Deposite>(), 0, "1234qwerty", "1234qwerty", "1234qwerty", DateTime.Now, "1234qwerty", "1234qwerty");

            // Act
            repository.Create(user);
            repository.Create(user);
            List<Person> users = repository.GetAll();

            // Assert
            Assert.AreEqual(1, users.Count);
        }

        [TestMethod]
        public void TestUserRepositoryUpdate()
        {
            // Arrange
            UserRepository repository = UserRepository.GetInstance();
            string email = "user@example.com";
            Person user = new User(Guid.NewGuid(), email, "password1", new List<Deposite>(), 0, "1234qwerty", "1234qwerty", "1234qwerty", DateTime.Now, "1234qwerty", "user");
            repository.Create(user);

            user.Role = "admin";

            // Act
            repository.Update(user);
            Person updatedUser = repository.GetUserByEmail(email);

            // Assert
            Assert.AreEqual("admin", updatedUser.Role);
        }

        [TestMethod]
        public void TestUserRepositoryCreateDeposit()
        {
            // Arrange
            UserRepository repository = UserRepository.GetInstance();
            string email = "user@example.com";
            Person user = new User(Guid.NewGuid(), email, "password", new List<Deposite>(), 0, "1234qwerty", "1234qwerty", "1234qwerty2", DateTime.Now, "1234qwerty2", "1234qwerty23");
            repository.Create(user);

            Deposite deposit = new Deposite
            {
                Id = Guid.NewGuid(),
                Amount = 1000,
                DepositeRate = 0.05
            };

            // Act
            repository.CreateDeposit(user, deposit);
            Person updatedUser = repository.GetUserByEmail(email);

            // Assert
            Assert.AreEqual(1, updatedUser.Deposits.Count);
            Assert.IsTrue(updatedUser.Deposits.Contains(deposit));
        }

        [TestMethod]
        public void TestUserRepositoryDeleteDeposit()
        {
            // Arrange
            UserRepository repository = UserRepository.GetInstance();
            string email = "user@example.com";
            Person user = new User(Guid.NewGuid(), email, "password1", new List<Deposite>(), 0, "1234qwerty", "1234qwerty", "1234qwerty", DateTime.Now, "1234qwerty", "1234qwerty");
            repository.Create(user);

            Deposite deposit = new Deposite
            {
                Id = Guid.NewGuid(),
                Amount = 1000,
                DepositeRate = 0.05
            };

            repository.CreateDeposit(user, deposit);

            // Act
            repository.DeleteDeposite(user, deposit.Id);
            Person updatedUser = repository.GetUserByEmail(email);

            // Assert
            Assert.AreEqual(0, updatedUser.Deposits.Count);
            Assert.IsFalse(updatedUser.Deposits.Contains(deposit));
        }
        [TestMethod]
            public void TestUserRepositoryUpdateBalance()
        {
            // Arrange
            UserRepository repository = UserRepository.GetInstance();
            string email = "user@example.com";
            double initialBalance = 1000;
            Person user = new User(Guid.NewGuid(), email, "password", new List<Deposite>(), initialBalance, "", "", "", DateTime.Now, "", "");
            repository.Create(user);

            double updatedBalance = 1500;
            user.Balance = updatedBalance;

            // Act
            repository.Update(user);
            Person updatedUser = repository.GetUserByEmail(email);

            // Assert
            Assert.AreEqual(updatedBalance, updatedUser.Balance);
        }
    }
}