
-- I hope it is ok that I left my notes on here while I was working.  I tried linking the database into VS code
-- but I had some problems and it was easier for me to work through the problems this way.  If you want just 
-- the working queries, I'll remove my notes with the next submission.

/*
INFO-2780 SQL Server
Assignment 4: Subqueries
Author: J. Adam Saenzpardo
Date: 9/21/2020
Purpose: Use subqueries to retrieve, update or delete data in two or more tables.
*/

--1 
SELECT DISTINCT VendorName
FROM Vendors
WHERE VendorID IN
	(SELECT VendorID
	FROM Invoices)
ORDER BY VendorName;

--2
--SELECT AVG(PaymentTotal) -- find average for comparison
--FROM Invoices;

SELECT InvoiceNumber, InvoiceTotal
FROM Invoices
WHERE PaymentTotal > 
	(SELECT AVG(PaymentTotal)	--subquery to find average of PaymentTotal form Invoices table
	FROM Invoices
	WHERE PaymentTotal != 0);

--3
--SELECT TOP 50 PERCENT PaymentTotal, * -- subquery
--FROM Invoices
--WHERE PaymentTotal != 0;

SELECT InvoiceNumber, InvoiceTotal
FROM Invoices
WHERE PaymentTotal > ALL
	(SELECT TOP 50 PERCENT PaymentTotal -- to get greater than median for paid invoices
	FROM Invoices
	WHERE PaymentTotal != 0	
	ORDER By PaymentTotal);

--4
--SELECT *
--FROM GLAccounts;	-- view GLAccounts table

--SELECT *			-- view all accounts used in InvoiceLineItems table
--FROM InvoiceLineItems
--ORDER BY AccountNo;

SELECT AccountNo, AccountDescription
FROM GLAccounts
WHERE NOT EXISTS
    (SELECT *
     FROM InvoiceLineItems
     WHERE InvoiceLineItems.AccountNo = GLAccounts.AccountNo)	-- display if AccountNo in GLA table isn't present in
ORDER BY AccountNo;												-- InvoiceLineItems table

--5
--vendorname is only listed in Vendors table...vendorID is all that ties these together
--SELECT * 
--FROM VENDORS;
--SELECT *
--FROM InvoiceLineItems; --need to add invoices table in to get all info...
--SELECT *
--FROM Invoices; 

SELECT VendorName, Invoices.InvoiceID, InvoiceSequence, InvoiceLineItemAmount --only works with invoices.invoiceid here?...needs more work
FROM Vendors JOIN Invoices  --join vendors and invoice using VendorID --> InvoiceLineItems can't go here, it needs to go after
  ON Vendors.VendorID = Invoices.VendorID
JOIN InvoiceLineItems --third table gets joined here using same key as above
  ON Invoices.InvoiceID = InvoiceLineItems.InvoiceID
WHERE Invoices.InvoiceID IN 
      (SELECT InvoiceID
       FROM InvoiceLineItems
       WHERE InvoiceSequence > 1);
	   
--6
-- getting error after subquery for expected AS, ID... need more work
--SELECT MAX(InvoiceTotal) AS Maximum	--Gets max from invoices
--FROM Invoices;
--SELECT VendorID, MAX(InvoiceTotal) AS Maximum --Gets max and groups by vendor --should be my subquery
--FROM Invoices
--WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0
--GROUP BY VendorID;

SELECT SUM(Maximum) AS "Sum of Largest Unpaid Invoices"
FROM (SELECT VendorID, MAX(InvoiceTotal) AS Maximum
      FROM Invoices
      WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0
      GROUP BY VendorID) AS MyMax;

--7
--SELECT COUNT(VendorCity) As "Vendor City" -- total vendors
--FROM Vendors;
--SELECT COUNT(VendorCity + VendorState) AS "Vendors" -- vendors plus straight
--FROM Vendors;
--SELECT VendorCity + VendorState --finalized subquery
--FROM Vendors
--GROUP BY VendorCity + VendorState
--HAVING COUNT(*) > 1;

SELECT VendorName, VendorCity, VendorState
FROM Vendors
WHERE VendorCity + VendorState NOT IN --needs to be NOT IN...need to display all entries that are less than 2
	(SELECT VendorCity + VendorState
	FROM Vendors
	GROUP BY VendorCity + VendorState
	HAVING COUNT(*) > 1)
ORDER BY VendorCity, VendorState;

--8
SELECT * 
FROM Invoices;
Select * 
FROM Vendors; -- VendorID key
SELECT MIN(InvoiceDate)
FROM Invoices
WHERE Invoices.VendorID = Invoices.VendorID; --too confusing, change to InvoiceCheck and InvoiceMain

SELECT VendorName, InvoiceNumber AS "First Invoice", InvoiceDate AS "Date", InvoiceTotal AS "Total"
FROM Invoices AS InvoiceMain JOIN Vendors
  ON InvoiceMain.VendorID = Vendors.VendorID
WHERE InvoiceDate = -- subquery here
  (SELECT MIN(InvoiceDate)
   FROM Invoices AS InvoiceCheck
   WHERE InvoiceCheck.VendorID = InvoiceMain.VendorID)
ORDER BY VendorName;

--9
-- problem 6
--SELECT SUM(Maximum) AS "Sum of Largest Unpaid Invoices"
--FROM (SELECT VendorID, MAX(InvoiceTotal) AS Maximum
--      FROM Invoices
--      WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0
--      GROUP BY VendorID) AS MyMax;
--problem 9
WITH MaximumInvoice AS
	(SELECT VendorID, MAX(InvoiceTotal) AS Maximum -- use same subquery as problem 6 here...
    FROM Invoices
    WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0
    GROUP BY VendorID)
SELECT SUM(Maximum) AS "Sum of Largest Unpaid Invoices"
FROM MaximumInvoice;
