namespace dbo{
public class DatabaseLog
{
public string DatabaseLogID {get;set;}
public string PostTime {get;set;}
public string DatabaseUser {get;set;}
public string Event {get;set;}
public string Schema {get;set;}
public string Object {get;set;}
public string TSQL {get;set;}
public string XmlEvent {get;set;}

}
public class ErrorLog
{
public string ErrorLogID {get;set;}
public string ErrorTime {get;set;}
public string UserName {get;set;}
public string ErrorNumber {get;set;}
public string ErrorSeverity {get;set;}
public string ErrorState {get;set;}
public string ErrorProcedure {get;set;}
public string ErrorLine {get;set;}
public string ErrorMessage {get;set;}

}
public class AWBuildVersion
{
public string SystemInformationID {get;set;}
public string Database Version {get;set;}
public string VersionDate {get;set;}
public string ModifiedDate {get;set;}

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
public string ModifiedDate {get;set;}

}
public class Department
{
public string DepartmentID {get;set;}
public string Name {get;set;}
public string GroupName {get;set;}
public string ModifiedDate {get;set;}

}
public class Employee
{
public string BusinessEntityID {get;set;}
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
public string ModifiedDate {get;set;}

}
public class EmployeeDepartmentHistory
{
public string BusinessEntityID {get;set;}
public string DepartmentID {get;set;}
public string ShiftID {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public string ModifiedDate {get;set;}

}
public class EmployeePayHistory
{
public string BusinessEntityID {get;set;}
public string RateChangeDate {get;set;}
public string Rate {get;set;}
public string PayFrequency {get;set;}
public string ModifiedDate {get;set;}

}
public class JobCandidate
{
public string JobCandidateID {get;set;}
public string BusinessEntityID {get;set;}
public string Resume {get;set;}
public string ModifiedDate {get;set;}

}
public class vEmployee
{
public string BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string JobTitle {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public string EmailPromotion {get;set;}
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
public string BusinessEntityID {get;set;}
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
public string BusinessEntityID {get;set;}
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
public string JobCandidateID {get;set;}
public string BusinessEntityID {get;set;}
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
public string ModifiedDate {get;set;}

}
public class vJobCandidateEmployment
{
public string JobCandidateID {get;set;}
public string Emp.StartDate {get;set;}
public string Emp.EndDate {get;set;}
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
public string JobCandidateID {get;set;}
public string Edu.Level {get;set;}
public string Edu.StartDate {get;set;}
public string Edu.EndDate {get;set;}
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
public string AddressID {get;set;}
public string AddressLine1 {get;set;}
public string AddressLine2 {get;set;}
public string City {get;set;}
public string StateProvinceID {get;set;}
public string PostalCode {get;set;}
public string SpatialLocation {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class AddressType
{
public string AddressTypeID {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class StateProvince
{
public string StateProvinceID {get;set;}
public string StateProvinceCode {get;set;}
public string CountryRegionCode {get;set;}
public string IsOnlyStateProvinceFlag {get;set;}
public string Name {get;set;}
public string TerritoryID {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class BusinessEntity
{
public string BusinessEntityID {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class BusinessEntityAddress
{
public string BusinessEntityID {get;set;}
public string AddressID {get;set;}
public string AddressTypeID {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class BusinessEntityContact
{
public string BusinessEntityID {get;set;}
public string PersonID {get;set;}
public string ContactTypeID {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class ContactType
{
public string ContactTypeID {get;set;}
public string Name {get;set;}
public string ModifiedDate {get;set;}

}
public class CountryRegion
{
public string CountryRegionCode {get;set;}
public string Name {get;set;}
public string ModifiedDate {get;set;}

}
public class EmailAddress
{
public string BusinessEntityID {get;set;}
public string EmailAddressID {get;set;}
public string EmailAddress {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class Password
{
public string BusinessEntityID {get;set;}
public string PasswordHash {get;set;}
public string PasswordSalt {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class Person
{
public string BusinessEntityID {get;set;}
public string PersonType {get;set;}
public string NameStyle {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string EmailPromotion {get;set;}
public string AdditionalContactInfo {get;set;}
public string Demographics {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class vAdditionalContactInfo
{
public string BusinessEntityID {get;set;}
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
public string ModifiedDate {get;set;}

}
public class PersonPhone
{
public string BusinessEntityID {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberTypeID {get;set;}
public string ModifiedDate {get;set;}

}
public class PhoneNumberType
{
public string PhoneNumberTypeID {get;set;}
public string Name {get;set;}
public string ModifiedDate {get;set;}

}
public class vStateProvinceCountryRegion
{
public string StateProvinceID {get;set;}
public string StateProvinceCode {get;set;}
public string IsOnlyStateProvinceFlag {get;set;}
public string StateProvinceName {get;set;}
public string TerritoryID {get;set;}
public string CountryRegionCode {get;set;}
public string CountryRegionName {get;set;}

}
}
namespace Production{
public class ScrapReason
{
public string ScrapReasonID {get;set;}
public string Name {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductCategory
{
public string ProductCategoryID {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductCostHistory
{
public string ProductID {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public string StandardCost {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductDescription
{
public string ProductDescriptionID {get;set;}
public string Description {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductDocument
{
public string ProductID {get;set;}
public string DocumentNode {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductInventory
{
public string ProductID {get;set;}
public string LocationID {get;set;}
public string Shelf {get;set;}
public string Bin {get;set;}
public string Quantity {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductListPriceHistory
{
public string ProductID {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public string ListPrice {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductModel
{
public string ProductModelID {get;set;}
public string Name {get;set;}
public string CatalogDescription {get;set;}
public string Instructions {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductModelIllustration
{
public string ProductModelID {get;set;}
public string IllustrationID {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductModelProductDescriptionCulture
{
public string ProductModelID {get;set;}
public string ProductDescriptionID {get;set;}
public string CultureID {get;set;}
public string ModifiedDate {get;set;}

}
public class BillOfMaterials
{
public string BillOfMaterialsID {get;set;}
public string ProductAssemblyID {get;set;}
public string ComponentID {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public string UnitMeasureCode {get;set;}
public string BOMLevel {get;set;}
public string PerAssemblyQty {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductPhoto
{
public string ProductPhotoID {get;set;}
public string ThumbNailPhoto {get;set;}
public string ThumbnailPhotoFileName {get;set;}
public string LargePhoto {get;set;}
public string LargePhotoFileName {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductProductPhoto
{
public string ProductID {get;set;}
public string ProductPhotoID {get;set;}
public string Primary {get;set;}
public string ModifiedDate {get;set;}

}
public class TransactionHistory
{
public string TransactionID {get;set;}
public string ProductID {get;set;}
public string ReferenceOrderID {get;set;}
public string ReferenceOrderLineID {get;set;}
public string TransactionDate {get;set;}
public string TransactionType {get;set;}
public string Quantity {get;set;}
public string ActualCost {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductReview
{
public string ProductReviewID {get;set;}
public string ProductID {get;set;}
public string ReviewerName {get;set;}
public string ReviewDate {get;set;}
public string EmailAddress {get;set;}
public string Rating {get;set;}
public string Comments {get;set;}
public string ModifiedDate {get;set;}

}
public class TransactionHistoryArchive
{
public string TransactionID {get;set;}
public string ProductID {get;set;}
public string ReferenceOrderID {get;set;}
public string ReferenceOrderLineID {get;set;}
public string TransactionDate {get;set;}
public string TransactionType {get;set;}
public string Quantity {get;set;}
public string ActualCost {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductSubcategory
{
public string ProductSubcategoryID {get;set;}
public string ProductCategoryID {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class UnitMeasure
{
public string UnitMeasureCode {get;set;}
public string Name {get;set;}
public string ModifiedDate {get;set;}

}
public class WorkOrder
{
public string WorkOrderID {get;set;}
public string ProductID {get;set;}
public string OrderQty {get;set;}
public string StockedQty {get;set;}
public string ScrappedQty {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public string DueDate {get;set;}
public string ScrapReasonID {get;set;}
public string ModifiedDate {get;set;}

}
public class Culture
{
public string CultureID {get;set;}
public string Name {get;set;}
public string ModifiedDate {get;set;}

}
public class WorkOrderRouting
{
public string WorkOrderID {get;set;}
public string ProductID {get;set;}
public string OperationSequence {get;set;}
public string LocationID {get;set;}
public string ScheduledStartDate {get;set;}
public string ScheduledEndDate {get;set;}
public string ActualStartDate {get;set;}
public string ActualEndDate {get;set;}
public string ActualResourceHrs {get;set;}
public string PlannedCost {get;set;}
public string ActualCost {get;set;}
public string ModifiedDate {get;set;}

}
public class Document
{
public string DocumentNode {get;set;}
public string DocumentLevel {get;set;}
public string Title {get;set;}
public string Owner {get;set;}
public string FolderFlag {get;set;}
public string FileName {get;set;}
public string FileExtension {get;set;}
public string Revision {get;set;}
public string ChangeNumber {get;set;}
public string Status {get;set;}
public string DocumentSummary {get;set;}
public string Document {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class Illustration
{
public string IllustrationID {get;set;}
public string Diagram {get;set;}
public string ModifiedDate {get;set;}

}
public class Location
{
public string LocationID {get;set;}
public string Name {get;set;}
public string CostRate {get;set;}
public string Availability {get;set;}
public string ModifiedDate {get;set;}

}
public class Product
{
public string ProductID {get;set;}
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
public string DaysToManufacture {get;set;}
public string ProductLine {get;set;}
public string Class {get;set;}
public string Style {get;set;}
public string ProductSubcategoryID {get;set;}
public string ProductModelID {get;set;}
public string SellStartDate {get;set;}
public string SellEndDate {get;set;}
public string DiscontinuedDate {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class vProductAndDescription
{
public string ProductID {get;set;}
public string Name {get;set;}
public string ProductModel {get;set;}
public string CultureID {get;set;}
public string Description {get;set;}

}
public class vProductModelCatalogDescription
{
public string ProductModelID {get;set;}
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
public string ModifiedDate {get;set;}

}
public class vProductModelInstructions
{
public string ProductModelID {get;set;}
public string Name {get;set;}
public string Instructions {get;set;}
public string LocationID {get;set;}
public string SetupHours {get;set;}
public string MachineHours {get;set;}
public string LaborHours {get;set;}
public string LotSize {get;set;}
public string Step {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
}
namespace Purchasing{
public class vVendorWithContacts
{
public string BusinessEntityID {get;set;}
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
public string EmailPromotion {get;set;}

}
public class vVendorWithAddresses
{
public string BusinessEntityID {get;set;}
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
public string ShipMethodID {get;set;}
public string Name {get;set;}
public string ShipBase {get;set;}
public string ShipRate {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class ProductVendor
{
public string ProductID {get;set;}
public string BusinessEntityID {get;set;}
public string AverageLeadTime {get;set;}
public string StandardPrice {get;set;}
public string LastReceiptCost {get;set;}
public string LastReceiptDate {get;set;}
public string MinOrderQty {get;set;}
public string MaxOrderQty {get;set;}
public string OnOrderQty {get;set;}
public string UnitMeasureCode {get;set;}
public string ModifiedDate {get;set;}

}
public class Vendor
{
public string BusinessEntityID {get;set;}
public string AccountNumber {get;set;}
public string Name {get;set;}
public string CreditRating {get;set;}
public string PreferredVendorStatus {get;set;}
public string ActiveFlag {get;set;}
public string PurchasingWebServiceURL {get;set;}
public string ModifiedDate {get;set;}

}
public class PurchaseOrderDetail
{
public string PurchaseOrderID {get;set;}
public string PurchaseOrderDetailID {get;set;}
public string DueDate {get;set;}
public string OrderQty {get;set;}
public string ProductID {get;set;}
public string UnitPrice {get;set;}
public string LineTotal {get;set;}
public string ReceivedQty {get;set;}
public string RejectedQty {get;set;}
public string StockedQty {get;set;}
public string ModifiedDate {get;set;}

}
public class PurchaseOrderHeader
{
public string PurchaseOrderID {get;set;}
public string RevisionNumber {get;set;}
public string Status {get;set;}
public string EmployeeID {get;set;}
public string VendorID {get;set;}
public string ShipMethodID {get;set;}
public string OrderDate {get;set;}
public string ShipDate {get;set;}
public string SubTotal {get;set;}
public string TaxAmt {get;set;}
public string Freight {get;set;}
public string TotalDue {get;set;}
public string ModifiedDate {get;set;}

}
}
namespace Sales{
public class vStoreWithContacts
{
public string BusinessEntityID {get;set;}
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
public string EmailPromotion {get;set;}

}
public class vStoreWithAddresses
{
public string BusinessEntityID {get;set;}
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
public string ShoppingCartItemID {get;set;}
public string ShoppingCartID {get;set;}
public string Quantity {get;set;}
public string ProductID {get;set;}
public string DateCreated {get;set;}
public string ModifiedDate {get;set;}

}
public class SpecialOffer
{
public string SpecialOfferID {get;set;}
public string Description {get;set;}
public string DiscountPct {get;set;}
public string Type {get;set;}
public string Category {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public string MinQty {get;set;}
public string MaxQty {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class SpecialOfferProduct
{
public string SpecialOfferID {get;set;}
public string ProductID {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class Store
{
public string BusinessEntityID {get;set;}
public string Name {get;set;}
public string SalesPersonID {get;set;}
public string Demographics {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class CountryRegionCurrency
{
public string CountryRegionCode {get;set;}
public string CurrencyCode {get;set;}
public string ModifiedDate {get;set;}

}
public class CreditCard
{
public string CreditCardID {get;set;}
public string CardType {get;set;}
public string CardNumber {get;set;}
public string ExpMonth {get;set;}
public string ExpYear {get;set;}
public string ModifiedDate {get;set;}

}
public class Currency
{
public string CurrencyCode {get;set;}
public string Name {get;set;}
public string ModifiedDate {get;set;}

}
public class CurrencyRate
{
public string CurrencyRateID {get;set;}
public string CurrencyRateDate {get;set;}
public string FromCurrencyCode {get;set;}
public string ToCurrencyCode {get;set;}
public string AverageRate {get;set;}
public string EndOfDayRate {get;set;}
public string ModifiedDate {get;set;}

}
public class Customer
{
public string CustomerID {get;set;}
public string PersonID {get;set;}
public string StoreID {get;set;}
public string TerritoryID {get;set;}
public string AccountNumber {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesOrderDetail
{
public string SalesOrderID {get;set;}
public string SalesOrderDetailID {get;set;}
public string CarrierTrackingNumber {get;set;}
public string OrderQty {get;set;}
public string ProductID {get;set;}
public string SpecialOfferID {get;set;}
public string UnitPrice {get;set;}
public string UnitPriceDiscount {get;set;}
public string LineTotal {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesOrderHeader
{
public string SalesOrderID {get;set;}
public string RevisionNumber {get;set;}
public string OrderDate {get;set;}
public string DueDate {get;set;}
public string ShipDate {get;set;}
public string Status {get;set;}
public string OnlineOrderFlag {get;set;}
public string SalesOrderNumber {get;set;}
public string PurchaseOrderNumber {get;set;}
public string AccountNumber {get;set;}
public string CustomerID {get;set;}
public string SalesPersonID {get;set;}
public string TerritoryID {get;set;}
public string BillToAddressID {get;set;}
public string ShipToAddressID {get;set;}
public string ShipMethodID {get;set;}
public string CreditCardID {get;set;}
public string CreditCardApprovalCode {get;set;}
public string CurrencyRateID {get;set;}
public string SubTotal {get;set;}
public string TaxAmt {get;set;}
public string Freight {get;set;}
public string TotalDue {get;set;}
public string Comment {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesOrderHeaderSalesReason
{
public string SalesOrderID {get;set;}
public string SalesReasonID {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesPerson
{
public string BusinessEntityID {get;set;}
public string TerritoryID {get;set;}
public string SalesQuota {get;set;}
public string Bonus {get;set;}
public string CommissionPct {get;set;}
public string SalesYTD {get;set;}
public string SalesLastYear {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesPersonQuotaHistory
{
public string BusinessEntityID {get;set;}
public string QuotaDate {get;set;}
public string SalesQuota {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesReason
{
public string SalesReasonID {get;set;}
public string Name {get;set;}
public string ReasonType {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesTaxRate
{
public string SalesTaxRateID {get;set;}
public string StateProvinceID {get;set;}
public string TaxType {get;set;}
public string TaxRate {get;set;}
public string Name {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class PersonCreditCard
{
public string BusinessEntityID {get;set;}
public string CreditCardID {get;set;}
public string ModifiedDate {get;set;}

}
public class SalesTerritory
{
public string TerritoryID {get;set;}
public string Name {get;set;}
public string CountryRegionCode {get;set;}
public string Group {get;set;}
public string SalesYTD {get;set;}
public string SalesLastYear {get;set;}
public string CostYTD {get;set;}
public string CostLastYear {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class vIndividualCustomer
{
public string BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public string EmailPromotion {get;set;}
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
public string BusinessEntityID {get;set;}
public string TotalPurchaseYTD {get;set;}
public string DateFirstPurchase {get;set;}
public string BirthDate {get;set;}
public string MaritalStatus {get;set;}
public string YearlyIncome {get;set;}
public string Gender {get;set;}
public string TotalChildren {get;set;}
public string NumberChildrenAtHome {get;set;}
public string Education {get;set;}
public string Occupation {get;set;}
public string HomeOwnerFlag {get;set;}
public string NumberCarsOwned {get;set;}

}
public class vSalesPerson
{
public string BusinessEntityID {get;set;}
public string Title {get;set;}
public string FirstName {get;set;}
public string MiddleName {get;set;}
public string LastName {get;set;}
public string Suffix {get;set;}
public string JobTitle {get;set;}
public string PhoneNumber {get;set;}
public string PhoneNumberType {get;set;}
public string EmailAddress {get;set;}
public string EmailPromotion {get;set;}
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
public string BusinessEntityID {get;set;}
public string TerritoryID {get;set;}
public string StartDate {get;set;}
public string EndDate {get;set;}
public string rowguid {get;set;}
public string ModifiedDate {get;set;}

}
public class vSalesPersonSalesByFiscalYears
{
public string SalesPersonID {get;set;}
public string FullName {get;set;}
public string JobTitle {get;set;}
public string SalesTerritory {get;set;}
public string 2002 {get;set;}
public string 2003 {get;set;}
public string 2004 {get;set;}

}
public class vStoreWithDemographics
{
public string BusinessEntityID {get;set;}
public string Name {get;set;}
public string AnnualSales {get;set;}
public string AnnualRevenue {get;set;}
public string BankName {get;set;}
public string BusinessType {get;set;}
public string YearOpened {get;set;}
public string Specialty {get;set;}
public string SquareFeet {get;set;}
public string Brands {get;set;}
public string Internet {get;set;}
public string NumberEmployees {get;set;}

}
}
namespace db_owner{
}
namespace db_accessadmin{
}
namespace db_securityadmin{
}
namespace db_ddladmin{
}
namespace db_backupoperator{
}
namespace db_datareader{
}
namespace db_datawriter{
}
namespace db_denydatareader{
}
namespace db_denydatawriter{
}

