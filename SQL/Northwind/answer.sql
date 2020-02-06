/* 1-) Write a SQL statement to display SKU and Description.*/
SELECT SKU, Inventory_Description
FROM INVENTORY;
/* 2. Write a SQL statement to display Warehouse with no duplications. */
SELECT DISTINCT WarehouseID
FROM INVENTORY;
/* 3. Write a SQL statement to display all data on products having a QuantityOnHand greater than 0.*/
SELECT *
FROM INVENTORY
WHERE QuantityOnHand >0;
/* 4. Write a SQL statement to display the SKU, Description, and Warehouse on products having QuantityOnHand equal to 0. 
Sort the results in descending order by Warehouse and ascending order of QuantityOnHand. */
SELECT SKU, Description, WarehouseID
FROM INVENTORY
WHERE QuantityOnHand =0
ORDER BY Warehouse DESC, QuantityOnHand;
/* 5. Write a SQL statement to display the SKU and Inventory_Description of all items stored in the Seattle, Chicago, or New Jersey warehouse. */
SELECT SKU, Inventory_Description
FROM INVENTORY
WHERE WarehouseID IN (
SELECT WarehouseID 
FROM WAREHOUSE 
WHERE Warehouse = 'Seattle' OR Warehouse = 'Chicago' OR Warehouse = 'New Jersey');
/* 6. Write a SQL statement to display the SKU and Inventory_Description of all items not stored in the Seattle, Chicago, or New Jersey warehouse. Use NOT IN. */
SELECT SKU, [Inventory_Description]
FROM INVENTORY
WHERE WarehouseID  NOT IN (
SELECT WarehouseID 
FROM WAREHOUSE 
WHERE Warehouse = 'Seattle' OR Warehouse = 'Chicago' OR Warehouse = 'New Jersey');
/* 7. Write a SQL statement to show SKU and Inventory_Description for all products having Description that includes the word 'Foot'. */
SELECT SKU, Inventory_Description
FROM INVENTORY
WHERE Inventory_Description 
LIKE '*Foot*';
/* 8. Write a SQL statement to show SKU and Warehouse for all products having a 'w' in the third position from the left in Warehouse. */
SELECT SKU, WarehouseID
FROM INVENTORY
WHERE WarehouseID IN (
SELECT WarehouseID 
FROM WAREHOUSE
WHERE Warehouse LIKE '??w*');
/* 9. Write a SQL expression to produce a single column called ItemLocation that combines
the Description, the phrase “is located in”, and Warehouse for all products that have a
QuantityOnHand greater than 0. Do not be concerned with removing trailing blanks. */
SELECT Inventory_Description + ' is located in ' + WarehouseID AS ItemLocation
FROM INVENTORY
WHERE QuantityOnHand > 0;
/* 10. Write a SQL expression to display the Warehouse and a count of QuantityOnHand,
grouped by Warehouse. Name the count TotalItemsOnHand and display the results in
descending order of TotalItemsOnHand.
Note that “a count of” actually means the “sum” in this context.  */
SELECT WarehouseID, Sum(QuantityOnHand) AS Totals
FROM INVENTORY
GROUP BY WarehouseID
ORDER BY Sum(QuantityOnHand) DESC;
/* 11. Write an SQL statement to show the SKU, SKU_Description, Warehouse 
for all items stored in a warehouse managed by 'Lucille Smith'. Use a subquery. */
SELECT INVENTORY.SKU, INVENTORY.Inventory_Description, INVENTORY.WarehouseID
FROM INVENTORY
WHERE INVENTORY.WarehouseID
IN (SELECT WarehouseID FROM WAREHOUSE WHERE Manager LIKE '*Smith*');
/* 12. Write an SQL statement to show the Warehouse and average QuantityOnHand 
of all items stored in a warehouse managed by 'Lucille Smith'. Use a subquery. */
SELECT INVENTORY.WarehouseID, Avg(QuantityOnHand) AS AverageQuantityOnHand
FROM INVENTORY
WHERE WarehouseID IN (SELECT WarehouseID FROM WAREHOUSE WHERE Manager LIKE '*Smith*')
GROUP BY [WarehouseID];
/* 13. Write an SQL statement that uses all of the SQL built-in functions 
on the QuantityOnHand column. Include meaningful column names in the result. */
SELECT SUM (QuantityOnHand) AS Inventory, AVG (QuantityOnHand) AS AvgInventory, MIN (QuantityOnHand) AS MinInventory, MAX (QuantityOnHand) AS MaxInventory, COUNT (QuantityOnHand) AS TotalInventory
FROM INVENTORY;
/* 14. Write an SQL statement to display the WarehouseID and the sum of QuantityOnHand, 
grouped by WarehouseID. Name the sum TotalItemsOnHand and display the results 
in descending order of TotalItemsOnHand. */
SELECT WarehouseID, SUM(QuantityOnHand) AS TotalItemsOnHand
FROM INVENTORY
GROUP BY WarehouseID
ORDER BY SUM(QuantityOnHand) DESC;
/* 15.Write a SQL statement to display information in Employees. */
SELECT * FROM Employees;
/* 16.Write a SQL statement to display employee id, a single column called Name that combines the first name and last name of employees whose birthdate is smaller than 1955-01-01. */
SELECT EmployeeID, FirstName + ' ' + LastName AS Name, BirthDate FROM Employees WHERE BirthDate < '1955-01-01';
/* 17.Write a SQL statement to display product name, category name which category id equals 2.(Inner Join) */
SELECT ProductName, CategoryName FROM Products INNER JOIN Categories ON Products.CategoryID=Categories.CategoryID WHERE Products.CategoryID=2;
/* 18.Write a SQL statement to display product name, category name, unit price for all data.(join) */
SELECT ProductName, CategoryName, [Order Details].UnitPrice FROM [Order Details], Products, Categories WHERE [Order Details].ProductID=Products.ProductID AND Products.CategoryID=Categories.CategoryID;
/* 19.Write a SQL statement to display category name, average of unit price called Average_UnitPrice grouped by category name and ordered by Average_UnitPrice. */
SELECT CategoryName, AVG([Order Details].UnitPrice) AS Average_UnitPrice FROM [Order Details], Products, Categories WHERE [Order Details].ProductID=Products.ProductID AND Products.CategoryID=Categories.CategoryID GROUP BY CategoryName ORDER BY Average_UnitPrice;
/* 20.Write a SQL statement to display company name started with c. */
SELECT Customers.CompanyName FROM Customers WHERE CompanyName LIKE 'c%';
/* 21.Write a SQL statement to display company name for all products having a 'c' in the third position from the left in company name. */
SELECT CompanyName FROM Suppliers WHERE CompanyName LIKE '__c%';
/* 22.Write a SQL statement to show number of stocks of products which their category name have 'con' word in any position. */
SELECT UnitsInStock FROM Products WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE Categories.CategoryName LIKE '%con%');
/* 23.Write a SQL statement to display a single column called Name that combines the first name and last name of employees who live in London. */
SELECT FirstName + ' ' + LastName AS Name, City FROM Employees WHERE City='London';
/* 24.Write a SQL statement to show all information of products, their category names where discontinued of products equals to 0 ordered by product name. */
SELECT DISTINCT b.*, a.CategoryName FROM Categories a INNER JOIN Products  b ON a.CategoryID=b.CategoryID WHERE b.Discontinued=0 ORDER BY b.ProductName;
/*25.Add a new record to Orders table including all columns.*/
INSERT INTO Orders(CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry) 
VALUES('HANAR',4,'1997-08-09','1997-09-06','1997-08-13',3,66.99,'James Car','agacli','bornova',NULL,35410,'Turkey');
/*26.Add a new record to Employees table including LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Country, Extension, Notes, ReportsTo, PhotoPath.*/
INSERT INTO Employees(LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Country, Extension, Notes, ReportsTo, PhotoPath)
VALUES ('pehlivancik','mert','student','prof','1950-12-12','1980-12-12','19 Yasar Hill','izmir','TR','5000','XXX',7,'http://mert.com');
/*27.Add a new record to Shippers table including CompanyName,Phone.*/
INSERT INTO Shippers(CompanyName,Phone)
VALUES ('YasarCom','05550000000')
SELECT CompanyName,Phone
FROM Shippers;
/*28.
CREATE TABLE [dbo].[Categories_backup](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Categories_backup] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
Create a new table by running the code at the top. Then, copy all the records in the Categories table to the Categories_backup table.*/
CREATE TABLE [dbo].[Categories_backup](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Categories_backup] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

INSERT INTO [Categories_backup] (CategoryName,Description,Picture)
SELECT CategoryName,Description,Picture FROM Categories;
/*29.Update the person's title is Sales Manager, city is Yorkshire whose EmployeeID is which you added person in step 2 from Employees table.*/
UPDATE Employees
SET Title='Sales Manager', City='Yorkshire'
WHERE EmployeeID = 10;
/*30.Update the ship name to Ave. 5 de Mayo Porlamar from shippers table which company name of customer is GROSELLA-Restaurante from customer table.*/
UPDATE Orders
SET ShipName = 'Ave. 5 de Mayo Porlamar'
FROM Orders AS o
INNER JOIN Customers AS c
ON c.CustomerID = o.CustomerID
WHERE c.CompanyName = 'GROSELLA-Restaurante';
/*31.Update the company name of shippers to Yasar A.S but company name includes 'pp' in any position or  phone of shippers has (313) 555-5735.*/
UPDATE Shippers
SET CompanyName = 'YASAR A.S'
WHERE CompanyName LIKE '%pp%' OR Phone = '(313) 555-5735';
/*32.Update the company name of shippers to Aras Kargo and phone to (503)555-2222 which company name of shippers is Migros.*/
UPDATE Shippers
SET CompanyName = 'Aras Kargo',Phone = '(503)555-2222'
UPDATE Shippers
SET CompanyName = 'Migros'
WHERE Phone = '(503)555-2222';
/*33.Delete all records of order id is 11078  from Orders table.*/
DELETE FROM Orders
WHERE OrderID = 11078;
/*34.Delete all records from Categories_backup.*/
DELETE FROM Categories_backup
/*35.Delete the records which quantity is 40 and unit price smaller than 20 from Order Details.*/
DELETE FROM [Order Details]
WHERE Quantity = 40 AND UnitPrice <= 20;
/*36.Delete the records which their territory dsescription is New York.*/
delete EmployeeTerritories
from EmployeeTerritories  inner join Territories  on Territories.TerritoryID = EmployeeTerritories.TerritoryID
WHERE  Territories.TerritoryDescription= 'New York' ;
/*37-)Create a procedure which shows all datas of ID's in category table which have the unit prices higher than 70 in the producks table.*/
CREATE PROCEDURE IDdata
AS
SELECT *
FROM Products AS p,Categories AS c
WHERE p.CategoryID = c.CategoryID AND p.UnitPrice > 70;
/*38-)Create a procedure and some inputs (lastname,firstName...) and then insert those inputs as a row in the Employees table*/
CREATE PROCEDURE ADDING
(
@LastName varchar(100),
@FirstName varchar(40))
as BEGIN
INSERT Employees(LastName,FirstName) VALUES (@LastName,@FirstName);
End
/*39-)Create a procedure and an input that update the freight's value to zero in the Orders table. And the input must be equal to the 
postcode in the customers table.*/
CREATE PROCEDURE UPDT
(
@getPostalCode nvarchar(50)
)
AS
BEGIN
UPDATE Orders
SET Freight=0
FROM Orders AS o
INNER JOIN Customers AS c
ON c.CustomerID = o.CustomerID
WHERE c.PostalCode = @getPostalCode;
END
/*40-)Create a procedure and an input that delete EmployeeTerritories in the Employess table. And the TerritoryID which is also in the Employees 
table must be equal to the TerritoryID in the Territorys table which territory name equal to your input*/
CREATE PROCEDURE DeletingEmp
(
@GetBirthDate datetime
)
AS
BEGIN
delete Employees
from EmployeeTerritories  inner join Employees  on Employees.EmployeeID = EmployeeTerritories.EmployeeID
WHERE  Employees.BirthDate = @GetBirthDate;
END
/*41-)Create a trigger for the orders table and the insert function. Define two variables in this trigger for the 
productID and the unitPrice from the order details table and update the orders tables freight column. the freight column equal the unite price.  */
CREATE TRIGGER trig
ON Orders
FOR INSERT
AS
Declare
        @ProductID   int,
		@UnitPrice int;
BEGIN
SELECT @ProductID = [Order Details].ProductID,@UnitPrice=[Order Details].UnitPrice
FROM [Order Details]
UPDATE Orders
SET Freight = @UnitPrice
where @ProductID = Orders.OrderID
END
/*42-)Create a trigger for shippers table and delete function. when you delete a data from the shippers table you must update your 
company name in the Shippers table*/
CREATE TRIGGER trige
ON Shippers
FOR DELETE
AS
Declare
        @newCompanyName   varchar(50);		
BEGIN
UPDATE Shippers
SET CompanyName=@newCompanyName
END
/*43-)Create a trigger for employees table and update function. when you update your table, delete an employeeTerritories where lastName='Fuller'*/
CREATE TRIGGER triger
ON Employees
FOR UPDATE
AS
BEGIN
delete Employees
from EmployeeTerritories  inner join Territories  on Territories.TerritoryID = EmployeeTerritories.TerritoryID
WHERE  Employees.LastName = 'Fuller';
END
/*44-)Create a trigger on Orders table for delete function. when you delete a function in the orders table. the trigger will calculate sum of 
freight in the Orders table*/
CREATE TRIGGER trigerr
ON Orders
FOR DELETE
AS
BEGIN
SELECT SUM(Freight) AS RESULT
FROM Orders
END
