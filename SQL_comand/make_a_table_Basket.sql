use Groop_Project_
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Basket' AND type_desc = 'USER_TABLE')
drop table Basket
go
create table Basket
(ID_Product_ varchar(50) NOT NULL primary key, Product_name_ varchar(50), Product_description_ varchar(50), Product_cost_ real, Product_quantity_ real, Basket_time varchar(16))

