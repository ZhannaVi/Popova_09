//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Popova_09.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Monkey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monkey()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int MonkeyId { get; set; }
        public string MonkeyName { get; set; }
        public int ViewId { get; set; }
        public int Relaese { get; set; }
        public string Owner { get; set; }
        public System.DateTime DatePriem { get; set; }
        public decimal Cost { get; set; }
        public string descr { get; set; }
    
        public virtual ViewMonkey ViewMonkey { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
