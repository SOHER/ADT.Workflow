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
    using System.ComponentModel.DataAnnotations;

    public partial class THEME
    {
        public THEME()
        {
            this.ARTICLE = new HashSet<ARTICLE>();
        }
    
        [Key]
        public int THEME_ID { get; set; }
        public string THEME_LABEL { get; set; }
    
        public virtual ICollection<ARTICLE> ARTICLE { get; set; }
    }
}
