﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_GetClientReportDataResult
    {
        public int NameUniqueID { get; set; }
        public string FullNickName { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string MiddelName { get; set; }
        public string TaxID { get; set; }
        public string Medicare { get; set; }
        public string MiddleINITIAL { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int ActualAge { get; set; }
        public int NearestAge { get; set; }
        public string MonthDayOfBirth { get; set; }
        public bool ProducerYN { get; set; }
        public bool? Organization { get; set; }
        public bool HeadOfHouseholdYN { get; set; }
        public bool PrinaryPhoneYN { get; set; }
        public bool PrimaryEmailYN { get; set; }
        public bool PrimaryMailYN { get; set; }
        public int NumOfDeps { get; set; }
        public string DependentStatus { get; set; }
        public DateTime? DateOfMarriage { get; set; }
        public decimal Income { get; set; }
        public decimal FamilyIncome { get; set; }
        public decimal NetWorth { get; set; }
        public string Gender { get; set; }
        public string Industry { get; set; }
        public string Status { get; set; }
        public string MaritalStatus { get; set; }
        public string Tobacco { get; set; }
        public string Occupation { get; set; }
        public string EmailContact { get; set; }
        public string EmailAddress { get; set; }
        [Column("nNameFlexfld1", TypeName = "decimal(13,2)")]
        public decimal? nNameFlexfld1 { get; set; }
        [Column("nNameFlexfld2", TypeName = "decimal(13,2)")]
        public decimal? nNameFlexfld2 { get; set; }
        [Column("nNameFlexfld3", TypeName = "decimal(13,2)")]
        public decimal? nNameFlexfld3 { get; set; }
        [Column("nNameFlexfld4", TypeName = "decimal(13,2)")]
        public decimal? nNameFlexfld4 { get; set; }
        [Column("nNameFlexfld5", TypeName = "decimal(16,6)")]
        public decimal? nNameFlexfld5 { get; set; }
        [Column("nNameFlexfld6", TypeName = "decimal(16,6)")]
        public decimal? nNameFlexfld6 { get; set; }
        public int? iNameFlexfld7 { get; set; }
        public int? iNameFlexfld8 { get; set; }
        public string cNameFlexfld9 { get; set; }
        public string cNameFlexfld10 { get; set; }
        public string cNameFlexfld11 { get; set; }
        public string cNameFlexfld12 { get; set; }
        public DateTime? dNameFlexfld13 { get; set; }
        public DateTime? dNameFlexfld14 { get; set; }
        public DateTime? dNameFlexfld15 { get; set; }
        public DateTime? dNameFlexfld16 { get; set; }
        public string cNameFlexfld17 { get; set; }
        public string cNameFlexfld18 { get; set; }
        public string cNameFlexfld19 { get; set; }
        public string cNameFlexfld20 { get; set; }
        public DateTime? dNameFlexfld21 { get; set; }
        public DateTime? dNameFlexfld22 { get; set; }
        public string cNameFlexfld23 { get; set; }
        public string cNameFlexfld24 { get; set; }
        public string cNameFlexfld25 { get; set; }
        public string cNameFlexfld26 { get; set; }
        public string cNameFlexfld27 { get; set; }
        public string cNameFlexfld28 { get; set; }
        public string cNameFlexfld29 { get; set; }
        public string cNameFlexfld30 { get; set; }
        public string Greet { get; set; }
        public string Addressee { get; set; }
        public string Title { get; set; }
        public string BusinessName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string CarrierRoute { get; set; }
        public string DeliveryPoint { get; set; }
        public string PhoneContact { get; set; }
        public string FullPhone { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneAreaCode { get; set; }
        public string PhoneNum { get; set; }
        public string PhoneExt { get; set; }
        public DateTime? SpouseDateOfBirth { get; set; }
        public int SpouseActualAge { get; set; }
        public int SpouseNearestAge { get; set; }
        public string SpouseTaxID { get; set; }
        public string SpouseFullName { get; set; }
    }
}
