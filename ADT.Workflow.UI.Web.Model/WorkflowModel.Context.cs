﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class workflowEntities : DbContext
    {
        public workflowEntities()
            : base("name=workflowEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ARTICLE> ARTICLE { get; set; }
        public DbSet<FILE> FILE { get; set; }
        public DbSet<FILE_TYPE> FILE_TYPE { get; set; }
        public DbSet<FUNCTION> FUNCTION { get; set; }
        public DbSet<HISTORIC> HISTORIC { get; set; }
        public DbSet<IMG> IMG { get; set; }
        public DbSet<PERSON> PERSON { get; set; }
        public DbSet<ROLE> ROLE { get; set; }
        public DbSet<STATUS> STATUS { get; set; }
        public DbSet<TEAM> TEAM { get; set; }
        public DbSet<THEME> THEME { get; set; }
        public DbSet<VIDEO> VIDEO { get; set; }
    }
}
