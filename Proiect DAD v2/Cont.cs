//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proiect_DAD_v2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cont
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cont()
        {
            this.Rulajes = new myBindingColl<Rulaje>();
        }
    
        public int id { get; set; }
        public string Simbol { get; set; }
        public string Denumire { get; set; }
        public Nullable<double> SID { get; set; }
        public Nullable<double> SIC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual myBindingColl<Rulaje> Rulajes { get; set; }
    }
}
