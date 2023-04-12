using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;
using Itogovayaa.itogovayaaDataSetTableAdapters;

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для tovari.xaml
    /// </summary>
    public partial class tovari : Page
    {
        product_category_TableAdapter product_Category = new product_category_TableAdapter();

        public tovari()
        {
            InitializeComponent();
            grid.ItemsSource = product_Category.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                if (kategoria.Text != null)
                {
                    if (kategoria.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in kategoria.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            product_Category.InsertQuery(kategoria.Text);
                            grid.ItemsSource = product_Category.GetData();
                            kategoria.Text = "";
                        }
                        else MessageBox.Show("Строка имеет неверный формат");
                    }
                    else MessageBox.Show("Превышен лимит символов, ожидалось 15");
                }
                else MessageBox.Show("Поле не должно быть пустым!");
            }
            else MessageBox.Show("Элемент не выбран");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                if (kategoria.Text != null)
                {
                    if (kategoria.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in kategoria.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid.SelectedItem as DataRowView).Row[1];
                            product_Category.UpdateQuery(kategoria.Text, Convert.ToInt32(id));
                            grid.ItemsSource = product_Category.GetData();
                            kategoria.Text = "";
                        }
                        else MessageBox.Show("Строка имеет неверный формат");
                    }
                    else MessageBox.Show("Превышен лимит символов, ожидалось 15");
                }
                else MessageBox.Show("Поле не должно быть пустым!");
            }
            else MessageBox.Show("Элемент не выбран");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedValue != null)
            {
                var value = (grid.SelectedValue as DataRowView).Row[1];
                product_Category.DeleteQuery((int)value);
                grid.ItemsSource = product_Category.GetData();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                kategoria.Text = (grid.SelectedItem as DataRowView).Row[0].ToString();
            }
        }
    }
}
