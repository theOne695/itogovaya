﻿using Itogovayaa.itogovayaaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Page
    {
        role_TableAdapter role_ = new role_TableAdapter();
        public AdminWindow()
        {
            InitializeComponent();
            grid1.ItemsSource = role_.GetData();
        }

        private void grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid1.SelectedItem != null)
                name_role.Text = (grid1.SelectedItem as DataRowView).Row[1].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (grid1.SelectedItem != null)
            {
                if (name_role.Text != null)
                {
                    if (name_role.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in name_role.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid1.SelectedItem as DataRowView).Row[0];
                            role_.UpdateQuery(name_role.Text, Convert.ToInt32(id));
                            grid1.ItemsSource = role_.GetData();
                            name_role.Text = "";
                        }
                        else MessageBox.Show("Строка имеет неверный формат");
                    }
                    else MessageBox.Show("Превышен лимит символов, ожидалось 15");
                }
                else MessageBox.Show("Поле не должно быть пустым!");
            }
            else MessageBox.Show("Элемент не выбран");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid1.SelectedItem != null)
            {
                if (name_role.Text != null)
                {
                    if (name_role.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in name_role.Text)
                        {
                            if (!char.IsHighSurrogate(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            role_.InsertQuery(name_role.Text);
                            grid1.ItemsSource = role_.GetData();
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
            if (grid1.SelectedValue != null)
            {
                var value = (grid1.SelectedValue as DataRowView).Row[0];
                role_.DeleteQuery((int)value);
                grid1.ItemsSource = role_.GetData();
            }
            else 
            {
                MessageBox.Show("Неверные данные!");
            }
        }
    }
}
