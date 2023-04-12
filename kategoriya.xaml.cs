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
    /// Логика взаимодействия для kategoriya.xaml
    /// </summary>
    public partial class kategoriya : Page
    {
        product_TableAdapter adapter = new product_TableAdapter();
        subcategory_TableAdapter subcategory = new subcategory_TableAdapter();
        public kategoriya()
        {
            InitializeComponent();
            grid3.ItemsSource = adapter.GetData();
            sub_.ItemsSource = subcategory.GetData();
            sub_.DisplayMemberPath = "Наименование";
            sub_.SelectedValuePath = "Айди";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                if (count.Text != null)
                {
                    if (count.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in count.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            adapter.InsertQuery(count.Text, sub_.SelectedIndex + 1);
                            grid3.ItemsSource = adapter.GetData();
                            count.Text = "";
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
                if (sub_.Text != null)
                {
                    if (sub_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in sub_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            adapter.InsertQuery(count.Text, sub_.SelectedIndex + 1);
                            grid3.ItemsSource = adapter.GetData();
                            sub_.Text = "";
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
                if (count.Text != null)
                {
                    if (count.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in count.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            adapter.UpdateQuery(count.Text, Convert.ToInt32(sub_.SelectedValue), Convert.ToInt32(id));
                            grid3.ItemsSource = adapter.GetData();
                            count.Text = "";
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
                if (sub_.Text != null)
                {
                    if (sub_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in sub_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            adapter.UpdateQuery(count.Text, Convert.ToInt32(sub_.SelectedValue), Convert.ToInt32(id));
                            grid3.ItemsSource = adapter.GetData();
                            sub_.Text = "";
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

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                count.Text = (grid3.SelectedItem as DataRowView).Row[1].ToString();
                sub_.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
            }
        }
    }
}
