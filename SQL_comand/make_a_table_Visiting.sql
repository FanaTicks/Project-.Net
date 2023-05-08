IF EXISTS (SELECT name FROM sys.objects
 WHERE name = 'Visiting' AND type_desc = 'USER_TABLE')
drop table Visiting
go
create table Visiting
(ID_Visiting varchar(50) NOT NULL primary key, 
 ID_Ticket varchar(50), constraint ID_Ticket foreign key (ID_Ticket) references Ticket (ID_Ticket),
 Visiting_start_date varchar(10), 
 Visiting_end_date varchar(10), 
 Visiting_type varchar(5))