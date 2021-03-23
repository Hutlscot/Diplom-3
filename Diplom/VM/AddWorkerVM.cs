using System;
using System.Windows;
using System.Windows.Media.Media3D;
using Diplom.OtherClasses;

namespace Diplom.VM
{
    public class AddWorkerVM
    {
        public Workers addedWorker { get; set; }
        public AddWorkerVM()
        {
            addedWorker = new Workers();
        }

        private RelayCommand addWorkerCommand;

        public RelayCommand AddWorkerCommand
        {
            get
            {
                return addWorkerCommand ?? (new RelayCommand(obj =>
                {
                    try
                    {
                        var conn = new ConnectionDB();
                        conn.Workers.Add(addedWorker);
                        conn.SaveChanges();
                        MessageBox.Show("Успешно сохранено");
                        Transfer.GoTo("Сотрудники");
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