//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADT.Workflow.DAL
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
