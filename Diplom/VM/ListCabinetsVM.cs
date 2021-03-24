using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class ListCabinetsVM
    {
        public List<Cabinets> listCabinets { get; set; }

        public Cabinets selectedCabinet { get; set; }

        public ListCabinetsVM()
        {
            var conn = new ConnectionDB();
            listCabinets = conn.Cabinets.ToList();
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

        private RelayCommand delCabinetCommand;
        public RelayCommand DelCabinetCommand
        {
            get
            {
                return delCabinetCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                            var conn = new ConnectionDB();
                            conn.Cabinets.Remove(conn.Cabinets.Find(selectedCabinet.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("Кабинеты");
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