use Groop_Project_
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Abonement' AND type_desc = 'USER_TABLE')
drop table Abonement
go
create table Abonement
(ID_Abonement varchar(50) NOT NULL primary key, 
 Name_Abonement varchar (50),
 Abonementt_price varchar(50))