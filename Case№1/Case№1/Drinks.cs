//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Case_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drinks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drinks()
        {
            this.VendingMachineDrinks = new HashSet<VendingMachineDrinks>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public decimal Cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendingMachineDrinks> VendingMachineDrinks { get; set; }
    }
}
