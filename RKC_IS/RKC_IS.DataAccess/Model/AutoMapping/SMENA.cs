//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RKC_IS.DataAccess.Model.AutoMapping
{
    using System;
    using System.Collections.Generic;
    
    public partial class SMENA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMENA()
        {
            this.GRUPA = new HashSet<GRUPA>();
        }
    
        public int ID { get; set; }
        public string ZAOR_Organizace { get; set; }
        public string ZADS_DruhSmena { get; set; }
        public System.DateTime Cas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPA> GRUPA { get; set; }
    }
}
