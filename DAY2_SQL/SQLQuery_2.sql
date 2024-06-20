
USE AdventureWorks2019
GO
--Write queries for following scenarios
--1. How many products can you find in the Production.Product table?
SELECT COUNT(ProductID)
From Production.Product

--ANS: There are 504 products.


--2.Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
--i) method
SELECT COUNT(ProductID) AS numberOfProductsInSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--ii) method
SELECT COUNT(*) AS NumberOfProductsInSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL;



--3.How many Products reside in each SubCategory? Write a query to display the results with the following titles.

-- ProductSubcategoryID CountedProducts

-- -------------------- ---------------
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID



-- 4.How many products that do not have a product subcategory.
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NULL 
GROUP BY ProductSubcategoryID

    --or--
SELECT COUNT(*) AS NumberOfProductsWithoutSubcategory
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

--ans: 209


--5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity) AS TotalProductQuantity
FROM Production.ProductInventory

--ans:335974

/*
6. Write a query to list the sum of products in the Production.ProductInventory table 
   and LocationID set to 40 and limit the result to include just summarized quantities less than 100.

              ProductID    TheSum

              -----------        ----------
*/

SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

/*
7.Write a query to list the sum of products with the shelf information in the Production.ProductInventory table 
  and LocationID set to 40 and limit the result to include just summarized quantities less than 100

    Shelf      ProductID    TheSum

    ----------   -----------        -----------
*/
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

--8. Write the query to list the average quantity for products 
--where column LocationID has the value of 10 from the table Production.ProductInventory table.

SELECT ProductID, AVG(Quantity) AS AverageQuantity
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

/*
--9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory

    ProductID   Shelf      TheAvg

    ----------- ---------- -----------
*/
SELECT ProductID, Shelf, AVG(Quantity) AS AverageQuantity
FROM Production.ProductInventory
GROUP BY ProductID,Shelf

/*
10.  Write query  to see the average quantity  of  products by shelf 
excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory

    ProductID   Shelf      TheAvg

    ----------- ---------- -----------
*/
SELECT ProductID, Shelf, AVG(Quantity) AS AverageQuantity
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID,Shelf


/*
11.  List the members (rows) and average list price in the Production.Product table. 
This should be grouped independently over the Color and the Class column. 
Exclude the rows where Color or Class are null.

    Color                        Class              TheCount          AvgPrice

    -------------- - -----    -----------            ---------------------
*/
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class


--Joins:
/*
12.   Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. 
Join them and produce a result set similar to the following.

    Country                        Province

    ---------                          ----------------------
*/
SELECT c.Name AS Country, p.Name AS Province
FROM person.CountryRegion c JOIN person.StateProvince p ON c.CountryRegionCode = p.CountryRegionCode

/*
13.  Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables 
and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

    Country                        Province

    ---------                          ----------------------
*/
SELECT c.Name AS Country, p.Name AS Province
FROM person.CountryRegion c JOIN person.StateProvince p ON c.CountryRegionCode = p.CountryRegionCode
WHERE c.Name IN('Germany', 'Canada')



USE Northwind
GO
-- Using Northwnd Database: (Use aliases for all the Joins)
--14. List all Products that has been sold at least once in last 27 years.
SELECT DISTINCT p.ProductID, p.ProductName
From Products p
JOIN [Order Details] od ON od.ProductID = p.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
--WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())
WHERE YEAR(o.OrderDate) >= 1997

--15.  List top 5 locations (Zip Code) where the products sold most.

SELECT TOP 5 c.PostalCode AS [Zip Code], COUNT(od.ProductID) AS SoldCount
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
--WHERE c.PostalCode IS NOT NULL  ??
GROUP BY c.PostalCode
ORDER BY SoldCount DESC




--16.  List top 5 locations (Zip Code) where the products sold most in last 27 years.
SELECT TOP 5 c.PostalCode AS [Zip Code], COUNT(od.ProductID) AS SoldCount
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE YEAR(o.OrderDate) >= YEAR(GETDATE()) - 27
GROUP BY c.PostalCode
ORDER BY SoldCount DESC

--17.  List all city names and number of customers in that city.  
SELECT c.City, COUNT(c.CustomerID) AS NumberOfCustomers
FROM Customers c 
GROUP By c.City


--18.  List city names which have more than 2 customers, and number of customers in that city

SELECT c.City, COUNT(c.CustomerID) AS NumberOfCustomers
FROM Customers c 
GROUP By c.City
HAVING COUNT(c.CustomerID) > 2

--19.  List the names of customers who placed orders after 1/1/98 with order date.

SELECT c.ContactName AS CustomerName, o.OrderDate
FROM Orders o JOIN Customers c ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'
ORDER BY o.OrderDate;

--20.  List the names of all customers with most recent order dates

--:subquery o1 on CustomerID to retrieve the customer names with the most recent order dates.
--:then joins the Orders table (o2) again to retrieve the complete information for the most recent orders
SELECT 
    c.ContactName AS CustomerName,
    o2.OrderDate AS MostRecentOrderDates
FROM Customers c
JOIN (
    SELECT 
        CustomerID,
        MAX(OrderDate) AS RecentDate
    FROM Orders
    GROUP BY CustomerID
) o1 ON c.CustomerID = o1.CustomerID
JOIN Orders o2 ON o1.CustomerID = o2.CustomerID AND o1.RecentDate = o2.OrderDate;


--21.  Display the names of all customers  along with the  count of products they bought
SELECT 
    c.ContactName AS CustomerName, COUNT(od.ProductID) AS CountOfProducts
FROM Customers c
LEFT JOIN Orders o ON o.CustomerID = c.CustomerID
LEFT JOIN [Order Details] od ON od.OrderID = o.OrderID
GROUP by c.ContactName, c.CustomerID


--22.  Display the customer ids who bought more than 100 Products with count of products.

SELECT o.CustomerID, COUNT(od.ProductID) AS ProductCount
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY o.CustomerID
HAVING COUNT(od.ProductID) > 100;


/*
23.  List all of the possible ways that suppliers can ship their products. Display the results as below

    Supplier Company Name                Shipping Company Name

    ---------------------------------            ----------------------------------
*/

SELECT DISTINCT 
    s.CompanyName AS [Supplier Company Name],
    sp.CompanyName AS [Shipping Company Name]
FROM Suppliers s
CROSS JOIN Shippers sp

--24.  Display the products order each day. Show Order date and Product Name.

SELECT o.OrderDate, p.ProductName
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.OrderDate, p.ProductName;


--25.  Displays pairs of employees who have the same job title.
SELECT e1.FirstName AS FirstName1, 
       e1.LastName AS LastName1, 
       e2.FirstName AS FirstName2,
       e2.LastName AS LastName2,
       e1.Title AS JobTitle
FROM Employees e1 JOIN Employees e2 ON e1.Title = e2.Title AND e1.EmployeeID < e2.EmployeeID -- avoid duplicate AB, BA pair


--26.  Display all the Managers who have more than 2 employees reporting to them.
SELECT 
    m.EmployeeID AS ManagerID,
    m.FirstName AS ManagerFirstName,
    m.LastName AS ManagerLastName,
    COUNT(e.EmployeeID) AS NumberOfEmployeesReportingTo
FROM Employees m
JOIN Employees e ON m.EmployeeID = e.ReportsTo
GROUP BY m.EmployeeID, m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) > 2;

/*
27.  Display the customers and suppliers by city. The results should have the following columns

City

Name

Contact Name,

Type (Customer or Supplier)
*/

SELECT City, CompanyName AS Name, ContactName AS [Contact Name],'Customer' AS Type
FROM Customers

UNION ALL

SELECT City, CompanyName AS Name, ContactName AS [Contact Name], 'Supplier' AS Type
FROM Suppliers
ORDER BY City, Type

