/*
Homework 1:
Aşağıdakı procedure'ları yazacaqsınız.
-spAddPersonal (parametrləri alıb yeni data əlavə edəcək və prosedurda şifrələnmə istifadə ediləcək)
*/
exec spAddPersonal 
@personalName='Valeh2',
@personalSurname='Suleyman2', 
@personalEmail='qaqashqaqash2@gmail.com',
@PersonalGender=0,
@personalIsdeleted=0

select * from Personals

create  proc spAddPersonal
(
@personalName nvarchar(50),
@personalSurname nvarchar(50),
@personalEmail nvarchar(250),
@personalGender char(1),
@personalIsdeleted bit
)
with encryption
as
begin
	insert into Personals(PersonalName,PersonalSurname,PersonalEmail,Gender,CreatedDate,UpdatedDate,IsDeleted)
	values(@personalName,@personalSurname,@personalEmail,@personalGender,getdate(),null,0);
end
/*
-spEditPersonal (parametrləri alıb Id'yə görə dataları editləyəcək)*/

select * from Personals

exec spEditPersonal 
@personalID=4,
@personalName='Valikooooo',
@personalSurname='Suliman', 
@personalEmail='hotmail@gmail.com',
@PersonalGender=0,
@personalIsdeleted=0

create  proc spEditPersonal
(
@PersonalID int,
@personalName nvarchar(50),
@personalSurname nvarchar(50),
@personalEmail nvarchar(250),
@personalGender char(1),
@personalIsdeleted bit
)
with encryption
as
begin
	update  Personals set PersonalName=@personalName,
	PersonalSurname=@personalSurname,
	PersonalEmail=@personalEmail,
	Gender=@personalGender,
	CreatedDate=getdate(),
	UpdatedDate=getdate(),
	IsDeleted=@personalIsdeleted
	where PersonalID=@PersonalID;

end
/*
-spRemovePersonal (Id'ə görə datanı siləcək)*/
select * from Personals;
exec spRemovePersonal
@PersonalID=3;

create proc spRemovePersonal
(
@PersonalID int
)
with Encryption
as
begin
delete from Personals where PersonalID=@PersonalID
End;

/*
-spGetAllPersonals (parametr almayan prosedur olacaq)*/
exec spGetAllPersonals;

create proc spGetAllPersonals

with encryption 
as 
begin 
select * from Personals
end

/*
-spGetPersonalById (Id'ə görə 1 dənə personel qaytaracaq)*/
exec spGetPersonalById @id=5;

create proc spGetPersonalById
(
@id int
)
with encryption 
as
begin
select * from Personals where PersonalID=@id;
end
/*
-spSearchPersonalByEmail (aldığı parametri Email column'u üzrə axtarıb nəticəni qaytaracaq)
*/
select * from Personals

exec spSearchPersonalByEmail @Email='qaqashqaqash2@gmail.com';


create proc spSearchPersonalByEmail
(
@Email nvarchar(250)	
)
with encryption
as 
begin
select * from Personals where PersonalEmail=@Email;
end
