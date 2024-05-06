using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization
{
    public static class Users
    {
        public static List<Person> GetUsers()
        {
            //StreamReader sr = new StreamReader("D:\\ис21\\Autorization-master\\Autorization-master\\Autorization\\Users.txt");
            List<Person> accounts = new List<Person> { 
                new Person { Name="Батыр", Surname="Дауров", Fathername="Хусейнович", Role="Админ", UriPath="ryan.jpg" }, 
                new Person { Name="Света", Surname = "Бузмакова", Fathername = "Александровна", Role = "Программист", UriPath = "ryan.jpg" },
                new Person { Name="Ариша", Surname = "Харитонова", Fathername = "Андреевна", Role = "Дизайнер", UriPath = "margo.jpeg" },
                new Person {Name="Алина", Surname = "Харитонова", Fathername = "Андреевна", Role = "Верстальщик", UriPath = "margo.jpeg" },
            };
            /*Person account = new Person();
            string line = sr.ReadLine();
            int i = 0;
            while (line != null)
            {
                i++; 
                string[] temp = line.Split(';');

                account.Surname = temp[0];
                account.Name = temp[1];
                account.Fathername = temp[2];
                account.Role = temp[3];

                accounts.Add(account);

                if (temp[4] != "none") account.UriPath = temp[4];
            }
            sr.Close();*/
            return accounts;
        }
        
    }
}
