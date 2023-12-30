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
    
    public partial class CartList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CartList()
        {
            this.Orderdetails = new HashSet<Orderdetail>();
        }
    
        public int ID { get; set; }
        public string Product_Name { get; set; }
        public decimal MRP { get; set; }
        public string Email_ID { get; set; }
        public string OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string OrderCode { get; set; }
        public string ShipCity { get; set; }
        public string ShipCode { get; set; }
        public string ShipCountry { get; set; }
        public string userName { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> payment_ID { get; set; }
    
        public virtual AdminLoginMst AdminLoginMst { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual UserRegMst UserRegMst { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
