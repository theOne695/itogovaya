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
    /// Логика взаимодействия для obiedinenie.xaml
    /// </summary>
    public partial class obiedinenie : Page
    {
        check_warehouse_product_providerTableAdapter adapter = new check_warehouse_product_providerTableAdapter();
        check_TableAdapter check_TableAdapter = new check_TableAdapter();
        warehouse_product_providerTableAdapter warehouse_ = new warehouse_product_providerTableAdapter();
        public obiedinenie()
        {
            InitializeComponent();
            grid3.ItemsSource = adapter.GetData();
            check_.ItemsSource = check_TableAdapter.GetData();
            check_.DisplayMemberPath = "Айди";
            check_.SelectedValuePath = "Цена";
            product_.ItemsSource = warehouse_.GetData();
            product_.DisplayMemberPath = "Айди";
            product_.SelectedValuePath = "Адрес";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                if (check_.Text != null)
                {
                    if (check_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in check_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            adapter.InsertQuery(check_.SelectedIndex+1, product_.SelectedIndex+1);
                            grid3.ItemsSource = adapter.GetData();
                            check_.Text = "";
                        }
                        else MessageBox.Show("Строка имеет неверный формат");
                    }
                    else MessageBox.Show("Превышен лимит символов, ожидалось 15");
                }
                else MessageBox.Show("Поле не должно быть пустым!");
            }
            else MessageBox.Show("Элемент не выбран");

            if (grid3.SelectedItem != null)
            {
                if (product_.Text != null)
                {
                    if (product_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in product_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            adapter.InsertQuery(check_.SelectedIndex+1, product_.SelectedIndex+1);
                            grid3.ItemsSource = adapter.GetData();
                            product_.Text = "";
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
            if (grid3.SelectedItem != null)
            {
                if (check_.Text != null)
                {
                    if (check_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in check_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            adapter.UpdateQuery(Convert.ToInt32(product_.SelectedValue), Convert.ToInt32(check_.SelectedValue), Convert.ToInt32(id));
                            grid3.ItemsSource = adapter.GetData();
                            check_.Text = "";
                        }
                        else MessageBox.Show("Строка имеет неверный формат");
                    }
                    else MessageBox.Show("Превышен лимит символов, ожидалось 15");
                }
                else MessageBox.Show("Поле не должно быть пустым!");
            }
            else MessageBox.Show("Элемент не выбран");

            if (grid3.SelectedItem != null)
            {
                if (product_.Text != null)
                {
                    if (product_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in product_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            adapter.UpdateQuery(Convert.ToInt32(product_.SelectedValue), Convert.ToInt32(check_.SelectedValue), Convert.ToInt32(id));
                            grid3.ItemsSource = adapter.GetData();
                            product_.Text = "";
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
            if (grid3.SelectedValue != null)
            {
                var value = (grid3.SelectedValue as DataRowView).Row[0];
                adapter.DeleteQuery((int)value);
                grid3.ItemsSource = adapter.GetData();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void grid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid3.SelectedItem != null)
                check_.Text = (grid3.SelectedItem as DataRowView).Row[1].ToString();
                product_.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
        }
    }
}
