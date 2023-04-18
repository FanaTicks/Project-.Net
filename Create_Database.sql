go
IF EXISTS (SELECT name FROM sys.objects
WHERE name = 'Phones' AND type_desc = 'USER_DATABASE')
drop database Phones
go
CREATE DATABASE Phones