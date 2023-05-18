/*
Homework 1:
Ev tapşırığı olaraq custom function'lar yaratmağı öyrənib, kiçik bir calculator app'ı yazacaqsınız.
C#'da etdiyiniz calculator app'lar kimi hazırlaya bilərsiniz. Əsas məsələ custom function'larla
işləməkdir.*/
create function Topla(@sayi1 int, @sayi2 int)
returns int 
as  
begin
declare @toplam int
set @toplam=@sayi1+@sayi2
return  @toplam 
end

create function Cixma(@sayi1 int, @sayi2 int)
returns int 
as  
begin
declare @cixma int
set @cixma=@sayi1-@sayi2
return  @cixma  
end

create function Vurma(@sayi1 int, @sayi2 int)
returns int 
as  
begin
declare @vurma int
set @vurma=@sayi1*@sayi2
return  @vurma  
end

create function Bolme(@sayi1 int, @sayi2 int)
returns int 
as  
begin
declare @bolme int
if(@sayi2=0) 
begin 
set 
@bolme=0
end
else 
begin
set
@bolme=@sayi1/@sayi2
end
return  @bolme  
end


select dbo.Topla(15,10);
select dbo.Cixma(15,10);
select dbo.Vurma(15,10);
select dbo.Bolme(0,10);
select dbo.Bolme(10,2);
/*
Homework 2:
C#'da bildiyiniz bütün data tiplərin SQL'dəki qarşılığını tapın. Bir table yaradıb, C#'da bildiyiniz bütün 
data tiplərinin SQL'də olan qarşılığından istifadə edərək praktika edin. İnsertlərini də yazın mütləq.

bigint = 8 baytliq,  ondalik deyer  almir
binary = 2 li  deyer  
bit = true/false (bool)
char = sabit uzunluq, riyazi islemler  olmayacaq (char)
varchar=deyisken uzunlukdaki  deyer(ayirdigi yer  de  girilen uzunluga  gore  deyer alir, 
		charda  deyer  uzunlugu ne veribse onun  ucun yer  acir)


*/
