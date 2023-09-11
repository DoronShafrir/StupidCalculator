using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace TestColor1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Calc1 calc = new Calc1();
            if (sharedata3 == "Sum")
            {
                calc.Display = (sharedata1 + sharedata2).ToString();
            };

            this.DataContext = calc;

            List<string> itemList = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };

            myList.ItemsSource = itemList;
        }
        public class Calc1
        {
            public int Numb1 { get; set; }
            public int Numb2 { get; set; }
            public string Display { get; set; }
        }
        private int sharedata1;
        private int sharedata2;
        private string sharedata3;





        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            string v1 = Num1.Text;
            string v2 = Num2.Text;
            
            try
            {
                int sum1 = int.Parse(v1);
                int sum2 = int.Parse(v2); 
                Display.Text = (sum1 + sum2).ToString();
            }
            catch
            {
                MessageBox.Show("Input must be digits", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            string v1 = Num1.Text;
            string v2 = Num2.Text;

            try
            {
                int sum1 = int.Parse(v1);
                int sum2 = int.Parse(v2);
                Display.Text = (sum1 - sum2).ToString();
            }
            catch
            {
                MessageBox.Show("Input must be digits", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            string v1 = Num1.Text;
            string v2 = Num2.Text;

            try
            {
                int sum1 = int.Parse(v1);
                int sum2 = int.Parse(v2);
                Display.Text = (sum1 * sum2).ToString();
            }
            catch
            {
                MessageBox.Show("Input must be digits", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Div_Click(object sender, RoutedEventArgs e)
        {
            string v1 = Num1.Text;
            string v2 = Num2.Text;

            try
            {
                float sum1 = float.Parse(v1);
                float sum2 = float.Parse(v2);
                Display.Text = (sum1 / sum2).ToString();
            }
            catch
            {
                MessageBox.Show("Input must be digits", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public bool Validity(string v1, string v2, string v3)
        {

            try
            {
                sharedata1 = int.Parse(v1);
                sharedata2 = int.Parse(v2);
                sharedata3 = v3;
                return true;
            }
            catch
            {
                MessageBox.Show("Input must be digits", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
        
    }
}