using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Diplom.OtherClasses
{
    public static class Transfer
    {
        public static Frame frame;

        public static void GoTo(string namePage)
        {
            MessageBox.Show(namePage);
        }
    }
}
