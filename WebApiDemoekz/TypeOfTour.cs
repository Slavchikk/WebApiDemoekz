//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiDemoekz
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeOfTour
    {
        public int id_type_of_tour { get; set; }
        public int id_tour { get; set; }
        public int id_type { get; set; }
    
        public virtual Tour Tour { get; set; }
        public virtual Type Type { get; set; }
    }
}
