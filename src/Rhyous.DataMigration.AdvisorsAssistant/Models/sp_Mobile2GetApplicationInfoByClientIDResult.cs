﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rhyous.DataMigration.AdvisorsAssistant.Models
{
    public partial class sp_Mobile2GetApplicationInfoByClientIDResult
    {
        public bool? ClientOrg { get; set; }
        public int? UniqueNameID { get; set; }
        public Guid? ClientID { get; set; }
        public Guid? ClientgUID { get; set; }
        public string ClientFullName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientMiddleName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientMiddleINITIAL { get; set; }
        public string ClientPrefix { get; set; }
        public string ClientSuffix { get; set; }
        public DateTime? ClientDateOfBirth { get; set; }
        public int? ClientAgeActual { get; set; }
        public int? ClientAgeNearest { get; set; }
        public string ClientEmployer { get; set; }
        public int? ClientDependentsNumber { get; set; }
        public string ClientDependentStatus { get; set; }
        public decimal? ClientIncomeEarned { get; set; }
        public decimal? ClientIncomeTotal { get; set; }
        public decimal? ClientNetWorth { get; set; }
        [Column("ClientTaxBracket", TypeName = "decimal(7,3)")]
        public decimal? ClientTaxBracket { get; set; }
        public DateTime? ClientRetireDate { get; set; }
        public string ClientGender { get; set; }
        public string ClientIndustry { get; set; }
        public string ClientMaritalStatus { get; set; }
        public string ClientTobacco { get; set; }
        public string ClientOccupation { get; set; }
        public string ClientTaxID { get; set; }
        public string ClientMedicare { get; set; }
        public string ClientCitizenship { get; set; }
        public string ClientPassport { get; set; }
        public DateTime? ClientPassportExpiration { get; set; }
        public DateTime? ClientPassportIssueDate { get; set; }
        public string ClientResidency { get; set; }
        public string ClientGreencard { get; set; }
        public DateTime? ClientGreencardExpiration { get; set; }
        public DateTime? ClientGreencardIssueDate { get; set; }
        public string ClientDriversLicense { get; set; }
        public string ClientDriversLicenseJurisdiction { get; set; }
        public DateTime? ClientDriversLicenseExpiration { get; set; }
        public DateTime? ClientDriversLicenseIssueDate { get; set; }
        public string ClientPhoneLocation { get; set; }
        public string ClientPhoneContact { get; set; }
        public string ClientPhoneCountryCode { get; set; }
        public string ClientPhoneAreaCode { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ClientPhoneExtension { get; set; }
        public string ClientFullPhone { get; set; }
        public string ClientHomePhoneAreaCode { get; set; }
        public string ClientHomePhoneNumber { get; set; }
        public string ClientCellPhoneAreaCode { get; set; }
        public string ClientCellPhoneNumber { get; set; }
        public string ClientWorkPhoneAreaCode { get; set; }
        public string ClientWorkPhoneNumber { get; set; }
        public string ClientWorkPhoneExtension { get; set; }
        public string ClientFaxAreaCode { get; set; }
        public string ClientFaxNumber { get; set; }
        public string ClientFaxExtension { get; set; }
        public string ClientEmail { get; set; }
        public string ClientGreeting { get; set; }
        public string ClientPrimeAddressLocation { get; set; }
        public string ClientPrimeAddress1 { get; set; }
        public string ClientPrimeAddress2 { get; set; }
        public string ClientPrimeAddress3 { get; set; }
        public string ClientPrimeCity { get; set; }
        public string ClientPrimeState { get; set; }
        public string ClientPrimeZipCode { get; set; }
        public string ClientPrimeRegion { get; set; }
        public string ClientPrimeCountry { get; set; }
        public string ClientPrimeCarrierRoute { get; set; }
        public string ClientPrimeDeliveryPoint { get; set; }
        public string ClientLegalAddressLocation { get; set; }
        public string ClientLegalAddress1 { get; set; }
        public string ClientLegalAddress2 { get; set; }
        public string ClientLegalAddress3 { get; set; }
        public string ClientLegalCity { get; set; }
        public string ClientLegalState { get; set; }
        public string ClientLegalZipCode { get; set; }
        public string ClientLegalRegion { get; set; }
        public string ClientLegalCountry { get; set; }
        public string ClientLegalCarrierRoute { get; set; }
        public string ClientLegalDeliveryPoint { get; set; }
        public string ClientWorkBusinessName { get; set; }
        public string ClientWorkAddress1 { get; set; }
        public string ClientWorkAddress2 { get; set; }
        public string ClientWorkAddress3 { get; set; }
        public string ClientWorkCity { get; set; }
        public string ClientWorkState { get; set; }
        public string ClientWorkZipCode { get; set; }
        public string ClientWorkRegion { get; set; }
        public string ClientWorkCountry { get; set; }
        public string ClientWorkCarrierRoute { get; set; }
        public string ClientWorkDeliveryPoint { get; set; }
        public DateTime? ClientDateOfMarriage { get; set; }
        public Guid? SpousegUID { get; set; }
        public string SpouseFullName { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseMiddleName { get; set; }
        public string SpouseLastName { get; set; }
        public string SpouseMiddleINITIAL { get; set; }
        public string SpousePrefix { get; set; }
        public string SpouseSuffix { get; set; }
        public DateTime? SpouseDateOfBirth { get; set; }
        public int? SpouseAgeActual { get; set; }
        public int? SpouseAgeNearest { get; set; }
        public string SpouseEmployer { get; set; }
        public int? SpouseDependentsNumber { get; set; }
        public string SpouseDependentStatus { get; set; }
        public decimal? SpouseIncomeEarned { get; set; }
        public decimal? SpouseIncomeTotal { get; set; }
        public decimal? SpouseNetWorth { get; set; }
        [Column("SpouseTaxBracket", TypeName = "decimal(7,3)")]
        public decimal? SpouseTaxBracket { get; set; }
        public string SpouseGender { get; set; }
        public string SpouseIndustry { get; set; }
        public string SpouseMaritalStatus { get; set; }
        public string SpouseTobacco { get; set; }
        public string SpouseOccupation { get; set; }
        public string SpouseTaxID { get; set; }
        public string SpouseMedicare { get; set; }
        public string SpouseCitizenship { get; set; }
        public string SpousePassport { get; set; }
        public DateTime? SpousePassportExpiration { get; set; }
        public DateTime? SpousePassportIssueDate { get; set; }
        public string SpouseResidency { get; set; }
        public string SpouseGreencard { get; set; }
        public DateTime? SpouseGreencardExpiration { get; set; }
        public DateTime? SpouseGreencardIssueDate { get; set; }
        public string SpouseDriversLicense { get; set; }
        public string SpouseDriversLicenseJurisdiction { get; set; }
        public DateTime? SpouseDriversLicenseExpiration { get; set; }
        public DateTime? SpouseDriversLicenseIssueDate { get; set; }
        public string SpousePhoneLocation { get; set; }
        public string SpousePhoneContact { get; set; }
        public string SpousePhoneCountryCode { get; set; }
        public string SpousePhoneAreaCode { get; set; }
        public string SpousePhoneNumber { get; set; }
        public string SpousePhoneExtension { get; set; }
        public string SpouseFullPhone { get; set; }
        public string SpouseHomePhoneAreaCode { get; set; }
        public string SpouseHomePhoneNumber { get; set; }
        public string SpouseCellPhoneAreaCode { get; set; }
        public string SpouseCellPhoneNumber { get; set; }
        public string SpouseWorkPhoneAreaCode { get; set; }
        public string SpouseWorkPhoneNumber { get; set; }
        public string SpouseWorkPhoneExtension { get; set; }
        public string SpouseFaxAreaCode { get; set; }
        public string SpouseFaxNumber { get; set; }
        public string SpouseFaxExtension { get; set; }
        public string SpouseEmail { get; set; }
        public string SpouseGreeting { get; set; }
        public string SpousePrimeAddressLocation { get; set; }
        public string SpousePrimeAddress1 { get; set; }
        public string SpousePrimeAddress2 { get; set; }
        public string SpousePrimeAddress3 { get; set; }
        public string SpousePrimeCity { get; set; }
        public string SpousePrimeState { get; set; }
        public string SpousePrimeZipCode { get; set; }
        public string SpousePrimeRegion { get; set; }
        public string SpousePrimeCountry { get; set; }
        public string SpousePrimeCarrierRoute { get; set; }
        public string SpousePrimeDeliveryPoint { get; set; }
        public string SpouseLegalAddressLocation { get; set; }
        public string SpouseLegalAddress1 { get; set; }
        public string SpouseLegalAddress2 { get; set; }
        public string SpouseLegalAddress3 { get; set; }
        public string SpouseLegalCity { get; set; }
        public string SpouseLegalState { get; set; }
        public string SpouseLegalZipCode { get; set; }
        public string SpouseLegalRegion { get; set; }
        public string SpouseLegalCountry { get; set; }
        public string SpouseLegalCarrierRoute { get; set; }
        public string SpouseLegalDeliveryPoint { get; set; }
        public string SpouseWorkBusinessName { get; set; }
        public string SpouseWorkAddress1 { get; set; }
        public string SpouseWorkAddress2 { get; set; }
        public string SpouseWorkAddress3 { get; set; }
        public string SpouseWorkCity { get; set; }
        public string SpouseWorkState { get; set; }
        public string SpouseWorkZipCode { get; set; }
        public string SpouseWorkRegion { get; set; }
        public string SpouseWorkCountry { get; set; }
        public string SpouseWorkCarrierRoute { get; set; }
        public string SpouseWorkDeliveryPoint { get; set; }
        public Guid? JointgUID { get; set; }
        public string JointFullName { get; set; }
        public string JointFirstName { get; set; }
        public string JointMiddleName { get; set; }
        public string JointLastName { get; set; }
        public string JointMiddleINITIAL { get; set; }
        public string JointPrefix { get; set; }
        public string JointSuffix { get; set; }
        public DateTime? JointDateOfBirth { get; set; }
        public int? JointAgeActual { get; set; }
        public int? JointAgeNearest { get; set; }
        public string JointEmployer { get; set; }
        public int? JointDependentsNumber { get; set; }
        public string JointDependentStatus { get; set; }
        public decimal? JointIncomeEarned { get; set; }
        public decimal? JointIncomeTotal { get; set; }
        public decimal? JointNetWorth { get; set; }
        public string JointGender { get; set; }
        public string JointIndustry { get; set; }
        public string JointMaritalStatus { get; set; }
        public string JointTobacco { get; set; }
        public string JointOccupation { get; set; }
        public string JointTaxID { get; set; }
        public string JointMedicare { get; set; }
        public string JointCitizenship { get; set; }
        public string JointPassport { get; set; }
        public DateTime? JointPassportExpiration { get; set; }
        public DateTime? JointPassportIssueDate { get; set; }
        public string JointResidency { get; set; }
        public string JointGreencard { get; set; }
        public DateTime? JointGreencardExpiration { get; set; }
        public DateTime? JointGreencardIssueDate { get; set; }
        public string JointDriversLicense { get; set; }
        public string JointDriversLicenseJurisdiction { get; set; }
        public DateTime? JointDriversLicenseExpiration { get; set; }
        public DateTime? JointDriversLicenseIssueDate { get; set; }
        public string JointPhoneLocation { get; set; }
        public string JointPhoneContact { get; set; }
        public string JointPhoneCountryCode { get; set; }
        public string JointPhoneAreaCode { get; set; }
        public string JointPhoneNumber { get; set; }
        public string JointPhoneExtension { get; set; }
        public string JointFullPhone { get; set; }
        public string JointHomePhoneAreaCode { get; set; }
        public string JointHomePhoneNumber { get; set; }
        public string JointCellPhoneAreaCode { get; set; }
        public string JointCellPhoneNumber { get; set; }
        public string JointWorkPhoneAreaCode { get; set; }
        public string JointWorkPhoneNumber { get; set; }
        public string JointWorkPhoneExtension { get; set; }
        public string JointFaxAreaCode { get; set; }
        public string JointFaxNumber { get; set; }
        public string JointFaxExtension { get; set; }
        public string JointEmail { get; set; }
        public string JointPrimeAddressLocation { get; set; }
        public string JointPrimeAddress1 { get; set; }
        public string JointPrimeAddress2 { get; set; }
        public string JointPrimeAddress3 { get; set; }
        public string JointPrimeCity { get; set; }
        public string JointPrimeState { get; set; }
        public string JointPrimeZipCode { get; set; }
        public string JointPrimeRegion { get; set; }
        public string JointPrimeCountry { get; set; }
        public string JointPrimeCarrierRoute { get; set; }
        public string JointPrimeDeliveryPoint { get; set; }
        public string JointLegalAddressLocation { get; set; }
        public string JointLegalAddress1 { get; set; }
        public string JointLegalAddress2 { get; set; }
        public string JointLegalAddress3 { get; set; }
        public string JointLegalCity { get; set; }
        public string JointLegalState { get; set; }
        public string JointLegalZipCode { get; set; }
        public string JointLegalRegion { get; set; }
        public string JointLegalCountry { get; set; }
        public string JointLegalCarrierRoute { get; set; }
        public string JointLegalDeliveryPoint { get; set; }
        public string JointWorkBusinessName { get; set; }
        public string JointWorkAddress1 { get; set; }
        public string JointWorkAddress2 { get; set; }
        public string JointWorkAddress3 { get; set; }
        public string JointWorkCity { get; set; }
        public string JointWorkState { get; set; }
        public string JointWorkZipCode { get; set; }
        public string JointWorkRegion { get; set; }
        public string JointWorkCountry { get; set; }
        public string JointWorkCarrierRoute { get; set; }
        public string JointWorkDeliveryPoint { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyAddress3 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZipCode { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhoneAreaCode { get; set; }
        public string CompanyPhonenumber { get; set; }
        public string CompanyPhoneExtension { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTaxID { get; set; }
        public Guid? InsuredgUID { get; set; }
        public string InsuredFullName { get; set; }
        public string InsuredFirstName { get; set; }
        public string InsuredMiddleName { get; set; }
        public string InsuredLastName { get; set; }
        public string InsuredMiddleINITIAL { get; set; }
        public string InsuredPrefix { get; set; }
        public string InsuredSuffix { get; set; }
        public DateTime? InsuredDateOfBirth { get; set; }
        public int? InsuredAgeActual { get; set; }
        public int? InsuredAgeNearest { get; set; }
        public string InsuredEmployer { get; set; }
        public int? InsuredDependentsNumber { get; set; }
        public string InsuredDependentStatus { get; set; }
        public decimal? InsuredIncomeEarned { get; set; }
        public decimal? InsuredIncomeTotal { get; set; }
        public decimal? InsuredNetWorth { get; set; }
        public string InsuredGender { get; set; }
        public string InsuredIndustry { get; set; }
        public string InsuredMaritalStatus { get; set; }
        public string InsuredTobacco { get; set; }
        public string InsuredOccupation { get; set; }
        public string InsuredTaxID { get; set; }
        public string InsuredMedicare { get; set; }
        public string InsuredCitizenship { get; set; }
        public string InsuredPassport { get; set; }
        public DateTime? InsuredPassportExpiration { get; set; }
        public DateTime? InsuredPassportIssueDate { get; set; }
        public string InsuredResidency { get; set; }
        public string InsuredGreencard { get; set; }
        public DateTime? InsuredGreencardExpiration { get; set; }
        public DateTime? InsuredGreencardIssueDate { get; set; }
        public string InsuredDriversLicense { get; set; }
        public string InsuredDriversLicenseJurisdiction { get; set; }
        public DateTime? InsuredDriversLicenseExpiration { get; set; }
        public DateTime? InsuredDriversLicenseIssueDate { get; set; }
        public string InsuredPhoneLocation { get; set; }
        public string InsuredPhoneContact { get; set; }
        public string InsuredPhoneCountryCode { get; set; }
        public string InsuredPhoneAreaCode { get; set; }
        public string InsuredPhoneNumber { get; set; }
        public string InsuredPhoneExtension { get; set; }
        public string InsuredFullPhone { get; set; }
        public string InsuredHomePhoneAreaCode { get; set; }
        public string InsuredHomePhoneNumber { get; set; }
        public string InsuredCellPhoneAreaCode { get; set; }
        public string InsuredCellPhoneNumber { get; set; }
        public string InsuredWorkPhoneAreaCode { get; set; }
        public string InsuredWorkPhoneNumber { get; set; }
        public string InsuredWorkPhoneExtension { get; set; }
        public string InsuredFaxAreaCode { get; set; }
        public string InsuredFaxNumber { get; set; }
        public string InsuredFaxExtension { get; set; }
        public string InsuredEmail { get; set; }
        public string InsuredPrimeAddressLocation { get; set; }
        public string InsuredPrimeAddress1 { get; set; }
        public string InsuredPrimeAddress2 { get; set; }
        public string InsuredPrimeAddress3 { get; set; }
        public string InsuredPrimeCity { get; set; }
        public string InsuredPrimeState { get; set; }
        public string InsuredPrimeZipCode { get; set; }
        public string InsuredPrimeRegion { get; set; }
        public string InsuredPrimeCountry { get; set; }
        public string InsuredPrimeCarrierRoute { get; set; }
        public string InsuredPrimeDeliveryPoint { get; set; }
        public string InsuredLegalAddressLocation { get; set; }
        public string InsuredLegalAddress1 { get; set; }
        public string InsuredLegalAddress2 { get; set; }
        public string InsuredLegalAddress3 { get; set; }
        public string InsuredLegalCity { get; set; }
        public string InsuredLegalState { get; set; }
        public string InsuredLegalZipCode { get; set; }
        public string InsuredLegalRegion { get; set; }
        public string InsuredLegalCountry { get; set; }
        public string InsuredLegalCarrierRoute { get; set; }
        public string InsuredLegalDeliveryPoint { get; set; }
        public string InsuredWorkBusinessName { get; set; }
        public string InsuredWorkAddress1 { get; set; }
        public string InsuredWorkAddress2 { get; set; }
        public string InsuredWorkAddress3 { get; set; }
        public string InsuredWorkCity { get; set; }
        public string InsuredWorkState { get; set; }
        public string InsuredWorkZipCode { get; set; }
        public string InsuredWorkRegion { get; set; }
        public string InsuredWorkCountry { get; set; }
        public string InsuredWorkCarrierRoute { get; set; }
        public string InsuredWorkDeliveryPoint { get; set; }
        public Guid? TrustgUID { get; set; }
        public string TrustFullName { get; set; }
        public DateTime? TrustDate { get; set; }
        public string TrustTaxID { get; set; }
        public string TrustAddress1 { get; set; }
        public string TrustAddress2 { get; set; }
        public string TrustAddress3 { get; set; }
        public string TrustCity { get; set; }
        public string TrustState { get; set; }
        public string TrustZipCode { get; set; }
        public string TrustAddressee { get; set; }
        public string TrustEmail { get; set; }
        public string TrustPhoneAreaCode { get; set; }
        public string TrustPhonenumber { get; set; }
        public string TrustPhoneExtension { get; set; }
        public Guid? Beneficiary1gUID { get; set; }
        public string Beneficiary1FullName { get; set; }
        public string Beneficiary1FirstName { get; set; }
        public string Beneficiary1MiddleName { get; set; }
        public string Beneficiary1MiddleINITIAL { get; set; }
        public string Beneficiary1Prefix { get; set; }
        public string Beneficiary1Suffix { get; set; }
        public string Beneficiary1LastName { get; set; }
        public bool? Beneficiary1Org { get; set; }
        public DateTime? Beneficiary1DateOfBirth { get; set; }
        public string Beneficiary1TaxID { get; set; }
        public string Beneficiary1Relationship { get; set; }
        public string Beneficiary1PrimeGreeting { get; set; }
        public string Beneficiary1PrimeAddressLocation { get; set; }
        public string Beneficiary1PrimeAddress1 { get; set; }
        public string Beneficiary1PrimeAddress2 { get; set; }
        public string Beneficiary1PrimeAddress3 { get; set; }
        public string Beneficiary1PrimeCity { get; set; }
        public string Beneficiary1PrimeState { get; set; }
        public string Beneficiary1PrimeZipCode { get; set; }
        public string Beneficiary1PrimeRegion { get; set; }
        public string Beneficiary1PrimeCountry { get; set; }
        public string Beneficiary1PrimeCarrierRoute { get; set; }
        public string Beneficiary1PrimeDeliveryPoint { get; set; }
        public string Beneficiary1PrimePhoneLocation { get; set; }
        public string Beneficiary1PrimePhoneContact { get; set; }
        public string Beneficiary1PrimePhoneCountryCode { get; set; }
        public string Beneficiary1PrimePhoneAreaCode { get; set; }
        public string Beneficiary1PrimePhoneNumber { get; set; }
        public string Beneficiary1PrimePhoneExtension { get; set; }
        public string Beneficiary1PrimeFullPhone { get; set; }
        public string Beneficiary1PrimeEmail { get; set; }
        public Guid? Beneficiary2gUID { get; set; }
        public string Beneficiary2FullName { get; set; }
        public string Beneficiary2FirstName { get; set; }
        public string Beneficiary2MiddleName { get; set; }
        public string Beneficiary2MiddleINITIAL { get; set; }
        public string Beneficiary2Prefix { get; set; }
        public string Beneficiary2Suffix { get; set; }
        public string Beneficiary2LastName { get; set; }
        public bool? Beneficiary2Org { get; set; }
        public DateTime? Beneficiary2DateOfBirth { get; set; }
        public string Beneficiary2TaxID { get; set; }
        public string Beneficiary2Relationship { get; set; }
        public string Beneficiary2PrimeGreeting { get; set; }
        public string Beneficiary2PrimeAddressLocation { get; set; }
        public string Beneficiary2PrimeAddress1 { get; set; }
        public string Beneficiary2PrimeAddress2 { get; set; }
        public string Beneficiary2PrimeAddress3 { get; set; }
        public string Beneficiary2PrimeCity { get; set; }
        public string Beneficiary2PrimeState { get; set; }
        public string Beneficiary2PrimeZipCode { get; set; }
        public string Beneficiary2PrimeRegion { get; set; }
        public string Beneficiary2PrimeCountry { get; set; }
        public string Beneficiary2PrimeCarrierRoute { get; set; }
        public string Beneficiary2PrimeDeliveryPoint { get; set; }
        public string Beneficiary2PrimePhoneLocation { get; set; }
        public string Beneficiary2PrimePhoneContact { get; set; }
        public string Beneficiary2PrimePhoneCountryCode { get; set; }
        public string Beneficiary2PrimePhoneAreaCode { get; set; }
        public string Beneficiary2PrimePhoneNumber { get; set; }
        public string Beneficiary2PrimePhoneExtension { get; set; }
        public string Beneficiary2PrimeFullPhone { get; set; }
        public string Beneficiary2PrimeEmail { get; set; }
        public Guid? Beneficiary3gUID { get; set; }
        public string Beneficiary3FullName { get; set; }
        public string Beneficiary3FirstName { get; set; }
        public string Beneficiary3MiddleName { get; set; }
        public string Beneficiary3MiddleINITIAL { get; set; }
        public string Beneficiary3Prefix { get; set; }
        public string Beneficiary3Suffix { get; set; }
        public string Beneficiary3LastName { get; set; }
        public bool? Beneficiary3Org { get; set; }
        public DateTime? Beneficiary3DateOfBirth { get; set; }
        public string Beneficiary3TaxID { get; set; }
        public string Beneficiary3Relationship { get; set; }
        public string Beneficiary3PrimeGreeting { get; set; }
        public string Beneficiary3PrimeAddressLocation { get; set; }
        public string Beneficiary3PrimeAddress1 { get; set; }
        public string Beneficiary3PrimeAddress2 { get; set; }
        public string Beneficiary3PrimeAddress3 { get; set; }
        public string Beneficiary3PrimeCity { get; set; }
        public string Beneficiary3PrimeState { get; set; }
        public string Beneficiary3PrimeZipCode { get; set; }
        public string Beneficiary3PrimeRegion { get; set; }
        public string Beneficiary3PrimeCountry { get; set; }
        public string Beneficiary3PrimeCarrierRoute { get; set; }
        public string Beneficiary3PrimeDeliveryPoint { get; set; }
        public string Beneficiary3PrimePhoneLocation { get; set; }
        public string Beneficiary3PrimePhoneContact { get; set; }
        public string Beneficiary3PrimePhoneCountryCode { get; set; }
        public string Beneficiary3PrimePhoneAreaCode { get; set; }
        public string Beneficiary3PrimePhoneNumber { get; set; }
        public string Beneficiary3PrimePhoneExtension { get; set; }
        public string Beneficiary3PrimeFullPhone { get; set; }
        public string Beneficiary3PrimeEmail { get; set; }
        public Guid? BeneficiaryContingentgUID { get; set; }
        public string BeneficiaryContingentFullName { get; set; }
        public string BeneficiaryContingentFirstName { get; set; }
        public string BeneficiaryContingentMiddleName { get; set; }
        public string BeneficiaryContingentMiddleINITIAL { get; set; }
        public string BeneficiaryContingentPrefix { get; set; }
        public string BeneficiaryContingentSuffix { get; set; }
        public string BeneficiaryContingentLastName { get; set; }
        public bool? BeneficiaryContingentOrg { get; set; }
        public DateTime? BeneficiaryContingentDateOfBirth { get; set; }
        public string BeneficiaryContingentTaxID { get; set; }
        public string BeneficiaryContingentRelationship { get; set; }
        public string BeneficiaryContingentPrimePrimeGreeting { get; set; }
        public string BeneficiaryContingentPrimeAddressLocation { get; set; }
        public string BeneficiaryContingentPrimeAddress1 { get; set; }
        public string BeneficiaryContingentPrimeAddress2 { get; set; }
        public string BeneficiaryContingentPrimeAddress3 { get; set; }
        public string BeneficiaryContingentPrimeCity { get; set; }
        public string BeneficiaryContingentPrimeState { get; set; }
        public string BeneficiaryContingentPrimeZipCode { get; set; }
        public string BeneficiaryContingentPrimeRegion { get; set; }
        public string BeneficiaryContingentPrimeCountry { get; set; }
        public string BeneficiaryContingentPrimeCarrierRoute { get; set; }
        public string BeneficiaryContingentPrimeDeliveryPoint { get; set; }
        public string BeneficiaryContingentPrimePhoneLocation { get; set; }
        public string BeneficiaryContingentPrimePhoneContact { get; set; }
        public string BeneficiaryContingentPrimePhoneCountryCode { get; set; }
        public string BeneficiaryContingentPrimePhoneAreaCode { get; set; }
        public string BeneficiaryContingentPrimePhoneNumber { get; set; }
        public string BeneficiaryContingentPrimePhoneExtension { get; set; }
        public string BeneficiaryContingentPrimeFullPhone { get; set; }
        public string BeneficiaryContingentPrimeEmail { get; set; }
        public string RegistrationType { get; set; }
        public string PrimaryObjective { get; set; }
        public string SecondaryObjective { get; set; }
        public string RiskTolerance { get; set; }
        public string TimeHorizon { get; set; }
        public string AccountantgUID { get; set; }
        public string AccountantFullName { get; set; }
        public string AccountantPhoneContact { get; set; }
        public string AccountantPhoneCountryCode { get; set; }
        public string AccountantPhoneAreaCode { get; set; }
        public string AccountantPhoneNumber { get; set; }
        public string AccountantPhoneExtension { get; set; }
        public string AccountantFullPhone { get; set; }
        public Guid? AttorneygUID { get; set; }
        public string AttorneyFullName { get; set; }
        public string AttorneyPhoneContact { get; set; }
        public string AttorneyPhoneCountryCode { get; set; }
        public string AttorneyPhoneAreaCode { get; set; }
        public string AttorneyPhoneNumber { get; set; }
        public string AttorneyPhoneExtension { get; set; }
        public string AttorneyFullPhone { get; set; }
        public Guid? BankgUID { get; set; }
        public string BankFullName { get; set; }
        public string BankBranch { get; set; }
        public string BankRoutingNumber { get; set; }
        public string BankAccount { get; set; }
        public string BankAccountType { get; set; }
        public string BankPhoneContact { get; set; }
        public string BankPhoneCountryCode { get; set; }
        public string BankPhoneAreaCode { get; set; }
        public string BankPhoneNumber { get; set; }
        public string BankPhoneExtension { get; set; }
        public string BankFullPhone { get; set; }
        public string BankAddress1 { get; set; }
        public string BankAddress2 { get; set; }
        public string BankAddress3 { get; set; }
        public string BankCity { get; set; }
        public string BankState { get; set; }
        public string BankZipCode { get; set; }
        public string BankRegion { get; set; }
        public string BankCountry { get; set; }
        public string BankCarrierRoute { get; set; }
        public string BankDeliveryPoint { get; set; }
    }
}
