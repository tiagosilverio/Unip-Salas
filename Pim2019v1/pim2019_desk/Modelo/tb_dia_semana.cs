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
    
    public partial class tb_dia_semana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_dia_semana()
        {
            this.tb_aula_local = new HashSet<tb_aula_local>();
        }
    
        public int idDiaSemana { get; set; }
        public string nomeDiaSemana { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_aula_local> tb_aula_local { get; set; }
    }
}
