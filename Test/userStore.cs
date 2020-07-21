using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Models;

namespace Test
{
    public  class userStore
    {
        public static List<UserModel> userModels = new List<UserModel>();
       public void Add(UserModel data)
        {
            userModels.Add(data);
        }
        public UserModel Get(string email, string Password)
        {
            UserModel userdetails = userModels.Where(data => data.Details.Password == Password && data.Details.UserName == email).FirstOrDefault(); 
            return userdetails;
        }
    }
}