//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pim2019_desk.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_sigla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_sigla()
        {
            this.tb_turma = new HashSet<tb_turma>();
        }
    
        public int idSigla { get; set; }
        public string nomeSigla { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_turma> tb_turma { get; set; }
    }
}
