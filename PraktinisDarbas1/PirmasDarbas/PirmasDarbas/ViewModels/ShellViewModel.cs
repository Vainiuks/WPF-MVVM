using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasDarbas.ViewModels
{
   public class ShellViewModel : Conductor<object>
    {

        public void UzkrautiLista()
        {
            var Wmanager = new WindowManager();
            CustomerViewModel customer_view_model = new CustomerViewModel();
            Wmanager.ShowWindow(customer_view_model);
        }

        public void UzkrautiPuslapi()
        {
            var Wmanager = new WindowManager();
            ShellViewModel shell_view_model = new ShellViewModel();
            Wmanager.ShowWindow(shell_view_model);
        }

      


    }
}
