using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class ContactModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]

        public int Phonenumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }
    }
}