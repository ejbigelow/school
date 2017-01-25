/*
Eric Bigelow 
Stored procedure for Northwind
Procedure returns the total amount of customers in the customers table


*/
create procedure CustCount

AS

SELECT
count(*)
FROM
Customers
