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
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Page
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (pass.Text == povt.Text && pass.Text !="")
            {
                
                MessageBox.Show("Вы авторизовались");
                
            }
            else
            {
                MessageBox.Show("Пароль введён неправильно");
            }
            if (pass.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль");
            }
            var db = new alex_kEntities1();
            var user = new Users();
            user.Login= Login1.Text;
            user.Password = pass.Text;
            db.Users.Add(user);
            db.SaveChanges();

        }
    }
}
