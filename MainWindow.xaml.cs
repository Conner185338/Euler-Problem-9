/*
 * Conner Warboys
 * Project Euler Problem 9
 * May 12th, 2019
 * ICS3U
*/
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

namespace _185338PythagoreanTriplet
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            /*int a = 0;
            int b = 0;
            int c = 0;*/

            for (int a = 0; a < 1001; a++)
            {
                for (int b = 0; b < 1001; b++)
                {
                    for (int c = 0; c < 1001; c++)
                    {
                        if (a < b && b < c && a + b + c == 1000 && a * a + b * b == c * c)
                        {
                            lblOuput.Content = a + Environment.NewLine + b + Environment.NewLine + c;
                        }
                    }
                }
            } 
        }
    }
}
