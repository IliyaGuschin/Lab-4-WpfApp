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

namespace Lab_4_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            Double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate_Euro.Text);
            double sumEuro = Convert.ToDouble(sum_Euro.Text);
            Double resDouble = rateEuro * sumEuro;
            resSumEuro.Text = resDouble.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate_Grivna.Text);
            double sumGrivna = Convert.ToDouble(sum_Grivna.Text);
            Double resDouble = rateGrivna * sumGrivna;
            resSumGrivna.Text = resDouble.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate_Drama.Text);
            double sumDrama = Convert.ToDouble(sum_Drama.Text);
            Double resDouble = rateDrama * sumDrama;
            resSumDrama.Text = resDouble.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double Inches = Convert.ToDouble(InchesToMeters.Text);
            double resDouble = 0.0254 * Inches;
            InchesToMetersTotal.Text = resDouble.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double Feets = Convert.ToDouble(FeetsToMeters.Text);
            double resDouble = 0.348 * Feets;
            FeetsToMetersTotal.Text = resDouble.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double Miles = Convert.ToDouble(MilesToMeters.Text);
            double resDouble = 1069 * Miles;
            MilesToMetersTotal.Text = resDouble.ToString();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        { 
        double Layouts = Convert.ToDouble(LayoutsToMeters.Text);
        double resDouble = 1066 * Layouts;
        LayoutsToMetersTotal.Text = resDouble.ToString();
        }
}
}
