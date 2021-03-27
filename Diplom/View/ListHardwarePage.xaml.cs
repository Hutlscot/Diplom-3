using Diplom.VM;
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

namespace Diplom.View
{
    /// <summary>
    /// Логика взаимодействия для ListHardwarePage.xaml
    /// </summary>
    public partial class ListHardwarePage : Page
    {
        private List<Hardware> sortedHardware { get; set; }
        public ListHardwarePage()
        {
            InitializeComponent();
            var conn = new ConnectionDB();
            sortedHardware = conn.Hardware.ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = (sender as TextBox).Text;
            grid.ItemsSource = sortedHardware.Where(x => x.SerialNumber.Contains(text)).ToList();
        }
    }
}
