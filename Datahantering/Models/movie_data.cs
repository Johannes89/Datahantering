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
    
    public partial class movie_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movie_data()
        {
            this.movie_actor = new HashSet<movie_actor>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Grade { get; set; }
        public int Length { get; set; }
        public string Summary { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movie_actor> movie_actor { get; set; }
    }
}