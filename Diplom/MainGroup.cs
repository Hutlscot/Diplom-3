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
    
    public partial class MainGroup
    {
        public int Id { get; set; }
        public string ModelProcessor { get; set; }
        public int RAM { get; set; }
        public string DiskSize { get; set; }
    
        public virtual Hardware Hardware { get; set; }
    }
}