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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = new alex_kEntities1();
            var users = x.Users.Where((user) => user.Login == Login1.Text && user.Password == Password1.Password).ToList();
            if (users.Count > 0)
            {

               Console.WriteLine(x.userType.Find(users[0].Type).name);
                if(x.userType.Find(users[0].Type).name == "user")
                {
                    NavigationService.Navigate(new Posle(users[0]));
                   
                }
                else
                {
                    NavigationService.Navigate(new forAdmin(users[0]));
                }
                
            }
            else
            {
                 MessageBox.Show("user not found");
            }

        }
    }
}
