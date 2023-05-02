using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp2
{
    public class VirtualDatabase
    {
        public static List<User> Users = new List<User>();

        static VirtualDatabase()
        {
            Users.Add(new User
            {
                Id = 1,
                Name="Orxan",
                Surname="Ferecov",
                Username="OrxanFerecov",
                Password="Orxan12345"
            });

            Users.Add(new User
            {
                Id = 2,
                Name = "Royal",
                Surname = "Memmedov",
                Username = "RoyalMemmedov",
                Password = "Royal12345"
            });

            Users.Add(new User
            {
                Id = 3,
                Name = "Valeh",
                Surname = "Suleymanov",
                Username = "Valeh",
                Password = "Valeh12345"
            });

        }
    }
}
