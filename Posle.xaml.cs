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
    /// Логика взаимодействия для Posle.xaml
    /// </summary>
    public partial class Posle : Page
    {
        private Users user;
        public Posle(Users user)
        {
            this.user = user;
            InitializeComponent();
            UserName.Content = $"{user.Login}";
            Password.Content = $"{user.Password}";
            UserMenu.Content = "user";
        }
    }
}
