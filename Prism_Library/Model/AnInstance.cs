//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prism_Library.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnInstance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnInstance()
        {
            this.Subscription = new HashSet<Subscription>();
        }
    
        public int IDAnInstance { get; set; }
        public int IDStatus { get; set; }
        public string InventoryNum { get; set; }
        public int IDBook { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscription { get; set; }
    }
}
