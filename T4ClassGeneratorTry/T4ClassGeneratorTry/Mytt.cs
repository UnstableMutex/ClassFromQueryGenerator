using System;
namespace dbo{
public class DatabaseLog
{
public int DatabaseLogID {get;set;}
public DateTime PostTime {get;set;}
public string DatabaseUser {get;set;}
public string Event {get;set;}
public string Schema {get;set;}
public string Object {get;set;}
public string TSQL {get;set;}
public string XmlEvent {get;set;}

}
public class ErrorLog
{
public int ErrorLogID {get;set;}
public DateTime ErrorTime {get;set;}
public string UserName {get;set;}
public int ErrorNumber {get;set;}
public int ErrorSeverity {get;set;}
public int ErrorState {get;set;}
public string ErrorProcedure {get;set;}
public int ErrorLine {get;set;}
public string ErrorMessage {get;set;}

}
public class AWBuildVersion
{
public string SystemInformationID {get;set;}
public string Database Version {get;set;}
public DateTime VersionDate {get;set;}
public DateTime ModifiedDate {get;set;}

}
}
namespace guest{
}
namespace INFORMATION_SCHEMA{
}
namespace sys{
}
namespace HumanResources{
public class Shift
{
public string ShiftID {get;set;}
public string Name {get;set;}
public string StartTime {get;set;}
public string EndTime {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Department
{
public string DepartmentID {get;set;}
public string Name {get;set;}
public string GroupName {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Employee
{
public int BusinessEntityID {get;set;}
public string NationalIDNumber {get;set;}
public string LoginID {get;set;}
public string OrganizationNode {get;set;}
public string OrganizationLevel {get;set;}
public string JobTitle {get;set;}
public string BirthDate {get;set;}
public string MaritalStatus {get;set;}
public string Gender {get;set;}
public string HireDate {get;set;}
public string SalariedFlag {get;set;}
public string VacationHours {get;set;}
public string SickLeaveHours {get;set;}
public string CurrentFlag {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class EmployeeDepartmentHistory
{
public int BusinessEntityID {get;set;}
public string DepartmentID {get;set;}
public string ShiftID {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class EmployeePayHistory
{
public int BusinessEntityID {get;set;}
public DateTime RateChangeDate {get;set;}
public string Rate {get;set;}
public string PayFrequency {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class JobCandidate
{
public int JobCandidateID {get;set;}
public int BusinessEntityID {get;set;}
public string Resume {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vEmployee
{
public int BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string JobTitle {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public int EmailPromotion {get;set;}
public string AddressLine1 {get;set;}
public string AddressLine2 {get;set;}
public string City {get;set;}
public string StateProvinceName {get;set;}
public string PostalCode {get;set;}
public string CountryRegionName {get;set;}
public string AdditionalContactInfo {get;set;}

}
public class vEmployeeDepartment
{
public int BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string JobTitle {get;set;}
public string Department {get;set;}
public string GroupName {get;set;}
public string StartDate {get;set;}

}
public class vEmployeeDepartmentHistory
{
public int BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string Shift {get;set;}
public string Department {get;set;}
public string GroupName {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}

}
public class vJobCandidate
{
public int JobCandidateID {get;set;}
public int BusinessEntityID {get;set;}
public string Name.Prefix {get;set;}
public string Name.First {get;set;}
public string Name.Middle {get;set;}
public string Name.Last {get;set;}
public string Name.Suffix {get;set;}
public string Skills {get;set;}
public string Addr.Type {get;set;}
public string Addr.Loc.CountryRegion {get;set;}
public string Addr.Loc.State {get;set;}
public string Addr.Loc.City {get;set;}
public string Addr.PostalCode {get;set;}
public string EMail {get;set;}
public string WebSite {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vJobCandidateEmployment
{
public int JobCandidateID {get;set;}
public DateTime Emp.StartDate {get;set;}
public DateTime Emp.EndDate {get;set;}
public string Emp.OrgName {get;set;}
public string Emp.JobTitle {get;set;}
public string Emp.Responsibility {get;set;}
public string Emp.FunctionCategory {get;set;}
public string Emp.IndustryCategory {get;set;}
public string Emp.Loc.CountryRegion {get;set;}
public string Emp.Loc.State {get;set;}
public string Emp.Loc.City {get;set;}

}
public class vJobCandidateEducation
{
public int JobCandidateID {get;set;}
public string Edu.Level {get;set;}
public DateTime Edu.StartDate {get;set;}
public DateTime Edu.EndDate {get;set;}
public string Edu.Degree {get;set;}
public string Edu.Major {get;set;}
public string Edu.Minor {get;set;}
public string Edu.GPA {get;set;}
public string Edu.GPAScale {get;set;}
public string Edu.School {get;set;}
public string Edu.Loc.CountryRegion {get;set;}
public string Edu.Loc.State {get;set;}
public string Edu.Loc.City {get;set;}

}
}
namespace Person{
public class Address
{
public int AddressID {get;set;}
public string AddressLine1 {get;set;}
public string AddressLine2 {get;set;}
public string City {get;set;}
public int StateProvinceID {get;set;}
public string PostalCode {get;set;}
public string SpatialLocation {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class AddressType
{
public int AddressTypeID {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class StateProvince
{
public int StateProvinceID {get;set;}
public string StateProvinceCode {get;set;}
public string CountryRegionCode {get;set;}
public string IsOnlyStateProvinceFlag {get;set;}
public string Name {get;set;}
public int TerritoryID {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class BusinessEntity
{
public int BusinessEntityID {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class BusinessEntityAddress
{
public int BusinessEntityID {get;set;}
public int AddressID {get;set;}
public int AddressTypeID {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class BusinessEntityContact
{
public int BusinessEntityID {get;set;}
public int PersonID {get;set;}
public int ContactTypeID {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ContactType
{
public int ContactTypeID {get;set;}
public string Name {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class CountryRegion
{
public string CountryRegionCode {get;set;}
public string Name {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class EmailAddress
{
public int BusinessEntityID {get;set;}
public int EmailAddressID {get;set;}
public string EmailAddress {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Password
{
public int BusinessEntityID {get;set;}
public string PasswordHash {get;set;}
public string PasswordSalt {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Person
{
public int BusinessEntityID {get;set;}
public string PersonType {get;set;}
public string NameStyle {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public int EmailPromotion {get;set;}
public string AdditionalContactInfo {get;set;}
public string Demographics {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vAdditionalContactInfo
{
public int BusinessEntityID {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string TelephoneNumber {get;set;}
public string TelephoneSpecialInstructions {get;set;}
public string Street {get;set;}
public string City {get;set;}
public string StateProvince {get;set;}
public string PostalCode {get;set;}
public string CountryRegion {get;set;}
public string HomeAddressSpecialInstructions {get;set;}
public string EMailAddress {get;set;}
public string EMailSpecialInstructions {get;set;}
public string EMailTelephoneNumber {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class PersonPhone
{
public int BusinessEntityID {get;set;}
public string PhoneNumber {get;set;}
public int PhoneNumberTypeID {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class PhoneNumberType
{
public int PhoneNumberTypeID {get;set;}
public string Name {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vStateProvinceCountryRegion
{
public int StateProvinceID {get;set;}
public string StateProvinceCode {get;set;}
public string IsOnlyStateProvinceFlag {get;set;}
public string StateProvinceName {get;set;}
public int TerritoryID {get;set;}
public string CountryRegionCode {get;set;}
public string CountryRegionName {get;set;}

}
}
namespace Production{
public class ScrapReason
{
public string ScrapReasonID {get;set;}
public string Name {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductCategory
{
public int ProductCategoryID {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductCostHistory
{
public int ProductID {get;set;}
public DateTime StartDate {get;set;}
public DateTime EndDate {get;set;}
public string StandardCost {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductDescription
{
public int ProductDescriptionID {get;set;}
public string Description {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductDocument
{
public int ProductID {get;set;}
public string DocumentNode {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductInventory
{
public int ProductID {get;set;}
public string LocationID {get;set;}
public string Shelf {get;set;}
public string Bin {get;set;}
public string Quantity {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductListPriceHistory
{
public int ProductID {get;set;}
public DateTime StartDate {get;set;}
public DateTime EndDate {get;set;}
public string ListPrice {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductModel
{
public int ProductModelID {get;set;}
public string Name {get;set;}
public string CatalogDescription {get;set;}
public string Instructions {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductModelIllustration
{
public int ProductModelID {get;set;}
public int IllustrationID {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductModelProductDescriptionCulture
{
public int ProductModelID {get;set;}
public int ProductDescriptionID {get;set;}
public string CultureID {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class BillOfMaterials
{
public int BillOfMaterialsID {get;set;}
public int ProductAssemblyID {get;set;}
public int ComponentID {get;set;}
public DateTime StartDate {get;set;}
public DateTime EndDate {get;set;}
public string UnitMeasureCode {get;set;}
public string BOMLevel {get;set;}
public string PerAssemblyQty {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductPhoto
{
public int ProductPhotoID {get;set;}
public string ThumbNailPhoto {get;set;}
public string ThumbnailPhotoFileName {get;set;}
public string LargePhoto {get;set;}
public string LargePhotoFileName {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductProductPhoto
{
public int ProductID {get;set;}
public int ProductPhotoID {get;set;}
public string Primary {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class TransactionHistory
{
public int TransactionID {get;set;}
public int ProductID {get;set;}
public int ReferenceOrderID {get;set;}
public int ReferenceOrderLineID {get;set;}
public DateTime TransactionDate {get;set;}
public string TransactionType {get;set;}
public int Quantity {get;set;}
public string ActualCost {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductReview
{
public int ProductReviewID {get;set;}
public int ProductID {get;set;}
public string ReviewerName {get;set;}
public DateTime ReviewDate {get;set;}
public string EmailAddress {get;set;}
public int Rating {get;set;}
public string Comments {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class TransactionHistoryArchive
{
public int TransactionID {get;set;}
public int ProductID {get;set;}
public int ReferenceOrderID {get;set;}
public int ReferenceOrderLineID {get;set;}
public DateTime TransactionDate {get;set;}
public string TransactionType {get;set;}
public int Quantity {get;set;}
public string ActualCost {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductSubcategory
{
public int ProductSubcategoryID {get;set;}
public int ProductCategoryID {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class UnitMeasure
{
public string UnitMeasureCode {get;set;}
public string Name {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class WorkOrder
{
public int WorkOrderID {get;set;}
public int ProductID {get;set;}
public int OrderQty {get;set;}
public int StockedQty {get;set;}
public string ScrappedQty {get;set;}
public DateTime StartDate {get;set;}
public DateTime EndDate {get;set;}
public DateTime DueDate {get;set;}
public string ScrapReasonID {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Culture
{
public string CultureID {get;set;}
public string Name {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class WorkOrderRouting
{
public int WorkOrderID {get;set;}
public int ProductID {get;set;}
public string OperationSequence {get;set;}
public string LocationID {get;set;}
public DateTime ScheduledStartDate {get;set;}
public DateTime ScheduledEndDate {get;set;}
public DateTime ActualStartDate {get;set;}
public DateTime ActualEndDate {get;set;}
public string ActualResourceHrs {get;set;}
public string PlannedCost {get;set;}
public string ActualCost {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Document
{
public string DocumentNode {get;set;}
public string DocumentLevel {get;set;}
public string Title {get;set;}
public int Owner {get;set;}
public string FolderFlag {get;set;}
public string FileName {get;set;}
public string FileExtension {get;set;}
public string Revision {get;set;}
public int ChangeNumber {get;set;}
public string Status {get;set;}
public string DocumentSummary {get;set;}
public string Document {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Illustration
{
public int IllustrationID {get;set;}
public string Diagram {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Location
{
public string LocationID {get;set;}
public string Name {get;set;}
public string CostRate {get;set;}
public string Availability {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Product
{
public int ProductID {get;set;}
public string Name {get;set;}
public string ProductNumber {get;set;}
public string MakeFlag {get;set;}
public string FinishedGoodsFlag {get;set;}
public string Color {get;set;}
public string SafetyStockLevel {get;set;}
public string ReorderPoint {get;set;}
public string StandardCost {get;set;}
public string ListPrice {get;set;}
public string Size {get;set;}
public string SizeUnitMeasureCode {get;set;}
public string WeightUnitMeasureCode {get;set;}
public string Weight {get;set;}
public int DaysToManufacture {get;set;}
public string ProductLine {get;set;}
public string Class {get;set;}
public string Style {get;set;}
public int ProductSubcategoryID {get;set;}
public int ProductModelID {get;set;}
public DateTime SellStartDate {get;set;}
public DateTime SellEndDate {get;set;}
public DateTime DiscontinuedDate {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vProductAndDescription
{
public int ProductID {get;set;}
public string Name {get;set;}
public string ProductModel {get;set;}
public string CultureID {get;set;}
public string Description {get;set;}

}
public class vProductModelCatalogDescription
{
public int ProductModelID {get;set;}
public string Name {get;set;}
public string Summary {get;set;}
public string Manufacturer {get;set;}
public string Copyright {get;set;}
public string ProductURL {get;set;}
public string WarrantyPeriod {get;set;}
public string WarrantyDescription {get;set;}
public string NoOfYears {get;set;}
public string MaintenanceDescription {get;set;}
public string Wheel {get;set;}
public string Saddle {get;set;}
public string Pedal {get;set;}
public string BikeFrame {get;set;}
public string Crankset {get;set;}
public string PictureAngle {get;set;}
public string PictureSize {get;set;}
public string ProductPhotoID {get;set;}
public string Material {get;set;}
public string Color {get;set;}
public string ProductLine {get;set;}
public string Style {get;set;}
public string RiderExperience {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vProductModelInstructions
{
public int ProductModelID {get;set;}
public string Name {get;set;}
public string Instructions {get;set;}
public int LocationID {get;set;}
public string SetupHours {get;set;}
public string MachineHours {get;set;}
public string LaborHours {get;set;}
public int LotSize {get;set;}
public string Step {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
}
namespace Purchasing{
public class vVendorWithContacts
{
public int BusinessEntityID {get;set;}
public string Name {get;set;}
public string ContactType {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public int EmailPromotion {get;set;}

}
public class vVendorWithAddresses
{
public int BusinessEntityID {get;set;}
public string Name {get;set;}
public string AddressType {get;set;}
public string AddressLine1 {get;set;}
public string AddressLine2 {get;set;}
public string City {get;set;}
public string StateProvinceName {get;set;}
public string PostalCode {get;set;}
public string CountryRegionName {get;set;}

}
public class ShipMethod
{
public int ShipMethodID {get;set;}
public string Name {get;set;}
public string ShipBase {get;set;}
public string ShipRate {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class ProductVendor
{
public int ProductID {get;set;}
public int BusinessEntityID {get;set;}
public int AverageLeadTime {get;set;}
public string StandardPrice {get;set;}
public string LastReceiptCost {get;set;}
public DateTime LastReceiptDate {get;set;}
public int MinOrderQty {get;set;}
public int MaxOrderQty {get;set;}
public int OnOrderQty {get;set;}
public string UnitMeasureCode {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Vendor
{
public int BusinessEntityID {get;set;}
public string AccountNumber {get;set;}
public string Name {get;set;}
public string CreditRating {get;set;}
public string PreferredVendorStatus {get;set;}
public string ActiveFlag {get;set;}
public string PurchasingWebServiceURL {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class PurchaseOrderDetail
{
public int PurchaseOrderID {get;set;}
public int PurchaseOrderDetailID {get;set;}
public DateTime DueDate {get;set;}
public string OrderQty {get;set;}
public int ProductID {get;set;}
public string UnitPrice {get;set;}
public string LineTotal {get;set;}
public string ReceivedQty {get;set;}
public string RejectedQty {get;set;}
public string StockedQty {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class PurchaseOrderHeader
{
public int PurchaseOrderID {get;set;}
public string RevisionNumber {get;set;}
public string Status {get;set;}
public int EmployeeID {get;set;}
public int VendorID {get;set;}
public int ShipMethodID {get;set;}
public DateTime OrderDate {get;set;}
public DateTime ShipDate {get;set;}
public string SubTotal {get;set;}
public string TaxAmt {get;set;}
public string Freight {get;set;}
public string TotalDue {get;set;}
public DateTime ModifiedDate {get;set;}

}
}
namespace Sales{
public class vStoreWithContacts
{
public int BusinessEntityID {get;set;}
public string Name {get;set;}
public string ContactType {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public int EmailPromotion {get;set;}

}
public class vStoreWithAddresses
{
public int BusinessEntityID {get;set;}
public string Name {get;set;}
public string AddressType {get;set;}
public string AddressLine1 {get;set;}
public string AddressLine2 {get;set;}
public string City {get;set;}
public string StateProvinceName {get;set;}
public string PostalCode {get;set;}
public string CountryRegionName {get;set;}

}
public class ShoppingCartItem
{
public int ShoppingCartItemID {get;set;}
public string ShoppingCartID {get;set;}
public int Quantity {get;set;}
public int ProductID {get;set;}
public DateTime DateCreated {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SpecialOffer
{
public int SpecialOfferID {get;set;}
public string Description {get;set;}
public string DiscountPct {get;set;}
public string Type {get;set;}
public string Category {get;set;}
public DateTime StartDate {get;set;}
public DateTime EndDate {get;set;}
public int MinQty {get;set;}
public int MaxQty {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SpecialOfferProduct
{
public int SpecialOfferID {get;set;}
public int ProductID {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Store
{
public int BusinessEntityID {get;set;}
public string Name {get;set;}
public int SalesPersonID {get;set;}
public string Demographics {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class CountryRegionCurrency
{
public string CountryRegionCode {get;set;}
public string CurrencyCode {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class CreditCard
{
public int CreditCardID {get;set;}
public string CardType {get;set;}
public string CardNumber {get;set;}
public string ExpMonth {get;set;}
public string ExpYear {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Currency
{
public string CurrencyCode {get;set;}
public string Name {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class CurrencyRate
{
public int CurrencyRateID {get;set;}
public DateTime CurrencyRateDate {get;set;}
public string FromCurrencyCode {get;set;}
public string ToCurrencyCode {get;set;}
public string AverageRate {get;set;}
public string EndOfDayRate {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class Customer
{
public int CustomerID {get;set;}
public int PersonID {get;set;}
public int StoreID {get;set;}
public int TerritoryID {get;set;}
public string AccountNumber {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesOrderDetail
{
public int SalesOrderID {get;set;}
public int SalesOrderDetailID {get;set;}
public string CarrierTrackingNumber {get;set;}
public string OrderQty {get;set;}
public int ProductID {get;set;}
public int SpecialOfferID {get;set;}
public string UnitPrice {get;set;}
public string UnitPriceDiscount {get;set;}
public string LineTotal {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesOrderHeader
{
public int SalesOrderID {get;set;}
public string RevisionNumber {get;set;}
public DateTime OrderDate {get;set;}
public DateTime DueDate {get;set;}
public DateTime ShipDate {get;set;}
public string Status {get;set;}
public string OnlineOrderFlag {get;set;}
public string SalesOrderNumber {get;set;}
public string PurchaseOrderNumber {get;set;}
public string AccountNumber {get;set;}
public int CustomerID {get;set;}
public int SalesPersonID {get;set;}
public int TerritoryID {get;set;}
public int BillToAddressID {get;set;}
public int ShipToAddressID {get;set;}
public int ShipMethodID {get;set;}
public int CreditCardID {get;set;}
public string CreditCardApprovalCode {get;set;}
public int CurrencyRateID {get;set;}
public string SubTotal {get;set;}
public string TaxAmt {get;set;}
public string Freight {get;set;}
public string TotalDue {get;set;}
public string Comment {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesOrderHeaderSalesReason
{
public int SalesOrderID {get;set;}
public int SalesReasonID {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesPerson
{
public int BusinessEntityID {get;set;}
public int TerritoryID {get;set;}
public string SalesQuota {get;set;}
public string Bonus {get;set;}
public string CommissionPct {get;set;}
public string SalesYTD {get;set;}
public string SalesLastYear {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesPersonQuotaHistory
{
public int BusinessEntityID {get;set;}
public DateTime QuotaDate {get;set;}
public string SalesQuota {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesReason
{
public int SalesReasonID {get;set;}
public string Name {get;set;}
public string ReasonType {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesTaxRate
{
public int SalesTaxRateID {get;set;}
public int StateProvinceID {get;set;}
public string TaxType {get;set;}
public string TaxRate {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class PersonCreditCard
{
public int BusinessEntityID {get;set;}
public int CreditCardID {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class SalesTerritory
{
public int TerritoryID {get;set;}
public string Name {get;set;}
public string CountryRegionCode {get;set;}
public string Group {get;set;}
public string SalesYTD {get;set;}
public string SalesLastYear {get;set;}
public string CostYTD {get;set;}
public string CostLastYear {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vIndividualCustomer
{
public int BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public int EmailPromotion {get;set;}
public string AddressType {get;set;}
public string AddressLine1 {get;set;}
public string AddressLine2 {get;set;}
public string City {get;set;}
public string StateProvinceName {get;set;}
public string PostalCode {get;set;}
public string CountryRegionName {get;set;}
public string Demographics {get;set;}

}
public class vPersonDemographics
{
public int BusinessEntityID {get;set;}
public string TotalPurchaseYTD {get;set;}
public DateTime DateFirstPurchase {get;set;}
public DateTime BirthDate {get;set;}
public string MaritalStatus {get;set;}
public string YearlyIncome {get;set;}
public string Gender {get;set;}
public int TotalChildren {get;set;}
public int NumberChildrenAtHome {get;set;}
public string Education {get;set;}
public string Occupation {get;set;}
public string HomeOwnerFlag {get;set;}
public int NumberCarsOwned {get;set;}

}
public class vSalesPerson
{
public int BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string JobTitle {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public int EmailPromotion {get;set;}
public string AddressLine1 {get;set;}
public string AddressLine2 {get;set;}
public string City {get;set;}
public string StateProvinceName {get;set;}
public string PostalCode {get;set;}
public string CountryRegionName {get;set;}
public string TerritoryName {get;set;}
public string TerritoryGroup {get;set;}
public string SalesQuota {get;set;}
public string SalesYTD {get;set;}
public string SalesLastYear {get;set;}

}
public class SalesTerritoryHistory
{
public int BusinessEntityID {get;set;}
public int TerritoryID {get;set;}
public DateTime StartDate {get;set;}
public DateTime EndDate {get;set;}
public string rowguid {get;set;}
public DateTime ModifiedDate {get;set;}

}
public class vSalesPersonSalesByFiscalYears
{
public int SalesPersonID {get;set;}
public string FullName {get;set;}
public string JobTitle {get;set;}
public string SalesTerritory {get;set;}
public string 2002 {get;set;}
public string 2003 {get;set;}
public string 2004 {get;set;}

}
public class vStoreWithDemographics
{
