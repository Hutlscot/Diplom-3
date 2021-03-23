using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Diplom.View;

namespace Diplom.OtherClasses
{
    public static class Transfer
    {
        public static Frame frame;

        public static void GoTo(string namePage)
        {
            switch (namePage)
            {
                case "Добавление сотрудника":
                {
                    frame.Navigate(new AddWorkerPage());
                    break;
                }
                case "Сотрудники":
                {
                    frame.Navigate(new ListWorkersPage());
                    break;
                }
            }
        }
    }
}
