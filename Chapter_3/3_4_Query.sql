SELECT InvoiceTotal,
	InvoiceTotal * .1,
	InvoiceTotal * 1.1

FROM Invoices

WHERE InvoiceTotal >= 1000;