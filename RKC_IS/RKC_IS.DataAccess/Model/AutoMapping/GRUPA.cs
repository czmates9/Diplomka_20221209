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
    
    public partial class GRUPA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRUPA()
        {
            this.STROJ_GRUPA = new HashSet<STROJ_GRUPA>();
            this.USER_GRUPA = new HashSet<USER_GRUPA>();
        }
    
        public int ID { get; set; }
        public int ID_SMENA { get; set; }
        public string Nazev { get; set; }
        public string ZATG_TypGrupa { get; set; }
        public int C_USER { get; set; }
        public System.DateTime C_DATE { get; set; }
        public Nullable<int> M_USER { get; set; }
        public Nullable<System.DateTime> M_DATE { get; set; }
        public int STAV { get; set; }
        public Nullable<int> STAV_NASLEDUJICI { get; set; }
    
        public virtual SMENA SMENA { get; set; }
        public virtual SY_STAV SY_STAV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STROJ_GRUPA> STROJ_GRUPA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_GRUPA> USER_GRUPA { get; set; }
    }
}
