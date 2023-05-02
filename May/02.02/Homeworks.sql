/*
Homework 1:
Dərsdə restore etdiyiniz AdventureWorks2017 database'ini silin və yenidən restore edin.

Homework 2:
Aşağıdakı mövzuları araşdırın:
Sql Server Management Studio'nun nə olduğu haqqında araşdırma edin.
Database nədir?
Table nədir?
Column nədir?
Row nədir?

Homework 3:
AdventureWorks2017 database'ində aşağıdakı məlumatları almaq üçün lazım olan select sorğularını yazın.

Store adlı table'dan bütün column'ları select edin.

Product adlı table'dan bütün column'ları select edin.

ProductCategory adlı table'dan sadəcə ProductCategoryID və Name column'larını select edin.

AddressType adlı table'dan sadəcə AddressTypeID və Name column'larını select edin.

Document adlı table'dan sadəcə Title, FileName, ChangeNumber və Status column'larını select edin.
*/
use AdventureWorks2017;
Select * from  Sales.Store;
Select * from Production.Product;
Select ProductCategoryID, Name  from Production.ProductCategory;
Select  AddressTypeID, Name from Person.AddressType;
Select Title, FileName, ChangeNumber, Status  from Production.Document;
/*

Homework 4:
Araşdırıb və ya düşünüb yaza biləcəyiniz bonus sorğu (yaza bilməsəniz eybi yox):*/
Select Name from Production.ProductCategory where ProductCategoryID=1;
Select Name from Production.ProductCategory where ProductCategoryID=2;
Select Name from Production.ProductCategory where ProductCategoryID=3;
Select Name from Production.ProductCategory where ProductCategoryID=4;
/*
Store table'ından bütün məlumatları * ilə çəkin. Sadəcə ilk column SalesPersonID olsun.
Bu sorğuda SalesPersonID iki dəfə çıxsa da olar eybi yox
*/

Select SalesPersonID, * from  Sales.Store    ;