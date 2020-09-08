USE AP;

-- Question 1
SELECT *
FROM Invoices
WHERE CreditTotal <> 0;

-- Question 2
SELECT *
FROM Vendors
WHERE VendorName LIKE 'us%';

-- Question 3
SELECT *
FROM Vendors
WHERE VendorAddress2 IS NULL;

-- Question 4
SELECT AccountNo AS Number, AccountDescription AS Description
FROM GLAccounts
ORDER BY AccountNo Desc;

-- Question 5
SELECT InvoiceTotal, PaymentTotal, CreditTotal, InvoiceTotal - PaymentTotal - CreditTotal AS BalanceTotal 
FROM Invoices
WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0;

-- Question 6 - explicit join
SELECT *
FROM Vendors JOIN Terms
	ON Vendors.DefaultTermsID = Terms.TermsID;

-- Question 7 
--explicit inner join
-- Invoices table 1, InvoiceLineItems table 2, GLAccounts table 3
SELECT InvoiceNumber, InvoiceDate, InvoiceSequence, AccountDescription --list all columns to display from every table here
FROM Invoices	--table one here
	JOIN InvoiceLineItems -- join tables 1 and 2 using the InvoiceID relationship
		ON Invoices.InvoiceID = InvoiceLineItems.InvoiceID
	JOIN GLAccounts ON InvoiceLineItems.AccountNo = GLAccounts.AccountNo; -- join table 3 to table 2 using the AccountNo relationship

--implicit inner join - used prior to SQL-92 standards
SELECT InvoiceNumber, InvoiceDate, InvoiceSequence, AccountDescription -- all columns to view
FROM Invoices, InvoiceLineItems, GLAccounts --all tables to work with
WHERE Invoices.InvoiceID = InvoiceLineItems.InvoiceID --table 1 to 2 join
	AND InvoiceLineItems.AccountNo = GLAccounts.AccountNo; --table 2 to 3 join

-- Question 8
SELECT *
FROM GLAccounts LEFT JOIN InvoiceLineItems -- outer join with GLAccounts on left
	ON GLAccounts.AccountNo = InvoiceLineItems.AccountNo -- using AccountNo as relationship
WHERE InvoiceLineItems.AccountNo IS NULL; -- if AccountNo is NULL - GLAccount is not used.  

-- Question 9
-- table Invoices
-- columns InvoiceID, Status
-- Status = Late, Paid or Pending
-- Late if InvoiceDueDate < 2016-04-30
-- Paid if value in PaymentDate is NULL
/*
Need more work here...something's amiss
*/
Select *
FROM Invoices
WHERE PaymentDate < '2016-03-01';

SELECT 'Late' AS Status, InvoiceID
FROM Invoices	
WHERE PaymentDate <= '2016-04-30'
UNION
SELECT 'Paid' AS Status, InvoiceID
FROM Invoices
WHERE PaymentDate IS NULL
UNION 
SELECT 'Pending' AS Status, InvoiceID
FROM Invoices
WHERE PaymentDate > '2016-04-30' 
	AND PaymentDate IS NOT NULL;