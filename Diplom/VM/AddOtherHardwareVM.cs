using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class AddOtherHardwareVM
    {
        public OtherHardwares addedItem { get; set; }
        public Hardware addedHardware { get; set; }
        public AddOtherHardwareVM()
        {
            addedHardware = new Hardware();
            addedItem = new OtherHardwares();
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
                        conn.Hardware.Add(addedHardware);
                        conn.SaveChanges();
                        addedItem.Hardware = addedHardware;
                        conn.OtherHardwares.Add(addedItem);
                        conn.SaveChanges();
                        MessageBox.Show("Успешно сохранено");
                        Transfer.GoTo("Прочее оборудование");
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
