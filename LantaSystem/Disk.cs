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
    
    public partial class Disk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disk()
        {
            this.Buying_Goods = new HashSet<Buying_Goods>();
        }
    
        public int ID_Disk { get; set; }
        public string Title_Disk { get; set; }
        public string Description_Disk { get; set; }
        public int Price_Disk { get; set; }
        public int ID_Type_Disk { get; set; }
        public int ID_Compatibility { get; set; }
        public int ID_Type_Goods { get; set; }
        public int ID_Firm { get; set; }
    
        public virtual Compatibility Compatibility { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buying_Goods> Buying_Goods { get; set; }
        public virtual Firm Firm { get; set; }
        public virtual Type_Disk Type_Disk { get; set; }
        public virtual Type_Goods Type_Goods { get; set; }
    }
}
