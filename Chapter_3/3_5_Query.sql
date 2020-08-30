SELECT InvoiceNumber as Number, InvoiceTotal as Total, PaymentTotal + CreditTotal as Credits, 
	InvoiceTotal - (PaymentTotal + CreditTotal) as Balance

FROM Invoices
	
WHERE InvoiceTotal BETWEEN 500 AND 10000

ORDER BY InvoiceTotal;

