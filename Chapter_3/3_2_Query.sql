SELECT InvoiceNumber as Number, InvoiceTotal as Total, PaymentTotal + CreditTotal as Credits, 
	InvoiceTotal - (PaymentTotal + CreditTotal) as Balance

FROM Invoices;

