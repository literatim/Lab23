﻿using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}