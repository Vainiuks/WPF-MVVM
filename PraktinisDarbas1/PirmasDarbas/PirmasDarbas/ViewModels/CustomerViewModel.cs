using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasDarbas.ViewModels
{
    public class CustomerViewModel : Screen
    {
        public List<Models.User> _RegisteredPeople = new List<Models.User>();
        public CustomerViewModel()
        {
            _RegisteredPeople = Models.RegisterPeopleList.UserList;
        }


      

    }
}
