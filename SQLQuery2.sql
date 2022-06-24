--1
use AdventureWorks2019
Go

SELECT c.Name AS Country,s.Name AS Province
FROM Person.CountryRegion AS c JOIN Person.StateProvince AS s ON c.CountryRegionCode = s.CountryRegionCode

--2
SELECT c.Name AS Country,s.Name AS Province
FROM Person.CountryRegion AS c JOIN Person.StateProvince AS s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany','Canada')

--3
use Northwind
GO

declare @today datetime
select @today = GETDATE()

SELECT DISTINCT d.ProductID,COUNT(d.Quantity) AS prodNumber
FROM Orders AS o JOIN [Order Details] AS d ON o.OrderID = d.OrderID JOIN Products AS p ON d.ProductID = p.ProductID
WHERE @today - o.OrderDate > 25
GROUP BY d.ProductID
HAVING COUNT(d.Quantity) >= 1

--4
--declare @today datetime
--select @today = GETDATE()

SELECT TOP 5 o.ShipPostalCode,COUNT(d.Quantity*p.UnitsOnOrder) AS prodNumber 
FROM Orders AS o JOIN [Order Details] AS d ON o.OrderID = d.OrderID JOIN Products AS p ON d.ProductID = p.ProductID
WHERE @today - o.OrderDate > 25
GROUP BY o.ShipPostalCode
ORDER BY COUNT(d.Quantity*p.UnitsOnOrder) DESC

--5
SELECT City, COUNT(City) AS #ofCus
FROM Customers
GROUP BY City

--6
SELECT City, COUNT(City) AS #ofCus
FROM Customers
GROUP BY City
HAVING COUNT(City) > 2

--7
SELECT c.ContactName, COUNT(d.Quantity*p.UnitsOnOrder) NumofProd
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] d ON o.OrderID = d.OrderID JOIN Products p ON d.ProductID = p.ProductID
GROUP BY c.ContactName

--8
SELECT c.CustomerID, COUNT(d.Quantity*p.UnitsOnOrder) NumofProd
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] d ON o.OrderID = d.OrderID JOIN Products p ON d.ProductID = p.ProductID
GROUP BY c.CustomerID
HAVING COUNT(d.Quantity*p.UnitsOnOrder) > 100

--9

SELECT DISTINCT sh.CompanyName [Supplier Company Name], s.CompanyName [Shipping Company Name]
FROM Shippers s JOIN Orders o ON s.[ShipperID] = o.ShipVia JOIN [Order Details] d ON o.OrderID = d.OrderID JOIN Products p ON d.ProductID = p.ProductID JOIN Shippers sh ON p.SupplierID = sh.ShipperID

--10

SELECT o.OrderDate, p.ProductName
FROM Orders o JOIN [Order Details] d ON o.OrderID = d.OrderID JOIN Products p ON d.ProductID = p.ProductID

--11

SELECT e1.FirstName + ' '+e1.LastName Employee1Name,e2.FirstName + ' '+e2.LastName Employee2Name
FROM Employees e1,Employees e2
WHERE e1.Title = e2.Title AND e1.EmployeeID != e2.EmployeeID

--or

SELECT e1.FirstName + ' '+e1.LastName Employee1Name,e2.FirstName + ' '+e2.LastName Employee2Name
FROM Employees e1 INNER JOIN Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID != e2.EmployeeID

--12

SELECT e.FirstName + ' ' + e.LastName ManagerName
FROM Employees e
WHERE e.EmployeeID IN 
(
SELECT e.ReportsTo
FROM Employees e
GROUP BY e.ReportsTo
HAVING COUNT(e.ReportsTo) > 2
)

--13 

SELECT City, CustomerID NAME, ContactName, 'Customer' Type
FROM Customers
UNION ALL
SELECT City, CompanyName NAME, ContactName, 'Supplier' Type
FROM Suppliers
ORDER BY City

--14
SELECT c.City
FROM Customers c
WHERE c.City IN
(SELECT e.City
FROM Employees e)

--15
--a
SELECT c.City
FROM Customers c
WHERE c.City NOT IN
(SELECT e.City
FROM Employees e)

--b
SELECT c.City
FROM Customers c
WHERE c.CustomerID IS NOT NULL
UNION
SELECT e.City
FROM Employees e
WHERE e.EmployeeID IS NULL


--16
SELECT p.ProductName,COUNT(d.Quantity) AS [Order Quantities]
FROM Products p JOIN [Order Details] d ON p.ProductID = d.ProductID
GROUP BY p.ProductName


--17
--a
SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) >= 2
UNION
SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) >= 2

--b
SELECT DISTINCT City
FROM Customers
WHERE City IN
(SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > =2)


--18

SELECT c.City
FROM Customers c
WHERE c.CustomerID IN
(
SELECT o.CustomerID
FROM Orders o
WHERE o.OrderID IN
(
SELECT d.OrderID
FROM [Order Details] d
GROUP BY d.OrderID
HAVING COUNT(d.ProductID) > 2))

--19

SELECT TOP 5 p.ProductName, AVG(p.UnitPrice) AS AaeragePrice, o.ShipCity, MAX(d.Quantity) AS pdQuantity
FROM [Order Details] d JOIN Products p ON d.ProductID = p.ProductID JOIN Orders o ON o.OrderID = d.OrderID
GROUP BY p.ProductName,o.ShipCity
ORDER BY pdQuantity DESC

--20
SELECT TOP 1 o.ShipCity
FROM Orders o 
GROUP BY o.ShipCity
ORDER BY COUNT(o.OrderID) DESC

SELECT o.ShipCity
FROM [Order Details] d JOIN Orders o ON d.OrderID = o.OrderID
GROUP BY o.ShipCity
ORDER BY MAX(d.Quantity) DESC

SELECT o.ShipCity, RANK() OVER( ORDER BY MAX(d.Quantity) DESC) RNK
FROM [Order Details] d JOIN Orders o ON d.OrderID = o.OrderID
GROUP BY o.ShipCity 


--21
--1. UNION will remove duplicate records
--2. Use DISTINCT can also remove the duplicate records