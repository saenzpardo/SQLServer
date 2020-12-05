/*
	Assignment 9 - Chapter 13 - Views
	Author: J. Adam Saenzpardo
	11/9/2020
*/

--1
-- view
DROP VIEW InvoiceBasic
GO
CREATE VIEW InvoiceBasic AS
SELECT VendorName, InvoiceNumber, InvoiceTotal
FROM Vendors JOIN Invoices
	ON Vendors.VendorID = Invoices.VendorID;

-- select statement
SELECT *
FROM InvoiceBasic
WHERE VendorName LIKE '[N-P]%'
ORDER BY VendorName;

--2
-- view
DROP VIEW Top10PaidInvoices
GO
CREATE VIEW Top10PaidInvoices AS
SELECT TOP 10 VendorName, MAX(InvoiceDate) AS LastInvoice,
			  SUM(InvoiceTotal) AS SumOfInvoices
FROM Vendors JOIN Invoices
	ON Vendors.VendorID = Invoices.VendorID
WHERE InvoiceTotal - CreditTotal - PaymentTotal = 0
GROUP BY VendorName;

--SELECT *
--FROM  Top10PaidInvoices;

--3
-- view
DROP VIEW VendorAddress
GO
CREATE VIEW VendorAddress AS 
SELECT VendorID, VendorAddress1, VendorAddress2, VendorCity, 
	   VendorState, VendorZipCode
FROM Vendors;
-- select VendorID 4
SELECT * 
FROM VendorAddress
WHERE VendorID = 4;
-- update VendorID 4
UPDATE VendorAddress
SET VendorAddress1 = '1990 Westwood Blvd', VendorAddress2 = 'Ste 260'
WHERE VendorID = 4;

--4 
SELECT *
FROM sys.foreign_keys;

--5
-- copied the following from dbo.InvoiceBasic Design view
-- before changing sort type to Ascending
SELECT dbo.Vendors.VendorName, dbo.Invoices.InvoiceNumber, dbo.Invoices.InvoiceTotal
FROM   dbo.Vendors INNER JOIN
             dbo.Invoices ON dbo.Vendors.VendorID = dbo.Invoices.VendorID
-- after change
SELECT TOP (100) PERCENT dbo.Vendors.VendorName, dbo.Invoices.InvoiceNumber, dbo.Invoices.InvoiceTotal
FROM   dbo.Vendors INNER JOIN
             dbo.Invoices ON dbo.Vendors.VendorID = dbo.Invoices.VendorID
ORDER BY dbo.Vendors.VendorName