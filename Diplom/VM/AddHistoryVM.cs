using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class AddHistoryVM
    {
        public Histoty addedItem { get; set; }

        public List<Hardware> hardwares { get; set; }
        public Hardware selectedHardware { get; set; }

        public List<Cabinets> cabinets { get; set; }
        public Cabinets selectedCabinet { get; set; }

        public AddHistoryVM()
        {
            addedItem = new Histoty();
            addedItem.Date = DateTime.Now;
            var conn = new ConnectionDB();
            hardwares = conn.Hardware.ToList();
            cabinets = conn.Cabinets.ToList();
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
                        addedItem.CabinetId = selectedCabinet.Id;
                        addedItem.HardwareId = selectedHardware.Id;
                        conn.Histoty.Add(addedItem);
                        conn.SaveChanges();
                        MessageBox.Show("Успешно сохранено");
                        Transfer.GoTo("История учета");
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
