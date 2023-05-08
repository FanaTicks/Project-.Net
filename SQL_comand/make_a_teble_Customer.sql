use Groop_Project_
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Customer' AND type_desc = 'USER_TABLE')
drop table Customer
go
create table Customer
(ID_Customer varchar(50) NOT NULL primary key, Customer_name varchar(50), Customer_surname varchar(50), Customer_Phone varchar(50), Customer_Post_Adres varchar(50))
