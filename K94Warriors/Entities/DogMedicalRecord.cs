//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K94Warriors.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class DogMedicalRecord
    {
        public DogMedicalRecord()
        {
            this.MetaDatas = new HashSet<MetaData>();
        }
    
        public int RecordID { get; set; }
        public int DogProfileID { get; set; }
        public string RecordType { get; set; }
        public string Title { get; set; }
        public byte[] RecordBytes { get; set; }
        public string RecordText { get; set; }
        public Nullable<System.DateTime> RecordExpirationDate { get; set; }
    
        public virtual DogProfile DogProfile { get; set; }
        public virtual ICollection<MetaData> MetaDatas { get; set; }
    }
}