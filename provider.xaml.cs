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
    /// Логика взаимодействия для provider.xaml
    /// </summary>
    public partial class provider : Page
    {
        provider_TableAdapter provider_ = new provider_TableAdapter();
        public provider()
        {
            InitializeComponent();
            grid3.ItemsSource = provider_.GetData();
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
                            provider_.InsertQuery(address_.Text, phone_.Text, contact_.Text);
                            grid3.ItemsSource = provider_.GetData();
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
                if (phone_.Text != null)
                {
                    if (phone_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in phone_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            provider_.InsertQuery(address_.Text, phone_.Text, contact_.Text);
                            grid3.ItemsSource = provider_.GetData();
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
                if (contact_.Text != null)
                {
                    if (contact_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in contact_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            provider_.InsertQuery(address_.Text, phone_.Text, contact_.Text);
                            grid3.ItemsSource = provider_.GetData();
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
                            provider_.UpdateQuery(address_.Text, phone_.Text, contact_.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = provider_.GetData();
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
                if (phone_.Text != null)
                {
                    if (phone_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in phone_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            provider_.UpdateQuery(address_.Text, phone_.Text, contact_.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = provider_.GetData();
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
                if (contact_.Text != null)
                {
                    if (contact_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in contact_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            provider_.UpdateQuery(address_.Text, phone_.Text, contact_.Text, Convert.ToInt32(id));
                            grid3.ItemsSource = provider_.GetData();
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
                provider_.DeleteQuery((int)value);
                grid3.ItemsSource = provider_.GetData();
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
                phone_.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
                contact_.Text = (grid3.SelectedItem as DataRowView).Row[3].ToString();
        }
    }
}
