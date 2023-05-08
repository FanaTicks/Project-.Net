use Groop_Project_
go
IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Ticket' AND type_desc = 'USER_TABLE')
drop table Ticket
go
create table Ticket
(ID_Ticket varchar(50) NOT NULL primary key, 
 ID_Coach varchar(50), constraint ID_Coach foreign key (ID_Coach) references Coach (ID_Coach),
 Name_Customer varchar (50),
 SName_Customer varchar (50),
 Ticket_type varchar(50),
 Ticket_price varchar(50),
 Ticket_discription varchar(50),
 Ticket_start_date varchar (10),
 Ticket_end_date varchar (10),
 Ticket_permitions varchar (10))
