using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    partial class Printers
    {
        public string IsMfyString
        {
            get
            {
                if (IsMFY)
                    return "да";
                return "нет";
            }
        }
        public string HaveTwoPrintString
        {
            get
            {
                if(HavePrintDoubleList)
                {
                    return "есть";
                }
                return "нет";
            }
        }
    }
}
