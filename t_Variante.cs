//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreatorTeste
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Variante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Variante()
        {
            this.t_Intrebari = new HashSet<t_Intrebari>();
            this.t_Intrebari1 = new HashSet<t_Intrebari>();
            this.t_Intrebari2 = new HashSet<t_Intrebari>();
            this.t_Intrebari3 = new HashSet<t_Intrebari>();
        }
    
        public int ID_Varianta { get; set; }
        public int ID_TextVarianta { get; set; }
        public bool Corecta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Intrebari> t_Intrebari { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Intrebari> t_Intrebari1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Intrebari> t_Intrebari2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Intrebari> t_Intrebari3 { get; set; }
        public virtual t_TexteVariante t_TexteVariante { get; set; }
    }
}