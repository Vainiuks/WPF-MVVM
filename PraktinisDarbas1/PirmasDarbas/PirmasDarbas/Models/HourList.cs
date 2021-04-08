using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasDarbas.Models
{
   public class HourList
    {
        public static List<string> Hlist = new List<string>();

        public static void AddHours()
        {
            Hlist.Clear();

            Hlist.Add("08:00");
            Hlist.Add("09:00");
            Hlist.Add("10:00");
            Hlist.Add("11:00");
            Hlist.Add("12:00");
            Hlist.Add("14:00");
            Hlist.Add("15:00");
            Hlist.Add("16:00");
            Hlist.Add("17:00");
            Hlist.Add("18:00");
            Hlist.Add("19:00");

        }

        public static string GetCurrentTime()
        {
            string CurrentHourMinute = DateTime.Now.ToString("HH:mm");

       

            return CurrentHourMinute;


        }
    }
}
