using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class AddCabinetVM
    {
        public Cabinets addedCabinets { get; set; }
        public List<Workers> listWorkers { get; set; } 
        public Workers selectedWorker { get; set; }
        public AddCabinetVM()
        {
            addedCabinets = new Cabinets();
            var conn = new ConnectionDB();
            listWorkers = conn.Workers.ToList();
        }

        private RelayCommand addCabinetCommand;
        public RelayCommand AddCabinetCommand
        {
            get
            {
                return addCabinetCommand ?? (new RelayCommand(obj =>
                {
                    try
                    {
                        var conn = new ConnectionDB();
                        addedCabinets.Workers.Add(conn.Workers.Find(selectedWorker.Id));
                        conn.Cabinets.Add(addedCabinets);
                        conn.SaveChanges();
                        MessageBox.Show("Успешно сохранено");
                        Transfer.GoTo("Кабинеты");
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