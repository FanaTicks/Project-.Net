use Store
go
IF EXISTS(SELECT name FROM sys.objects
WHERE name = 'SellingView' AND type_desc = 'SellingView')
drop view SellingView
go
create view SellingView
as select ID_selling,Product_name, Name_worker, Surname_worker,Name_user, Surname_user, Selling_time, Selling_quantity, Selling_price
from Selling, Worker, Users, Product
where Selling.ID_Worker_s = Worker.ID_Worker and Selling.ID_User = Users.ID_User and Selling.ID_Product_s = Product.ID_Product