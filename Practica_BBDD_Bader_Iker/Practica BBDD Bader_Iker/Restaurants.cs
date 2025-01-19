//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica_BBDD_Bader_Iker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurants
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restaurants()
        {
            this.GaleriaImatges = new HashSet<GaleriaImatges>();
            this.Horaris = new HashSet<Horaris>();
            this.Resenyes = new HashSet<Resenyes>();
            this.Reserves = new HashSet<Reserves>();
            this.Categories = new HashSet<Categories>();
        }
    
        public string Nom { get; set; }
        public int idRestaurant { get; set; }
        public string NomCiutat { get; set; }
        public string Adresa { get; set; }
        public string CodiPostal { get; set; }
        public string eMail { get; set; }
        public string TelefonContacte { get; set; }
        public string MiniaturaWeb { get; set; }
        public string LinkWeb { get; set; }
        public string GoogleMapsLink { get; set; }
    
        public virtual Ciutats Ciutats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GaleriaImatges> GaleriaImatges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horaris> Horaris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resenyes> Resenyes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserves> Reserves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Categories> Categories { get; set; }
    }
}
