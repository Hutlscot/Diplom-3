using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Hardware
    {
        //название группы того, что это за оборудование
        public string GroupName
        {
            get
            {
                if (MainGroup != null)
                {
                    return "Основная группа";
                }
                if (Printers != null)
                {
                    return "Принтеры";
                }
                if (OtherHardwares != null)
                {
                    return "Прочее оборудование";
                }
                if (Consumables != null)
                {
                    return "Расходники";
                }
                return "Неизвестная группа";
            }
        }
    }
}
