//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consumables
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Interface { get; set; }
        public int Amount { get; set; }
    
        public virtual Hardware Hardware { get; set; }
    }
}