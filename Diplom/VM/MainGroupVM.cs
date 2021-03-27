using Diplom.OtherClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom.VM
{
    class MainGroupVM
    {
        public List<MainGroup> listPk { get; set; }

        public MainGroup selectedPk { get; set; }
        public MainGroupVM()
        {
            var conn = new ConnectionDB();
            listPk = conn.MainGroup.ToList();
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

        private RelayCommand delPkCommand;
        public RelayCommand DelPkCommand
        {
            get
            {
                return delPkCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                            var conn = new ConnectionDB();
                            conn.MainGroup.Remove(conn.MainGroup.Find(selectedPk.Id));
                            conn.Hardware.Remove(conn.Hardware.Find(selectedPk.Hardware.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("Основная группа");
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
