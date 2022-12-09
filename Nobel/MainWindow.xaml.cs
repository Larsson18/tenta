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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nobel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Dinner dinner = new Dinner();
        Person person = new Person();
        private void btnDinner_Click(object sender, RoutedEventArgs e)
        {
            // gör numren till en string och drar in dom när jag kallar på metoden
            string A = "1203", B = "11", C = "12340";
            dinner.GetSeatNumber(A);
            dinner.GetSeatNumber(B);
            dinner.GetSeatNumber(C);
        }

        private void btnWinner_Click(object sender, RoutedEventArgs e)
        {
            dinner.GetWinners(2022);
        }

        private void btnSecretGuest_Click(object sender, RoutedEventArgs e)
        {
            dinner.FindSecretGuest();
            
        }

        private void btnShowGuest_Click(object sender, RoutedEventArgs e)
        {
            lstGuests.ItemsSource = null;
            lstGuests.ItemsSource = dinner.Guests;
        }




    }
}
