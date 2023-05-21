using MyBank.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace MyBank.Repository
{
    public class DepositeTypeRepository
    {
        private static DepositeTypeRepository _instance;
        private Dictionary<string, DepositeType> _depositeTypes = new Dictionary<string, DepositeType>();
        private string _depositeTypeFile;

        public DepositeTypeRepository(string depositeTypeFile)
        {
            _depositeTypeFile = depositeTypeFile;
        }

        public static DepositeTypeRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DepositeTypeRepository("depositeTypes.json");
                _instance.Load();
            }
            return _instance;
        }

        public List<DepositeType> GetDepositeTypes()
        {
            return _depositeTypes.Values.ToList();
        }

        public void CreateDepositeType(DepositeType depositeType)
        {
            if (_depositeTypes.ContainsKey(Convert.ToString(depositeType.Id)))
            {
                MessageBox.Show("Тип депозиту з таким ідентифікатором вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _depositeTypes.Add(Convert.ToString(depositeType.Id), depositeType);
        }

        public void UpdateDepositeType(DepositeType updatedDepositeType)
        {
            if (_depositeTypes.ContainsKey(Convert.ToString(updatedDepositeType.Id)))
            {
                _depositeTypes[Convert.ToString(updatedDepositeType.Id)] = updatedDepositeType;
                Save();
            }
            else
            {
                MessageBox.Show("Тип депозиту з вказаним ідентифікатором не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteDepositeType(string depositeTypeId)
        {
            if (_depositeTypes.ContainsKey(depositeTypeId))
            {
                _depositeTypes.Remove(depositeTypeId);
                Save();
            }
            else
            {
                MessageBox.Show("Тип депозиту з вказаним ідентифікатором не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Save()
        {
            var depositeTypes = _depositeTypes.Values.ToList();

            var jsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var depositeTypeJson = System.Text.Json.JsonSerializer.Serialize(depositeTypes, jsonOptions);

            File.WriteAllText(_depositeTypeFile, depositeTypeJson);
        }

        public void Load()
        {
            if (File.Exists(_depositeTypeFile))
            {
                var depositeTypeJson = File.ReadAllText(_depositeTypeFile);
                var jsonOptions = new JsonSerializerOptions();
                var depositeTypes = System.Text.Json.JsonSerializer.Deserialize<List<DepositeType>>(depositeTypeJson, jsonOptions);
                foreach (var depositeType in depositeTypes)
                {
                    if (!_depositeTypes.ContainsKey(Convert.ToString(depositeType.Id)))
                        _depositeTypes.Add(Convert.ToString(depositeType.Id), depositeType);
                }
            }
        }
    }
}
