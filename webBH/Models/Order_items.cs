//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webBH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_items
    {
        public int id { get; set; }
        public Nullable<int> quanlity { get; set; }
        public int id_order { get; set; }
        public int id_product { get; set; }
        public Nullable<int> total_money { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}