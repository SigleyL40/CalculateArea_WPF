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

namespace WpfAreaCalculationApp
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

        private void btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            string widthValueCheck = tb_Width.Text;
            string heightValueCheck = tb_Height.Text;
            double w = 0;
            double h = 0;
            bool canConvertWidth = double.TryParse(widthValueCheck, out w);
            bool canConvertHeigth = double.TryParse(heightValueCheck, out h);

            // handles the calculate button being clicked without values
            if (!(string.IsNullOrEmpty(widthValueCheck) || string.IsNullOrEmpty(heightValueCheck)))
            {
                if (canConvertWidth == true && canConvertHeigth == true)
                {
                    double area = w * h;
                    string result = string.Format(" {0} x {1} gives an area of {2}\n", w, h, area);
                    tb_results.AppendText(result);
                    tb_Width.Clear();
                    tb_Height.Clear();
                }

                canConvertWidth = false;
                canConvertHeigth = false;

                return;
            }                  
        }
    }
}
