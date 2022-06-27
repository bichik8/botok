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

namespace botok
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

        double value_in_tb = 0;
        int value_slider = 0;



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cb.SelectedItem == mk)
            {
                metr_in_kilom();
                value_in_tb = 0;
            }
            if (cb.SelectedItem == km)
            {
                kilom_in_metr();
                value_in_tb = 0;
            }
        }
         private void metr_in_kilom()
        {
            value_slider = Int32.Parse(val.Text);
            value_in_tb = Double.Parse(tb.Text);
            tb_Copy.Text = (Convert.ToString(Math.Round((value_in_tb * 3.6), value_slider))) + " км/с";
        }

        private void kilom_in_metr()
        {
            value_slider = Int32.Parse(val.Text);
            value_in_tb = Double.Parse(tb.Text);
            tb_Copy.Text = (Convert.ToString(Math.Round((value_in_tb / 3.6), value_slider))) + " м/с";
        }

        
    }
}
