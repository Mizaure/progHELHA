//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebArticlesApp.Models
{
    using System;
    
    public partial class GetProductById_Result
    {
        public System.Guid articleID { get; set; }
        public string Nom { get; set; }
        public System.Guid categorieID { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
