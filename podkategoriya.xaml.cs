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
    /// Логика взаимодействия для podkategoriya.xaml
    /// </summary>
    public partial class podkategoriya : Page
    {
        subcategory_TableAdapter subcategory = new subcategory_TableAdapter();
        product_category_TableAdapter product_Category = new product_category_TableAdapter();
        public podkategoriya()
        {
            InitializeComponent();
            grid2.ItemsSource = subcategory.GetData();
            categ_.ItemsSource = product_Category.GetData();
            categ_.DisplayMemberPath = "Наименование";
            categ_.SelectedValuePath = "Айди";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (grid2.SelectedItem != null)
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
                            subcategory.InsertQuery(name_.Text, categ_.SelectedIndex + 1);
                            grid2.ItemsSource = subcategory.GetData();
                            name_.Text = "";
                        }
                        else MessageBox.Show("Строка имеет неверный формат");
                    }
                    else MessageBox.Show("Превышен лимит символов, ожидалось 15");
                }
                else MessageBox.Show("Поле не должно быть пустым!");
            }
            else MessageBox.Show("Элемент не выбран");

            if (grid2.SelectedItem != null)
            {
                if (categ_.Text != null)
                {
                    if (categ_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in categ_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            subcategory.InsertQuery(name_.Text, categ_.SelectedIndex + 1);
                            grid2.ItemsSource = subcategory.GetData();
                            categ_.Text = "";
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
            if (grid2.SelectedItem != null)
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
                            object id = (grid2.SelectedItem as DataRowView).Row[0];
                            subcategory.UpdateQuery(name_.Text, Convert.ToInt32(categ_.SelectedValue), Convert.ToInt32(id));
                            grid2.ItemsSource = subcategory.GetData();
                            name_.Text = "";
                        }
                        else MessageBox.Show("Строка имеет неверный формат");
                    }
                    else MessageBox.Show("Превышен лимит символов, ожидалось 15");
                }
                else MessageBox.Show("Поле не должно быть пустым!");
            }
            else MessageBox.Show("Элемент не выбран");

            if (grid2.SelectedItem != null)
            {
                if (categ_.Text != null)
                {
                    if (categ_.Text.Length <= 15)
                    {
                        int check = 0;
                        foreach (var i in categ_.Text)
                        {
                            if (!char.IsLetter(i))
                            {
                                check++;
                            }
                        }
                        if (check == 0)
                        {
                            object id = (grid2.SelectedItem as DataRowView).Row[0];
                            subcategory.UpdateQuery(name_.Text, Convert.ToInt32(categ_.SelectedValue), Convert.ToInt32(id));
                            grid2.ItemsSource = subcategory.GetData();
                            categ_.Text = "";
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
            if (grid2.SelectedValue != null)
            {
                var value = (grid2.SelectedValue as DataRowView).Row[0];
                subcategory.DeleteQuery((int)value);
                grid2.ItemsSource = subcategory.GetData();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid2.SelectedItem != null)
            {
                name_.Text = (grid2.SelectedItem as DataRowView).Row[1].ToString();
                categ_.Text = (grid2.SelectedItem as DataRowView).Row[2].ToString();
            }
        }
    }
}
