USE AP;

/*
INFO-2800
Author: J. Adam Saenzpardo
Date: 10/5/2020
Assignment 5: Updating Data with Queries
Purpose: Use SQL Queries to modify, update, create and delete information from tables.
*/

--1
DROP TABLE IF EXISTS VendorCopy -- drop tables if exist (only works for SQL Server 2016 onward)
DROP TABLE IF EXISTS InvoiceCopy
SELECT * 
INTO VendorCopy -- copy into new table here
FROM Vendors
SELECT *
INTO InvoiceCopy -- copy into new table here
FROM Invoices;

--SELECT *			-- all match
--FROM VendorCopy;
--SELECT * 
--FROM Vendors;
--SELECT * 
--FROM InvoiceCopy;
--SELECT * 
--FROM Invoices;

--2
--SELECT * -- check InvoiceCopy before adding
--FROM InvoiceCopy;

INSERT INTO InvoiceCopy -- insert row
	(VendorID, InvoiceTotal, TermsID, InvoiceNumber, PaymentTotal, InvoiceDueDate, InvoiceDate, CreditTotal, PaymentDate)
Values (32, 434.58, 2, 'AX-014-027', 0.00, '2016-07-08', '2016-06-21', 0.00, NULL);

--SELECT * -- insertion check
--FROM InvoiceCopy
--WHERE InvoiceNumber = 'AX-014-027';
--SELECT * -- verify table check
--FROM InvoiceCopy;

--3
--SELECT *
--FROM Vendors
--WHERE VendorState != 'CA'; -- 47 entries before modification

INSERT INTO VendorCopy
SELECT 
	VendorName, VendorAddress1, VendorAddress2, VendorCity, VendorState, 
	VendorZipCode, VendorPhone, VendorContactLName, VendorContactFName,
	DefaultTermsID, DefaultAccountNo
FROM Vendors
WHERE VendorState != 'CA'; -- no worky

--4
--SELECT *
--FROM VendorCopy
--WHERE DefaultAccountNo = 400; -- 6 entries before UPDATE -- 0 after update

UPDATE VendorCopy
SET DefaultAccountNo = 403 -- old number
WHERE DefaultAccountNo = 400; -- new number

--5
--SELECT *
--FROM InvoiceCopy;
--SELECT * 
--FROM Invoices;

UPDATE InvoiceCopy
SET PaymentDate = GETDATE(),
    PaymentTotal = InvoiceTotal - CreditTotal
WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0;

--6
--SELECT *
--FROM InvoiceCopy
--WHERE TermsID = 2;
--SELECT * 
--FROM VendorCopy;
--SELECT VendorID -- final subquery
--FROM VendorCopy
--WHERE DefaultTermsID = 2;

UPDATE InvoiceCopy
SET TermsID = 2
WHERE VendorID IN
    (SELECT VendorID
     FROM VendorCopy
     WHERE DefaultTermsID = 2);

--7
--VendorID is key...

UPDATE InvoiceCopy
SET TermsID = 2
FROM InvoiceCopy JOIN VendorCopy
  ON InvoiceCopy.VendorID = VendorCopy.VendorID
WHERE DefaultTermsID = 2;

--8
--SELECT * 
--FROM VendorCopy
--WHERE VendorState = 'MN'; -- 4 entries -- 0 entries after DELETE

DELETE VendorCopy
WHERE VendorState = 'MN';

--9
--SELECT VendorState
--FROM VendorCopy
--ORDER BY VendorState;
--SELECT *
--FROM InvoiceCopy;
---- VendorID is key
--SELECT DISTINCT VendorState -- final subquery
--FROM VendorCopy JOIN InvoiceCopy
--	ON VendorCopy.VendorID = InvoiceCopy.VendorID;

DELETE VendorCopy
WHERE VendorState NOT IN
  (SELECT DISTINCT VendorState
   FROM VendorCopy JOIN InvoiceCopy
     ON VendorCopy.VendorID = InvoiceCopy.VendorID);