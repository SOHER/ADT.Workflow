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


    
    public partial class ARTICLE
    {
        public ARTICLE()
        {
            this.FILE = new HashSet<FILE>();
            this.HISTORIC1 = new HashSet<HISTORIC>();
            this.IMG = new HashSet<IMG>();
            this.THEME = new HashSet<THEME>();
            this.VIDEO = new HashSet<VIDEO>();
        }
    
        [Key]
        public int ARTICLE_ID { get; set; }
        public int ARTICLE_NBR { get; set; }
        public string AUTHOR { get; set; }
        public string SOURCES { get; set; }
        public string ANGLE { get; set; }
        public string TITLE { get; set; }
        public string TITLE_FB { get; set; }
        public string CHAPO { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public string HISTORIC { get; set; }
        public Nullable<System.DateTime> MODIFICATION_DATE { get; set; }
        public Nullable<System.DateTime> VALIDATION_DATE { get; set; }
        public Nullable<System.DateTime> TARGET_DATE { get; set; }
    
        public virtual ICollection<FILE> FILE { get; set; }
        public virtual ICollection<HISTORIC> HISTORIC1 { get; set; }
        public virtual ICollection<IMG> IMG { get; set; }
        public virtual ICollection<THEME> THEME { get; set; }
        public virtual ICollection<VIDEO> VIDEO { get; set; }
    }
}
