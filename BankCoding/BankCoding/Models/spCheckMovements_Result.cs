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
    
    public partial class spCheckMovements_Result
    {
        public string Transaction { get; set; }
        public string Concept { get; set; }
        public string Reference { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Interests { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    }
}