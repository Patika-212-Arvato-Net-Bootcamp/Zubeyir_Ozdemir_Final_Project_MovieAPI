using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProjectAPI.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "admin1", EmailAddress = "adada.admin@email.com", Password = "admin12345", GivenName = "Ahmet", Surname = "Mehmet", Role = "Administrator" },
            new UserModel() { Username = "admin2", EmailAddress = "wwqeq.admin@email.com", Password = "password12345", GivenName = "Hasan", Surname = "Hüseyin", Role = "Seller" },
        };
    }
}
