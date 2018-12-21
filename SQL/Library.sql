CREATE DATABASE dbFinalSQL14
GO
USE dbFinalSQL14
GO
DROP database dbFinalSQL13

CREATE TABLE BORROWER(
	CardNo INT PRIMARY KEY IDENTITY (1000,1) NOT NULL,
	Name VARCHAR (150) NULL,
	[Address] VARCHAR (150) NULL,
	Phone VARCHAR (40) NULL,
);

INSERT INTO BORROWER(Name, [Address], Phone)
	VALUES
	('Jon Dope', '169 SW Main St. Portland, OR', '453-807-2668'),
	('Jon Doe', '12 SW Main St. Portland, OR', '757-847-2121'),
	('Steffan del Prado', '34 SE Pine St. Pheonix, AZ', '509-777-5555'),
	('Christian Espinoza', '56 NW apple ave Salt Lake City, UT', '303-994-2287'),
	('Stephen Legg', '78 NE Taco St. New York City, NY', '202-654-7076'),
	('Tom Cruz', '90 Maple Ave Virginia Beach, VA', '707-888-3538'),
	('Jacob Moullet', '987 Pear St. Williamsburg, VA', '757-772-8762'),
	('Laura Schneider', '654 N Plumb Ave Lexington, VA', '202-456-8839'),
	('Jessica Daly', '321 S Pizza St. Portland, OR', '503-333-3535'),
;

SELECT * FROM BORROWER;

CREATE TABLE LIBRARY_BRANCH(
	BranchID INT PRIMARY KEY IDENTITY (200,1) NOT NULL,
	BranchName VARCHAR (150) NULL,
	[Address] VARCHAR (150) NULL,
);

INSERT INTO LIBRARY_BRANCH(BranchName, [Address])
	VALUES 
	('Sharpstown', '106 Piankatank Turn, Yorktown, VA 23666'),
	('Central', '7717 Nesbit Dr, Norfolk, VA 23693'),
	('Midtown', '3032 Stark St. Portland, OR 97201'),
	('Williamsburg', '509 Hasley Ave. Poquoson, VA 23661')
;

SELECT * FROM LIBRARY_BRANCH;

CREATE TABLE PUBLISHER(
	Publisher_Name VARCHAR(150) NOT NULL,
	[Address] VARCHAR (150) NULL,
	Phone VARCHAR (150) NULL,
);

INSERT INTO PUBLISHER(Publisher_Name, [Address], Phone)
	VALUES
	('Viking Press', '1745 Broadway, New York, NY 10019', '212-782-9000'),
	('Move Books', '814 N Franklin St #100, Chicago, IL 60610', '312-337-0747'),
	('Ashounding Stories', '', ''),
	('Doubleday', '1745 Broadway, New York, NY 10019', ''),
	('Harper & Row', '49 East 33rd Street, New York, N.Y. 10016', ''),
	('Warner Books, Inc', '75 Rockefeller Plaza: New York, NY, 10019', '212-522-7200'),
	('New York Evening Mirror', '', ''),
	('Lackington, Hughes, Harding, Mavor & Jones', '', ''),
	('Archibald Constable and Company', '', ''),
	('Little Brown', '53 State St, Boston, MA 02109', '617-227-0730'),
	('C. A. Reitzel', 'København, Dept. of Nordic Studies Njalsgade 128, build. 2 Copenhagen S DK-2300 Denmark', ''),
	('Macmillan', 'London, England', '')
;

SELECT * FROM PUBLISHER;

CREATE TABLE BOOK(
	BookID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Title VARCHAR (150) NULL,
	Publisher_Name VARCHAR(150) NOT NULL,
);

INSERT INTO BOOK(Title, Publisher_Name)
	VALUES
	('The Lost Tribe', 'Move Books'),
	('It', 'Viking Press'),
	('Who Goes There?', 'Astounding Stories'),
	('The Shining', 'Doubleday'),
	('Pet Sematary', 'Doubleday'),
	('The Giving Tree', 'Harper & Row'),
	('Carrie', 'Doubleday'),
	('The Da Vinci Code', 'Doubleday'),
	('The Lost Symbol', 'Doubleday'),
	('Where the Red Fern Grows', 'Doubleday'),
	('The Iliad', ''),
	('The Odyssey', ''),
	('To Kill A Mockingbird', 'Warner Books, Inc'),
	('The Raven', 'New York Evening Mirror'),
	('Frankenstein', 'Lackington, Hughes, Harding, Mavor & Jones'),
	('Dracula', 'Archibald Constable and Company'),
	('The Tipping Point', 'Little Brown'),
	('The Little Mermaid', 'C. A. Reitzel'),
	('Alice''s Adventures in Wonderland', 'Macmillan'),
	('Jabberwocky', 'Macmillan')
;

SELECT * FROM BOOK;

CREATE TABLE BOOK_AUTHORS(
	BookID INT FOREIGN KEY REFERENCES BOOK(BookID) NOT NULL,
	AuthorName CHAR (30) NULL,
);

INSERT INTO BOOK_AUTHORS(BookID, AuthorName)
	VALUES
	(1, 'Mark Lee'),
	(2, 'Stephen King'),
	(3, 'John W. Campbell, Jr'),
	(4, 'Stephen King'),
	(5, 'Stephen King'),
	(6, 'Shel Silverstein'),
	(7, 'Stephen King'),
	(8, 'Dan Brown'),
	(9, 'Dan Brown'),
	(10, 'Wilson Rawls'),
	(11, 'Homer'),
	(12, 'Homer'),
	(13, 'Harper Lee'),
	(14, 'Edgar Allan Poe'),
	(15, 'Mary Shelley'),
	(16, 'Bram Stoker'),
	(17, 'Malcolm Gladwell'),
	(18, 'Hans Christian Andersen'),
	(19, 'Lewis Carroll'),
	(20, 'Lewis Carroll')
;

SELECT * FROM BOOK_AUTHORS;

CREATE TABLE BOOK_COPIES(
	BookID INT FOREIGN KEY REFERENCES BOOK(BookId) NOT NULL,
	BranchId INT FOREIGN KEY REFERENCES Library_Branch(BranchId) NULL,
	No_Of_Copies INT NULL,
);

INSERT INTO BOOK_COPIES(BookID, BranchId, No_Of_Copies)
	VALUES 
	(1, 200, 3),
	(2, 200, 2),
	(3, 200, 3),
	(4, 200, 1),
	(5, 200, 2),
	(6, 200, 3),
	(7, 200, 2),
	(8, 200, 2),
	(9, 200, 2),
	(10, 200, 1),
	(11, 200, 1),
	(12, 200, 2),
	(13, 200, 3),
	(14, 200, 3),
	(15, 200, 3),
	(16, 200, 4),
	(17, 200, 3),
	(18, 200, 2),
	(19, 200, 4),
	(20, 200, 1),

	(1, 201, 2),
	(2, 201, 3),
	(3, 201, 2),
	(4, 201, 1),
	(5, 201, 3),
	(6, 201, 2),
	(7, 201, 3),
	(8, 201, 4),
	(9, 201, 5),
	(10, 201, 2),
	(11, 201, 4),
	(12, 201, 2),
	(13, 201, 5),
	(14, 201, 3),
	(15, 201, 2),
	(16, 201, 2),
	(17, 201, 1),
	(18, 201, 1),
	(19, 201, 2),
	(20, 201, 2),

	(1, 202, 2),
	(2, 202, 2),
	(3, 202, 2),
	(4, 202, 2),
	(5, 202, 2),
	(6, 202, 2),
	(7, 202, 3),
	(8, 202, 2),
	(9, 202, 1),
	(10, 202, 2),
	(11, 202, 4),
	(12, 202, 2),
	(13, 202, 2),
	(14, 202, 1),
	(15, 202, 1),
	(16, 202, 3),
	(17, 202, 1),
	(18, 202, 1),
	(19, 202, 1),
	(20, 202, 1),

	(1, 203, 2),
	(2, 203, 2),
	(3, 203, 2),
	(4, 203, 3),
	(5, 203, 1),
	(6, 203, 1),
	(7, 203, 2),
	(8, 203, 1),
	(9, 203, 1),
	(10, 203, 2),
	(11, 203, 2),
	(12, 203, 3),
	(13, 203, 3),
	(14, 203, 3),
	(15, 203, 3),
	(16, 203, 2),
	(17, 203, 2),
	(18, 203, 2),
	(19, 203, 2),
	(20, 203, 2)
;

SELECT * FROM BOOK_AUTHORS;

CREATE TABLE BOOK_LOANS(
	BookID INT FOREIGN KEY REFERENCES BOOK(BookId) NOT NULL,
	BranchId INT FOREIGN KEY REFERENCES Library_Branch(BranchId) NOT NULL,
	CardNo INT FOREIGN KEY REFERENCES Borrower(CardNo) NOT NULL,
	DateOut DATE NOT NULL,
	DueDate DATE NOT NULL,
);

INSERT INTO BOOK_LOANS(BookID, BranchId, CardNo, DateOut, DueDate)
	VALUES
	(1, 200, 1007, '2018-04-21', '2018-04-28'),
	(3, 200, 1000, '2018-04-21', '2018-04-28'),
	(5, 200, 1000, '2018-04-21', '2018-04-28'),
	(7, 200, 1006, '2018-04-21', '2018-04-28'),
	(9, 202, 1000, '2018-04-21', '2018-04-28'),
	(11, 200, 1003, '2018-04-21', '2018-04-28'),
	(13, 200, 1000, '2018-04-21', '2018-04-28'),
	(17, 200, 1002, '2018-04-21', '2018-04-28'),
	(15, 201, 1003, '2018-04-21', '2018-04-28'),
	(19, 201, 1002, '2018-04-21', '2018-04-28'),
	(2, 201, 1000, '2018-04-20', '2018-04-27'),
	(4, 201, 1007, '2018-04-20', '2018-04-27'),
	(6, 202, 1005, '2018-04-20', '2018-04-27'),
	(8, 201, 1006, '2018-04-20', '2018-04-27'),
	(10, 201, 1003, '2018-04-20', '2018-04-27'),
	(12, 201, 1005, '2018-04-20', '2018-04-27'),
	(14, 201, 1006, '2018-04-20', '2018-04-27'),
	(16, 202, 1001, '2018-04-20', '2018-04-27'),
	(18, 202, 1000, '2018-04-20', '2018-04-27'),
	(20, 202, 1001, '2018-04-20', '2018-04-27'),
	(1, 202, 1000, '2018-04-19', '2018-04-26'),
	(3, 202, 1004, '2018-04-19', '2018-04-26'),
	(5, 202, 1004, '2018-04-19', '2018-04-26'),
	(7, 202, 1006, '2018-04-19', '2018-04-26'),
	(9, 202, 1003, '2018-04-19', '2018-04-26'),
	(11, 202, 1006, '2018-04-19', '2018-04-26'),
	(13, 202, 1005, '2018-04-19', '2018-04-26'),
	(15, 202, 1001, '2018-04-19', '2018-04-26'),
	(17, 202, 1001, '2018-04-19', '2018-04-26'),
	(19, 202, 1002, '2018-04-19', '2018-04-26'),
	(2, 202, 1002, '2018-04-18', '2018-04-25'),
	(4, 202, 1005, '2018-04-18', '2018-04-25'),
	(6, 202, 1002, '2018-04-18', '2018-04-25'),
	(8, 202, 1003, '2018-04-18', '2018-04-25'),
	(10, 202, 1001, '2018-04-18', '2018-04-25'),
	(12, 202, 1001, '2018-04-18', '2018-04-25'),
	(14, 203, 1000, '2018-04-18', '2018-04-25'),
	(16, 203, 1002, '2018-04-18', '2018-04-25'),
	(18, 203, 1007, '2018-04-18', '2018-04-25'),
	(20, 203, 1006, '2018-04-18', '2018-04-25'),
	(1, 203, 1004, '2018-04-17', '2018-04-24'),
	(3, 203, 1002, '2018-04-17', '2018-04-24'),
	(5, 203, 1001, '2018-04-17', '2018-04-24'),
	(7, 203, 1001, '2018-04-17', '2018-04-24'),
	(9, 203, 1000, '2018-04-17', '2018-04-24'),
	(11, 203, 1004, '2018-04-17', '2018-04-24'),
	(13, 203, 1002, '2018-04-17', '2018-04-24'),
	(15, 203, 1002, '2018-04-17', '2018-04-24'),
	(17, 203, 1001, '2018-04-17', '2018-04-24'),
	(19, 203, 1004, '2018-04-17', '2018-04-24')
;

SELECT * FROM BOOK_LOANS;

/*-------------------------------------------------------------------------------------------------
	1. how many copies of the book titled "the lost tribe" are owned by the library branch whose 
		name is "sharpstown"?
-------------------------------------------------------------------------------------------------*/

SELECT 
	bk.Title
	,cps.No_Of_Copies
	,lb.*
	FROM BOOK bk 
	LEFT JOIN BOOK_COPIES cps
	ON cps.BookID = bk.BookID
	LEFT JOIN LIBRARY_BRANCH lb
	ON cps.BranchId = lb.BranchID
	WHERE 
	bk.Title = 'The Lost Tribe'
	AND lb.BranchName = 'Sharpstown'
	;

/*-------------------------------------------------------------------------------------------------
	2. how many copies of the book titled "the lost tribe" are owned by each library branch?
-------------------------------------------------------------------------------------------------*/

SELECT bk.Title, bc.No_Of_Copies, lb.BranchName 
	FROM BOOK bk
	LEFT JOIN BOOK_COPIES bc
	ON bc.BookID = bk.BookID
	LEFT JOIN LIBRARY_BRANCH lb
	ON lb.BranchID = bc.BranchId
	WHERE Title = 'The Lost Tribe'
	;
	
/*-------------------------------------------------------------------------------------------------
	3. retrieve the names of all borrowers who do not have any books checked out.
-------------------------------------------------------------------------------------------------*/

SELECT br.Name, bl.CardNo 
	FROM BOOK_LOANS bl
	FULL OUTER JOIN BORROWER br
	ON bl.CardNo = br.CardNo
	WHERE bl.CardNo is NULL
	;
	
/*-------------------------------------------------------------------------------------------------
	4. for each book that is loaned out from the "sharpstown" branch and whose duedate is today, 
		retrieve the book title, the borrower's name and the borrower's address. 
-------------------------------------------------------------------------------------------------*/

SELECT bk.Title, br.Name, br.[Address] 
	FROM BOOK bk
	INNER JOIN BOOK_LOANS bl 
	ON bl.BookID = bl.BookID
	INNER JOIN LIBRARY_BRANCH lb
	ON bl.BranchId = lb.BranchID
	INNER JOIN BORROWER br
	ON br.CardNo = bl.CardNo
	WHERE DueDate = '2018-04-28' AND lb.BranchName = 'Sharpstown'
	;

/*-------------------------------------------------------------------------------------------------
	5. for each library branch, retrieve the branch name and the total number of books loaned out 
		from that branch.
-------------------------------------------------------------------------------------------------*/

SELECT COUNT(bl.BookID), lb.BranchName 
	FROM LIBRARY_BRANCH lb
	INNER JOIN BOOK_LOANS bl
	ON lb.BranchID = bl.BranchId
	GROUP BY lb.BranchName
	; 

/*-------------------------------------------------------------------------------------------------
	6. retrieve the names, addresses, and number of books checked out for all borrowers who have 
		more than five books checked out.
-------------------------------------------------------------------------------------------------*/

SELECT br.CardNo, br.Name, br.[Address], COUNT(*)
	FROM BORROWER br, BOOK_LOANS bl
	WHERE br.CardNo = bl.CardNo
	GROUP BY br.CardNo, br.Name, br.[Address]
	HAVING COUNT(br.CardNo) >5
	;

/*-------------------------------------------------------------------------------------------------
	7. for each book authored (or co-authored) by "stephen king", retrieve the title and the number 
		of copies owned by the library branch whose name is "centeral".
-------------------------------------------------------------------------------------------------*/

SELECT bk.Title, bc.No_Of_Copies, lb.BranchName 
	FROM BOOK_AUTHORS ba, BOOK bk, BOOK_COPIES bc, LIBRARY_BRANCH lb
	WHERE ba.BookID = bk.BookID
	AND bk.BookID = bc.BookID
	AND bc.BranchId = lb.BranchID
	AND ba.AuthorName = 'Stephen King'
	AND lb.BranchName = 'Central'
	;