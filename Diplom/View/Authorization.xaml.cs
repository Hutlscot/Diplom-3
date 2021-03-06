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

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var conn = new ConnectionDB();
            var user = conn.Users.FirstOrDefault(x => x.Login == login.Text && x.Password == password.Password);
            if (user == null)
            { 
                MessageBox.Show("не верные данные");
                return;
            }
            else
            {
                var application = new MainWindow();
                application.Show();
                Close();
            }


        }
    }
}
