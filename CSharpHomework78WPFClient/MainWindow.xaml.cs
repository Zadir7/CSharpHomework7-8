using CSharpHomework7_8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using static CSharpHomework78WPFClient.AccessAPI;

namespace CSharpHomework78WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
            SetBindings();
        }
        public async void SetBindings()
        {
            List<Employee> employees = await GetData<List<Employee>>(client.BaseAddress + "api/employees/getemployees");
            List<Department> departments = await GetData<List<Department>>(client.BaseAddress + "api/departments/getdepartments");
            EmployeeGrid.ItemsSource = employees;
            DepartmentGrid.ItemsSource = departments;
        }

        private void EmployeeGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowDetails(EmployeeGrid.SelectedItem);
        }
        private void DepartmentGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowDetails(DepartmentGrid.SelectedItem);
        }
        private void ShowDetails(object item)
        {
            Details d = new Details(item);
            d.Show();
        }
    }
}
