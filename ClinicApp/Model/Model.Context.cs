﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ClinicDBEntities : DbContext
    {
        public ClinicDBEntities()
            : base("name=ClinicDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<CardRecord> CardRecord { get; set; }
        public virtual DbSet<CardRecordMedicalTest> CardRecordMedicalTest { get; set; }
        public virtual DbSet<CardRecordMedicine> CardRecordMedicine { get; set; }
        public virtual DbSet<ClinicEmployee> ClinicEmployee { get; set; }
        public virtual DbSet<MedicalTest> MedicalTest { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<PatientsListView> PatientsListView { get; set; }
        public virtual DbSet<CardRecordsWithDoctorNameView> CardRecordsWithDoctorNameView { get; set; }
    
        public virtual ObjectResult<PatientByPhone_Result> PatientByPhone(string phone)
        {
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PatientByPhone_Result>("PatientByPhone", phoneParameter);
        }
    
        public virtual ObjectResult<Patient> PatientsByFIO(string fIO)
        {
            var fIOParameter = fIO != null ?
                new ObjectParameter("FIO", fIO) :
                new ObjectParameter("FIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("PatientsByFIO", fIOParameter);
        }
    
        public virtual ObjectResult<Patient> PatientsByFIO(string fIO, MergeOption mergeOption)
        {
            var fIOParameter = fIO != null ?
                new ObjectParameter("FIO", fIO) :
                new ObjectParameter("FIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("PatientsByFIO", mergeOption, fIOParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int InsertCard(Nullable<int> cardNumber)
        {
            var cardNumberParameter = cardNumber.HasValue ?
                new ObjectParameter("cardNumber", cardNumber) :
                new ObjectParameter("cardNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCard", cardNumberParameter);
        }
    
        public virtual int InsertPatient(string fio, Nullable<System.DateTime> birthDate, string address, string phone, Nullable<int> cardID)
        {
            var fioParameter = fio != null ?
                new ObjectParameter("fio", fio) :
                new ObjectParameter("fio", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("birthDate", birthDate) :
                new ObjectParameter("birthDate", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPatient", fioParameter, birthDateParameter, addressParameter, phoneParameter, cardIDParameter);
        }
    
        public virtual ObjectResult<Patient> GetPatientByID(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("GetPatientByID", idParameter);
        }
    
        public virtual ObjectResult<Patient> GetPatientByID(Nullable<int> id, MergeOption mergeOption)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Patient>("GetPatientByID", mergeOption, idParameter);
        }
    
        public virtual ObjectResult<CardRecordsWithDoctorNameView> GetCardRecordsByCardId(Nullable<int> cardID)
        {
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CardRecordsWithDoctorNameView>("GetCardRecordsByCardId", cardIDParameter);
        }
    
        public virtual ObjectResult<CardRecordsWithDoctorNameView> GetCardRecordsByCardId(Nullable<int> cardID, MergeOption mergeOption)
        {
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CardRecordsWithDoctorNameView>("GetCardRecordsByCardId", mergeOption, cardIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetDocterID(string fio)
        {
            var fioParameter = fio != null ?
                new ObjectParameter("fio", fio) :
                new ObjectParameter("fio", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetDocterID", fioParameter);
        }
    
        public virtual ObjectResult<CardRecordsWithDoctorNameView> GetRecordByDate(Nullable<int> cardID, Nullable<System.DateTime> recordDate)
        {
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            var recordDateParameter = recordDate.HasValue ?
                new ObjectParameter("recordDate", recordDate) :
                new ObjectParameter("recordDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CardRecordsWithDoctorNameView>("GetRecordByDate", cardIDParameter, recordDateParameter);
        }
    
        public virtual ObjectResult<CardRecordsWithDoctorNameView> GetRecordByDate(Nullable<int> cardID, Nullable<System.DateTime> recordDate, MergeOption mergeOption)
        {
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            var recordDateParameter = recordDate.HasValue ?
                new ObjectParameter("recordDate", recordDate) :
                new ObjectParameter("recordDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CardRecordsWithDoctorNameView>("GetRecordByDate", mergeOption, cardIDParameter, recordDateParameter);
        }
    
        public virtual ObjectResult<CardRecordsWithDoctorNameView> GetRecordByDiaghosis(Nullable<int> cardID, string diaghosis)
        {
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            var diaghosisParameter = diaghosis != null ?
                new ObjectParameter("diaghosis", diaghosis) :
                new ObjectParameter("diaghosis", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CardRecordsWithDoctorNameView>("GetRecordByDiaghosis", cardIDParameter, diaghosisParameter);
        }
    
        public virtual ObjectResult<CardRecordsWithDoctorNameView> GetRecordByDiaghosis(Nullable<int> cardID, string diaghosis, MergeOption mergeOption)
        {
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            var diaghosisParameter = diaghosis != null ?
                new ObjectParameter("diaghosis", diaghosis) :
                new ObjectParameter("diaghosis", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CardRecordsWithDoctorNameView>("GetRecordByDiaghosis", mergeOption, cardIDParameter, diaghosisParameter);
        }
    
        public virtual int InsertCardRecord(Nullable<int> recordNumber, string diaghosis, string info, Nullable<System.DateTime> date, Nullable<int> docterID, Nullable<int> cardID)
        {
            var recordNumberParameter = recordNumber.HasValue ?
                new ObjectParameter("recordNumber", recordNumber) :
                new ObjectParameter("recordNumber", typeof(int));
    
            var diaghosisParameter = diaghosis != null ?
                new ObjectParameter("diaghosis", diaghosis) :
                new ObjectParameter("diaghosis", typeof(string));
    
            var infoParameter = info != null ?
                new ObjectParameter("info", info) :
                new ObjectParameter("info", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var docterIDParameter = docterID.HasValue ?
                new ObjectParameter("docterID", docterID) :
                new ObjectParameter("docterID", typeof(int));
    
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCardRecord", recordNumberParameter, diaghosisParameter, infoParameter, dateParameter, docterIDParameter, cardIDParameter);
        }
    
        public virtual int InsertCardRecordMedicalTests(Nullable<int> medTestID, Nullable<int> cardRecID)
        {
            var medTestIDParameter = medTestID.HasValue ?
                new ObjectParameter("medTestID", medTestID) :
                new ObjectParameter("medTestID", typeof(int));
    
            var cardRecIDParameter = cardRecID.HasValue ?
                new ObjectParameter("cardRecID", cardRecID) :
                new ObjectParameter("cardRecID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCardRecordMedicalTests", medTestIDParameter, cardRecIDParameter);
        }
    
        public virtual int InsertCardRecordMedicine(Nullable<int> medID, Nullable<int> cardRecID)
        {
            var medIDParameter = medID.HasValue ?
                new ObjectParameter("medID", medID) :
                new ObjectParameter("medID", typeof(int));
    
            var cardRecIDParameter = cardRecID.HasValue ?
                new ObjectParameter("cardRecID", cardRecID) :
                new ObjectParameter("cardRecID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCardRecordMedicine", medIDParameter, cardRecIDParameter);
        }
    
        public virtual ObjectResult<Medicine> GetMedicineByName(string medicineName)
        {
            var medicineNameParameter = medicineName != null ?
                new ObjectParameter("MedicineName", medicineName) :
                new ObjectParameter("MedicineName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Medicine>("GetMedicineByName", medicineNameParameter);
        }
    
        public virtual ObjectResult<Medicine> GetMedicineByName(string medicineName, MergeOption mergeOption)
        {
            var medicineNameParameter = medicineName != null ?
                new ObjectParameter("MedicineName", medicineName) :
                new ObjectParameter("MedicineName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Medicine>("GetMedicineByName", mergeOption, medicineNameParameter);
        }
    
        public virtual ObjectResult<MedicalTest> GetTestByName(string testName)
        {
            var testNameParameter = testName != null ?
                new ObjectParameter("TestName", testName) :
                new ObjectParameter("TestName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MedicalTest>("GetTestByName", testNameParameter);
        }
    
        public virtual ObjectResult<MedicalTest> GetTestByName(string testName, MergeOption mergeOption)
        {
            var testNameParameter = testName != null ?
                new ObjectParameter("TestName", testName) :
                new ObjectParameter("TestName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MedicalTest>("GetTestByName", mergeOption, testNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetCardRecordID(Nullable<int> cardID, Nullable<int> recordNumber)
        {
            var cardIDParameter = cardID.HasValue ?
                new ObjectParameter("cardID", cardID) :
                new ObjectParameter("cardID", typeof(int));
    
            var recordNumberParameter = recordNumber.HasValue ?
                new ObjectParameter("recordNumber", recordNumber) :
                new ObjectParameter("recordNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetCardRecordID", cardIDParameter, recordNumberParameter);
        }
    }
}