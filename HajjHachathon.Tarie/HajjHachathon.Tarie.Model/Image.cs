//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HajjHachathon.Tarie.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public int Id { get; set; }
        public Nullable<int> CaseId { get; set; }
        public byte[] Image1 { get; set; }
    
        public virtual Case Case { get; set; }
    }
}
