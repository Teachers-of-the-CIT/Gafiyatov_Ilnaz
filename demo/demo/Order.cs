//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int order_id { get; set; }
        public string order_elements { get; set; }
        public Nullable<System.DateTime> order_start_date { get; set; }
        public Nullable<System.DateTime> order_delivery_date { get; set; }
        public Nullable<int> point_id { get; set; }
        public string order_user_fullname { get; set; }
        public Nullable<int> order_code { get; set; }
        public string order_status { get; set; }
    
        public virtual Point Point { get; set; }
    }
}