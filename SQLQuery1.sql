use AdventureWorks2019
Go   

--1
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product

--2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

--3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

--4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL and ListPrice > 0

--5
SELECT Name, Color
FROM Production.Product
WHERE Color IS NOT NULL 

--6
SELECT 'NAME:' + ' ' + Name + ' -- ' + 'COLOR:' + ' ' + Color AS Result
FROM Production.Product
WHERE Color IS NOT NULL 

--7
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500 

--8
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black','Blue')

--9
SELECT *
FROM Production.Product
WHERE Name LIKE 'S%'

--10
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE '[A,S]%'
ORDER BY Name

--11
SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%' 

--12
SELECT DISTINCT ISNULL(ProductSubcategoryID,0), ISNULL(Color,'default')
FROM Production.Product

