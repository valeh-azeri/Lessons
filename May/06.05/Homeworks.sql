/*
Praktiki tapsiriqlar 1:
1. Production.Product table'ından ProductID'si 20-dən böyük olan məlumatların bütün column'larını gətir.
*/
select * from Production.Product where ProductID>20;
/*
2. Production.Product table'ından ProductID'si 20-dən kiçik olan məlumatların bütün column'larını gətir.
*/
select * from Production.Product where ProductID<20;
/*
3. Production.Product table'ından ListPrice'ı 200-dən böyük, 500-dən kiçik olan məlumatların ProductID, Name və ListPrice column'larını gətir.
*/
select ProductID, [Name], ListPrice  from Production.Product where  ListPrice>200 and ListPrice<500;
/*
4. Production.Product table'ından SafetyStockLevel'i 900-dən böyük, 1500-dən kiçik olan və
ProductID'si 10 olmayan məlumatların bütün column'larını gətir.
*/
select * from Production.Product  where  SafetyStockLevel>900 and SafetyStockLevel<1500 and  ProductID!=10;
/*
5. Production.Product table'ından ProductNumber'ı 'BA-8327' olmayan, Color'u 'Black' olan ilk 50 dənə məlumatın 
bütün column'larını gətir.*/
select top 50 * from Production.Product  where ProductNumber='BA-8327' and Color='Black';
/*
6. Production.Product table'ından ListPrice'ı 500-dən kiçik və ya bərabər olan məlumatların 50%'ni gətir.*/
select top 50 percent * from Production.Product where  ListPrice<=500;
/*
7. Production.Product table'ından ListPrice'ı 1001-dən böyük və ya bərabər olan məlumatların 25%'ni gətir.*/
select top 25 percent * from Production.Product where  ListPrice>=1001;
/*
8. Production.Product table'ından Color'u 'Black' və ya 'Red' olan,
Color'u 'Yellow' olmayan məlumatların bütün column'larını gətir.*/
select * from Production.Product where (Color='Black' or Color='Red') and  Color!='Yellow'; 
/*
9. Production.Product table'ından ProductID'si 100-dən böyük, 500-dən kiçik olan və 300, 
500 olmayan məlumatların ProductID column'unu gətir.*/
select ProductID Identifikasiya from Production.Product where (ProductID>100 and ProductID<500) and  (ProductID!=300 and ProductID!=500);
/*
10. Production.Product table'ından SafetyStockLevel'i 800 və ya 1000 olan amma Color'u 'Black' və ya 'Blue' olmayan məlumatların bütün column'larını gətir.*/
select  * from Production.Product where (SafetyStockLevel=800 or SafetyStockLevel=1000) and (Color!='Black' or Color!='Blue');
/*
11. Person.Address table'ından City, PostalCode və AddressLine1 column'larının dəyərlərini aralarında vergül olmaqla 
FullAddress column adı ilə çəkin.*/
select City+' '+ PostalCode+' '+ AddressLine1 FullAddress  from Person.Address;
/*


Praktiki tapsiriqlar 2:
1. Person.PersonPhone table'ından PhoneNumber column'unda 15 rəqəmi olan məlumatların bütün column'larını gətir.*/
Select * from Person.PersonPhone  where PhoneNumber like '%15%';
/*
2. Person.PersonPhone table'ından PhoneNumber'i 1 rəqəmilə başlayan məlumatların bütün column'larını gətir.*/
select * from Person.PersonPhone where PhoneNumber like '1%';
/*
3. Person.PersonPhone table'ından PhoneNumber'i 15 rəqəmilə bitən məlumatların bütün column'larını gətir.*/
select * from Person.PersonPhone where PhoneNumber like '%15';
/*
4. Person.PersonPhone table'ından PhoneNumber column'unda 82 rəqəmi olan məlumatların bütün column'larını gətir.*/
select * from Person.PersonPhone where PhoneNumber like '%82%';
/*
5. Person.ContactType table'ından Name column'unda a hərfi olan məlumatların bütün column'larını gətir.*/
select * from Person.ContactType where  [Name] like '%a%';
/*
6. Person.ContactType table'ından Name'i r hərfilə başlayan məlumatların bütün column'larını gətir.*/
select * from Person.ContactType where  [Name] like 'r%';
/*
7. Person.ContactType table'ından Name'i s hərfilə bitən məlumatların bütün column'larını gətir.*/
select * from Person.ContactType where  [Name] like '%s';
/*
8. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan məlumatların bütün column'larını gətir.*/
select * from Person.Person where  FirstName like'%a' and  FirstName like 'o%'; 
/*
9. Person.Person table'ından FirstName'i a hərfilə bitən və o hərfilə başlayan və LastName'ında 'ver' sözü olan məlumatların bütün column'larını gətir.*/
select * from Person.Person where  FirstName like'%a' and  FirstName like 'o%' and  LastName like '%ver%'; 
/*
10. Person.Person table'ından FirstName'i a hərfilə bitən və PersonType'ı ZT olmayan ilk 40 məlumatın bütün column'larını gətir.*/
select  top 40 * from Person.Person where  FirstName like'%a' and PersonType!='ZT'; 

/*
VACİB QEYD: Taskların heç birini edərkən qətiyyən copy-paste etməyin. Bütün sorğuları bir-bir özünüz yazın.

Bütün taskları Adventure Works database'ində işləyəcəksiniz. Table seçimlərini sizə həvalə edirəm.

Homework 1:
Ən az 10 fərqli table'dan məlumat select edin.*/
select * from dbo.ErrorLog ;
select * from HumanResources.Department ;
select * from HumanResources.Department ;
select * from HumanResources.Employee ;
select * from HumanResources.EmployeeDepartmentHistory ;
select * from HumanResources.EmployeePayHistory ;
select * from HumanResources.JobCandidate ;
select * from HumanResources.Shift ;
select * from Person.Address ;
select * from Person.CountryRegion;

/*

Homework 2:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 1 column'a şərt qoyun.*/
select * from HumanResources.EmployeePayHistory where PayFrequency=2;
select * from HumanResources.JobCandidate where BusinessEntityID='274' ;
select * from HumanResources.Shift where Name='Day' ;
select * from Person.Address where  City='Bothell' ;
select * from Person.CountryRegion where CountryRegionCode='AL';
/*

Homework 3:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (and ilə).*/

select * from Person.Address where  City='Bothell' and StateProvinceID>30 ;
select * from Person.CountryRegion where CountryRegionCode='AL' or CountryRegionCode='AZ'; 
select * from Person.Address where  City='Bothell' or PostalCode='9811' ;
select * from HumanResources.EmployeePayHistory where BusinessEntityID>50 and Rate>20
select * from HumanResources.Employee where JobTitle  like 's%'  and Gender='M' ;
/*
Homework 4:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 2 column'a şərt qoyun (or ilə).
Homework 5:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (and ilə).

Homework 6:
Ən az 5 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 4 column'a şərt qoyun (or ilə).

Homework 7:
Ən az 6 fərqli table'dan məlumat select edin. Hər select sorğusunda where'da 3-4 column'a şərt qoyun (and və or ilə).

Homework 8:
5 fərqli table'dan ilk 5, 10, 15, 20, 25 məlumatı çəkməyə çalışın. Birindən ilk 5, digərindən ilk 10 və s.*/
Select top 5 * from Person.Address ;
Select top 10 * from Person.AddressType;
Select top 15 * from Person.BusinessEntityContact;
Select top 20 * from Production.Product;
Select top 25 * from Production.ProductDescription;
/*
Homework 9:
Sales.SalesOrderDetail table'dan CarrierTrackingNumber'ində 480 rəqəmi keçən, OrderQty'i 15 olmayanları gətirin.*/
Select * from Sales.SalesOrderDetail where  CarrierTrackingNumber like '%480%' and OrderQty!=15;
/*
	
Homework 10:
Sales.SalesOrderDetail table'dan UnitPrice'ı 250-dən böyük və ya bərabər olan amma 125 olmayan,
ProductID'si 1-dən böyük və 1000-dən kiçik və ya bərabər olanları gətirin
*/

Select * from Sales.SalesOrderDetail where (UnitPrice>=250  and UnitPrice!=125)  and  (ProductID>1 and ProductID<=1000) ;




--------Asagidaki ev ve praktiki tapsiriqlar queries faylinda ayrilib diqqetli olun--------




/*
(IN və NOT IN keçəndən sonrakı hissələrin praktiki və ev tapşırıqları)
Part 3:
1. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, 
Eric olan məlumatların bütün column'larını gətir.*/
Select * from Person.Person where FirstName IN ('Scott','Frank','Eric') order by FirstName desc;
/*
2. In istifadə edərək Person.Person table'ından FirstName column'u Scott, Frank, Eric olan məlumatların 
FirstName, MiddleName, LastName column'larını FullName adı olaraq gətir.*/
Select FirstName+' '+ LastName+' '+MiddleName FullName from Person.Person where FirstName IN ('Scott','Frank','Eric') order by FullName desc;
/*
3. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların bütün column'larını gətir.*/
Select * from Person.Person where FirstName NOT IN ('Eugene','Barry','Jack') order by FirstName desc;
/*

4. Not In istifadə edərək Person.Person table'ından FirstName column'u Eugene, Barry, Jack olmayan məlumatların 
BusinessEntityID column'unun toplamını Total adı olaraq gətir.*/
select  sum(BusinessEntityID) Total  from Person.Person where FirstName Not In ('Eugene','Barry', 'Jack') ; -- SUALI BASA DUSMEDIM 
/*
5. Person.Address table'ından bütün dataları gətir. Ancaq PostalCode column'una görə A-dan Z'yə (artan) sırala.*/
select * from Person.Address order by PostalCode asc;
/*6. Person.Address table'ından bütün dataları gətir. Ancaq City column'una görə Z-dən A'ya (azalan) sırala.*/
select * from Person.Address order by City desc;
/*
7. Person.Address table'ından City column'una görə qruplaşdıraraq neçə adres olduğunu çıxardın. 
Yəni hər şəhər üçün neçə adres məlumatı var? Eyni zamanda da şəhər sayına görə azalan sıralama edin.*/

select City, Count(AddressLine1) from Person.Address  group by City  order by COUNT(AddressLine1) desc;
