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

namespace Itogovayaa
{
    /// <summary>
    /// Логика взаимодействия для sklad.xaml
    /// </summary>
    public partial class sklad : Page
    {
        warehouse_TableAdapter warehouse_ = new warehouse_TableAdapter();
        public sklad()
        {
            InitializeComponent();
            grid3.ItemsSource = warehouse_.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                if (address_.Text != null)
                {
                    if (address_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in address_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            warehouse_.InsertQuery(address_.Text, name_.Text);
                            grid3.ItemsSource = warehouse_.GetData();
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
                if (name_.Text != null)
                {
                    if (name_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in name_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            warehouse_.InsertQuery(address_.Text, name_.Text);
                            grid3.ItemsSource = warehouse_.GetData();
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
                if (address_.Text != null)
                {
                    if (address_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in address_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            warehouse_.UpdateQuery(address_.Text, name_.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = warehouse_.GetData();
                            address_.Text = "";
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
                if (name_.Text != null)
                {
                    if (name_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in name_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            warehouse_.UpdateQuery(address_.Text, name_.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = warehouse_.GetData();
                            address_.Text = "";
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
                warehouse_.DeleteQuery((int)value);
                grid3.ItemsSource = warehouse_.GetData();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void grid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid3.SelectedItem != null)
                address_.Text = (grid3.SelectedItem as DataRowView).Row[1].ToString();
                name_.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
        }
    }
}
