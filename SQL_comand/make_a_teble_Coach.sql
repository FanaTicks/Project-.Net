use Groop_Project_
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Speciality' AND type_desc = 'USER_TABLE')
drop table Speciality
go
create table Speciality
(ID_Speciality varchar(50) NOT NULL primary key, Speciality_name varchar(50), Speciality_description varchar(50), Experience varchar(50))


IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Coach' AND type_desc = 'USER_TABLE')
drop table Coach
go
create table Coach
(ID_Coach varchar(50) NOT NULL primary key, 
 ID_Speciality varchar(50), constraint ID_Speciality foreign key (ID_Speciality) references Speciality (ID_Speciality),
 Coach_Login varchar(50), 
 Coach_Password varchar(50), 
 Coach_Name varchar(50),
 Coach_Surname varchar(50), 
 Coach_Phone varchar(10), 
 Coach_Post_adress varchar(50))