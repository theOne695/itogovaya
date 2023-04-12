using Itogovayaa.itogovayaaDataSetTableAdapters;
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

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для s_p_p.xaml
    /// </summary>
    public partial class s_p_p : Page
    {
        warehouse_product_providerTableAdapter adapter = new warehouse_product_providerTableAdapter();
        provider_TableAdapter provider_ = new provider_TableAdapter();
        warehouse_TableAdapter warehouse_ = new warehouse_TableAdapter();
        product_category_TableAdapter _product_ = new product_category_TableAdapter();
        public s_p_p()
        {
            InitializeComponent();
            grid3.ItemsSource = adapter.GetData();
            check_.ItemsSource = provider_.GetData();
            check_.DisplayMemberPath = "Айди";
            check_.SelectedValuePath = "Адрес";
            product_.ItemsSource = warehouse_.GetData();
            product_.DisplayMemberPath = "Айди";
            product_.SelectedValuePath = "Адрес";
            ware_.ItemsSource = _product_.GetData();
            ware_.DisplayMemberPath = "Айди";
            ware_.SelectedValuePath = "Цена";
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
                            adapter.InsertQuery(check_.SelectedIndex + 1, product_.SelectedIndex + 1, ware_.SelectedIndex+1);
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
                            adapter.InsertQuery(check_.SelectedIndex + 1, product_.SelectedIndex + 1, ware_.SelectedIndex + 1);
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

            if (grid3.SelectedItem != null)
            {
                if (ware_.Text != null)
                {
                    if (ware_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in ware_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            adapter.InsertQuery(check_.SelectedIndex + 1, product_.SelectedIndex + 1, ware_.SelectedIndex + 1);
                            grid3.ItemsSource = adapter.GetData();
                            ware_.Text = "";
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
                            adapter.UpdateQuery(Convert.ToInt32(product_.SelectedValue), Convert.ToInt32(check_.SelectedValue), Convert.ToInt32(ware_.SelectedValue), Convert.ToInt32(id));
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
                            adapter.UpdateQuery(Convert.ToInt32(product_.SelectedValue), Convert.ToInt32(check_.SelectedValue), Convert.ToInt32(ware_.SelectedValue), Convert.ToInt32(id));
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

            if (grid3.SelectedItem != null)
            {
                if (ware_.Text != null)
                {
                    if (ware_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in ware_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            adapter.UpdateQuery(Convert.ToInt32(product_.SelectedValue), Convert.ToInt32(check_.SelectedValue), Convert.ToInt32(ware_.SelectedValue), Convert.ToInt32(id));
                            grid3.ItemsSource = adapter.GetData();
                            ware_.Text = "";
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
            {
                check_.Text = (grid3.SelectedItem as DataRowView).Row[1].ToString();
                product_.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
                ware_.Text = (grid3.SelectedItem as DataRowView).Row[3].ToString();
            }
        }
    }
}
