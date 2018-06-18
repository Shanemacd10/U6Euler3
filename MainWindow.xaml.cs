/*Project Euler 3
 * Shane MacDonald
 * June 18, 2018
 * Calculated the largest prime factor of 600851475143
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

namespace U6Euler3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number = 600851475143;
        double temp;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 2; i < Math.Floor(Math.Sqrt(number)); i++)
            {
                temp = 0;
                if(number % i == 0)
                {
                    number = number / i;
                    temp = i;
                }
                if(temp != 0)
                {
                    lblOutput.Content = number.ToString();
                }
            }
        }
    }
}
