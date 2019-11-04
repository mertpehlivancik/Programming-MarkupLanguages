# Northwind
- This project contains questions about SQL. 
- The Northwind database must be used when practicing these questions.
## ER Diagram of Northwind Database
![](northwind-er-relationship.png)
## Questions
1. Write a SQL statement to display SKU and Description.
2. Write a SQL statement to display Warehouse with 
no duplications.
3. Write a SQL statement to display all data on products having a 
QuantityOnHand greater than 0.
4. Write a SQL statement to display the SKU, Description, and 
Warehouse on products
having QuantityOnHand equal to 0. 
Sort the results in descending order by Warehouse
and ascending order of QuantityOnHand.
5. Write a SQL statement to display the SKU and Inventory_Description of all items stored in the
Seattle, Chicago, or New Jersey warehouse.
6. Write a SQL statement to display the SKU and Inventory_Description of all items not stored in the
Seattle, Chicago, or New Jersey warehouse. Use NOT IN.
7. Write a SQL statement to show SKU and Inventory_Description for all products having Description
that includes the word 'Foot'.
8. Write a SQL statement to show SKU and Warehouse for all products having a 'w' in the
third position from the left in Warehouse.
9. Write a SQL expression to produce a single column called ItemLocation that combines
the Description, the phrase “is located in”, and Warehouse for all products that have a
QuantityOnHand greater than 0. Do not be concerned with removing trailing blanks.
10. Write a SQL expression to display the Warehouse and a count of QuantityOnHand,
grouped by Warehouse. Name the count TotalItemsOnHand and display the results in
descending order of TotalItemsOnHand.
Note that “a count of” actually means the “sum” in this context. 
11. Write an SQL statement to show the SKU, SKU_Description, Warehouse 
for all items stored in a warehouse managed by 'Lucille Smith'. Use a subquery.
12. Write an SQL statement to show the Warehouse and average QuantityOnHand 
of all items stored in a warehouse managed by 'Lucille Smith'. Use a subquery.
13. Write an SQL statement that uses all of the SQL built-in functions 
on the QuantityOnHand column. Include meaningful column names in the result.
14. Write an SQL statement to display the WarehouseID and the sum of QuantityOnHand, 
grouped by WarehouseID. Name the sum TotalItemsOnHand and display the results 
in descending order of TotalItemsOnHand.
15. Write a SQL statement to display information in Employees.
16. Write a SQL statement to display employee id, a single column called Name that combines the first name and last name of employees whose birthdate is smaller than 1955-01-01.
17. Write a SQL statement to display product name, category name which category id equals 2.(Inner Join)
18. Write a SQL statement to display product name, category name, unit price for all data.(join)
19. Write a SQL statement to display category name, average of unit price in Order Detail called Average_UnitPrice grouped by category name and ordered by Average_UnitPrice.
20. Write a SQL statement to display company name started with c.
21. Write a SQL statement to display company name for all products having a 'c' in the third position from the left in company name.
22. Write a SQL statement to show number of stocks of products which their category name have 'con' word in any position.
23. Write a SQL statement to display a single column called Name that combines the first name and last name of employees who live in London.
24. Write a SQL statement to show all information of products, their category names where discontinued of products equals to 0 ordered by product name.
25. Add a new record to Orders table including all columns.
26. Add a new record to Employees table including LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Country, Extension, Notes, ReportsTo, PhotoPath.
27. Add a new record to Shippers table including CompanyName,Phone.
28.CREATE TABLE [dbo].[Categories_backup](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Categories_backup] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
Create a new table by running the code at the top. Then, copy all the records in the Categories table to the Categories_backup table.
29. Update the person's title is Sales Manager, city is Yorkshire whose EmployeeID is which you added person in step 2 from Employees table.
30. Update the ship name to Ave. 5 de Mayo Porlamar from shippers table which company name of customer is GROSELLA-Restaurante from customer table.
31. Update the company name of shippers to Yasar A.S but company name includes 'pp' in any position or  phone of shippers has (313) 555-5735.
32. Update the company name of shippers to Aras Kargo and phone to (503)555-2222 which company name of shippers is Migros.
33. Delete all records of order id is 11078  from Orders table.
34. Delete all records from Categories_backup.
35. Delete the records which quantity is 40 and unit price smaller than 20 from Order Details.

36. Delete the records which their territory dsescription is New York.

37. Create a procedure which shows all datas of ID's in category table which have the unit prices higher than 70 in the producks table.  
38. Create a procedure and some inputs (lastname,firstName...) and then insert those inputs as a row in the Employees table 

39. Create a procedure and an input that update the freight's value to zero in the Orders table. And the input must be equal to the 
postcode in the customers table.

40. Create a procedure and an input that delete Employees the Employess table. Where employeeID equal to employeeTerritories EmployeeID and birthdate equal to your input.

41. Create a trigger for the orders table and the insert function. Define two variables in this trigger for the 
productID and the unitPrice from the order details table and update the orders tables freight column. the freight column equal the unite price.  

42. Create a trigger for shippers table and delete function. when you delete a data from the shippers table you must update your 
company name in the Shippers table.

43. Create a trigger for employees table and update function. when you update your table, delete an employeeTerritories where lastName='Fuller'.

44. Create a trigger on Orders table for delete function. when you delete a function in the orders table. the trigger will calculate sum of freight in the Orders table.
