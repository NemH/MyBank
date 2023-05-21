using MyBank.Model;
using System.Text.Json;
using System.Text.RegularExpressions;
using MyBank.Model;
using MyBank.Repository;
using MyBank.User_View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace MyBank.Repository
{
    public class UserRepository : IUserRepository<Person>
    {
        public static UserRepository _instance;
        public Dictionary<string, Person> _users = new Dictionary<string, Person>();
        public Dictionary<string, Deposite> _deposits = new Dictionary<string, Deposite>();
        public string _userFile;

        private UserRepository(string userFile, string depositFile)
        {
            _userFile = userFile;
            _users = new Dictionary<string, Person>();
            _deposits = new Dictionary<string, Deposite>();
        }

        public UserRepository()
        {
        }

        public static UserRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserRepository("users.json", "deposits.json");
                _instance.Load();
            }
            return _instance;
        }

        public Person GetUserByEmail(string email)
        {
            return _users.Values.FirstOrDefault(u => u.Email == email);
        }
        public void Create(Person user)
        {
            if (_users.ContainsKey(user.Email))
            {
                MessageBox.Show("Об'єкт з таким логіном вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(user.Password))
            {
                MessageBox.Show("Невірний пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_users.Count == 0)
            {
                user.Role = "admin";
            }
            else
            {
                user.Role = "user";
            }

            _users.Add(user.Email, user);
            MessageBox.Show("Користувач успішностворений", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 6 || password.Length > 256)
            {
                return false;
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)"))
            {
                return false;
            }

            return true;
        }



        public void Update(Person user)
        {
            if (!_users.ContainsKey(Convert.ToString(user.Id)))
            {
            }
            else
            {
                if (_users[Convert.ToString(user.Id)].Role == "admin" && AdminCount() <= 1 && user.Role != "admin")
                {
                    user.Role = "admin";
                }
                _users[Convert.ToString(user.Id)] = user;
            }
        }


        public void Delete(string email)
        {
            if (!_users.Remove(email))
            {
                MessageBox.Show("Не знайдено об'єкт із вказаним логіном.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (AdminCount() <= 1 && _users[email].Role != "admin")
                    _users.Remove(email);
            }
        }

        public List<Person> GetAll()
        {
            return _users.Values.ToList();
        }

        public List<Deposite> GetAllDeposits()
        {
            return _deposits.Values.ToList();
        }

        public List<Person> GetUsersWithRoles()
        {
            return _users.Values.Where(u => !string.IsNullOrEmpty(u.Role)).ToList();
        }

        public Person GetUserByDeposit(Deposite deposit, List<Person> users)
        {
            foreach (Person user in users)
            {
                foreach (Deposite userDeposit in user.Deposits)
                {
                    if (userDeposit.Id == deposit.Id)
                    {
                        return user;
                    }
                }
            }

            return null;
        }

        public void Save()
        {
            var users = _users.Values.Where(u => u is Model.User).Cast<Model.User>().ToList();

            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var userJson = System.Text.Json.JsonSerializer.Serialize(users, jsonOptions);

            var backupUserDirectory = "backup";
            var backupUserFileName = Path.Combine(backupUserDirectory, GetBackupFileName(_userFile));

            Directory.CreateDirectory(backupUserDirectory);

            File.WriteAllText(backupUserFileName, File.ReadAllText(_userFile));

            File.WriteAllText(_userFile, userJson);
        }

        public void Load()
        {
            if (File.Exists(_userFile))
            {
                var userJson = File.ReadAllText(_userFile);
                var jsonOptions = new JsonSerializerOptions();
                var users = System.Text.Json.JsonSerializer.Deserialize<List<Model.User>>(userJson, jsonOptions);
                foreach (var user in users)
                {
                    if (!_users.ContainsKey(user.Email))
                        _users.Add(user.Email, user);

                    foreach (var deposit in user.Deposits)
                    {
                        if (!_deposits.ContainsKey(deposit.Id.ToString()))
                            _deposits.Add(deposit.Id.ToString(), deposit);
                    }
                }
            }
        }

        private string GetBackupFileName(string originalFileName)
        {
            var backupFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + originalFileName;
            return backupFileName;
        }

        private int AdminCount()
        {
            int count = 0;
            foreach (var user in _users.Values)
            {
                if (user.Role == "admin")
                {
                    count++;
                }
            }
            return count;
        }

        public void CreateDeposit(Person user, Deposite deposit)
        {
            bool userExists = _users.Any(entry => entry.Value.Email == user.Email);

            if (!userExists)
            {
                MessageBox.Show("Не знайдено користувача з вказаною електронною адресою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Person existingUser = _users[user.Email];

            existingUser.Deposits.Add(deposit);
            _deposits.Add(deposit.Id.ToString(), deposit);

            Update(existingUser);
        }

        public void DeleteDeposite(Person user, Guid depositeId)
        {
            if (!_users.ContainsKey(user.Email))
            {
                MessageBox.Show("Не знайдено користувача з вказаною електронною адресою.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var existingDeposite = user.Deposits.FirstOrDefault(d => d.Id == depositeId);
            if (existingDeposite == null)
            {
                MessageBox.Show("Не знайдено депозит із вказаним ID.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            user.Deposits.Remove(existingDeposite);
            _deposits.Remove(depositeId.ToString());

            Update(user);
        }

    }
}