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

namespace Dynamit
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

        private void btnNitro_Click(object sender, RoutedEventArgs e)
        {
            double C = 12.01, H = 1.01, N = 14.01, O = 16;

            double totalWeight = C * 3 + H * 5 + N * 3 + O * 9;


            MessageBox.Show($" Molekylärvikten för nitroglycerin är: {Convert.ToInt16(totalWeight)}");

            MessageBox.Show($" Det korrekta värdet är: {totalWeight}");
        }

        private void btnDynamite_Click(object sender, RoutedEventArgs e)
        {
            // fick inspiration till denna från gammla Val tentan
            int totalInput = int.Parse(txtDynamite.Text);
            char[] bombLenght = new char[totalInput];
            for (int i = 0; i < totalInput; i++)
            {
                bombLenght[i] = 'O';
            }
            if (totalInput<=0)
            {
                txtBomb.Text = "Pfft!";
            }
            else
            {
                //https://stackoverflow.com/questions/1324009/net-c-sharp-convert-char-to-string för att konvertera arrayen
                string bomb = new string(bombLenght);
                txtBomb.Text = $"B{bomb}M!";
            }

        }

        private void btnMoreMolecules_Click(object sender, RoutedEventArgs e)
        {
            //CalculateMolecularWeight("C3H5N3O9");
        }

        // har inte tid att göra klart uppgift 9 tyvärr
        // jag kommenterar bort denna metod så det inte finns några error

        //public double CalculateMolecularWeight(string molecules) 
        //{
        //    char[] values = new char[molecules.Length];
        //    for (int i = 0; i < molecules.Length; i++)
        //    {
                
        //        if (char.IsLetter(values[i]))
        //        {
        //            //GetAtomicWeight * char.IsDigit(values[i]);
                    
        //        }
        //    }
        //}

        public static double GetAtomicWeight(char atom)
        {
            return atom switch
            {
                'C' => 12.0107,
                'H' => 1.00794,
                'N' => 14.0067,
                'O' => 15.9994,
                'S' => 32.065,
                _ => 0,
            };
        }

    }
}
