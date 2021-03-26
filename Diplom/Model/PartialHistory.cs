using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Histoty
    {
        public string isEntUsing
        {
            get
            {
                if (IsEnterUsing)
                    return "Ввод";
                return "Вывод";
            }
        }
    }
}
