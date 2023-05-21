using MyBank.Model;
using MyBank.Repository;
using MyBank.User_View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json.Serialization;

namespace MyBank.Model
{
    public class DepositeType
    {
        public DepositeType()
        {
        }
        [JsonConstructor]
        public DepositeType(double depositRate, string name, string currency, Guid id)
        {
            DepositRate = depositRate;
            Name = name;
            Currency = currency;
            Id = id;
        }

        public double DepositRate { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public Guid Id { get; set; }
    }

}
