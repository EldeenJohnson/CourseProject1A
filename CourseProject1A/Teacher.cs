//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseProject1A
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Qualification { get; set; }
        public string Grade { get; set; }
        public Nullable<int> Emergency_ID { get; set; }
    
        public virtual Emergency_contact Emergency_contact { get; set; }
    }
}
