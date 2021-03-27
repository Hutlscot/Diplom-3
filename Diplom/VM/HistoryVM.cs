using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    public class HistoryVM
    {
        public List<Histoty> histoties { get; set; }

        public Histoty selectedHistory { get; set; }
        public HistoryVM()
        {
            var conn = new ConnectionDB();
            histoties = conn.Histoty.ToList();
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
                            conn.Histoty.Remove(conn.Histoty.Find(selectedHistory.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("История учета");
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
