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
    
    public partial class FILE_TYPE
    {
        public FILE_TYPE()
        {
            this.FILE = new HashSet<FILE>();
        }
    
        public int FILE_TYPE_ID { get; set; }
        public string FILE_TYPE_LABEL { get; set; }
    
        public virtual ICollection<FILE> FILE { get; set; }
    }
}
