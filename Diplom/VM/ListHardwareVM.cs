using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace Diplom.VM
{
    public class ListHardwareVM
    {
        public List<Hardware> ListHardwares { get; set; }

        public Hardware selectedHardware { get; set; }

        public ListHardwareVM()
        {
            var conn = new ConnectionDB();
            ListHardwares = conn.Hardware.ToList();
        }

        private RelayCommand delCommand;
        public RelayCommand DelCommand
        {
            get
            {
                return delCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                            var conn = new ConnectionDB();
                            conn.Hardware.Remove(conn.Hardware.Find(selectedHardware.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("Оборудование");
                            MessageBox.Show("Успешно удалено");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show($"Ошибка удаления {e}");
                        }

                    }));
            }
        }
    }
}