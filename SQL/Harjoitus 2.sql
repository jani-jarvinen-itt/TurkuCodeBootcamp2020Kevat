-- Harjoitus 2.1
SELECT COUNT(CustomerID)
FROM Customers

-- Harjoitus 2.2
SELECT -- ProductName, UnitPrice, UnitsInStock,
SUM(UnitPrice * UnitsInStock) AS 'Varastoarvo'
FROM Products

-- Harjoitus 2.3
/*
SELECT ProductID
FROM Products
WHERE ProductName LIKE '%tofu%'
*/

SELECT -- OrderID, ProductID, UnitPrice, Quantity,
SUM(UnitPrice * Quantity * (1-Discount)) AS 'Yhteensä'
FROM [Order Details]
WHERE ProductID IN (SELECT ProductID
					FROM Products
					WHERE ProductName LIKE '%tofu%')

/*
SELECT *
FROM [Order Details]
*/