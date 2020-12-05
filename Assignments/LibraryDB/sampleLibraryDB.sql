CREATE DATABASE db_library
USE db_library
GO



CREATE TABLE tbl_publisher	 (
	 publisher_name VARCHAR(50) PRIMARY KEY NOT NULL, 
	 publisher_address VARCHAR(50) NOT NULL,
	 publisher_phone VARCHAR(50) NOT NULL
);


CREATE TABLE tbl_book (
	 book_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	 book_title VARCHAR(50) NOT NULL,
	 book_publishername VARCHAR(50) NOT NULL CONSTRAINT fk_book_publishername FOREIGN KEY REFERENCES tbl_publisher(publisher_name) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE tbl_authors (
	 authors_id INT NOT NULL CONSTRAINT 
        fk_book_bookid FOREIGN KEY 
            REFERENCES tbl_book(book_id) 
            ON UPDATE CASCADE ON DELETE CASCADE,
	 authors_authorname VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_borrower (
	 borrower_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	 borrower_name VARCHAR(50) NOT NULL,
	 borrower_address VARCHAR(50) NOT NULL,
	 borrower_phone VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_branch (
	 branch_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	 branch_name VARCHAR(50) NOT NULL,
	 branch_address VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_copies (
	 copies_bookid INT NOT NULL CONSTRAINT fk_copies_bookid FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 copies_branchid INT NOT NULL CONSTRAINT fk_branch_id FOREIGN KEY REFERENCES tbl_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 copies_copynumber INT NOT NULL
);

CREATE TABLE tbl_loans (
	 loans_id INT NOT NULL CONSTRAINT fk_loans_bookid FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 loans_branchid INT NOT NULL CONSTRAINT fk_loans_branchid FOREIGN KEY REFERENCES tbl_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 loans_cardno INT NOT NULL CONSTRAINT fk_borrower_id FOREIGN KEY REFERENCES tbl_borrower(borrower_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 loans_dateout VARCHAR(50) NOT NULL,
	 loans_duedate VARCHAR(50) NOT NULL
);

INSERT INTO tbl_publisher VALUES ('Random House', '123 Main St', '123-456-7890')

INSERT INTO tbl_book VALUES ('Jurrassic Park', 'Random House')

SELECT * FROM tbl_book

INSERT INTO tbl_branch VALUES ('Downtown', '123 Peach St.'), ('Riverside', '345 Side St')

SELECT * FROM tbl_branch

INSERT INTO tbl_authors VALUES (2, 'Stephen King'), (8, 'Roald Dahl'), (10, 'William Shakespeare'), (12, 'Agatha Christie'), (13, 'Tony Hillerman'), (14, 'JRR Tolkien'), (15, 'Brandon Sanderson'), (17, 'CS Lewis'), (21, 'JK Rowling'), (22,'Philip K Dick')

INSERT INTO tbl_book VALUES ('It',  'Random House'), ('The Dark Tower', 'Random House'), ('Carrie',  'Random House'), ('The Shining', 'Random House'), ('James and the Giant Peach', 'Random House'), ('Charlie and the Chocolate Factory', 'Random House'), ('The Tempest', 'Random House'), ('Macbeth', 'Random House'), ('Murder on the Orient Express', 'Random House'), ('Patrol', 'Random House'), ('The Return of the King', 'Random House'), ('The Way of Kings', 'Random House'), ('Words of Radiance', 'Random House'), ('The Silver Chair', 'Random House'), ('The Magicians Nephew', 'Random House'), ('Voyage of the Dawn Treader', 'Random House'), ('The Last Battle', 'Random House'), ('Harry Potter and the Deathly Hallows', 'Random House'), ('A Scanner Darkly', 'Random House'), ('Do Androids Dream of Electric Sheep?', 'Random House')

SELECT * FROM tbl_authors

INSERT INTO tbl_copies VALUES (11, 1, 2), (2, 3, 2), (3, 4, 2), (4, 1, 2), (5, 2, 2), (6, 1, 2), (7, 3, 2), (8, 4, 2), (9, 2, 2), (10, 1, 2)

SELECT * FROM tbl_copies

INSERT INTO tbl_borrower VALUES ('John Smith', '123 Blackbird St', '234-567-8901'), ('Mary Tyler', '234 BirdBlack St', '345-678-9012'), ('Tonald Drump', '345 Bluebird St', '456-789-0123'), ('Pablo Escobar', '567 Troubador St', '678-901-2345'), ('Susan White', '789 Google St', '789-012-3456'), ('Greg Black', '890 Frog St', '890-123-4567'), ('Tom Brown', '901 Fly St', '901-234-5678'), ('Jerry Green', '012 5th Ave', '012-345-5678')

SELECT * FROM tbl_borrower

INSERT INTO tbl_loans VALUES (2, 2, 4, '11/25/17', '12/22/17'), (3, 2, 4, '11/25/17', '12/22/17'), (4, 2, 4, '11/25/17', '12/22/17'), (5, 2, 4, '11/25/17', '12/22/17'), (6, 2, 4, '11/25/17', '12/22/17'), (7, 1, 7, '11/25/17', '12/22/17'), (8, 1, 7, '11/25/17', '12/22/17'),(9, 1, 7, '11/25/17', '12/22/17'),(10, 1, 7, '11/25/17', '12/22/17'),(11, 1, 7, '11/25/17', '12/22/17'),(12, 3, 1, '11/25/17', '12/22/17'),(13, 2, 2, '11/25/17', '12/22/17'),(14, 3, 3, '11/25/17', '12/22/17'),(15, 4, 5, '11/25/17', '12/22/17'),(16, 1, 6, '11/25/17', '12/22/17'),(17, 3, 8, '11/25/17', '12/22/17'),(18, 1, 7, '11/25/17', '12/22/17'),(19, 1, 7, '11/25/17', '12/22/17'),(20, 1, 7, '11/25/17', '12/22/17'),(21, 1, 7, '11/25/17', '12/22/17'),(22, 1, 7, '11/25/17', '12/22/17'),(23, 1, 7, '11/25/17', '12/22/17')

SELECT * FROM tbl_loans

--Question #1 finding number of copies lost tribe at sharpstown branch
CREATE PROC copies_losttribe
AS
SELECT C.copies_copynumber
FROM tbl_book AS B
JOIN tbl_copies AS C ON B.book_id = C.copies_bookid
JOIN tbl_branch AS BR ON C.copies_branchid = BR.branch_id
WHERE B.book_id = 2 AND BR.branch_id = 1
GO
--Question #2 How many copies lost tribe at each branch
CREATE PROC losttribe_branch
AS
SELECT BR.branch_name, B.book_title, C.copies_copynumber
FROM tbl_book AS B
LEFT OUTER JOIN tbl_copies AS C ON B.book_id = C.copies_bookid
LEFT OUTER JOIN tbl_branch AS BR ON C.copies_branchid = BR.branch_id
WHERE B.book_title = 'the lost tribe'
GO
--Question #3 Names of all borrowers who do not have books checked out
CREATE PROC names_checkedout
AS
SELECT BO.borrower_name
FROM tbl_borrower AS BO
JOIN tbl_loans AS L ON L.loans_cardno = BO.borrower_id
WHERE loans_id IS NULL
GO
--Question #4 For each book that is loaned out from the "Sharpstown" branch and whose
--DueDate is today, retrieve the book title, the borrower's name, and the borrower's address.
CREATE PROC sharpstown_borrower
AS
SELECT BO.borrower_name, BO.borrower_address, B.book_title
FROM tbl_book AS B
JOIN tbl_loans AS L ON L.loans_id = B.book_id
JOIN tbl_branch AS BR ON L.loans_branchid = BR.branch_id
JOIN tbl_borrower AS BO ON BO.borrower_id = L.loans_cardno
WHERE BR.branch_name = 'Sharpstown' AND L.loans_duedate = '11/25/17'
GO
--Question #5 For each library branch, retrieve the branch name 
--and the total number of books loaned out from that branch.
CREATE PROC branch_booknumber
AS
SELECT BR.branch_name, COUNT (C.copies_copynumber)
FROM tbl_branch AS BR
JOIN tbl_copies AS C ON BR.branch_id = C.copies_branchid
GROUP BY BR.branch_name
GO
--Question #6 Retrieve the names, addresses, and number of books checked 
--out for all borrowers who have more than five books checked out.
CREATE PROC retrieve_five
AS
SELECT BO.borrower_name, BO.borrower_address, COUNT (L.loans_id)
FROM tbl_borrower AS BO
JOIN tbl_loans AS L ON L.loans_cardno = BO.borrower_id
GROUP BY BO.borrower_name, BO.borrower_address
HAVING COUNT (L.loans_id) > 5
GO
--Question #7  For each book authored (or co-authored) by "Stephen King", 
--retrieve the title and the number of copies owned by the library branch whose name is "Central".
CREATE PROC king_central
AS
SELECT B.book_title, C.copies_copynumber
FROM tbl_book AS B
JOIN tbl_copies AS C ON C.copies_bookid = B.book_id
JOIN tbl_authors AS A ON A.authors_id = B.book_id
JOIN tbl_branch AS BR ON BR.branch_id = C.copies_branchid
WHERE authors_authorname = 'Stephen King' AND BR.branch_name = 'Central'
GO

/*This is a project I made to manage the books and accounts for a library to show some of my sql programming skills */
create database Library_Management_System
use Library_Management_System

/*create User table with fields*/
create table Users(
User_Id int identity(1,1) primary key not null,
Roles_ID int ,
Name varchar(20),
Division varchar(25),
Contact varchar(15),
Address varchar(500),
Year int
)

/*Insert details into Users table*/

insert into Users values(1,  'Hamish',   'Business Intelligence',  '0210000001', 'Auckland', 2018)
insert into Users values(2,  'Ross',   'Business Intelligence',  '0210000002', 'Rotorua', 2018)
insert into Users values(1,  'Trent',   'Business Intelligence',  '0210000003', 'Rawene', 2018)
insert into Users values(2,  'Martin',   'Business Intelligence',  '0210000004', 'Charleston', 2018)
insert into Users values(1,  'Camilla',   'Business Intelligence',  '0210000005', 'Dallas', 2018)
insert into Users values(2,  'Henry',   'Business Intelligence',  '0210000006',  'Rawene', 2018)
insert into Users values(1,  'Victoria',   'Business Intelligence',  '0210000007',  'Mumbai', 2018)
insert into Users values(1,  'Ariana',    'Data Analytics',  '0210000008',  'Manila', 2018)
insert into Users values(2,  'Luke',    'Data Analytics',  '0210000009',  'St Louis', 2018)
insert into Users values(2,  'Kat',   'Data Analytics',  '0210000010',  'Lusaka', 2019)
insert into Users values(2,  'Colin',  'Data Analytics',  '0210000011',  'Shanghai', 2019)
insert into Users values(1,  'Lauren', 'Data Analytics',  '0210000012',  'Dublin', 2019)
insert into Users values(1,  'Tim',  'Data Analytics',  '0210000013',  'Louisville', 2019) 
insert into Users values(1,  'Kane', 'Data Analytics',  '0210000014',  'Pukekohe', 2019)
insert into Users values(1,  'Tom',  'Business Intelligence',  '0210000015',  'Suva', 2019) 
insert into Users values(1,  'Inderbir',  'Business Intelligence',  '0210000016',  'Auckland', 2019)
insert into Users values(1,  'Lindsey',  'Data Analytics',  '0210000017',  'Whangerei', 2019)
insert into Users values(1,  'James', 'Data Analytics',  '0210000018',  'Mumbai', 2019)
insert into Users values(1,  'Lyla',  'Data Analytics',  '0210000019',  'Suva', 2019) 
insert into Users values(2,  'Matthew',  'Business Intelligence',  '0210000020', 'Auckland', 2019) 
                   
/*Show table of staff*/
select Name,Division,Contact,Address,Year 
from Users 
where Roles_ID>1
/*Show name and id of all users */
select Name,User_Id 
from Users


/*Create Book Table*/

create table Books(
Book_Id int primary key identity,
Book_Serial_Num int,
Book_Name varchar(50),
Author_Name varchar(50),
Book_Edition varchar(100),
category_Id int
)

/*Insert details into book table*/

insert into Books values(1001,  'True Allegiance', 'Ben Shapiro',   '1st',   1)
insert into Books values(1002,  '12 Rules for Life',    'Jordan Peterson',    '1st',   2)
insert into Books values(1003,  'Justice on Trial',     'Mollie Hemingway',   '1st',   3)
insert into Books values(1004,  'Sherlock Holmes',     'Arthur Conan Doyle',    '1st',   4)
insert into Books values(1005,  'Murder on the Orient Express',     'Agatha Christie',   '1st',   5)
insert into Books values(1006,  'The Girl with the Dragon Tattoo',      'Stieg Larsson',   '1st',   6)
insert into Books values(1007,  'The Right Side of History',   'Ben Shapiro',   '1st',   7)
insert into Books values(1008,  'The Secret in Their Eyes',     'Eduardo Sacheri',   '1st',   8)
insert into Books values(1009,  'Revenge',     'Ted Sullivan',   '1st',   9)
insert into Books values(1010,  'The Great Gatsby',    'Scott Fitzgerald',   '1st',   10)
insert into Books values(1011,  'The Count of Monte Cristo',  'Alexandre Dumas',   '2nd',   11)
insert into Books values(1012,  'Moby Dick',      'Herman Melville',   '2nd',   12)
insert into Books values(1013,  'Hamlet',      'William Shakespeare',   '2nd',   13)
insert into Books values(1014,  'Basic Economics',      'Thomas Sowell',   '2nd',   14)
insert into Books values(1015,  'Pride and Prejudice',    'Jane Austin',  '2nd',   15)
insert into Books values(1016,  'The Lovely Bones',   'Alice Sebold',   '2nd',   16)
insert into Books values(1017,  'True Grit',   'Charles Portis',  '2nd',   17)
insert into Books values(1018,  'Gone With The Wind', 'Margaret Mitchell',  '2nd',   18)
insert into Books values(1019,  'Economics in One Lesson',   'Heny Hazzlit',  '2nd',   19)
insert into Books values(1020,  'The Diary of a Young Girl',     'Anne Frank',   '2nd',   20)

/*Show table of book details and which division has taken out those books */

select Books.Book_Serial_Num,
Books.Book_Name,
Books.Author_Name,
Books.Book_Edition,
users.Division,
category.Book_Category 
from Books 
inner join category on Books.category_Id=category.category_Id
inner join Users on Users.User_Id=category.category_Id 



DROP TABLE category

/*Create category table */

create table category (
category_Id int identity primary key,
Book_Category varchar(100)
)

select * from category

insert into category values('Business Intelligence')
insert into category values('Business Intelligence')
insert into category values('Business Intelligence')
insert into category values('Business Intelligence')
insert into category values('Business Intelligence')
insert into category values('Business Intelligence')
insert into category values('Business Intelligence')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Business Intelligence')
insert into category values('Business Intelligence')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Data Analytics')
insert into category values('Business Intelligence')
insert into category values('Business Intelligence')




/*create book issues record table*/

create table Book_Issues(
Bk_Issue_Id int identity primary key,
Date_Of_Issue date,
Date_Of_Return date,
Book_Id int,
[User_Id] int,
category_Id int,
Book_Status varchar(20)
)

/*Book issue details*/

Insert into Book_Issues  Values ('2018-02-08','2018-02-10',2,2,1,'True')
Insert into Book_Issues  Values ('2018-01-02','2018-01-10',2,2,3,'True')
Insert into Book_Issues  Values ('2018-03-03','2018-03-10',2,3,3,'True')
Insert into Book_Issues  Values ('2018-01-02','2018-01-10',2,2,3,'True')
Insert into Book_Issues  Values ('2018-04-02','2018-04-10',1,2,3,'True')
Insert into Book_Issues  Values ('2018-06-06','2018-06-12',2,2,3,'True')
Insert into Book_Issues  Values ('2018-03-02','2018-03-10',6,6,3,'True')
Insert into Book_Issues  Values ('2018-01-02','2018-01-10',4,4,3,'True')
Insert into Book_Issues  Values ('2018-01-02','2018-01-10',2,4,5,'True')
Insert into Book_Issues  Values ('2018-01-02','2018-01-10',6,6,6,'True')
Insert into Book_Issues  Values ('2019-01-02','2019-01-10',2,2,3,'True')
Insert into Book_Issues  Values ('2019-01-02','2019-01-10',2,2,3,'True')
Insert into Book_Issues  Values ('2019-01-02','2019-01-10',2,2,3,'True')
Insert into Book_Issues  Values ('2019-04-02','2019-04-10',1,2,3,'True')
Insert into Book_Issues  Values ('2019-06-06','2019-06-12',2,2,3,'True')
Insert into Book_Issues  Values ('2019-03-02','2019-03-10',6,6,3,'True')
Insert into Book_Issues  Values ('2019-01-02','2019-01-10',2,2,3,'True')
Insert into Book_Issues  Values ('2019-01-02','2019-01-10',2,2,3,'True')

/*Show record of books issued by user and book*/

select Users.Stu_Id,Books.Book_Name,Books.Author_Name,Book_Issues.Date_Of_Issue,Date_Of_Return 
from Users 
inner join Book_Issues on Users.Stu_Id=Book_Issues.Stu_Id 
inner join Books on Books.Book_Id=Book_Issues.Book_Id


select Users.[User_Name],Books.Book_Name,Book_Issues.Date_Of_Issue,Book_Issues.Date_Of_Return 
from Users 
inner join Book_Issues on Users.Stu_Id=Book_Issues.Stu_Id 
inner join Books on Books.Book_Id=Book_Issues.Book_Id 
inner join category on category.category_Id=Book_Issues.category_Id

/*Create record of late fees*/

create table Due_Date_Fee(
Due_Date_Fee_Id int identity primary key,
Fee_Amount decimal(5,2),
Book_Id int ,
Bk_Issue_Id int
)

/*Show table of late fees for the books that have a fee againsst them */

select Books.Book_Name,Books.Author_Name,Book_Issues.Date_Of_Issue,Book_Issues.Date_Of_Return 
from Books 
inner join Due_Date_Fee on Books.Book_Id=Due_Date_Fee.Book_Id 
inner join Book_Issues on Book_Issues.Bk_Issue_Id=Due_Date_Fee.Bk_Issue_Id

/*initial record of due date fees*/

insert into Due_Date_Fee values(13,1,1),(7.99,2,2),(6.8,3,3)

/*Create User Roles*/

create table Roles(
Roles_ID int identity primary key,
Role_Name varchar(50)
)

insert into Roles values ('Admin'),('Staff'),('Management')

/*Stock table with table for name and number*/

create table Stocks(
Stock_ID int primary key identity,
Stock int,
Book_id int
)

create table stock(
StockID int identity primary key,
Stock nvarchar(500),
Book_Id int
)

/*Show inventory of books by category*/

select Books.Book_Name,category.Book_Category,Stocks.Stock 
from Stocks 
inner join Books on Stocks.Book_id=Books.Book_id 
inner join category on Stocks.Stock_ID=category.category_Id

select * from Stocks

insert into Stocks values(1,1),(2,2),(3,3)

/*Show inventory of books*/

select Books.Book_Name,Books.Author_Name,Stocks.Stock 
from Books 
inner join Stocks on Stocks.Book_id=Books.Book_Id

/*Show users with their roles*/


select  r.Role_Name,Name,Division,Contact,Address,Year 
from users u 
inner join Roles  r on r.Roles_ID = u.roles_id 
where u.roles_id>1

/*Show book issue information*/

select Books.Book_Name,[Users].Name As'Student_Name',category.Book_Category,CONVERT(varchar,Book_Issues.Date_Of_Issue,103) as Issue_Date 
from Book_Issues 
inner join Books on Book_Issues.Book_Id=Books.Book_Id 
inner join category on category.category_Id=Book_Issues.category_Id 
inner join [Users] on [Users].[User_Id]=Book_Issues.[User_Id]

/*Book issues by division for users with more than one book issues*/
SELECT Users.User_id, Users.division, Book_Issues.Book_Id, count(Book_Issues.Book_Id) AS count 
FROM Users 
JOIN Book_Issues ON Users.User_id = Book_Issues.User_id 
GROUP BY division 
HAVING count( Users.User_id ) > 1;

/*Check the books with the highest amount of fees*/
select Fee_Amount, Bk_Issue_Id, DENSE_RANK() OVER (ORDER BY Fee_Amount DESC) AS RANK 
from Due_Date_Fee

/* Total fees due*/
select sum(case when Fee_Amount >0 then Fee_Amount else 0 end) AS Overdue 
from Due_Date_Fee;

/* 5th highest Due date fee amount*/ 
SELECT TOP (1) Fee_Amount 
FROM(SELECT DISTINCT TOP (5) Fee_Amount 
      FROM Due_Date_Fee 
      ORDER BY Fee_Amount DESC) AS Fee 
ORDER BY Fee_Amount

/* split fee into dollar and cents*/
select Fee_Amount, trunc(Fee_Amount) as Dollars, nvl(100*(Fee_Amount - trunc(Fee_Amount)), 0) as Cents 
from Due_Date_Fee;


select * from Users 
Select * from Book_Issues
Select * from Books
Select * from category
Select * from Due_Date_Fee
Select * from Roles
Select * from Stocks
Select * from Users


CREATE DATABASE dbBookRecords;

CREATE TABLE tblBOOK
(BookId int NOT NULL,
Title nvarchar(50) NOT NULL,
PublisherName nvarchar(50) NOT NULL
)

INSERT INTO tblBOOK
(BookId,Title,PublisherName)
VALUES(1, ' The Lost Tribe', 'Mc Millan'),
(2, ' The Peaceful Warrior', 'Ordeniza Associates'),
(3, ' My Life', 'Joys PUbli'),
(4, ' We Are The World', 'Pruis Publisher'),
(5, ' The Way Station', 'KingsMen'),
(6, ' Perla Labandera', 'Blackintach Company'),
(7, ' The Echosera', 'Britanica Publisher'),
(8, ' The Froglet', 'National Geographic Publisher'),
(9, ' AKA SIA', 'Vogue Magazine'),
(10, ' Im Kimmy Dora', 'GQ Publisher'),
(11, ' I Love Black', 'Versae Publisher'),
(12, ' Life of a chef', 'Kilay Publisher'),
(13, ' I have Bangs', 'Dairy Publisher '),
(14, ' I have thick hair', 'ENya Publisher'),
(15, ' I love my jawline', 'Blackintach Company'),
(16, ' I am an Entreprenuer', 'Ordeniza Associates'),
(17, ' Modern Day Businesswoman', 'Joys PUbli'),
(18, ' My Juga and I', 'Joys PUbli'),
(19, ' My name is booba', 'Blackintach Company'),
(20, ' Perla: The Memoir', 'Versae Publisher')

CREATE TABLE tblBooks_AUTHOR
(BookId int NOT NULL,
AuthorName nvarchar(50) NOT NULL
)
INSERT INTO tblBooks_AUTHOR
(BookId, AuthorName)
VALUES(1,  'Pearl'),
(2,  'Ordeniza'),
(3,  'Joyce'),
(4,  'Mac'),
(5,  'Stephen King'),
(6,  'J.K Rowling'),
(7,  'Danielle Steel'),
(8,  'Oprah Winfrey'),
(9,  'Jessica Hagedorn'),
(10,'David Henry Hwang'),
(11, 'George Lucas '),
(12,'Nicholas Sparks'),
(13, 'Emily Dickenson'),
(14,  'Edgar Alan '),
(15,  'Shakespeare'),
(16,  'Spears'),
(17,  'Apollo'),
(18, 'October'),
(19,'Deepah'),
(20, 'Metra')

CREATE TABLE tblPublisher 
(Name nvarchar(50) NOT NULL,
[Address] nvarchar(50) NOT NULL,
Phone varchar(50) NOT NULL
)
INSERT INTO tblPublisher 
(Name, [Address], Phone)
VALUES( 'Mc Millan','Covina CA',23456546579),
( 'Ordeniza Associates', 'Duarte CA', 3245434789),
( 'Joys PUbli','North Hollywood CA ', 47634678768),
( 'Pruis Publisher','West Hollywood CA', 12576880987),
( 'KingsMen','Long Beach CA', 27367809979),
( 'Blackintach Company', 'West Covina CA', 62676789800),
( 'Britanica Publisher','Corona CA', 71456787655),
( 'National Geographic Publisher', 'New York NY', 762567876567),
('Vogue Magazine', 'New York NY', 21346786787),
( 'GQ Publisher', 'New York NY', 21378769878),
( 'Versae Publisher', 'Rome Italy', 021897789),
('Kilay Publisher','Walnut CA', 62635677688),
('Dairy Publisher ','Diamond Bar CA', 6165249899),
('ENya Publisher', 'Loch Lomond Scotland', 987767672)

CREATE TABLE tbkBook_Copies
(BookId int NOT NULL,
BranchId int NOT NULL,
No_Of_Copies int NOT NULL
)
INSERT INTO tblBooK_Copies
(BookId, BranchId, No_Of_Copies)
VALUES(1,1,2 ),
(2,1,2 ),
(3,1,3 ),
(4,1,4 ),
(5,1,5 ),
(6,1,6 ),
(7,1,7 ),
(8,1,8 ),
(9,1,9 ),
(10,1,10 ),
(11,1,11 ),
(12,2,12 ),
(13,2,13 ),
(14,2,14 ),
(15,2,15 ),
(16,2,16 ),
(17,2,17),
(18,2,18 ),
(19,2,19 ),
(20,2,20),
(8,2,8 ),
(9,2,9 ),
(10,3,10 ),
(11,3,11 ),
(12,3,12 ),
(13,3,13 ),
(14,3,14 ),
(15,3,15 ),
(16,3,16 ),
(17,3,17),
(18,3,18 ),
(19,3,19 ),
(20,3,20),
(1,4,2),
(2,4,2 ),
(3,4,3 ),
(4,4,4 ),
(5,4,5 ),
(6,4,6 ),
(7,4,7 ),
(8,4,8 ),
(9,4,9 ),
(10,4,10 ),
(11,4,11 )

CREATE TABLE tblLibrary_Branch
(BranchId int NOT NULL,
BranchName nvarchar(50) NOT NULL,
[Address] nvarchar(50) NOT NULL
)
INSERT INTO tblLibrary_Branch
(BranchId,BranchName, [Address])
VALUES(1,'Sharpstown','Los Angeles, CA'),
(2,'Central','New York, NY' ),
(3,'London','London, UK'),
(4 ,'Orange','Orange County, CA')



CREATE TABLE tblBorrower
(CardNo int NOT NULL,
Name nvarchar(50) NOT NULL,
[Address] nvarchar(50) NOT NULL,
Phone varchar(25) NOT NULL
)
INSERT INTO tblBorrower
(CardNo, Name, [Address], Phone )
VALUES(1,'Mac','Rowland Heights CA', 6263763766),
(2,'Des','Rowland Heights CA', 6263763166),
(3,'Justine','West Covina CA', 6263763736),
(4,'Camille','Rowland Heights CA', 6263743766),
(5,'JV','Rowland Heights CA', 6263763226),
(6,'Pearl','Duarte CA', 6263763732),
(6,'Albert','Alhambra CA', 6263233766),
(7,'Dave','Los Angeles CA', 6262365766)

CREATE TABLE Book_Loans
(BookId int NOT NULL,
BranchId int NOT NULL,
CardNo int NOT NULL,
DateOut int NOT NULL,
DueDate int NOT NULL
)
INSERT INTO Book_Loands
(BookId, BranchId, CardNo, DateOut, DueDate)
VALUES(1, 1, 1, 3012017, 4012017),
(2,	1,	2,	3012017, 4012017),
(3,	1,	3,	3012017, 4012017),
(4,	1,	4,	3012017, 4012017),
(5,	3,	5,	3012017, 4012017),
(6,	1,	6,	3012017, 4012017),
(7,	4,	7,	3012017, 4012017),
(8,	1,	8,	3012017, 4012017),
(9,	4,	9,	3012017, 4012017),
(1,	1,	1,	3012017, 4012017),
(2,	2,	2,	3012017, 4012017),
(3,	2,	3,	4012017, 5012017),
(4,	2,	4,	5012017, 5012017),
(5,	4,	5,	5012017, 7012017),
(6,	4,	6,	6012017, 7012017),
(7,	3,	7,	6012017, 7012017),
(8,	2,	8,	6012017, 7012017),
(9,	3,	9,	6012017, 7012017),
(10, 3,	1,	3012017, 4012017),
(11, 4,	2,	3012017, 4012017),
(12, 1,	3,	3012017, 4012017),
(13, 4,	4,	3012017, 4012017),
(14, 4,	5,	3012017, 4012017),
(15, 1,	6,	3012017, 4012017),
(16,	1,	7,	3012017, 4012017),
(17,	1,	8,	3012017, 4012017),
(18,	1,	9,	3012017, 4012017),
(19,	2,	1,	3012017, 4012017),
(20,	2,	1,	4012017, 5012017),
(1,	2,	1,	5012017, 5012017),
(3,	2,	3,	5012017, 7012017),
(5,	2,	1,	6012017, 7012017),
(2,	2,	6,	6012017, 7012017),
(8,	2,	1,	6012017, 7012017),
(19,	3,	7,	1012017, 7012017),
(1,	1,	2,	3012017, 4012017),
(13,	1,	1,	2012017, 4012017),
(14,	4,	8,	3012017, 4012017),
(15,	1,	3,	1012017, 4012017),
(16,	1,	6,	2012017, 4012017),
(17,	4,	6,	3012017, 4012017),
(18,	1,	1,	8012017, 9012017),
(19,	1,	6,	7012017, 10012017),
(1,	3,	3,	9012017, 11012017),
(2,	4,	5,	8012017, 9012017),
(3,	2,	8,	4012017, 5012017),
(4,	3,	4,	5012017, 7012017),
(5,	2,	7,	5012017, 9012017),
(6,	2,	2,	6012017, 11012017),
(7,	2,	4,	6012017, 7012017),
(8,	2,	3,	6012017, 7012017),
(9,	3,	5,	4012017, 7012017),
(10,	1,	7,	1012017, 11012017),
(11,	1,	7,	3012017, 12012017),
(12,	4,	4,	10012017, 4012017),
(13,	1,	3,	1012017, 4012017),
(14,	1,	3,	3012017, 4012017),
(15,	1,	2,	3012017, 4012017),
(16,	1,	1,	3012017, 4012017),
(17,	1,	1,	3012017, 4012017),
(18,	1,	6,	2012017, 4012017),
(19,	2,	7,	3012017, 4012017),
(20,	2,	1,	3012017, 5012017),
(1,	2,	8,	2012017, 3012017),
(3,	2,	1,	5012017, 7012017),
(5,	2,	2,	6012017, 7012017),
(2,	2,	5,	6012017, 7012017),
(8,	2,	1,	6012017, 7012017),
(19,	4,	8,	6012017, 7012017)

CREATE DATABASE db_library
USE db_library
GO



CREATE TABLE tbl_publisher	 (
	 publisher_name VARCHAR(50) PRIMARY KEY NOT NULL, 
	 publisher_address VARCHAR(50) NOT NULL,
	 publisher_phone VARCHAR(50) NOT NULL
);


CREATE TABLE tbl_book (
	 book_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	 book_title VARCHAR(50) NOT NULL,
	 book_publishername VARCHAR(50) NOT NULL CONSTRAINT fk_book_publishername FOREIGN KEY REFERENCES tbl_publisher(publisher_name) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE tbl_authors (
	 authors_id INT NOT NULL CONSTRAINT fk_book_bookid FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 authors_authorname VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_borrower (
	 borrower_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	 borrower_name VARCHAR(50) NOT NULL,
	 borrower_address VARCHAR(50) NOT NULL,
	 borrower_phone VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_branch (
	 branch_id INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	 branch_name VARCHAR(50) NOT NULL,
	 branch_address VARCHAR(50) NOT NULL
);

CREATE TABLE tbl_copies (
	 copies_bookid INT NOT NULL CONSTRAINT fk_copies_bookid FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 copies_branchid INT NOT NULL CONSTRAINT fk_branch_id FOREIGN KEY REFERENCES tbl_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 copies_copynumber INT NOT NULL
);

CREATE TABLE tbl_loans (
	 loans_id INT NOT NULL CONSTRAINT fk_loans_bookid FOREIGN KEY REFERENCES tbl_book(book_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 loans_branchid INT NOT NULL CONSTRAINT fk_loans_branchid FOREIGN KEY REFERENCES tbl_branch(branch_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 loans_cardno INT NOT NULL CONSTRAINT fk_borrower_id FOREIGN KEY REFERENCES tbl_borrower(borrower_id) ON UPDATE CASCADE ON DELETE CASCADE,
	 loans_dateout VARCHAR(50) NOT NULL,
	 loans_duedate VARCHAR(50) NOT NULL
);

INSERT INTO tbl_publisher VALUES ('Random House', '123 Main St', '123-456-7890')

INSERT INTO tbl_book VALUES ('Jurrassic Park', 'Random House')

SELECT * FROM tbl_book

INSERT INTO tbl_branch VALUES ('Downtown', '123 Peach St.'), ('Riverside', '345 Side St')

SELECT * FROM tbl_branch

INSERT INTO tbl_authors VALUES (2, 'Stephen King'), (8, 'Roald Dahl'), (10, 'William Shakespeare'), (12, 'Agatha Christie'), (13, 'Tony Hillerman'), (14, 'JRR Tolkien'), (15, 'Brandon Sanderson'), (17, 'CS Lewis'), (21, 'JK Rowling'), (22,'Philip K Dick')

INSERT INTO tbl_book VALUES ('It',  'Random House'), ('The Dark Tower', 'Random House'), ('Carrie',  'Random House'), ('The Shining', 'Random House'), ('James and the Giant Peach', 'Random House'), ('Charlie and the Chocolate Factory', 'Random House'), ('The Tempest', 'Random House'), ('Macbeth', 'Random House'), ('Murder on the Orient Express', 'Random House'), ('Patrol', 'Random House'), ('The Return of the King', 'Random House'), ('The Way of Kings', 'Random House'), ('Words of Radiance', 'Random House'), ('The Silver Chair', 'Random House'), ('The Magicians Nephew', 'Random House'), ('Voyage of the Dawn Treader', 'Random House'), ('The Last Battle', 'Random House'), ('Harry Potter and the Deathly Hallows', 'Random House'), ('A Scanner Darkly', 'Random House'), ('Do Androids Dream of Electric Sheep?', 'Random House')

SELECT * FROM tbl_authors

INSERT INTO tbl_copies VALUES (11, 1, 2), (2, 3, 2), (3, 4, 2), (4, 1, 2), (5, 2, 2), (6, 1, 2), (7, 3, 2), (8, 4, 2), (9, 2, 2), (10, 1, 2)

SELECT * FROM tbl_copies

INSERT INTO tbl_borrower VALUES ('John Smith', '123 Blackbird St', '234-567-8901'), ('Mary Tyler', '234 BirdBlack St', '345-678-9012'), ('Tonald Drump', '345 Bluebird St', '456-789-0123'), ('Pablo Escobar', '567 Troubador St', '678-901-2345'), ('Susan White', '789 Google St', '789-012-3456'), ('Greg Black', '890 Frog St', '890-123-4567'), ('Tom Brown', '901 Fly St', '901-234-5678'), ('Jerry Green', '012 5th Ave', '012-345-5678')

SELECT * FROM tbl_borrower

INSERT INTO tbl_loans VALUES (2, 2, 4, '11/25/17', '12/22/17'), (3, 2, 4, '11/25/17', '12/22/17'), (4, 2, 4, '11/25/17', '12/22/17'), (5, 2, 4, '11/25/17', '12/22/17'), (6, 2, 4, '11/25/17', '12/22/17'), (7, 1, 7, '11/25/17', '12/22/17'), (8, 1, 7, '11/25/17', '12/22/17'),(9, 1, 7, '11/25/17', '12/22/17'),(10, 1, 7, '11/25/17', '12/22/17'),(11, 1, 7, '11/25/17', '12/22/17'),(12, 3, 1, '11/25/17', '12/22/17'),(13, 2, 2, '11/25/17', '12/22/17'),(14, 3, 3, '11/25/17', '12/22/17'),(15, 4, 5, '11/25/17', '12/22/17'),(16, 1, 6, '11/25/17', '12/22/17'),(17, 3, 8, '11/25/17', '12/22/17'),(18, 1, 7, '11/25/17', '12/22/17'),(19, 1, 7, '11/25/17', '12/22/17'),(20, 1, 7, '11/25/17', '12/22/17'),(21, 1, 7, '11/25/17', '12/22/17'),(22, 1, 7, '11/25/17', '12/22/17'),(23, 1, 7, '11/25/17', '12/22/17')

SELECT * FROM tbl_loans

--Question #1 finding number of copies lost tribe at sharpstown branch
CREATE PROC copies_losttribe
AS
SELECT C.copies_copynumber
FROM tbl_book AS B
JOIN tbl_copies AS C ON B.book_id = C.copies_bookid
JOIN tbl_branch AS BR ON C.copies_branchid = BR.branch_id
WHERE B.book_id = 2 AND BR.branch_id = 1
GO
--Question #2 How many copies lost tribe at each branch
CREATE PROC losttribe_branch
AS
SELECT BR.branch_name, B.book_title, C.copies_copynumber
FROM tbl_book AS B
LEFT OUTER JOIN tbl_copies AS C ON B.book_id = C.copies_bookid
LEFT OUTER JOIN tbl_branch AS BR ON C.copies_branchid = BR.branch_id
WHERE B.book_title = 'the lost tribe'
GO
--Question #3 Names of all borrowers who do not have books checked out
CREATE PROC names_checkedout
AS
SELECT BO.borrower_name
FROM tbl_borrower AS BO
JOIN tbl_loans AS L ON L.loans_cardno = BO.borrower_id
WHERE loans_id IS NULL
GO
--Question #4 For each book that is loaned out from the "Sharpstown" branch and whose
--DueDate is today, retrieve the book title, the borrower's name, and the borrower's address.
CREATE PROC sharpstown_borrower
AS
SELECT BO.borrower_name, BO.borrower_address, B.book_title
FROM tbl_book AS B
JOIN tbl_loans AS L ON L.loans_id = B.book_id
JOIN tbl_branch AS BR ON L.loans_branchid = BR.branch_id
JOIN tbl_borrower AS BO ON BO.borrower_id = L.loans_cardno
WHERE BR.branch_name = 'Sharpstown' AND L.loans_duedate = '11/25/17'
GO
--Question #5 For each library branch, retrieve the branch name 
--and the total number of books loaned out from that branch.
CREATE PROC branch_booknumber
AS
SELECT BR.branch_name, COUNT (C.copies_copynumber)
FROM tbl_branch AS BR
JOIN tbl_copies AS C ON BR.branch_id = C.copies_branchid
GROUP BY BR.branch_name
GO
--Question #6 Retrieve the names, addresses, and number of books checked 
--out for all borrowers who have more than five books checked out.
CREATE PROC retrieve_five
AS
SELECT BO.borrower_name, BO.borrower_address, COUNT (L.loans_id)
FROM tbl_borrower AS BO
JOIN tbl_loans AS L ON L.loans_cardno = BO.borrower_id
GROUP BY BO.borrower_name, BO.borrower_address
HAVING COUNT (L.loans_id) > 5
GO
--Question #7  For each book authored (or co-authored) by "Stephen King", 
--retrieve the title and the number of copies owned by the library branch whose name is "Central".
CREATE PROC king_central
AS
SELECT B.book_title, C.copies_copynumber
FROM tbl_book AS B
JOIN tbl_copies AS C ON C.copies_bookid = B.book_id
JOIN tbl_authors AS A ON A.authors_id = B.book_id
JOIN tbl_branch AS BR ON BR.branch_id = C.copies_branchid
WHERE authors_authorname = 'Stephen King' AND BR.branch_name = 'Central'
GO


/*==============================CREATING TABLES=========================*/
CREATE TABLE LIBRARY_BRANCH (
	BranchID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	BranchName VARCHAR(50),
	BranchAddress VARCHAR(100)
	);

CREATE TABLE PUBLISHER (
	PublisherName VARCHAR(50) NOT NULL PRIMARY KEY,
	PublisherAddress VARCHAR(100),
	PublisherPhone VARCHAR(25)
);

CREATE TABLE BOOKS (
	BookID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	BookTitle VARCHAR(50),
	PublisherName VARCHAR(50) NOT NULL CONSTRAINT fk_PublisherName FOREIGN KEY REFERENCES PUBLISHER(PublisherName) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE BOOK_AUTHORS (
	BookID INT NOT NULL CONSTRAINT fk_BookID_Book_Author FOREIGN KEY REFERENCES BOOKS(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	AuthorName VARCHAR(50) NOT NULL
);

CREATE TABLE BOOK_COPIES (
	BookID INT NOT NULL CONSTRAINT fk_BookID_Book_Copies FOREIGN KEY REFERENCES BOOKS(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_BrachID_Book_Copies FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	Number_Of_Copies INT NOT NULL
);
CREATE TABLE BORROWER (
	CardNo INT NOT NULL PRIMARY KEY IDENTITY (1000000,1),
	BorrowerName VARCHAR(50) NOT NULL,
	BorrowerAddress VARCHAR(100) NOT NULL,
	BorrowerPhone VARCHAR (25) NOT NULL
);

CREATE TABLE BOOK_LOANS (
	BookID INT NOT NULL CONSTRAINT fk_BookID_Book_Loans FOREIGN KEY REFERENCES BOOKS(BookID) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchID INT NOT NULL CONSTRAINT fk_BrachID_Book_Loans FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchID) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT fk_CardNo FOREIGN KEY REFERENCES BORROWER(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut DATE NOT NULL,
	DateDUE DATE NOT NULL
);



/*==============================================*/

/*===============POPULATING LIBRARY DB===============*/


INSERT INTO LIBRARY_BRANCH 
	(BranchName,BranchAddress)
	VALUES
	('Sharpstown','711-2880 Nulla Street Seattle WA 11526'),
	('Central','3727 Ullamcorper Street Seattle WA 11523'),
	('Queen Anne','859 Sit Road Seattle WA 11564'),
	('BellTown','8679 Sodales Av Avenue Seattle WA 11566'),
	('First Hill','3279 Viverra Avenue Seattle WA 11572'),
	('Ballard','7292 Dictum Avenue Seattle WA 11598')
;
INSERT INTO PUBLISHER
	(PublisherName, PublisherAddress, PublisherPhone)
	VALUES
	('Penguin', '347-7666 Iaculis St. Woodruff SC 49854','(468) 353-2641'),
	('Eksmo', '4366 Lacinia Avenue Idaho Falls Ohio 19253', '(248) 675-4007'),
	('Inkvoice', '2546 Sociosqu Road Bethlehem Utah 02913', '(939) 353-1107'),
	('Telegraph', '193 Ullamcorper Avenue Amesbury HI 93373', '(302) 259-2375')
	;

INSERT INTO BOOKS
	(BookTitle,PublisherName)
	VALUES
	('The Lost Tribe', 'Penguin'),
	('2132: Polaris', 'Inkvoice'),
	('Children Of Venus', 'Telegraph'),
	('Too Much Broccoli', 'Eksmo'),
	('Teddy Loves It',  'Penguin'),
	('The Mother-Knot', 'Penguin'),
	('Burger-Of-The-Day', 'Eksmo'),
	('Red', 'Inkvoice'),
	('Not Today', 'Inkvoice'),
	('Shining', 'Telegraph'),
	('Christine', 'Telegraph'),
	('Lion King', 'Eksmo'),
	('Zarathustra', 'Penguin'),
	('Of Human Bondage', 'Eksmo'),
	('Leviathan', 'Eksmo'),
	('Fahrenheit 451', 'Penguin'),
	('Crime and Punishment', 'Eksmo'),
	('Old Man And The Sea', 'Penguin'),
	('Nausea', 'Inkvoice'),
	('Metamorphosis', 'Telegraph')
	;

INSERT INTO BOOK_AUTHORS
	(BookID, AuthorName)
	VALUES
	(1, 'Mark Lee'),
	(2, 'Andrew Dwyer'),
	(3, 'Pam Beasley'),
	(4, 'Bob Belcher'),
	(5, 'Ted Baker'),
	(6, 'Michael Scott'),
	(7, 'James Halpert'),
	(8, 'Rachel Green'),
	(9, 'Chandler Bing'),
	(10, 'Stephen King'),
	(11, 'Stephen King'),
	(12, 'William Shakespeare'),
	(13, 'Friedrich Nitzsche'),
	(14, 'Somerset Maugham'),
	(15, 'Thomas Hobbs'),
	(16, 'Ray Bradburry'),
	(17, 'Fyodor Dostoevsky'),
	(18, 'Ernst Hamingway'),
	(19, 'Jean-Paul Sartre'),
	(20, 'Friedrich Nitzsche')
	;
	
INSERT INTO  BOOK_COPIES 
(BranchID, BookID, Number_Of_Copies)
VALUES
(1, 1, 5),
(1, 3, 4),
(1, 5, 3),
(1, 7, 5),
(1, 9, 5),
(1, 11, 5),
(1, 13, 5),
(1, 15, 5),
(1, 17, 5),
(1, 19, 5),

(2, 2, 2),
(2, 4, 3),
(2, 6, 3),
(2, 8, 3),
(2, 10, 3),
(2, 12, 3),
(2, 14, 3),
(2, 16, 3),
(2, 18, 3),
(2, 20, 3),
	
(3, 1, 2),
(3, 2, 3),
(3, 3, 3),
(3, 4, 3),
(3, 5, 3),
(3, 6, 3),
(3, 7, 3),
(3, 8, 3),
(3, 9, 3),
(3, 10, 3),

(4, 11, 2),
(4, 12, 3),
(4, 13, 3),
(4, 14, 3),
(4, 15, 3),
(4, 16, 3),
(4, 17, 3),
(4, 18, 3),
(4, 19, 3),
(4, 20, 3)
;

INSERT INTO BORROWER
(BorrowerName, BorrowerAddress, BorrowerPhone)
VALUES
('David Mathews','1011 Malesuada Road, Moscow Kentucky 77382', '(357) 616-5411'),
('Xyla Cash', '969-1762 Tincidunt Road, Boise CT 35282', '(121) 347-0086'),
('Griffith Daniels', '6818 Eget Street, Tacoma AL 92508', '(425) 288-2332'),
('Anne Beasley', '987-4223 Urna Street, Savannah Illinois 85794', '(145) 987-4962'),
('Daniel Bernard', 'P.O. Box 567 1561 Duis Road, Pomona TN 08609', '(750) 558-3965'),
('Seth Farley', '6216 Aenean Avenue, Seattle Utah 81202', '(888) 106-8550'),
('Lee Preston', '981 Eget Road, Clemson GA 04645', '(221) 156-5026'),
('Merritt Watson', 'P.O. Box 686 7014 Amet Street, Corona Oklahoma 55246', '(622) 594-1662'),
('Katelyn Cooper','6059 Sollicitudin Road Burlingame Colorado 26278', '(414) 876-0865'),
('Lacy Eaton', '1379 Nulla. Avenue Asbury Park Montana 69679', '(932) 726-8645'),
('McKenzie Hernandez','Ap #367-674 Mi Street Greensboro VT 40684', '(168) 222-1592'),
('Haviva Holcomb', 'P.O. Box 642 3450 In Road Isle of Palms New York 03828', '(896) 303-1164')
;

INSERT INTO BOOK_LOANS
(BookID, BranchID, CardNo, DateOut, DateDUE)
VALUES
(1, 1, 1000000, '20180206', '20180306'),
(3, 1, 1000000, '20180306', '20180406'),
(5, 1, 1000000, '20180406', '20180506'),
(7, 1, 1000000, '20180606', '20180706'),
(9, 1, 1000000, '20180706', '20180806'),
(2, 2, 1000001, '20180206', '20180306'),
(4, 2, 1000001, '20180306', '20180406'),
(6, 2, 1000001, '20180406', '20180506'),
(8, 2, 1000001, '20180606', '20180706'),
(10, 2, 1000001, '20180706', '20180806'),
(1, 3, 1000002, '20180206', '20180306'),
(2, 3, 1000002, '20180206', '20180306'),
(3, 3, 1000002, '20180306', '20180406'),
(4, 3, 1000002, '20180406', '20180506'),
(5, 3, 1000002, '20180606', '20180706'),
(11, 4, 1000003, '20180206', '20180306'),
(12, 4, 1000003, '20180206', '20180306'),
(13, 4, 1000003, '20180406', '20180506'),
(14, 4, 1000003, '20180206', '20180306'),
(15, 4, 1000003, '20180406', '20180506'),
(11, 1, 1000004, '20180206', '20180306'),
(13, 1, 1000004, '20180406', '20180506'),
(15, 1, 1000004, '20180206', '20180306'),
(17, 1, 1000004, '20180206', '20180306'),
(19, 1, 1000004, '20180206', '20180306'),
(12, 2, 1000005, '20180206', '20180306'),
(14, 2, 1000005,'20180206', '20180306'),
(16, 2, 1000005, '20180206', '20180306'),
(18, 2, 1000005, '20180206', '20180306'),
(20, 2, 1000005, '20180406', '20180506'),
(6, 3, 1000006, '20180206', '20180306'),
(7, 3, 1000006, '20180606', '20180706'),
(8, 3, 1000006, '20180206', '20180306'),
(9, 3, 1000006, '20180706', '20180806'),
(10, 3, 1000006, '20180606', '20180706'),
(16, 4, 1000007, '20180206', '20180306'),
(17, 4, 1000007, '20180406', '20180506'),
(18, 4, 1000007, '20180306', '20180406'),
(19, 4, 1000007, '20180406', '20180506'),
(20, 4, 1000007, '20180306', '20180406'),
(9, 1, 1000008, '20180206', '20180306'),
(11, 1, 1000008, '20180206', '20180306'),
(13, 1, 1000008, '20180406', '20180506'),
(15, 1, 1000008, '20180706', '20180806'),
(17, 1, 1000008, '20180606', '20180706'),
(4, 2, 1000009, '20180206', '20180306'),
(6, 2, 1000009, '20180406', '20180506'),
(8, 2, 1000009, '20180606', '20180706'),
(10, 2, 1000009, '20180706', '20180806'),
(12, 2, 1000009, '20180206', '20180306'),
(11, 1, 1000000, '20180206', '20180306'),
(14, 2, 1000009, '20180206', '20180306')
;

/*===================LIBRARY QUERIES===================*/

/*1.) How many copies of the book titled "The Lost Tribe" are owned by the library branch whose name is "Sharpstown"?*/

GO
CREATE PROC Copies_Of_Lost_Tribe_Sharpstown
AS
BEGIN
	SELECT Number_OF_Copies AS 'Number of Copies', BookTitle, BranchName AS 'Branch Name'
		FROM BOOK_COPIES
		INNER JOIN BOOKS ON BOOK_COPIES.BookID = BOOKS.BookID
		INNER JOIN LIBRARY_BRANCH ON BOOK_COPIES.BranchID = LIBRARY_BRANCH.BranchID
		WHERE BookTitle LIKE '%The Lost Tribe%' AND BranchName LIKE '%Sharpstown%'
		;
END
GO
	/*2.) How many copies of the book titled "The Lost Tribe" are owned by each library branch?*/
CREATE PROC Copies_Of_Lost_Tribe_Each_Branch
AS
BEGIN
	SELECT Number_Of_Copies, BranchName
		FROM BOOK_COPIES
		INNER JOIN BOOKS ON BOOK_COPIES.BookID = BOOKS.BookID
		INNER JOIN LIBRARY_BRANCH ON BOOK_COPIES.BranchID = LIBRARY_BRANCH.BranchID
		WHERE BookTitle LIKE '%The Lost Tribe%'
		; 
END
GO
	/*3.) Retrieve the names of all borrowers who do not have any books checked out.*/
CREATE PROC Borrowers_No_Books
AS
BEGIN
	SELECT BorrowerName
	FROM BORROWER
	FULL OUTER JOIN BOOK_LOANS ON BORROWER.CardNo = BOOK_LOANS.CardNo
	WHERE BookID IS NULL /*or any field from BOOK_LOANS Table*/
END
GO
	/*4.) For each book that is loaned out from the "Sharpstown" branch and whose DueDate is today, 
	retrieve the book title, the borrower's name, and the borrower's address.*/

	/*I chose a different date since the population instructions didn't specify any particular date*/
CREATE PROC Due_Date_20180506
AS
BEGIN
	SELECT BorrowerName, BorrowerAddress, BookTitle
	FROM BORROWER
	INNER JOIN BOOK_LOANS ON BORROWER.CardNo = BOOK_LOANS.CardNo
	INNER JOIN BOOKS ON BOOK_LOANS.BookID = BOOKS.BookID
	WHERE DateDUE = '20180506'
END
GO

	/*5.) For each library branch, retrieve the branch name and the total number of books loaned out from that branch.*/
CREATE PROC Books_Loaned_Per_Branch
AS
BEGIN	
	SELECT BranchName, COUNT(*) AS '# Of Copies'
	FROM LIBRARY_BRANCH 
	INNER JOIN BOOK_LOANS ON LIBRARY_BRANCH.BranchID = BOOK_LOANS.BranchID
	GROUP BY BranchName
END
GO
	/*6.) Retrieve the names, addresses, and the number of books checked out for 
	all borrowers who have more than five books checked out.*/
CREATE PROC Borrowers_5books
AS
BEGIN
	SELECT BorrowerName, BorrowerAddress, Count(*) AS '# Of Copies'
	FROM BORROWER
	INNER JOIN BOOK_LOANS ON BORROWER.CardNo = BOOK_LOANS.CardNo
	GROUP BY BorrowerName, BorrowerAddress
	HAVING Count(*) > 5
END
GO
	/* 7.) For each book authored (or co-authored) by "Stephen King", retrieve the title and the number 
	of copies owned by the library branch whose name is "Central".*/
CREATE PROC Stephen_King_Books
AS
BEGIN
	SELECT BookTitle, Number_Of_Copies
	FROM BOOK_COPIES
	INNER JOIN BOOKS ON BOOK_COPIES.BookID = Books.BookID
	INNER JOIN BOOK_AUTHORS ON BOOK_COPIES.BookID = BOOK_AUTHORS.BookID
	INNER JOIN LIBRARY_BRANCH ON LIBRARY_BRANCH.BranchID = BOOK_COPIES.BranchID
	WHERE AuthorName LIKE '%Stephen King%' AND BranchName = 'Central'
END
GO

/*SELECT * FROM BOOK_LOANS;
SELECT * FROM BORROWER;
SELECT * FROM BOOK_COPIES;
SELECT * FROM BOOK_AUTHORS;
SELECT * FROM Books;
SELECT * FROM publisher;
SELECT * FROM LIBRary_branch;
*/

EXEC [dbo].[Books_Loaned_Per_Branch];
EXEC [dbo].[Borrowers_5books];
EXEC [dbo].[Borrowers_No_Books];
EXEC [dbo].[Copies_Of_Lost_Tribe_Each_Branch];
EXEC [dbo].[Copies_Of_Lost_Tribe_Sharpstown];
EXEC [dbo].[Due_Date_20180506];
EXEC [dbo].[Stephen_King_Books]; 



