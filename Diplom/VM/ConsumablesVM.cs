using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class ConsumablesVM
    {
        public List<Consumables> listItem { get; set; }

        public Consumables selectedItem { get; set; }
        public ConsumablesVM()
        {
            var conn = new ConnectionDB();
            listItem = conn.Consumables.ToList();
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
                            conn.Consumables.Remove(conn.Consumables.Find(selectedItem.Id));
                            conn.Hardware.Remove(conn.Hardware.Find(selectedItem.Hardware.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("Принтеры");
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
