//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankCoding.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAccountMovement
    {
        public int IdAccountMovement { get; set; }
        public Nullable<int> IdAccount { get; set; }
        public Nullable<int> IdTransaction { get; set; }
        public string Concept { get; set; }
        public string Reference { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Interests { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblTransaction tblTransaction { get; set; }
    }
}