use Store
go
IF EXISTS(SELECT name FROM sys.objects
WHERE name = 'DeliveryView' AND type_desc = 'DeliveryView')
drop view DeliveryView
go
create view DeliveryView
as select ID_delivery,Product_name, Name_worker, Surname_worker, delivery_time, delivery_quantity, delivery_price
from Delivery, Worker, Product
where Delivery.ID_Worker_d = Worker.ID_Worker and Delivery.ID_Product_d = Product.ID_Product