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

using Itogovayaa.itogovayaaDataSetTableAdapters;

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        authorization_TableAdapter adapter = new authorization_TableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var alllogin = adapter.GetData().Rows;
            int proverka = 0;

            for (int i = 0; i < alllogin.Count; i++)
            {
                if (alllogin[i][1].ToString() == login.Text && alllogin[i][2].ToString() == password.Password)
                {
                    string roled = (string)alllogin[i][3];

                    switch (roled)
                    {
                        case "Администротор":
                            proverka++;
                            header role = new header();
                            Close();
                            role.Show();
                            break;
                        case "Продавец":
                            proverka++;
                            header2 tovari = new header2();
                            Close();
                            tovari.Show();
                            break;
                        case "Покупатель":
                            proverka++;
                            Window1 obiedinenie = new Window1();
                            Close();
                            obiedinenie.Show();
                            break;

                    }
                }
            }
            if (proverka == 0)
            {
                MessageBox.Show("Неверный ввод данных!");
            }
        }
    }
}
