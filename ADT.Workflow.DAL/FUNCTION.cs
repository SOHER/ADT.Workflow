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
    
    public partial class FUNCTION
    {
        public FUNCTION()
        {
            this.PERSON = new HashSet<PERSON>();
        }
    
        public int FUNCTION_ID { get; set; }
        public string FUNCTION_LABEL { get; set; }
    
        public virtual ICollection<PERSON> PERSON { get; set; }
    }
}
