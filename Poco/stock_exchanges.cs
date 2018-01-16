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
    
    public partial class stock_exchanges
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stock_exchanges()
        {
            this.trades = new HashSet<trade>();
            this.brokers = new HashSet<broker>();
        }
    
        public int stock_ex_id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public Nullable<int> place_id { get; set; }
    
        public virtual place place { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trade> trades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<broker> brokers { get; set; }
    }
}