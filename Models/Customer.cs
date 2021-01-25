﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Tutoriall.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Customer()
        {

        }
        public Customer(int id, string name, string address, int age)
        {
            ID = id;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}