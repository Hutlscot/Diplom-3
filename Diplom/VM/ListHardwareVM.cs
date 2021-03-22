using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;

namespace Diplom.VM
{
    public class ListHardwareVM
    {
        public ObservableCollection<Hardware> ListHardwares { get; set; }

        public ListHardwareVM()
        {
            var conn = new ConnectionDB();
            ListHardwares = conn.Hardware;
        }
    }
}