use Groop_Project_
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Ticket1' AND type_desc = 'USER_TABLE')
drop table Ticket1
go
create table Ticket1
(ID_Ticket varchar(50) NOT NULL primary key, 
 ID_Customer_ varchar(50), constraint ID_Customer_ foreign key (ID_Customer_) references Customer (ID_Customer),
 ID_Coach_ varchar(50), constraint ID_Coach_ foreign key (ID_Coach_) references Coach (ID_Coach),
 ID_Adm_ varchar(50), constraint ID_Adm_ foreign key (ID_Adm_) references Administrator (ID_Adm),
 Ticket_type varchar(50),
 Ticket_price varchar(50),
 Ticket_discription varchar(50),
 Ticket_start_date varchar (10),
 Ticket_end_date varchar (10),
 Ticket_permitions varchar (10))


