using MyBank.Model;
using MyBank.Repository;
using MyBank.User_View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyBank.Model
{
    public class Deposite
    {
        public Guid Id { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public double DepositeRate { get; set; }
    }
}
