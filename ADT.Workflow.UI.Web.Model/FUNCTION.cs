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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class FUNCTION
    {
        public FUNCTION()
        {
            this.PERSON = new HashSet<PERSON>();
        }
    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FUNCTION_ID { get; set; }
        public string FUNCTION_LABEL { get; set; }
    
        public virtual ICollection<PERSON> PERSON { get; set; }
    }
}
