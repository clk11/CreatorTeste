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
    
    public partial class t_TexteVariante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_TexteVariante()
        {
            this.t_Variante = new HashSet<t_Variante>();
        }
    
        public int ID_TextVarianta { get; set; }
        public string TextVarianta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Variante> t_Variante { get; set; }
    }
}
