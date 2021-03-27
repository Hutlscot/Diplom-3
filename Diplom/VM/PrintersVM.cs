using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class PrintersVM
    {
        public List<Printers> printers { get; set; }

        public Printers selectedPrinter { get; set; }
        public PrintersVM()
        {
            var conn = new ConnectionDB();
            printers = conn.Printers.ToList();
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

        private RelayCommand delPrinterCommand;
        public RelayCommand DelPrinterCommand
        {
            get
            {
                return delPrinterCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                            var conn = new ConnectionDB();
                            conn.Printers.Remove(conn.Printers.Find(selectedPrinter.Id));
                            conn.Hardware.Remove(conn.Hardware.Find(selectedPrinter.Hardware.Id));
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
