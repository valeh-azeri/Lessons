/*
VACİB QEYD: Taskların heç birini edərkən qətiyyən copy-paste etməyin. Bütün sorğuları bir-bir özünüz yazın.

Bütün taskları Adventure Works database'ində işləyəcəksiniz. Table seçimlərini sizə həvalə edirəm.

Homework 1:
Inner, Left, Right və Full join mövzularını mükəmməl bir şəkildə araşdırın və hər biri üçün bir neçə dənə sorğular yazın.
*/
-- inner join 
select * from Person.Person;
select * from Person.PersonPhone;

select * from Person.Person 
inner join Person.PersonPhone
on Person.BusinessEntityID=PersonPhone.BusinessEntityID;

select * from Person.Person  pp
inner join Person.PersonPhone ppn
on pp.BusinessEntityID=ppn.BusinessEntityID;

-- left  join 
select * from Production.Product 
select * from Production.ProductModel

select * from Production.product  pp
left join Production.ProductModel ppm
on pp.ProductID=ppm.ProductModelID


--right join
select * from Production.product  pp
right join Production.ProductModel ppm
on pp.ProductID=ppm.ProductModelID

-- Full join
select * from Production.product  pp
FULL OUTER JOIN Production.ProductModel ppm
on pp.ProductID=ppm.ProductModelID

--Sub Query

/*
Bərabər birləşmə (Equi join)
SELECT column_list 
FROM table1, table2....
WHERE table1.column_name =
table2.column_name; 

və ya  
SELECT *
FROM table1 
JOIN table2
[ON (join_condition)]
--------------------------------------------

Qeyri - bərabər birləşmə (Non-equi join (Theta join))

Bu birləşmə təcrübədə nadir hallarda istifadə olunan SQL birləşmə formasıdır.
Bu birləşmələr bərabər şərtlərdən başqa digər şərti operatorlardan istifadə edən birləşmələrdir.
Sintaksisi aşağıdakı kimidir:

SELECT * or column list
FROM table_name1, table_name2 
WHERE table_name1.column [> | < | >= | <=] table_name2.column;

--------------------------------------------------------------------------
Özü-özünə birləşmə (Self Join) 

SQL özü-özünə birləşmə bir cədvələ qoşulma mexanizmidir. Bu birləşmədən eyni cədvəldəki bəzi digər qeydlər ilə 
cədvəldəki qeydləri birləşdirən bir nəticə toplusu yaratmaq istədikdə istifadə edilir.
Məsələn, bir işçi cədvəlində (employee table) işçilərin hamısını qaytaran və rəhbərlərinin kim olduğunu 
göstərən bir nəticə toplusuna nəzər salmaq istədikdə “self join” istifadə edə bilərik.
Sintaksisi aşağıdakı kimidir:

SELECT a.column_name, b.column_name... 
FROM table1 a, table1 b 
WHERE a.common_filed = b.common_field;

--------------------------------------------------
Çarpaz birləşmə (Cross Join)

Bu birləşmə iki cədvəlin bütün mümkün birləşmələri üçün bütün sətirləri qaytarır. Sol cədvəldən bütün sətirləri əmələ 
gətirir, sonra sağ cədvəldəki bütün sətirlər ilə birləşdirilir. Bu birləşmə bir növ Karteziya məhsulu (Cartesian product ) (A * B) olaraq da bilinir.
Məsələn, sol cədvəldə 100 sətir və sağ cədvəldə də 100 sətir varsa, çarpaz birləşmə nəticəsi 10000 sətir verəcəkdir.
SELECT * 
FROM table1 
CROSS JOIN table2;

----------------------------------------------------------
SQL xarici birləşmə (SQL outer join)

SQL xarici birləşmə, birləşmə şərtini təmin etməyən sətirlər ilə birlikdə qoşulma şərtini təmin edən hər iki iştirak 
cədvəlindən bütün sətirləri qaytarır.
SQL xarici birləşmə (outer join) operatoru (+) qoşulma şərtinin yalnız bir tərəfində istifadə olunur.
Select * 
FROM table1, table2 
WHERE conditions [+];
 

SQL xarici birləşməsinin alt kateqoriyalarına aşağıdakılar aiddir:

SQL soldan birləşmə ( SQL left outer join və ya sadəcə left join)
SQL sağdan birləşmə (SQL  right outer join və ya sadəcə right join)
SQL tam birləşmə (SQL full outer join və ya sadəcə full join)

--------------------------------------------------------------------
Tam birləşmə (Full join)

Tam xarici birləşmə bir INNER birləşməsinin nəticələrini, eləcə də sol və sağ xarici birləşmənin nəticələrini qaytaran 
iki cədvəl arasında birləşmə həyata keçirir. Bir çox verilənlər bazası tam SQL xarici birləşmələrin həyata keçirilməsini 
dəstəkləmir.
SELECT table1.column, table2.column

FROM table1

FULL OUTER JOIN table2

ON (table1.column = table2.column);
------------------------------------------------------------------

Təbii birləşmə (Natural join)
Sonda isə "natural join" haqqında yazmaq istərdim ki, bu birləşmənin də özünə məxsus xüsusiyyətləri vardır. 
Bunlara aşağıdakılar aid edilir.

Birləşmə eyni adı və məlumat növləri olan iki cədvəldəki bütün sütunlara əsaslanır.
Birləşmə, “NATURAL JOIN” açar sözlərindən istifadə edilərək yaradılır.
Bütün uyğun gələn sütunlarda bərabər dəyərlərə sahib olan iki cədvəldən sətir seçir.
 

Sintaksisi aşağıdakı kimidir:
SELECT table1.column, table2.column
FROM table1
NATURAL JOIN table2;

*/
--/----------------------------------------------------------------------------------------------------
/*
1. Teachers adında bir table yaradın. 5 column olsun.
2. Insert əmriylə 5 fərqli məlumat əlavə edin.
3. Məlumatları əlavə etdikdən sonra, məlumatları update edin. Update sorğularınızı müxtəlif yazın. 
   Yəni bir sorğuda 1, digərində 2 column update olsun.
   Bütün update sorğularında where istifadə edin (and or da olsun).
4. Table'dan müəyyən etdiyiniz şərtləri təmin edən dataları silin. Məsələn adı 'Ceyhun' olan datanı, Id'si 2 olan və s.
*/
create database School;
create table Teachers(
	TeacherID int,
	TeacherName nvarchar(50),
	TeacherSurname nvarchar(50),
	TeacherAdress nvarchar(300),
	TeacherDocumentNumber int
);

insert into Teachers (TeacherID,TeacherName,TeacherSurname,TeacherAdress,TeacherDocumentNumber) Values 
(1,'Valeh','Suleymanov','Mingecevir',123456);
insert into Teachers (TeacherID,TeacherName,TeacherSurname,TeacherAdress,TeacherDocumentNumber) Values 
(2,'Naile','Suleymanova','Samux',123457);
insert into Teachers (TeacherID,TeacherName,TeacherSurname,TeacherAdress,TeacherDocumentNumber) Values 
(3,'Tural','Memmedsaatov','Oguz',123457);
insert into Teachers (TeacherID,TeacherName,TeacherSurname,TeacherAdress,TeacherDocumentNumber) Values 
(4,'Akif','Seydeliyev','Gence',123457);
insert into Teachers (TeacherID,TeacherName,TeacherSurname,TeacherAdress,TeacherDocumentNumber) Values 
(5,'Valeh','Ehmedov','Oguz',123457);

update Teachers set TeacherName='Vaqif' where TeacherID=1;
update Teachers set TeacherName='Yegane', TeacherSurname='Memmedsaatova' where TeacherID=2;

delete Teachers where TeacherID>4;
delete Teachers where TeacherName='Valeh' or TeacherID>4;

---------------------------------------------------------------------------------------------------------

/*
Homework 2:
Kod yazaraq aşağıdakı table'ı yaradın. Sonra, UI tərəfdə də eynisini edin sadəcə table adının sonuna UI yazın ki, 
eyni adda iki table olmaz.
Həm kod, həm də UI tərəfdə bu iki table'ı yaratdıqdan sonra UI ilə yaratdığınızı silə bilərsiniz.
Sadəcə məşğələ məqsədi daşıyır. Ancaq Personals
lazım olacaq. Yaradandan sonra aşağıdakı text'i oxuyun...*/

/*
Personals:
		id rəqəm avtomatik artan deyer, boş buraxıla bilməz, təkrarlana bilməz (avtomatik artan dəyəri necə
		yazacağınızı araşdırın)
		name (50 simvollu mətn), boş buraxıla bilməz
		surname (50 simvollu mətn), boş buraxıla bilməz
		email (250 simvollu mətn), boş buraxıla bilməz, eynisi olmamalıdır
		gender (bunu araşdırın ki, 1 simvolu hansı tip datada saxlaya bilərsiniz? bit olmasın.)
		createdDate ,default olaraq indiki zamanı alsın, boş ola bilməz
		updatedDate boş ola bilər
		isDeleted boş olduğu halda false olsun*/
create table Personals(
	PersonalID int identity(1,1) primary key,
	PersonalName nvarchar(50) not null,
	PersonalSurname nvarchar(50) not null,
	PersonalEmail nvarchar(250) not null unique,
	Gender char(1) not null default 1,
	CreatedDate datetime  default getdate(),
	UpdatedDate datetime,
	IsDeleted nvarchar(5) default 'false'
);
/*
Aşağıda yazdığım select sorğusu sizə AdventureWorks database'indən müəyyən datalar qaytaracaq. Sizin etməli olduğunuz, 
aşağıdakı sorğuda sizə gələn
dataları, yuxarıda yaratdığınız Personals table'ınıza insert etməyinizdir. Ad, Soyad, Cinsiyyət select sorğusundan 
gəldiyi kimi daxil ediləcək. Email
ünvanı isə, ad.soyad@gmail.com formatında olacaq. Məsələn orxan.ferecov@gmail.com.
Aşağıdakı sorğuda sizə gələn ad və soyad ilə email generate edəcəksiniz. Ad və soyad böyük hərflə başlayır.
Siz araşdırma edərək ad və soyad'dan email
generate edən zaman ad və soyad'ı kiçik hərflərə çevirməyi tapmalısınız. yəni Orxan Ferecov üçün 
orxan.ferecov@gmail.com generate olunacaq. Bu taskı
etmək üçün, internetdən araşdırma etməlisiniz. Bir select sorğusundan gələn nəticəni başqa table'a insert etməyi 
öyrənməlisiniz.

	select * from Person.Person as PP
	inner join HumanResources.Employee HRE on
	PP.BusinessEntityId = HRE.BusinessEntityId
*/

--/-------------------------------------------------------------------------------------------------------



select * from Person.Person as PP
inner join HumanResources.Employee HRE on
PP.BusinessEntityId = HRE.BusinessEntityId

insert into Personals(PersonalName,PersonalSurname,Gender,PersonalEmail) 
select FirstName, LastName,Gender, Lower(FirstName) +'.'+Lower(LastName)+'@gmail.com' from Person.Person
inner join HumanResources.Employee on Person.Person.BusinessEntityID=HumanResources.Employee.BusinessEntityID
/*
Homework 2:
	Aşağıda yazdığım select sorğusunda hər iki table'dan column'lar gəlir. Siz elə etməlisiniz ki,
	BusinessEntityID column'u Id olaraq, 
	Firstname column'u Name olaraq,
	LastName column'u Surname olaraq,
	əlavə Email column'u Firstname və Lastname'dən 
	istifadə edərək kiçik hərflə orkhan.farajov@gmail.com olaraq, 
	Gender, 
	əlavə Date column'unda indiki tarixi almalısınız.

	select * from Person.Person as PP
	inner join HumanResources.Employee HRE on
	PP.BusinessEntityId = HRE.BusinessEntityId
*/

select BusinessEntityID id, FirstName Name, LastName Surname, Email lower(Name)+'.'+lower(Surname)+'@gmail.com',  
from Person.Person inner join HumanResources.Employee  on
Person.Person.BusinessEntityId = HumanResouce.BusinessEntityId;

