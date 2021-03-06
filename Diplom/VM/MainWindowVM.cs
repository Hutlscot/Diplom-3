using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Diplom.OtherClasses;
using Diplom.View;

namespace Diplom.VM
{
    public class MainWindowVM
    {
        public MainWindowVM()
        {

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
    }
}
