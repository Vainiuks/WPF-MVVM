using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PirmasDarbas.Models
{
    public class User
    {
        private string _Vardas;
        private string _Pavarde;
        private string _Data;
        private string _Valanda;
        private string _TelNumeris;

        public User(string Vardas1, string Pavarde1, string Data1, string Valanda1, string TelNumeris1)
        {
            Vardas = Vardas1;
            Pavarde = Pavarde1;
            Data = Data1;
            Valanda = Valanda1;
            Telefono_numeris = TelNumeris1;
        }

        public string Vardas { get => _Vardas; set => _Vardas = value; }
        public string Pavarde { get => _Pavarde; set => _Pavarde = value; }
        public string Data { get => _Data; set => _Data = value; }
        public string Valanda { get => _Valanda; set => _Valanda = value; }
        public string Telefono_numeris { get => _TelNumeris; set => _TelNumeris = value; }



        public static int Validacija(string Vardas, string Pavarde, string TelNumeris, string Data, string Valanda)
        {
            if (Vardas == String.Empty)
            {
                return -1;
            }
            if (Pavarde == String.Empty)
            {
                return -2;
            }        
            if (TelNumeris == String.Empty || !Regex.IsMatch(TelNumeris, "^[0-9]*$") || TelNumeris.Length != 7)
            {

                return -3;
            }
            Models.RegisterPeopleList.UserList.Add(new Models.User(Vardas, Pavarde, Data, Valanda, "+3706"+TelNumeris));
            return 0;
        }

      
    }
}
