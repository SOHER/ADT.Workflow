//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADT.Workflow.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class STATUS
    {
        public STATUS()
        {
            this.HISTORIC = new HashSet<HISTORIC>();
        }
    
        public int STATUS_ID { get; set; }
        public string STATUS_LABEL { get; set; }
    
        public virtual ICollection<HISTORIC> HISTORIC { get; set; }
    }
}
