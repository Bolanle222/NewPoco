//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Poco
{
    using System;
    using System.Collections.Generic;
    
    public partial class trade
    {
        public int trade_id { get; set; }
        public Nullable<int> share_id { get; set; }
        public Nullable<int> broker_id { get; set; }
        public Nullable<int> stock_ex_id { get; set; }
        public Nullable<System.DateTime> transaction_time { get; set; }
        public Nullable<int> share_amount { get; set; }
        public Nullable<decimal> price_total { get; set; }
    
        public virtual broker broker { get; set; }
        public virtual share share { get; set; }
        public virtual stock_exchanges stock_exchanges { get; set; }
    }
}