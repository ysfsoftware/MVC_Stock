//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TabloUrunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TabloUrunler()
        {
            this.TabloSatislar = new HashSet<TabloSatislar>();
        }
    
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public Nullable<short> UrunKategori { get; set; }
        public Nullable<decimal> UrunFiyat { get; set; }
        public Nullable<byte> UrunStok { get; set; }
    
        public virtual TabloKategoriler TabloKategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabloSatislar> TabloSatislar { get; set; }
    }
}
