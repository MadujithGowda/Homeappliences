//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homeappliences_application.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class product
    {
        public int id { get; set; }
        [Display(Name="Product")]
        public string product1 { get; set; }
        public int category_id { get; set; }
        public int brand_id { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> price { get; set; }
        public string Image { get; set; }
    
        public virtual brand brand { get; set; }
        public virtual category category { get; set; }
    }
}
