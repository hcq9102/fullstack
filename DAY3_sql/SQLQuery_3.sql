USE Northwind
GO

--1. List all cities that have both Employees and Customers.

SELECT DISTINCT e.City
FROM Employees e JOIN Customers c ON c.City = e.City
WHERE e.City IS NOT NULL

/*
2. List all cities that have Customers but no Employee.

a.  Use sub-query

b.  Do not use sub-query
*/

-- a. Use sub-query

SELECT DISTINCT c.City
FROM Customers c
WHERE c.City IS NOT NULL 
AND c.City NOT IN (
    SELECT DISTINCT e.City
    FROM Employees e
    WHERE e.City IS NOT NULL)


--b.Do not use sub-query

SELECT DISTINCT c.City
FROM Customers c 
LEFT JOIN Employees e ON c.City = e.City
WHERE c.City IS NOT NULL AND e.City IS NULL

--3. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrderQuantities
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName
ORDER BY TotalOrderQuantities DESC


--4.      List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(od.Quantity) AS TotalProducts
FROM Customers c JOIN Orders o ON o.CustomerID= c.CustomerID JOIN [Order Details] od ON od.OrderID = o.OrderID
WHERE c.City IS NOT NULL
GROUP BY c.City
ORDER BY TotalProducts DESC

/*
5.      List all Customer Cities that have at least two customers.

a.      Use union

b.      Use sub-query and no union

*/

--a.Use union
SELECT City, COUNT(CustomerID) AS NumberOfCustomers
FROM Customers
WHERE City IS NOT NULL
GROUP BY City
HAVING COUNT(CustomerID) >= 2

UNION

SELECT City,COUNT(CustomerID) AS NumberOfCustomers
FROM Customers
WHERE City IS NOT NULL
GROUP BY City
HAVING COUNT(CustomerID) >= 2;

--b. Use sub-query and no union
SELECT DISTINCT City, COUNT(CustomerID) AS NumberOfCustomers
FROM Customers 
WHERE 
City IN(
    SELECT City
    FROM Customers
    GROUP BY City
    Having COUNT(CustomerID)>=2
)
GROUP BY City


--6.List all Customer Cities that have ordered at least two different kinds of products.
SELECT DISTINCT City, COUNT(DISTINCT od.ProductID) AS NumberOfProduct
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE c.City IS NOT NULL
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2


--7.List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.CustomerID, c.ContactName, c.City AS CustomerCity, o.ShipCity
FROM Customers c
JOIN Orders o ON o.CustomerID = c.CustomerID
WHERE c.City<>o.ShipCity AND c.City IS NOT NULL AND o.ShipCity IS NOT NULL

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.

---method1
WITH ProductTotals AS (
    SELECT 
        p.ProductID,
        p.ProductName,
        SUM(od.Quantity) AS TotalQuantity,
        AVG(od.UnitPrice) AS AveragePrice
    FROM 
        Products p
    JOIN 
        [Order Details] od ON p.ProductID = od.ProductID
    GROUP BY 
        p.ProductID,
        p.ProductName
),
CityOrders AS (
    SELECT 
        p.ProductID,
        p.ProductName,
        c.City,
        SUM(od.Quantity) AS QuantityOrdered
    FROM 
        Products p
    JOIN 
        [Order Details] od ON p.ProductID = od.ProductID
    JOIN 
        Orders o ON od.OrderID = o.OrderID
    JOIN 
        Customers c ON o.CustomerID = c.CustomerID
    GROUP BY 
        p.ProductID,
        p.ProductName,
        c.City
),
CityWithMaxOrders AS (
    SELECT 
        ProductID,
        ProductName,
        City,
        QuantityOrdered,
        RANK() OVER (PARTITION BY ProductID ORDER BY QuantityOrdered DESC) AS CityRank
    FROM 
        CityOrders
)
SELECT TOP 5
    pt.ProductName,
    --pt.TotalQuantity,
    pt.AveragePrice,
    cmo.City AS TopCity
FROM 
    ProductTotals pt
JOIN 
    CityWithMaxOrders cmo ON pt.ProductID = cmo.ProductID
WHERE 
    cmo.CityRank = 1
ORDER BY 
    pt.TotalQuantity DESC

---method2

SELECT 
    p.ProductName,
    AVG(od.UnitPrice) AS AveragePrice,
    (
        SELECT TOP 1 c.City
        FROM Customers c
        JOIN Orders o ON c.CustomerID = o.CustomerID
        JOIN [Order Details] od2 ON o.OrderID = od2.OrderID
        WHERE od2.ProductID = p.ProductID
        GROUP BY c.City
        ORDER BY SUM(od2.Quantity) DESC
    ) AS TopCity
FROM 
    [Order Details] od
JOIN 
    Products p ON od.ProductID = p.ProductID
GROUP BY 
    p.ProductID, p.ProductName
ORDER BY 
    SUM(od.Quantity) DESC
OFFSET 0 ROWS
FETCH NEXT 5 ROWS ONLY;



--9.      List all cities that have never ordered something but we have employees there.

--a.      Use sub-query
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
    SELECT DISTINCT c.City
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
)


--b.  Do not use sub-query

SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Customers c ON e.City = c.City
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.CustomerID IS NULL


--10.  List one city, if exists, 
--that is the city from where the employee sold most orders (not the product quantity) is, 
--and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT EmployeeInCity
FROM (
    SELECT TOP 1
        e.City AS EmployeeInCity,
        COUNT(o.OrderID) AS TotalOrders
    FROM 
        Employees e
    JOIN 
        Orders o ON e.EmployeeID = o.EmployeeID
    GROUP BY 
        e.City
    ORDER BY 
        COUNT(o.OrderID) DESC
) AS TopEmployeeCity
JOIN (
    SELECT TOP 1
        c.City AS QuantityCity,
        SUM(od.Quantity) AS TotalQuantity
    FROM 
        Customers c
    JOIN 
        Orders o ON c.CustomerID = o.CustomerID
    JOIN 
        [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY 
        c.City
    ORDER BY 
        SUM(od.Quantity) DESC
) AS TopQuantityCity
ON TopEmployeeCity.EmployeeInCity = TopQuantityCity.QuantityCity;



--11. How do you remove the duplicates record of a table?
/*
Ans: Remove duplicate records from a table using CTE (Common Table Expressions), combined with the ROW_NUMBER() window function 
     to identify duplicate rows and a DELETE statement to delete the duplicated rows. 

*/


-----------------

--Q: Class question: what is the difference between varchar and nvarchar?
---varchar： Variable-length character data type that stores ANSI characters and automatically adjusts its size based on the length of the data.
---nvarchar： Variable-length character data type that stores Unicode characters and automatically adjusts its size based on the length of the data.




