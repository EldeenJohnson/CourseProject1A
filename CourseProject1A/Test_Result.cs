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
    
    public partial class Test_Result
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Test_Result()
        {
            this.Student_detail = new HashSet<Student_detail>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Student_ID { get; set; }
        public Nullable<int> Subject_ID { get; set; }
        public Nullable<int> Teacher_ID { get; set; }
        public Nullable<double> Score { get; set; }
        public string Semester { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_detail> Student_detail { get; set; }
        public virtual Student_detail Student_detail1 { get; set; }
        public virtual Subject_Table Subject_Table { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
