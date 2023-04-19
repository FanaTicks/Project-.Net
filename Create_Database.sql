go
IF EXISTS (SELECT name FROM sys.objects
WHERE name = 'Store' AND type_desc = 'USER_DATABASE')
drop database Store
go
CREATE DATABASE Store
