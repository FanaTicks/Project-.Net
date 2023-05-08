go
IF EXISTS (SELECT name FROM sys.objects
WHERE name = 'Groop_Project_' AND type_desc = 'USER_DATABASE')
drop database Groop_Project_
go
CREATE DATABASE Groop_Project_
