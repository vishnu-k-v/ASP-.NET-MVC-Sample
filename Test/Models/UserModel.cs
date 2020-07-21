using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class UserModel
    {
        public Account Details { get; set; }
        public ContactModel Contact { get; set; }
    }
}