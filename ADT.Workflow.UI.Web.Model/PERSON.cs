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
    
    public partial class PERSON
    {
        public PERSON()
        {
            this.HISTORIC = new HashSet<HISTORIC>();
        }
    
        public int PERSON_ID { get; set; }
        public int ID_TEAM { get; set; }
        public int ROLE_ID { get; set; }
        public int FUNCTION_ID { get; set; }
        public string NAME { get; set; }
        public string FIRSTNAME { get; set; }
        public string MAIL { get; set; }
        public string PWD { get; set; }
        public string PHONE { get; set; }
    
        public virtual FUNCTION FUNCTION { get; set; }
        public virtual ICollection<HISTORIC> HISTORIC { get; set; }
        public virtual TEAM TEAM { get; set; }
        public virtual ROLE ROLE { get; set; }
    }
}
