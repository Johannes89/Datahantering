//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datahantering.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class movie_actor
    {
        public int movieID { get; set; }
        public string Actor { get; set; }
    
        public virtual movie_data movie_data { get; set; }
    }
}