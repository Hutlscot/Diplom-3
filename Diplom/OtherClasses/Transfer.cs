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
                case "Кабинеты":
                {
                    frame.Navigate(new ListCabitensPage());
                    break;
                }
                case "История учета":
                {
                    frame.Navigate(new HistoryPage());
                    break;
                }
                case "Оборудование":
                {
                    frame.Navigate(new ListHardwarePage());
                    break;
                }
                case "Добавление кабинета":
                {
                    frame.Navigate(new AddCabinetPage());
                    break;
                }
                case "Добавление записи":
                {
                    frame.Navigate(new AddHistoryPage());
                    break;
                }
                case "Основная группа":
                    {
                        frame.Navigate(new MainGroupPage());
                        break;
                    }
                case "Добавление пк":
                    {
                        frame.Navigate(new AddMainGroupPage());
                        break;
                    }
                case "Принтеры":
                    {
                        frame.Navigate(new PrintersPage());
                        break;
                    }
                case "Добавление принтера":
                    {
                        frame.Navigate(new AddPrinterPage());
                        break;
                    }
                case "Расходники":
                    {
                        frame.Navigate(new ConsumablesPage());
                        break;
                    }
                case "Добавление расходников":
                    {
                        frame.Navigate(new AddConsumablePage());
                        break;
                    }
                case "Прочее оборудование":
                    {
                        frame.Navigate(new OtherHardwaresPage());
                        break;
                    }
                case "Добавление прочего оборудования":
                    {
                        frame.Navigate(new AddOtherhardwarePage());
                        break;
                    }


                default:
                    {
                        MessageBox.Show("not fount");
                        break;
                    }
            }
        }
    }
}
