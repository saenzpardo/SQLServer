/*
	Chapter 15: Scripting
	J. Adam Saenzpardo
*/

--1
CREATE PROC spBalanceRange
	@VendorVar varchar(50) = '%',
    @BalanceMin money = 0,
    @BalanceMax money = 0
AS
IF @BalanceMax = 0
	BEGIN
		SELECT VendorName, InvoiceNumber, InvoiceTotal - CreditTotal - PaymentTotal AS Balance
		FROM Vendors JOIN Invoices
		ON Vendors.VendorID = Invoices.VendorID
		WHERE VendorName LIKE @VendorVar 
			AND (InvoiceTotal - CreditTotal - PaymentTotal) >= @BalanceMin
			AND (InvoiceTotal - CreditTotal - PaymentTotal) > 0 		
		ORDER BY Balance DESC;
	END;
ELSE
	BEGIN
		SELECT VendorName, InvoiceNumber, InvoiceTotal - CreditTotal - PaymentTotal AS Balance
		FROM Vendors JOIN Invoices
		ON Vendors.VendorID = Invoices.VendorID
		WHERE VendorName LIKE @VendorVar 
			AND (InvoiceTotal - CreditTotal - PaymentTotal) > 0 
			AND (InvoiceTotal - CreditTotal - PaymentTotal) 
			BETWEEN @BalanceMin 
			AND @BalanceMax
		ORDER BY Balance DESC;
	END;

--DROP PROC spBalanceRange;
--2.a
EXEC spBalanceRange 'M%';
--2.b
EXEC spBalanceRange @BalanceMin = 200, @BalanceMax = 1000;
--2.c
EXEC spBalanceRange '[C-F]%', 0, 200;
--3
CREATE PROC spDateRange
	@DateMin varchar(50) = NULL,
	@DateMax varchar(50) = NULL
AS
IF @DateMin IS NULL OR @DateMax IS NULL
	THROW 50001, 'The DateMin and DateMax parameters are required.', 1;
IF NOT (ISDATE(@DateMin) = 1 AND ISDATE(@DateMax) = 1)
	THROW 50001, 'The date format is not valid. Please use mm/dd/yy.', 1;
IF CAST(@DateMin AS datetime) > CAST(@DateMax AS datetime)
	THROW 50001, 'The DateMin parameter must be earlier than DateMax', 1;
SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, InvoiceTotal - CreditTotal - PaymentTotal AS Balance
FROM Invoices
WHERE InvoiceDate BETWEEN @DateMin 
	AND @DateMax
ORDER BY InvoiceDate;

--DROP PROC spDateRange;
--4
BEGIN TRY
	EXEC spDateRange '2015-12-10', '2015-12-20';
END TRY
BEGIN CATCH
	PRINT 'Error Number:  ' + CONVERT(varchar(100), ERROR_NUMBER());
	PRINT 'Error Message: ' + CONVERT(varchar(100), ERROR_MESSAGE());
END CATCH;
--5
CREATE FUNCTION fnUnpaidInvoiceID()
RETURNS int
BEGIN
	RETURN
    (SELECT MIN(InvoiceID)
     FROM Invoices
     WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0
		AND InvoiceDueDate =
			(SELECT MIN(InvoiceDueDate)
			FROM Invoices
			WHERE InvoiceTotal - CreditTotal - PaymentTotal > 0))
END;

--DROP FUNCTION fnUnpaidInvoiceID;

SELECT VendorName, InvoiceNumber, InvoiceDueDate, InvoiceTotal - CreditTotal - PaymentTotal AS Balance
FROM Vendors JOIN Invoices
	ON Vendors.VendorID = Invoices.VendorID
WHERE InvoiceID = dbo.fnUnpaidInvoiceID();
--6
CREATE FUNCTION fnDateRange
	(@DateMin smalldatetime,
	@DateMax smalldatetime)
RETURNS TABLE
RETURN
	(SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, InvoiceTotal - CreditTotal - PaymentTotal AS Balance
	 FROM Invoices
	 WHERE InvoiceDate BETWEEN @DateMin AND @DateMax);

--DROP FUNCTION fnDateRange;
-- test function
SELECT * FROM fnDateRange('2015-12-10','2015-12-20');
--7
SELECT VendorName, fnTable.*
FROM Vendors JOIN Invoices
	ON Vendors.VendorID = Invoices.VendorID
	JOIN dbo.fnDateRange('2015-12-10','2015-12-20') AS fnTable
  ON Invoices.InvoiceNumber = fnTable.InvoiceNumber;
--8
CREATE TABLE ShippingLabels
	(VendorName varchar(50),
	VendorAddress1	varchar(50),
	VendorAddress2 varchar(50),
	VendorCity varchar(50),
	VendorState char(2),
	VendorZipCode varchar(20));

-- trigger
CREATE TRIGGER Invoices_UPDATE_Shipping
	ON Invoices
	AFTER INSERT, 
	UPDATE
AS
	INSERT ShippingLabels
	SELECT VendorName, VendorAddress1, VendorAddress2, VendorCity, VendorState, VendorZipCode
	FROM Vendors JOIN Inserted 
		ON Vendors.VendorID = (SELECT VendorID FROM Inserted)
	WHERE Inserted.InvoiceTotal - Inserted.PaymentTotal - Inserted.CreditTotal = 0;

-- test
UPDATE Invoices
SET PaymentTotal = 67.92, PaymentDate = '2012-04-23'
WHERE InvoiceID = 100;
--9
CREATE TABLE TestUniqueNulls
	(RowID int IDENTITY NOT NULL,
	NoDupName varchar(20) NULL);

SELECT * FROM TestUniqueNulls;

CREATE TRIGGER NoDuplicates
	ON TestUniqueNulls
	AFTER INSERT,
	UPDATE 
AS
BEGIN
	IF
	(SELECT COUNT(*)
	FROM TestUniqueNulls JOIN Inserted
		ON TestUniqueNulls.NoDupName = Inserted.NoDupName) > 1
	BEGIN
		ROLLBACK TRAN;
			THROW 50001, 'Duplicate value.', 1;
	END;
END;

INSERT into TestUniqueNulls 
VALUES (NULL);
INSERT into TestUniqueNulls 
VALUES (NULL);

SELECT * FROM TestUniqueNulls;

INSERT into TestUniqueNulls 
VALUES ('Adam');
INSERT into TestUniqueNulls 
VALUES ('Adam');

SELECT * FROM TestUniqueNulls;

INSERT into TestUniqueNulls 
VALUES ('Cat');
INSERT into TestUniqueNulls 
VALUES ('Dog');

INSERT into TestUniqueNulls 
VALUES ('Hamster');
INSERT into TestUniqueNulls 
VALUES ('Fish');
INSERT into TestUniqueNulls 
VALUES ('Parakeet');
--INSERT into TestUniqueNulls 
--VALUES ('Dog');
INSERT into TestUniqueNulls 
VALUES ('GoldFish');

SELECT * FROM TestUniqueNulls;

INSERT into TestUniqueNulls 
VALUES ('goldfish');