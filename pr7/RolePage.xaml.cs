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
    /// Логика взаимодействия для RolePage.xaml
    /// </summary>
    public partial class RolePage : Page
    {
        public RolePage()
        {
            InitializeComponent();
        }

        private void RoleButton_Click(object sender, RoutedEventArgs e)
        {
            switch (RoleBox.SelectedIndex) 
            {
                case 0:
                    this.NavigationService.Navigate(new AdministratorPage());
                    break;
                case 1:
                    this.NavigationService.Navigate(new ManagerPage());
                    break;
                case 2:
                    this.NavigationService.Navigate(new UserPage());    
                    break;
            }

        }
    }
}
