using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Media3D;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class ListWorkersVM
    {
        public List<Workers> listWorkers { get; set; }
        public Workers selectedWorker { get; set; }
        
        public ListWorkersVM()
        {
            var conn = new ConnectionDB();
            listWorkers = conn.Workers.ToList();
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
        private RelayCommand delWorkerCommand;
        public RelayCommand DelWorkerCommand
        {
            get
            {
                return delWorkerCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                            var conn = new ConnectionDB();
                            conn.Workers.Remove(conn.Workers.Find(selectedWorker.Id));
                            conn.SaveChanges();
                            Transfer.GoTo("Сотрудники");
                            MessageBox.Show("Успешно удалено");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show($"Ошибка удаления {e}");
                        }
                       
                    }));
            }
        }

        private RelayCommand updateWorkerCommand;
        public RelayCommand UpdateWorkerCommand
        {
            get
            {
                return delWorkerCommand ?? (new RelayCommand(
                    obj =>
                    {
                        try
                        {
                                //TODO дописать   
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show($"Ошибка {e}");
                        }

                    }));
            }
        }
    }
}