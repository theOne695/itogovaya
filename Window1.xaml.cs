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

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            obiedinenie obiedinenie = new obiedinenie();
            MyFrame.Content = obiedinenie;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new obiedinenie();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new s_p_p();
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new sklad();
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new provider();
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new check();
        }

        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new client();
        }
    }
}
