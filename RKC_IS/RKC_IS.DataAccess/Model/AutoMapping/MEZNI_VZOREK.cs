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
    
    public partial class MEZNI_VZOREK
    {
        public int ID { get; set; }
        public int ID_USER { get; set; }
        public int ID_FORMA { get; set; }
        public Nullable<System.DateTime> DatumZapsani { get; set; }
        public string ZaznamKontroly { get; set; }
        public string ReseniProblemu { get; set; }
        public string PopisProblemu { get; set; }
        public string CisloVyrobku { get; set; }
        public string JeOK { get; set; }
        public string JakKontrolovat { get; set; }
        public string PripravekNaKontrolu { get; set; }
        public string CetnostKontrol { get; set; }
        public Nullable<System.DateTime> UvolnenoDo { get; set; }
        public string Foto { get; set; }
        public int STAV { get; set; }
        public Nullable<int> STAV_NASLEDUJICI { get; set; }
        public int C_USER { get; set; }
        public System.DateTime C_DATE { get; set; }
        public Nullable<int> M_USER { get; set; }
        public Nullable<System.DateTime> M_DATE { get; set; }
    
        public virtual FORMA FORMA { get; set; }
        public virtual USER USER { get; set; }
        public virtual SY_STAV SY_STAV { get; set; }
    }
}
