//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jewelly.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoneMst
    {
        public int Stone_ID { get; set; }
        public decimal Stone_Gm { get; set; }
        public decimal Stone_Pcs { get; set; }
        public decimal Stone_Crt { get; set; }
        public decimal Stone_Rate { get; set; }
        public decimal Stone_Amt { get; set; }
        public Nullable<int> Style_Code { get; set; }
        public Nullable<int> StoneQlty_ID { get; set; }
    
        public virtual ItemMst ItemMst { get; set; }
        public virtual StoneQltyMst StoneQltyMst { get; set; }
    }
}
