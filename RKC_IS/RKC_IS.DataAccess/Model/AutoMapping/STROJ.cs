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
    
    public partial class STROJ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STROJ()
        {
            this.ESP_LOG = new HashSet<ESP_LOG>();
            this.SESTAVA = new HashSet<SESTAVA>();
            this.STROJ_GRUPA = new HashSet<STROJ_GRUPA>();
            this.STROJ_PARAMETR = new HashSet<STROJ_PARAMETR>();
            this.STROJ_PORUCHA = new HashSet<STROJ_PORUCHA>();
            this.STROJ_UDRZBA = new HashSet<STROJ_UDRZBA>();
            this.VZORKOVANI = new HashSet<VZORKOVANI>();
            this.WORKMONITOR = new HashSet<WORKMONITOR>();
            this.ZAKAZKA = new HashSet<ZAKAZKA>();
        }
    
        public int ID { get; set; }
        public string ZAOR_Organizace { get; set; }
        public string ZANS_NaklStr { get; set; }
        public string ZATS_Typ { get; set; }
        public string ZAVY_Vyrobce { get; set; }
        public string Nazev { get; set; }
        public string Cislo { get; set; }
        public int InventarniCislo { get; set; }
        public string VyrobniCislo { get; set; }
        public Nullable<System.DateTime> DatumVyroby { get; set; }
        public Nullable<double> DobaChodu { get; set; }
        public Nullable<double> X { get; set; }
        public Nullable<double> Y { get; set; }
        public Nullable<double> DX { get; set; }
        public Nullable<double> DY { get; set; }
        public int STAV { get; set; }
        public Nullable<int> STAV_NASLEDUJICI { get; set; }
        public int C_USER { get; set; }
        public System.DateTime C_DATE { get; set; }
        public Nullable<System.DateTime> M_DATE { get; set; }
        public Nullable<int> M_USER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESP_LOG> ESP_LOG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESTAVA> SESTAVA { get; set; }
        public virtual SY_STAV SY_STAV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STROJ_GRUPA> STROJ_GRUPA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STROJ_PARAMETR> STROJ_PARAMETR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STROJ_PORUCHA> STROJ_PORUCHA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STROJ_UDRZBA> STROJ_UDRZBA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VZORKOVANI> VZORKOVANI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WORKMONITOR> WORKMONITOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZAKAZKA> ZAKAZKA { get; set; }
    }
}
