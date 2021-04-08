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
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
        public CustomerView()
        {
            InitializeComponent();
            UzpildytiGrid();
          
        }


   
        private void UzpildytiGrid()
        {
          //  DataGridOfRegisteredPeople.ItemsSource = null;
            DataGridOfRegisteredPeople.ItemsSource = Models.RegisterPeopleList.UserList;   
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
 
            ViewModels.ShellViewModel m = new ViewModels.ShellViewModel();
            m.UzkrautiPuslapi();         
            this.Close();
        }
    }
}
