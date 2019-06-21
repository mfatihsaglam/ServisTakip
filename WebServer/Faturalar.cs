//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServisTakip
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faturalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faturalar()
        {
            this.Odemeler = new HashSet<Odemeler>();
        }
    
        public int faturaId { get; set; }
        public int ogrId { get; set; }
        public int okulServisId { get; set; }
        public System.DateTime kayitTarihi { get; set; }
        public bool kullanimDurumu { get; set; }
        public int servistekiOgrenciId { get; set; }
        public decimal faturaTutari { get; set; }
    
        public virtual Ogrenciler Ogrenciler { get; set; }
        public virtual OkulServisleri OkulServisleri { get; set; }
        public virtual ServistekiOgrenciler ServistekiOgrenciler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odemeler> Odemeler { get; set; }
    }
}