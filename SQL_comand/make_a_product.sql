use Groop_Project_
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Product' AND type_desc = 'USER_TABLE')
drop table Product
go
create table Product
(ID_Product varchar(50) NOT NULL primary key, Product_name varchar(50), Product_description varchar(50), Product_cost varchar(50), Product_quantity varchar(50))


IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Order_' AND type_desc = 'USER_TABLE')
drop table Order_
go
create table Order_
(ID_Order varchar(50) NOT NULL primary key,
 ID_Customer varchar(50), constraint ID_Customer foreign key (ID_Customer) references Customer (ID_Customer),
 ID_Product varchar(50), constraint ID_Product foreign key (ID_Product) references Product (ID_Product),
 ID_Adm varchar(50), constraint ID_Adm foreign key (ID_Adm) references Administrator (ID_Adm),
 Order_price varchar(50),
 Order_date varchar(10),
 Order_discription varchar(50))
