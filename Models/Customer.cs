using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Tutoriall.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
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