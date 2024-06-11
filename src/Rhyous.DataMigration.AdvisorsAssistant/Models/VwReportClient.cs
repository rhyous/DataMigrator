﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models;

public partial class VwReportClient
{
    public int UniqueNameId { get; set; }

    public int? UniquePrimaryProducerId { get; set; }

    public int? UniquePrimaryProducerNameId { get; set; }

    public int? UniquePrimaryProducerAddressId { get; set; }

    public int? UniquePrimaryProducerPhoneId { get; set; }

    public string PrimaryProducerFirstName { get; set; }

    public string PrimaryProducerLastName { get; set; }

    public string PrimaryProducer { get; set; }

    public string PrimaryProducerId { get; set; }

    public string HouseholdName { get; set; }

    public int UniqueHouseholdId { get; set; }

    public string HeadOfHouseholdFirstName { get; set; }

    public string HeadOfHouseholdLastName { get; set; }

    public int? HeadOfHouseholdId { get; set; }

    public string FullNickName { get; set; }

    public string FullName { get; set; }

    public string SortName { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string MiddleInitial { get; set; }

    public string LastName { get; set; }

    public string NickName { get; set; }

    public string Prefix { get; set; }

    public string Suffix { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string TaxId { get; set; }

    public string Medicare { get; set; }

    public string DriversLicenseId { get; set; }

    public string DlissueState { get; set; }

    public DateTime? DlexpirationDate { get; set; }

    public DateTime? DlissueDate { get; set; }

    public int? AgeActual { get; set; }

    public int? AgeNearest { get; set; }

    public string MonthDayOfBirth { get; set; }

    public int? MonthDayDobsort { get; set; }

    public bool ProducerYn { get; set; }

    public bool? OrganizationYn { get; set; }

    public bool HeadOfHouseholdYn { get; set; }

    public bool CanCallYn { get; set; }

    public bool CanMailYn { get; set; }

    public bool CanEmailYn { get; set; }

    public int DependentsNumber { get; set; }

    public string DependentStatus { get; set; }

    public DateTime? DateOfMarriage { get; set; }

    public string MonthDayOfMarriage { get; set; }

    public int? MonthDayMarriageSort { get; set; }

    public decimal IncomeEarned { get; set; }

    public decimal IncomeTotal { get; set; }

    public decimal NetWorth { get; set; }

    public DateTime? NameAddedDate { get; set; }

    public string NameAddedBy { get; set; }

    public DateTime? NameLastChangeDate { get; set; }

    public string NameChangedBy { get; set; }

    public string Gender { get; set; }

    public string Industry { get; set; }

    public string NameStatus { get; set; }

    public string MaritalStatus { get; set; }

    public string Tobacco { get; set; }

    public string Occupation { get; set; }

    public string NameTypeDescPrimary { get; set; }

    public string NameTypeAbbrPrimary { get; set; }

    public int? UniqueNameTypeCodeId { get; set; }

    public string EmailContact { get; set; }

    public string EmailAddress { get; set; }

    public string EmailGreeting { get; set; }

    public decimal? NameFlexField01Numeric { get; set; }

    public decimal? NameFlexField02Numeric { get; set; }

    public decimal? NameFlexField03Numeric { get; set; }

    public decimal? NameFlexField04Numeric { get; set; }

    public decimal? NameFlexField05Numeric { get; set; }

    public decimal? NameFlexField06Numeric { get; set; }

    public int? NameFlexField07Numeric { get; set; }

    public int? NameFlexField08Numeric { get; set; }

    public string NameFlexField09Text { get; set; }

    public string NameFlexField10Text { get; set; }

    public string NameFlexField11Text { get; set; }

    public string NameFlexField12Text { get; set; }

    public DateTime? NameFlexField13Date { get; set; }

    public DateTime? NameFlexField14Date { get; set; }

    public DateTime? NameFlexField15Date { get; set; }

    public DateTime? NameFlexField16Date { get; set; }

    public string NameFlexField17Text { get; set; }

    public string NameFlexField18Text { get; set; }

    public string NameFlexField19Text { get; set; }

    public string NameFlexField20Text { get; set; }

    public DateTime? NameFlexField21Date { get; set; }

    public DateTime? NameFlexField22Date { get; set; }

    public string NameFlexField23Text { get; set; }

    public string NameFlexField24Text { get; set; }

    public string NameFlexField25Text { get; set; }

    public string NameFlexField26Text { get; set; }

    public string NameFlexField27Text { get; set; }

    public string NameFlexField28Text { get; set; }

    public string NameFlexField29Text { get; set; }

    public string NameFlexField30Text { get; set; }

    public string AddressType { get; set; }

    public string AddressLocation { get; set; }

    public string Greeting { get; set; }

    public string Addressee { get; set; }

    public string AddressTitle { get; set; }

    public string JobTitle { get; set; }

    public string BusinessName { get; set; }

    public string Company { get; set; }

    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Address3 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipPostalCode { get; set; }

    public string ZipCode { get; set; }

    public string County { get; set; }

    public string Region { get; set; }

    public string Country { get; set; }

    public string CarrierRoute { get; set; }

    public string DeliveryPoint { get; set; }

    public string CityStateZip { get; set; }

    public string PhoneType { get; set; }

    public string PhoneContact { get; set; }

    public string PhoneCountryCode { get; set; }

    public string PhoneAreaCode { get; set; }

    public string PhoneNum { get; set; }

    public string PhoneExt { get; set; }

    public string FullPhone { get; set; }

    public DateTime? SpouseDateOfBirth { get; set; }

    public int? SpouseAgeActual { get; set; }

    public int? SpouseAgeNearest { get; set; }

    public string SpouseFullName { get; set; }

    public string SpouseNickName { get; set; }

    public string SpouseTaxId { get; set; }

    public string SpouseMedicare { get; set; }

    public string SpouseDriversLicenseId { get; set; }

    public DateTime? SpouseDlexpirationDate { get; set; }

    public DateTime? SpouseDlissueDate { get; set; }

    public string SpouseEmailAddress { get; set; }

    public string SpouseOccupation { get; set; }

    public string WebAddress { get; set; }

    public int? NumberOfAccounts { get; set; }

    public int? NumberOfPoliciesOwned { get; set; }

    public int? NumberOfPoliciesInsuredPrimary { get; set; }

    public int? NumberOfPoliciesInsured { get; set; }

    public decimal TaxBracket { get; set; }

    public string TaxBracketPct { get; set; }

    public Guid NameGuid { get; set; }

    public string NameApikey1 { get; set; }

    public string NameApikey2 { get; set; }

    public string NameApikey3 { get; set; }

    public string NamePhase { get; set; }
}