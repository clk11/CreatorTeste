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
    
    public partial class t_Rezultate
    {
        public int ID_Rezultat { get; set; }
        public int ID_InformatiiRezultat { get; set; }
        public int ID_IntrebareRezultat { get; set; }
    
        public virtual t_InformatiiRezultate t_InformatiiRezultate { get; set; }
        public virtual t_IntrebariRezultate t_IntrebariRezultate { get; set; }
    }
}
