using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasDarbas.Models
{
    public class RegisterPeopleList
    {
        public static List<User> UserList = new List<User>();

     
        public RegisterPeopleList()
        {

                UserList.Add(new User("Vainius", "Daraškevičius", "2021/04/10", "08:00", "+37069523144"));
                UserList.Add(new User("Petras", "Petrauskas", "2021/04/10", "09:00", "+37069523145"));
                UserList.Add(new User("Jonas", "Jonaitis", "2021/04/11", "14:00", "+37069523146"));
   
        }



    }
}
