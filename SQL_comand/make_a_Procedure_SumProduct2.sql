use Groop_Project_
go
CREATE PROC EndSumProduct AS
SELECT SUM(Product_cost_) AS 'Ціна до сплати'
FROM Basket