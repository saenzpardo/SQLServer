-- 33:00 into Vid 1 for start point
-- Create procedure @ 44:47
-- Stopped @ 50:57

--Search for authors, title or genre
CREATE FUNCTION fnAuthorSearch
	(@AuthorName varchar(50))
	RETURNS TABLE
RETURN
	(SELECT LastName + ', ' + FirstName As Author, ProductGenre as Genre, MediaType AS Type, ProductName as Title 
	FROM tbl_author JOIN tbl_product 
		ON tbl_author.AuthorID = tbl_product.ProductAuthor 
			JOIN tbl_media 
				ON tbl_media.MediaID = tbl_product.MediaID 
	WHERE
	CONTAINS ((LastName, FirstName), @AuthorName)); --can't use full-text index search in Visual Studio as I am trying

SELECT * FROM tbl_author;
SELECT * FROM fnAuthorSearch('Tolkien');
DROP FUNCTION fnAuthorSearch;

-- Search title
CREATE FUNCTION fnTitleSearch
	(@ProductTitle varchar(50))
	RETURNS TABLE
RETURN
	(SELECT LastName + ', ' + FirstName As Author, ProductGenre as Genre, MediaType AS Type, ProductName as Title 
		FROM tbl_author JOIN tbl_product 
			ON tbl_author.AuthorID = tbl_product.ProductAuthor 
				JOIN tbl_media 
					ON tbl_media.MediaID = tbl_product.MediaID 
		WHERE
		CONTAINS ((ProductName), @ProductTitle));

SELECT * FROM fnTitleSearch('Tower');
SELECT * FROM tbl_product;
DROP FUNCTION fnTitleSearch;

-- Search Genre
CREATE FUNCTION fnGenreSearch
	(@genre varchar(50))
	RETURNS TABLE
RETURN
	(SELECT LastName + ', ' + FirstName As Author, ProductGenre as Genre, MediaType AS Type, ProductName as Title 
		FROM tbl_author JOIN tbl_product 
			ON tbl_author.AuthorID = tbl_product.ProductAuthor 
				JOIN tbl_media 
					ON tbl_media.MediaID = tbl_product.MediaID 
		WHERE
		CONTAINS ((ProductGenre), @genre));

SELECT * FROM fnGenreSearch('Fantasy');
SELECT * FROM tbl_product;
DROP FUNCTION fnGenreSearch;

CREATE FUNCTION fnCustomerSearch
	(@CustomerID int)
	RETURNS TABLE
RETURN
	(SELECT CustomerID AS 'Library Card Number', LastName + ', ' + FirstName AS Name, CustomerPhoneNum As 'Phone Number',
		CustomerCity As City, CustomerState AS State, CustomerZip AS 'ZIP Code'
	FROM tbl_customer
	WHERE CustomerID = @CustomerID);

-- Function call to view customers
SELECT * FROM fnCustomerSearch(1);
--Add item to inventory

CREATE PROC spNewProduct
	@MediaID int,
	@ProductAuthor int,
	@ProductGenre varchar(50),
	@ProductName varchar(50)
AS
INSERT tbl_product
VALUES (@MediaID, @ProductAuthor, @ProductGenre, @ProductName);

EXEC spNewProduct 1, 6, 'Biography', 'The Life and Times of Adam Saenzpardo as a Lover, and a Gentleman';

SELECT * FROM tbl_product;
SELECT * FROM tbl_author;

--Remove item from inventory

--Create new customer
CREATE PROC spNewCustomer
	@FirstName varchar(50),
	@LastName varchar(50),
	@CustomerPhoneNum varchar(50),
	@CustomerAddress varchar(50),
	@CustomerCity varchar(50), 
	@CustomerState varchar(50),
	@CustomerZip varchar(50)
AS
INSERT tbl_customer
VALUES (@FirstName, @LastName,	@CustomerPhoneNum,
	@CustomerAddress, @CustomerCity, @CustomerState, @CustomerZip)
	
SELECT * FROM tbl_customer;

EXEC spNewCustomer 'Al', 'Bundy', '308-672-0871','123 Anywhere', 'Lincoln', 'NE', '12345';
--Display all inventory and author name
SELECT ProductName AS Title, FirstName + ' ' + LastName AS Author
FROM tbl_product JOIN tbl_author
	ON tbl_author.AuthorID = tbl_product.ProductAuthor;

--Display all Customers
SELECT LastName + ', ' + FirstName AS Name, CustomerPhoneNum As 'Phone Number',
	CustomerCity As City, CustomerState AS State, CustomerZip AS 'ZIP Code'
FROM tbl_customer
ORDER BY LastName;

SELECT * FROM tbl_customer;
SELECT * FROM tbl_product;
DELETE tbl_customer WHERE CustomerID = 17;

-- checkout procedure
CREATE PROC spNewCheckout
	@CustomerID int,
	@ProductID int,
	@DateBorrowed date,
	@DateDue smalldatetime,
	@DateReturned smalldatetime = Null
AS
-- not sure we need these set statements - can hardcode in C# to pass into parameters easier...
--SET @DateBorrowed = GETDATE()
--SET @DateDue = @DateBorrowed + 14
INSERT tbl_borrow
VALUES (@CustomerID, @ProductID, @DateBorrowed, @DateDue, @DateReturned);

DROP PROC spNewCheckout;

EXEC spNewCheckout 3, 5, '2020-12-3', '2020-12-4' ;

INSERT INTO tbl_borrow
	VALUES (1, 1, 2, '2020-10-1', '2020-10-20');
SELECT * FROM tbl_borrow;

-- display borrowed products
CREATE PROC spDisplayBorrowed
AS

SELECT tbl_borrow.ProductID as 'Product ID', FirstName + ' ' + LastName AS Customer, ProductName AS Title, DateDue AS 'Due Date' 
FROM tbl_borrow 
	JOIN tbl_customer 
		ON tbl_customer.CustomerID = tbl_borrow.CustomerID 
		JOIN tbl_product 
			ON tbl_product.ProductID = tbl_borrow.ProductID
WHERE DateReturned IS NULL;
-- end procedure

EXEC spDisplayBorrowed;

DROP PROC spDisplayBorrowed;

-- return product -- will just use DateTime.Now in C# to simplify UPDATE statement here.
UPDATE tbl_borrow 
SET DateReturned = '2020-12-05'
WHERE TransactionID = 3;

