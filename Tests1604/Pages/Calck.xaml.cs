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
using Library;

namespace Tests1604.Pages
{
    /// <summary>
    /// Логика взаимодействия для Calck.xaml
    /// </summary>
    public partial class Calck : Page
    {
        public Calck()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int OneResult = int.Parse(CalculateTexBoxOne.Text);
            int TwoResult = int.Parse(CalculateTexBoxTwo.Text);
            ResultCalculate.Text = Code.Sum(OneResult, TwoResult);
        }
    }
}
