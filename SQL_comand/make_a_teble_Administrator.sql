use Groop_Project_
go 

 IF EXISTS (SELECT name FROM sys.objects 
	WHERE name = 'Administrator' AND type_desc = 'USER_TABLE')
drop table Administrator
go
create table Administrator
(ID_Adm varchar(50) NOT NULL primary key,
 Adm_Login  varchar(50),
 Adm_Pass varchar(50),
 Adm_Name varchar(50),
 Adm_SName varchar(50),
 Adm_Phone varchar(50),
 Adm_Post_Adres varchar(50))