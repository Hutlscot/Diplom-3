using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class OtherHardwaresVM
    {
        public List<OtherHardwares> listItem { get; set; }

        public OtherHardwares selectedItem { get; set; }
        public OtherHardwaresVM()
        {
            var conn = new ConnectionDB();
            listItem = conn.OtherHardwares.ToList();
        }

        private RelayCommand commandGoTo;
        public RelayCommand CommandGoTo
        {
            get
            {
                return commandGoTo ?? (new RelayCommand(
                    title =>
                    {
                        Transfer.GoTo(title.ToString());
                    }));
            }
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
                            conn.OtherHardwares.Remove(conn.OtherHardwares.Find(selectedItem.Id));
                            conn.Hardware.Remove(conn.Hardware.Find(selectedItem.Hardware.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("Прочее оборудование");
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
