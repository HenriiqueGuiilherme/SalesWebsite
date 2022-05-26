﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebsite.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public  DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; }

        public Seller() { }
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
        }

        public void AddSales(SalesRecord sr)
        {
            SalesRecords.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            SalesRecords.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final) //Total sales amount in this period
        {
            return SalesRecords.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);
        }
    }
}
