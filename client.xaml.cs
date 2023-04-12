using Itogovayaa.itogovayaaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
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
    /// Логика взаимодействия для client.xaml
    /// </summary>
    public partial class client : Page
    {
        client_TableAdapter client_ = new client_TableAdapter();
        public client()
        {
            InitializeComponent();
            grid3.ItemsSource = client_.GetData();
        }

        private void grid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid3.SelectedItem != null)
                sur_name_.Text = (grid3.SelectedItem as DataRowView).Row[1].ToString();
                _name_.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
                otchestvo.Text = (grid3.SelectedItem as DataRowView).Row[3].ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                if (sur_name_.Text != null)
                {
                    if (sur_name_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in sur_name_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            client_.InsertQuery(sur_name_.Text, _name_.Text, otchestvo.Text);
                            grid3.ItemsSource = client_.GetData();
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
                if (_name_.Text != null)
                {
                    if (_name_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in _name_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            client_.InsertQuery(sur_name_.Text, _name_.Text, otchestvo.Text);
                            grid3.ItemsSource = client_.GetData();
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
                if (otchestvo.Text != null)
                {
                    if (otchestvo.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in otchestvo.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            client_.InsertQuery(sur_name_.Text, _name_.Text, otchestvo.Text);
                            grid3.ItemsSource = client_.GetData();
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
                if (sur_name_.Text != null)
                {
                    if (sur_name_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in sur_name_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            client_.UpdateQuery(sur_name_.Text, _name_.Text, otchestvo.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            sur_name_.Text = "";
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
                if (_name_.Text != null)
                {
                    if (_name_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in _name_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            client_.UpdateQuery(sur_name_.Text, _name_.Text, otchestvo.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            _name_.Text = "";
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
                if (otchestvo.Text != null)
                {
                    if (otchestvo.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in otchestvo.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            client_.UpdateQuery(sur_name_.Text, _name_.Text, otchestvo.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            otchestvo.Text = "";
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
                client_.DeleteQuery((int)value);
                grid3.ItemsSource = client_.GetData();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }
    }
}
