//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CardRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CardRecord()
        {
            this.CardRecordMedicalTest = new HashSet<CardRecordMedicalTest>();
            this.CardRecordMedicine = new HashSet<CardRecordMedicine>();
        }
    
        public int Id { get; set; }
        public int RecordNumber { get; set; }
        public string Diaghosis { get; set; }
        public string AddInfo { get; set; }
        public System.DateTime RecordDate { get; set; }
        public int ClinicEmployeeID { get; set; }
        public int CardID { get; set; }
    
        public virtual Card Card { get; set; }
        public virtual ClinicEmployee ClinicEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardRecordMedicalTest> CardRecordMedicalTest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardRecordMedicine> CardRecordMedicine { get; set; }
    }
}
