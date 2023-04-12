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
    /// Логика взаимодействия для check.xaml
    /// </summary>
    public partial class check : Page
    {
        check_TableAdapter check_ = new check_TableAdapter();
        warehouse_TableAdapter warehouse_ = new warehouse_TableAdapter();
        client_TableAdapter client_ = new client_TableAdapter();

        public check()
        {
            InitializeComponent();
            grid3.ItemsSource = check_.GetData();
            staff_.ItemsSource = warehouse_.GetData();
            staff_.DisplayMemberPath = "Фамилия";
            staff_.SelectedValuePath = "Айди";
            client_id_.ItemsSource = client_.GetData();
            client_id_.DisplayMemberPath = "Адрес";
            client_id_.SelectedValuePath = "Айди";
        }

        private void grid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                cost_.Text = (grid3.SelectedItem as DataRowView).Row[1].ToString();
                money_deposited_.Text = (grid3.SelectedItem as DataRowView).Row[2].ToString();
                change_.Text = (grid3.SelectedItem as DataRowView).Row[3].ToString();
                data_.Text = (grid3.SelectedItem as DataRowView).Row[4].ToString();
                staff_.Text = (grid3.SelectedItem as DataRowView).Row[5].ToString();
                client_id_.Text = (grid3.SelectedItem as DataRowView).Row[6].ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid3.SelectedItem != null)
            {
                if (cost_.Text != null)
                {
                    if (cost_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in cost_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            check_.InsertQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text));
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
                if (money_deposited_.Text != null)
                {
                    if (money_deposited_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in money_deposited_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            check_.InsertQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text));
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
                if (change_.Text != null)
                {
                    if (change_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in change_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            check_.InsertQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text));
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
                if (staff_.Text != null)
                {
                    if (staff_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in staff_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            check_.InsertQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text));
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
                if (client_id_.Text != null)
                {
                    if (client_id_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in client_id_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            check_.InsertQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text));
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
                if (cost_.Text != null)
                {
                    if (cost_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in cost_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            check_.UpdateQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text), Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            cost_.Text = "";
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
                if (money_deposited_.Text != null)
                {
                    if (money_deposited_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in money_deposited_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            check_.UpdateQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text), Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            money_deposited_.Text = "";
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
                if (change_.Text != null)
                {
                    if (change_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in change_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            check_.UpdateQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text), Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            change_.Text = "";
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
                if (staff_.Text != null)
                {
                    if (staff_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in staff_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            check_.UpdateQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text), Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            staff_.Text = "";
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
                if (client_id_.Text != null)
                {
                    if (client_id_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in client_id_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid3.SelectedItem as DataRowView).Row[0];
                            check_.UpdateQuery(Convert.ToInt32(cost_.Text), Convert.ToInt32(money_deposited_.Text), Convert.ToInt32(change_.Text), data_.Text, Convert.ToInt32(staff_.Text), Convert.ToInt32(client_id_.Text), Convert.ToInt32(id));
                            grid3.ItemsSource = client_.GetData();
                            client_id_.Text = "";
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
