//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmaWebApi.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firma()
        {
            this.Racun = new HashSet<Racun>();
        }
    
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string JIB { get; set; }
        public int OpstinaID { get; set; }
        public string PDVBroj { get; set; }
    
        public virtual Opstina Opstina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racun { get; set; }
    }
}