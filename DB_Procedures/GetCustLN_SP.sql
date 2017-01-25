/*
Eric Bigelow 
Stored procedure for Northwind
Procedure returns customers last names only alphabetically

create procedure GetCustLN

AS

SELECT
right(ContactName, len(ContactName)-charindex(' ', ContactName)) AS Lastname
FROM
Customers
ORDER BY Lastname