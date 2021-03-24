using System.Linq;

namespace Diplom
{
    public partial class Cabinets
    {
        public string ResponsiblePerson
        {
            get
            {
                var person = Workers.SingleOrDefault();
                return person != null ? person.Fio : "Нет ответственного";
            }
        }
    }
}