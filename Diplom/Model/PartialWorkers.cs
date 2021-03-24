namespace Diplom
{
    public partial class Workers
    {
        public string Fio
        {
            get
            {
                var fio = $"{LastName} {Name} {MiddleName}";
                return fio;
            }
        }
    }
}