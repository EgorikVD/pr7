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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public List<Employee> employees { get; set; }
        
        public UserPage()
        {
            InitializeComponent();
            Employee employee= new Employee();
           
            employees = employee.employees;
            EmployeeDG.ItemsSource =employees;
        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SortBox.SelectedIndex)
            {
                case 0:
                    employees = employees.OrderBy(emp => emp.LastName).ThenBy(emp => emp.Age).ToList();
                    break;
                case 1:
                    employees = employees.OrderByDescending(emp => emp.LastName).ThenByDescending(emp => emp.Age).ToList();
                    break;
            }
            EmployeeDG.ItemsSource = null;
            EmployeeDG.ItemsSource = employees;
        }
    }
}
