//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SingletonProjec.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentCourse
    {
        public int id { get; set; }
        public int StudentId { get; set; }
        public int TeacherCorse { get; set; }
        public Nullable<System.DateTime> Dönem { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual TeacherCourse TeacherCourse { get; set; }
    }
}
