USE AP;
GO
IF OBJECT_ID('Invoices_DELETE') IS NOT NULL
    DROP TRIGGER Invoices_DELETE;
GO

CREATE TRIGGER Invoices_DELETE
	ON Invoices
	AFTER DELETE
AS
INSERT INTO InvoiceArchive 
	(InvoiceID, VendorID, InvoiceNumber, InvoiceDate, InvoiceTotal,
	    PaymentTotal, CreditTotal, TermsID, InvoiceDueDate, PaymentDate)
	SELECT InvoiceID, VendorID, InvoiceNumber, InvoiceDate, InvoiceTotal,
	    PaymentTotal, CreditTotal, TermsID, InvoiceDueDate, PaymentDate 
	FROM Deleted;