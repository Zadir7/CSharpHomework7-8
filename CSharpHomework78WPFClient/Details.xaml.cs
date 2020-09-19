using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSharpHomework78WPFClient
{
    /// <summary>
    /// Логика взаимодействия для EmployeeDetails.xaml
    /// </summary>
    public partial class Details : Window
    {
        public Details(object item)
        {
            InitializeComponent();
            List<object> list = new List<object>();
            list.Add(item);
            DetailGrid.ItemsSource = list;
        }
    }
}
