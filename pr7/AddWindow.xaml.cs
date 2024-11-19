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
using System.Windows.Shapes;

namespace pr7
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public Employee employee {  get; set; }
        public int count;
        public AddWindow( int count)
        {
            InitializeComponent();
            this.count = count;
            
        }
        public AddWindow(Employee employee)
        {
            InitializeComponent();
            this.count = count-1;
            NameBox.Text = employee.FirstName;
            LastBox.Text = employee.LastName;
            AgeBox.Text=employee.Age.ToString();
            PositionBox.Text=employee.Position;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            employee = new Employee
            {

                Id = count + 1,
                FirstName = NameBox.Text,
                LastName = LastBox.Text,
                Age = Convert.ToInt32(AgeBox.Text),
                Position = PositionBox.Text

            };
            MessageBox.Show(employee.Id.ToString());
            this.Close();
        }
    }
}
