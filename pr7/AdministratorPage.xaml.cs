using System;
using System.Collections.Generic;
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

namespace pr7
{
    /// <summary>
    /// Логика взаимодействия для AdministratorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Page
    {
        public Employee employee=new Employee();
        public List<Employee> employees{ get; set; }
        public AdministratorPage()
        {
            InitializeComponent();
            employees = new List<Employee>();
            EmployeeDG.ItemsSource = employees;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow(EmployeeDG.AlternationCount);
            add.ShowDialog();

            employees.Add(add.employee);
            employee.addEmployee(add.employee);
            MessageBox.Show(employee.employees.Count.ToString());
            EmployeeDG.ItemsSource = null;
            EmployeeDG.ItemsSource = employees;
            
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeDG.SelectedItem is Employee selectEmployee)
            {
                AddWindow add = new AddWindow(selectEmployee);
                add.ShowDialog();
                employees[EmployeeDG.SelectedIndex] =add.employee;
                employee.employees[EmployeeDG.SelectedIndex] = add.employee;
                EmployeeDG.ItemsSource = null;
                EmployeeDG.ItemsSource = employees;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeDG.SelectedItem is Employee selectEmployee)
            { 
                employees.Remove(selectEmployee);
                employee.employees.Remove(selectEmployee);
                EmployeeDG.ItemsSource = null;
                EmployeeDG.ItemsSource = employees;
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления");
            }
        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SortBox.SelectedIndex)
            { 
             case 0:
                    employees=employees.OrderBy(emp => emp.LastName).ThenBy(emp=>emp.Age).ToList();
             break;
             case 1:
                    employees = employees.OrderByDescending(emp=>emp.LastName).ThenByDescending(emp=>emp.Age).ToList();
                    break;
            }
            EmployeeDG.ItemsSource= employees;
        }
    }
}
