using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class AddMainGroupVM
    {
        public MainGroup addedMainGroup { get; set; }

        public Hardware addedHardware { get; set; }

        public AddMainGroupVM()
        {
            addedMainGroup = new MainGroup();
            addedHardware = new Hardware();
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (new RelayCommand(obj =>
                {
                    try
                    {
                        var conn = new ConnectionDB();
                        conn.MainGroup.Add(addedMainGroup);
                        conn.SaveChanges();
                        //conn.Hardware.Add(addedHardware);
                        //conn.SaveChanges();

                       

                        MessageBox.Show("Успешно сохранено");
                        Transfer.GoTo("Основная группа");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Ошибка сохранения: {e}");
                    }

                }));
            }
        }
    }
}
