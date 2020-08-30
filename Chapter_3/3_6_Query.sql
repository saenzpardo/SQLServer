SELECT VendorContactLName + ', ' + VendorContactFName as [Full Name]

FROM Vendors

WHERE (VendorContactLName LIKE '[A-E]%')
	AND VendorContactLName LIKE '[^D]%'
		

ORDER BY VendorContactLName, VendorContactFName;