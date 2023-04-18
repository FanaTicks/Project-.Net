use Store
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Users' AND type_desc = 'USER_TABLE')
drop table Users
go
create table Users
(ID_User char(10) NOT NULL primary key, User_Login varchar(50), User_Password varchar(50), Name_user varchar(50),Surname_user varchar(50), User_Phone varchar(10), User_Post_adress varchar(50))


IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Worker' AND type_desc = 'USER_TABLE')
drop table Worker
go
create table Worker
(ID_Worker char(10) NOT NULL primary key, Worker_Login varchar(50), Worker_Password varchar(50), Name_worker varchar(50),Surname_worker varchar(50), Worker_Phone varchar(10), Worker_Post_adress varchar(50))


IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Manufacturer' AND type_desc = 'USER_TABLE')
drop table Manufacturer
go
create table Manufacturer
(ID_Manufacturer char(18) NOT NULL primary key, Name_Manufacturer varchar(50),Manufacturer_Adress varchar(50), Manufacturer_Phone varchar(10), Country varchar(50))


IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Product' AND type_desc = 'USER_TABLE')
drop table Product
go
create table Product
(ID_Product char(18) NOT NULL primary key, 
Product_name varchar(50), 
Product_type varchar(50), 
Product_description varchar(50), 
Product_image varbinary, Material varchar(50), ID_Manufacturer char(18),constraint ID_Manufacturer foreign key (ID_Manufacturer) references Manufacturer (ID_Manufacturer))


IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Selling' AND type_desc = 'USER_TABLE')
drop table Selling
go
create table Selling
(ID_selling char(18) NOT NULL primary key, 
Selling_price varchar(18), 
Selling_time date, 
Selling_quantity int,
ID_Product_s char(18),
constraint ID_Product_s foreign key (ID_Product_s) references Product (ID_Product),
ID_User char(10),
constraint ID_User foreign key (ID_User) references Users (ID_User),
ID_Worker_s char(10),
constraint ID_Worker_s foreign key (ID_Worker_s) references Worker (ID_Worker),)


IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Delivery' AND type_desc = 'USER_TABLE')
drop table Delivery
go
create table Delivery
(ID_delivery char(18) NOT NULL primary key, 
delivery_price varchar(18), 
delivery_time date, 
delivery_quantity int, 
ID_Product_d char(18),
constraint ID_Product_d foreign key (ID_Product_d) references Product (ID_Product),
ID_Worker_d char(10),
constraint ID_Worker_d foreign key (ID_Worker_d) references Worker (ID_Worker),)