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
        public string Description
        {
            get
            {
                return $"Корпус: {Corpus}, Этаж: {Floor}, №{Number}";
            }
        }
    }
}