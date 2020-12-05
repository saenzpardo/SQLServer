/*
	Sample database creation script for SQL Server 2016 class
	Author: J. Adam Saenzpardo
	Date: 10/28/2020
*/

-- notes:
-- IDENTITY (1,1) for auto increment by values of 1
-- CONSTRAINT
USE master;
GO
ALTER DATABASE LibraryDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
-- delete all instances of existing DB
DROP DATABASE LibraryDB
GO
--create database
CREATE DATABASE LibraryDB;
GO

-- use database created
USE LibraryDB;

--1.a/b

-- publisher table
CREATE TABLE tbl_publisher
(
    PublisherName       VARCHAR(50)     NOT NULL PRIMARY KEY,
    PublisherAddress    VARCHAR(50)     NOT NULL,
    PublisherCity       VARCHAR(50)     NOT NULL,
    PublisherState      VARCHAR(50)      NOT NULL, --modified to handle international publishers
    PublisherZip        VARCHAR(5)      NOT NULL,
    PublisherPhone      VARCHAR(18)     NOT NULL -- modified to handle international country codes for NON-US phone numbers 
);

-- media type table
CREATE TABLE tbl_media
(
	MediaID				INT				NOT NULL PRIMARY KEY IDENTITY (1,1),
	MediaType			VARCHAR(50)		NOT NULL,
    --MediaPublisher      VARCHAR(50)     NOT NULL CONSTRAINT fk_Media_PublisherName
    --                                    FOREIGN KEY REFERENCES tbl_publisher(PublisherName)
    --                                    ON UPDATE CASCADE ON DELETE CASCADE
                                        -- referential integrity needed here 
);

-- author table
CREATE TABLE tbl_author
(	
    AuthorID			INT				NOT NULL PRIMARY KEY IDENTITY (1,1), 
	FirstName			VARCHAR(50)		NOT NULL,
	LastName			VARCHAR(50)		NOT NULL,
	PublishingCompany	VARCHAR(50)	NOT NULL REFERENCES tbl_publisher(PublisherName)
);

-- customer table
CREATE TABLE tbl_customer
(
	CustomerID			INT				NOT NULL PRIMARY KEY IDENTITY (1,1),
	FirstName			VARCHAR(50)		NOT NULL,
	LastName			VARCHAR(50)		NOT NULL,
	CustomerPhoneNum	VARCHAR(12)		NULL,
	CustomerAddress		VARCHAR(50)		NOT NULL,		
	CustomerCity		VARCHAR(50)		NOT NULL,
	CustomerState		VARCHAR(10)		NOT NULL,
    CustomerZip         VARCHAR(5)      NOT NULL
);

-- product table
CREATE TABLE tbl_product
(
	ProductID			INT				NOT NULL PRIMARY KEY IDENTITY(1,1),
	MediaID				INT				NOT NULL
										REFERENCES tbl_media(MediaID),
	ProductAuthor		INT				NOT NULL
										REFERENCES tbl_author(AuthorID),
	ProductGenre		VARCHAR(50)		NOT NULL,
	ProductName			VARCHAR(50)		NOT NULL
);

-- borrow product table
CREATE TABLE tbl_borrow
(
	TransactionID		INT				NOT NULL PRIMARY KEY IDENTITY (1,1),
	CustomerID			INT				NOT NULL
										REFERENCES tbl_customer(CustomerID),
	ProductID			INT				NOT NULL
										REFERENCES tbl_product(ProductID),
	DateBorrowed		SMALLDATETIME	NOT NULL,
	DateDue				SMALLDATETIME	NOT NULL,
	DateReturned		SMALLDATETIME	NULL	
);


INSERT tbl_publisher (PublisherName, PublisherAddress, PublisherCity, PublisherState, PublisherZip, PublisherPhone) VALUES
('Simon and Schuster', '57 Littlefield Street', 'Avon', 'MA', '02322','+1-877-989-0009'),
('Allen & Unwin', '83 Alexander Street', 'Crows Nest', 'New South Wales', '2065', '+61-2-8425-0100'), -- screwed myself here...tables don't accept international information. Needs modified to fit without truncation
('Penguin Random House','400 Hahn Rd','Westminster','MD','21157','+1-410-848-1900'),
('HarperCollins','195 Broadway','New York','NY','10007','+1-800-242-7737'),
('Hachette Book Group','121 N Enterprise Blvd','Lebanon','IN','46052','+1-765-483-8600'),
('MacMillan','16365 James Madison Hwy US Route 15','Gordonsville','VA','22942','+1-888-330-8477'),
('Scholastic','557 Broadway','New York','NY','10012','+1-800-724-6527'),
('Sterling','387 Park Ave S Ste 11','New York','NY','10016','+1-212-532-7160'),
('Dover','31 E 2nd St','Mineola','NY','11501','+1-516-294-7000'),
('Tyndale House','351 Executive Drive','Carol Stream','IL','60188','+1-800-323-9400'),
('Disney Publishing WorldWide','44 S Broadway Ste 1000','While Plains','NY','10601','+1-914-288-4100'),
('John Wiley and Sons','111 River St','Hoboken','NJ','07030','+1-800-835-6770'),
('W.W. Norton','500 5th Ave','New York','NY','10110','+1-212-354-5500'),
('B&H Publishing','127 9th Ave N','Nashville','TN','37234','+1-615-251-3914'),
('Chronicle','680 Second Street','San Francisco','CA','94107','+1-800-759-0190')
GO

INSERT tbl_media (MediaType) VALUES --removed publisher here, not needed.
('Book'),
('AudioBook'),
('Video'),
('Newspaper'),
('Magazine'),
('MicroFilm')
GO

INSERT tbl_author (FirstName, LastName, PublishingCompany) VALUES
('Stephen', 'King', 'Simon and Schuster'),
('J.R.R.', 'Tolkien', 'Allen & Unwin'),
('John', 'Grisham', 'Penguin Random House'),
('Andrew', 'Cuomo', 'Penguin Random House'),
('Alisa', 'Cole', 'HarperCollins'),
('John', 'Lithgow', 'Chronicle'),
('Jeff','Kurti','Disney Publishing WorldWide'),
('Serge', 'Lang', 'Dover'),
('Jo', 'Taylor', 'Dover'),
('Neil DeGrasse','Tyson','W.W. Norton'),
('Amanda','Hesser','W.W. Norton'),
('Douglas','Boin','W.W. Norton'),
('Larry','McMurtry','Simon and Schuster'),
('Debbie','Viguie','Simon and Schuster'),
('Suzanne','Collins','Scholastic')
GO

INSERT tbl_customer (FirstName, LastName, CustomerPhoneNum, CustomerAddress, CustomerCity, CustomerState, CustomerZip) VALUES
('Adam', 'Saenzpardo', '308-672-0871', '220 E B Street', 'Hastings', 'NE', '68901'),
('John' ,'Doe', '308-555-2213', '1234 Anywhere Str', 'AnyTown', 'NE', '12345'),
('Jane' ,'Doe', '308-555-2210', '1233 Anywhere Str', 'AnyTown', 'NE', '12345'),
('Richard' ,'Dane', '308-555-2212', '1235 Anywhere Str', 'AnyTown', 'NE', '12345'),
('Scott' ,'Doke', '308-555-2215', '1237 Anywhere Str', 'AnyTown', 'NE', '12345'),
('Eddard' ,'Stark', '308-555-2213', '1234 Anywhere Str', 'Winterfell', 'Westeros', '22345'),
('Robb' ,'Stark', '308-555-2213', '1234 Anywhere Str', 'Winterfell', 'Westeros', '22345'),
('Sansa' ,'Stark', '308-555-2213', '1234 Anywhere Str', 'Winterfell', 'Westeros', '22345'),
('Catelyn' ,'Stark', '308-555-2213', '1234 Anywhere Str', 'Winterfell', 'Westeros', '22345'),
('Rickard' ,'Stark', '308-555-2213', '1234 Anywhere Str', 'Winterfell', 'Westeros', '22345'),
('Brandon' ,'Stark', '308-555-2213', 'Castle Black', 'The Wall', 'Westeros', '54321'),
('Arya' ,'Stark', '308-555-2213', '1234 Anywhere Str', 'Winterfell', 'Westeros', '22345'),
('Bran' ,'Stark', '308-555-2213', '1234 Anywhere Str', 'Winterfell', 'Westeros', '22345'),
('Hayden' ,'Winters', '308-555-2013', '12330 Anywhere Str', 'Los Angeles', 'CA', '52341'),
('Ella' ,'Hughes', '308-555-2213', '12331 Anywhere Str', 'Los Angeles', 'CA', '52342')
GO

-- 1.c

INSERT tbl_product (MediaID, ProductAuthor, ProductGenre, ProductName) VALUES
('1', '1', 'Fantasy', 'Dark Tower: The Gunslinger'),
('1', '1', 'Fantasy', 'Dark Tower II: The Drawing of the Three'),
('1', '1', 'Fantasy', 'Dark Tower III: The Waste Lands'),
('1', '1', 'Fantasy', 'Dark Tower IV: The Wizard and Glass'),
('1', '1', 'Fantasy', 'Dark Tower: The Wind Through the Keyhold'),
('1', '1', 'Fantasy', 'Dark Tower V: The Wolves of the Calla'),
('1', '1', 'Fantasy', 'Dark Tower VI: The Song of Susannah'),
('1', '1', 'Fantasy', 'Dark Tower VII: The Dark Tower'),
('2', '1', 'Fantasy', 'Dark Tower: The Gunslinger'),
('2', '1', 'Fantasy', 'Dark Tower II: The Drawing of the Three'),
('2', '1', 'Fantasy', 'Dark Tower III: The Waste Lands'),
('2', '1', 'Fantasy', 'Dark Tower IV: The Wizard and Glass'),
('2', '1', 'Fantasy', 'Dark Tower: The Wind Through the Keyhold'),
('2', '1', 'Fantasy', 'Dark Tower V: The Wolves of the Calla'),
('2', '1', 'Fantasy', 'Dark Tower VI: The Song of Susannah'),
('2', '1', 'Fantasy', 'Dark Tower VII: The Dark Tower'),
('1', '2', 'Fantasy', 'The Fellowship of the Ring'),
('1', '2', 'Fantasy', 'The Two Towers'),
('1', '2', 'Fantasy', 'The Return of the King'),
('2', '2', 'Fantasy', 'The Fellowship of the Ring'),
('2', '2', 'Fantasy', 'The Two Towers'),
('2', '2', 'Fantasy', 'The Return of the King')
GO

INSERT tbl_borrow (CustomerID, ProductID, DateBorrowed, DateDue, DateReturned) VALUES 
('1', '1', '2020-11-4', '2020-12-4', ''),
('2', '4', '2020-9-5', '2020-10-5', ''),
('3', '5', '2020-6-5', '2020-7-5', ''),
('4', '6', '2020-10-5', '2020-11-5', ''),
('5', '7', '2020-1-1', '2020-2-1', '2020-1-16'),
('6', '8', '2020-4-3', '2020-5-3', '2020-4-20'),
('7', '9', '2020-10-5', '2020-11-5', '2020-11-6'),
('8', '10', '2020-10-5', '2020-11-5', ''),
('9', '11', '2020-10-5', '2020-11-5', '2020-11-3'),
('10', '12', '2020-10-5', '2020-11-5', ''),
('1', '2', '2020-11-4', '2020-12-4', ''),
('1', '3', '2020-11-4', '2020-12-4', ''),
('15', '13', '2020-11-5', '2020-12-5', ''),
('14', '14', '2020-9-5', '2020-10-5', '2020-10-1'),
('14', '15', '2020-9-5', '2020-10-5', ''),
('15', '16', '2020-11-6', '2020-12-7', '')
GO
--2.a list all columns for all tables

SELECT TABLE_SCHEMA ,
       TABLE_NAME ,
       COLUMN_NAME ,
       ORDINAL_POSITION ,
       DATA_TYPE ,
       CHARACTER_MAXIMUM_LENGTH ,
       DATETIME_PRECISION
FROM   INFORMATION_SCHEMA.COLUMNS;

-- 2.b

SELECT *
FROM tbl_publisher
WHERE PublisherState = 'NY';

SELECT *
FROM tbl_media
WHERE MediaType LIKE '%[a-z]%';

SELECT *
FROM tbl_author JOIN tbl_publisher
	ON tbl_author.PublishingCompany = tbl_publisher.PublisherName
WHERE PublisherState = 'NY';

SELECT *
FROM tbl_customer
WHERE CustomerState = 'Westeros';

SELECT *
FROM tbl_product JOIN tbl_media
	ON tbl_product.MediaID = tbl_media.MediaID
WHERE MediaType = 'Book';

SELECT * 
FROM tbl_borrow JOIN tbl_customer
	ON tbl_borrow.CustomerID = tbl_customer.CustomerID
WHERE CustomerState = 'NE';

-- 2.c

SELECT *
FROM tbl_publisher
WHERE PublisherState = 'NY' AND
	PublisherZip < 10111;

SELECT *
FROM tbl_media
WHERE MediaType LIKE '%[a-z]%' AND
	LEN(MediaType) > 5;

SELECT *
FROM tbl_author JOIN tbl_publisher
	ON tbl_author.PublishingCompany = tbl_publisher.PublisherName
WHERE PublisherState != 'NY' AND
	PublisherCity = 'Avon';

SELECT *
FROM tbl_customer
WHERE LEN(CustomerState) > 2 AND
	CustomerState != 'The Wall';

SELECT *
FROM tbl_product JOIN tbl_media
	ON tbl_product.MediaID = tbl_media.MediaID
WHERE MediaType = 'Book' AND 
	ProductID = 5;


SELECT * 
FROM tbl_borrow JOIN tbl_customer
	ON tbl_borrow.CustomerID = tbl_customer.CustomerID
WHERE CustomerState = 'NE' AND
	DateDue >= GETDATE();

-- 2.d
SELECT *
FROM tbl_publisher
WHERE PublisherState = 'NY' OR
	PublisherState = 'CA';

SELECT *
FROM tbl_media
WHERE MediaType LIKE 'M%' OR
	MediaType = 'Book';

SELECT *
FROM tbl_author JOIN tbl_publisher
	ON tbl_author.PublishingCompany = tbl_publisher.PublisherName
WHERE PublisherState != 'NY' OR
	FirstName LIKE 'J%';

SELECT *
FROM tbl_customer
WHERE LEN(CustomerState) > 2 OR
	LastName = 'Doe';

SELECT *
FROM tbl_product JOIN tbl_media
	ON tbl_product.MediaID = tbl_media.MediaID
WHERE MediaType = 'Book' OR
	ProductName LIKE '%Gun%';

SELECT * 
FROM tbl_borrow JOIN tbl_customer
	ON tbl_borrow.CustomerID = tbl_customer.CustomerID
WHERE CustomerState = 'CA' OR
	DateDue >= GETDATE();

-- 2.e

SELECT *
FROM tbl_publisher
WHERE PublisherName NOT IN
	(SELECT DISTINCT PublishingCompany
	FROM tbl_author);

SELECT MediaType
FROM tbl_media
WHERE MediaID NOT IN
	(SELECT DISTINCT MediaID
	FROM tbl_product);

SELECT *
FROM tbl_author
WHERE LEN(LastName) >
	(SELECT COUNT(*)
	FROM tbl_media);

SELECT *
FROM tbl_customer
WHERE EXISTS 
	(SELECT *
	FROM tbl_borrow	
	WHERE tbl_borrow.CustomerID = tbl_customer.CustomerID);

SELECT *
FROM tbl_product
WHERE EXISTS
	(SELECT DISTINCT MediaType
	FROM tbl_media
	WHERE tbl_media.MediaID = tbl_product.MediaID);

SELECT *
FROM tbl_borrow
WHERE EXISTS
	(SELECT *
	FROM tbl_product
	WHERE tbl_product.ProductID = tbl_borrow.ProductID);

-- 2.f

SELECT * 
FROM tbl_publisher LEFT JOIN tbl_author
	ON tbl_publisher.PublisherName = tbl_author.PublishingCompany
WHERE tbl_author.AuthorID IS NULL ;

SELECT MediaType
FROM tbl_media LEFT JOIN tbl_product
	ON tbl_media.MediaID = tbl_product.MediaID
WHERE tbl_product.ProductID IS NULL;

SELECT * -- I'm not sure I can re-write this as a join.  I left it because I'd like to know for sure.
FROM tbl_author
WHERE LEN(LastName) >
	(SELECT COUNT(*)
	FROM tbl_media);

SELECT *
FROM tbl_customer LEFT JOIN tbl_borrow
	ON tbl_customer.CustomerID = tbl_borrow.CustomerID
WHERE ProductID IS NOT NULL;

SELECT * 
FROM tbl_product LEFT JOIN tbl_media
	ON tbl_product.MediaID = tbl_media.MediaID;

SELECT * 
FROM tbl_borrow LEFT JOIN tbl_product
	ON tbl_product.ProductID = tbl_borrow.ProductID;


-- 2.g
SELECT * 
FROM tbl_author 
	JOIN tbl_product
		ON tbl_author.AuthorID = tbl_product.ProductAuthor
	JOIN tbl_borrow ON tbl_borrow.CustomerID = tbl_borrow.CustomerID;

-- 2.h

SELECT LastName + ', ' + FirstName AS [Customer Name]
FROM tbl_customer
ORDER BY LastName DESC;

-- 2.i

SELECT tbl_customer.LastName + ', ' + tbl_customer.FirstName AS 'Customer Name', tbl_product.ProductName AS Title, tbl_borrow.DateDue AS 'Due Back'
FROM tbl_customer 
	JOIN tbl_borrow ON (tbl_customer.CustomerID = tbl_borrow.CustomerID)
	JOIN tbl_product ON (tbl_borrow.ProductID = tbl_product.ProductID)
WHERE CONVERT(date, DateBorrowed) = '2020-10-5' 
ORDER BY LastName DESC;

-- 2.j
SELECT COUNT(*) AS 'Total Transactions'
FROM tbl_borrow;

-- 2.k
UPDATE tbl_customer 
SET CustomerState = 'NE';

-- 2.l
UPDATE tbl_publisher
SET PublisherPhone = PublisherCity, PublisherCity = PublisherPhone;

-- 2.m

DELETE FROM tbl_media
DELETE FROM tbl_publisher
DELETE FROM tbl_author
DELETE FROM tbl_customer
DELETE FROM tbl_product
DELETE FROM tbl_borrow

-- all tables
--SELECT *
--FROM tbl_publisher;

--SELECT *
--FROM tbl_media;

--SELECT *
--FROM tbl_author;

--SELECT *
--FROM tbl_customer;

--SELECT *
--FROM tbl_product;

--SELECT *
--FROM tbl_borrow;