using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PirmasDarbas.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : Window
    {
        int counter = 0;
        public ShellView()
        {
            InitializeComponent();
            PopulateFirstDay();
        }

        public void PopulateFirstDay()
        {
            string CurrentTime = Models.HourList.GetCurrentTime();

            Models.HourList.AddHours();

            foreach (var hour in Models.HourList.Hlist)
            {
                int t1 = Int32.Parse(hour.Replace(":", ""));
                int t2 = Int32.Parse(CurrentTime.Replace(":", ""));      

                if (t1 > t2)
                {
                    ValandosComboBox.Items.Add(hour);
                }
            }

        }

        private void UzkrautiPirmaPuslapi_Click(object sender, RoutedEventArgs e)
        {
           
            ViewModels.ShellViewModel C_View = new ViewModels.ShellViewModel();

                Models.RegisterPeopleList list = new Models.RegisterPeopleList();

            C_View.UzkrautiLista();
            this.Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

            if (ValandosComboBox.SelectedIndex != -1 && Calendar1.SelectedDate.HasValue)
            {
                string Vardas = VardasTxt.Text;
                string Pavarde = PavardeTxt.Text;
                Console.WriteLine(Calendar1.SelectedDate.Value);
                string Data = Calendar1.SelectedDate.Value.ToString("yyyy/MM/dd");
                string TelNr = TelNrTxt.Text;
                string Valanda = (ValandosComboBox.SelectedItem.ToString());

                int ReturnedValue = Models.User.Validacija(Vardas, Pavarde, TelNr, Data, Valanda);

                if (ReturnedValue == -1)
                {
                    MessageBox.Show("Įveskitę Vardą");
                }
                if (ReturnedValue == -2)
                {
                    MessageBox.Show("Įveskitę Pavardę");
                }
                if (ReturnedValue == -3)
                {
                    MessageBox.Show("Telefono numerį gali sudaryti tik skaičiai. Telefono numeris susideda iš 7 skaitmenų");
                }
                if (ReturnedValue == 0)
                {
                    MessageBox.Show("Sėkmingai užsiregistravote");
                }
            }
            else 
            {
                MessageBox.Show("Nepasirinkote datos arba laiko");
            }

        }

        private void Calendar1_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
         
        }
    }
   
}
