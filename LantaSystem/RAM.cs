//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LantaSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class RAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RAM()
        {
            this.Buying_Goods = new HashSet<Buying_Goods>();
        }
    
        public int ID_RAM { get; set; }
        public string Title_RAM { get; set; }
        public string Description_RAM { get; set; }
        public int Price_RAM { get; set; }
        public int ID_Compatibility { get; set; }
        public int ID_Type_Goods { get; set; }
        public int ID_Firm { get; set; }
        public string IMG_RAM { get; set; }
    
        public virtual Compatibility Compatibility { get; set; }
        public virtual Firm Firm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buying_Goods> Buying_Goods { get; set; }
        public virtual Type_Goods Type_Goods { get; set; }
    }
}
