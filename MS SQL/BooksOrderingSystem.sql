--Create Following Tables in SQL

CREATE DATABASE BookingMgtSystem
USE BookingMgtSystem

--Book(ISBN, Title, Genre, PublicationDate, and Price)
CREATE TABLE Books (
ISBN int primary key,
Title varchar(100),
Genre varchar(50),
PublicationDate datetime,
Price int
);

--Author(AuthorId, Name)
CREATE TABLE Authors (
AuthorId int primary key,
Name varchar(255)
);

--Publisher(PublisherId,Name,Address,Contact)
CREATE TABLE Publisher(
PublisherId int primary key,
Name varchar(255),
Address text,
Contact bigint
);

--User(userId, email,ContactNumber)
CREATE TABLE Users(
userId int primary key,
userName varchar(255),
email varchar(255),
contactNumber bigint
);

--OrderTable(OrderId, OrderDate, TotalAmount , Status)
CREATE TABLE Orders(
orderId int primary key,
orderDate datetime,
totalAmount int,
status varchar(10)
);

--Create an Associative table for OrderDetails
CREATE TABLE OrderDetails(
orderId int,
ISBN int,
userId int
);

ALTER TABLE Books
ADD AuthorId int

ALTER TABLE Books
ADD CONSTRAINT FK_Books_Author
FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId);

ALTER TABLE Books
ADD PublisherId int

ALTER TABLE Books
ADD CONSTRAINT FK_Books_Publisher
FOREIGN KEY (PublisherId) REFERENCES Publisher(PublisherId);

ALTER TABLE OrderDetails
ADD CONSTRAINT FK_Order_OrderDetails
FOREIGN KEY (orderId) REFERENCES Orders(orderId);

ALTER TABLE OrderDetails
ADD CONSTRAINT FK_Books_OrderDetails
FOREIGN KEY (ISBN) REFERENCES Books(ISBN);

ALTER TABLE OrderDetails
ADD CONSTRAINT FK_Users_OrderDetails
FOREIGN KEY (userId) REFERENCES Users(userId);

ALTER TABLE OrderDetails
ADD Quantity INT;

--Write a query to list all books where Price is greater than 20
SELECT * from Books where Price > 20;

--List all books where PublisherID is 2
SELECT * from Books where PublisherId = 2;

--Find all orders where Status is "Pending"
SELECT * from Orders where status = 'Pending';

--Change the price of the book with ISBN = your choice  to 300
UPDATE Books SET Price = 300 where ISBN = 12345;

--Increase the price of all books in the "Technology" genre by 10%
UPDATE Books SET Price = Price + (Price * 10/100) where Genre = 'Technology';

--DELETE FROM Book WHERE ISBN = Your choice
DELETE from Books where ISBN = 12345;

--Get details of books published on or after January 1, 2022
SELECT * from Books where PublicationDate >= '2002-01-01';

--List all books where the genre is not "Science"
SELECT * from Books where Genre <> 'Science';

--List all customers with contact numbers that are not NULL
SELECT * from Users where contactNumber is not null;

--Count the total number of books in the bookstore.
SELECT COUNT(*) FROM Books;

--Find the average price of all books in the "Technology" genre
SELECT AVG(Price) FROM Books where Genre = 'Technology';

--Get the total revenue generated from all orders
SELECT SUM(totalAmount) FROM Orders;

--Find the minimum and maximum price of books in the "Fiction" genre
SELECT MAX(Price) as [MaximumPrice], MIN(Price) as [MinimumPrice] FROM Books;

--Count the number of orders for each status (Pending, Shipped, Delivered)
SELECT COUNT(*) as COUNT FROM Orders where status = 'Pending';
SELECT COUNT(*) as COUNT FROM Orders where status = 'Shipped';
SELECT COUNT(*) as COUNT FROM Orders where status = 'Delivered';

--Get the month when each order was placed
SELECT OrderId, month(orderDate) as MonthNumber, DateName(month,orderDate) as MonthName FROM Orders;

--Calculate the total revenue for each month
SELECT DateName(month,orderDate) as [Month], SUM(totalAmount) as GrandTotal
FROM Orders
GROUP BY DateName(month,orderDate);

--List all books along with their publisher names
SELECT B.ISBN, B.Title, B.Genre, P.Name, P.Contact FROM Books as B
INNER JOIN Publisher as P
on B.PublisherId = P.PublisherId;

--Retrieve all orders along with the names of the customers who placed them
SELECT O.orderId, O.ISBN, U.userName, U.contactNumber FROM OrderDetails as O
INNER JOIN Users as U
on O.userId = U.userId;

--Find all books that have been ordered at least once
SELECT B.ISBN, B.Title FROM OrderDetails as O
INNER JOIN Books as B
on O.ISBN = B.ISBN;

--Retrieve a list of authors along with the titles of books they have written
SELECT A.Name, B.Title FROM Books as B
INNER JOIN Authors as A
on A.AuthorId = B.AuthorId
ORDER BY A.Name;

--List all books along with their publisher names, including books with no publisher information
SELECT B.ISBN, B.Title, P.Name FROM Books as B
LEFT JOIN Publisher as P
on B.PublisherId = P.PublisherId;

--Retrieve all orders with their details, including orders with no items
SELECT * FROM Orders as O
RIGHT JOIN OrderDetails as OD
on O.orderId = OD.orderId;

--Find all pairs of customers from the same city
SELECT userName, city FROM Users ORDER BY city;

--Find the title of the book with the highest price
SELECT * FROM Books WHERE Price = (SELECT MAX(Price) FROM Books);

--List all authors who have written books in the "your choice" genre
SELECT * FROM Authors WHERE AuthorId IN (SELECT AuthorId FROM Books WHERE Genre = 'Fiction');

--Find the titles of books that have never been ordered
SELECT ISBN, Title FROM Books WHERE ISBN NOT IN (SELECT ISBN FROM OrderDetails); --not working

--Get the names of customers who have placed orders totaling more than ‘amount as per values you have in database’
SELECT userId, userName FROM Users WHERE userId IN 
	(SELECT userId FROM OrderDetails WHERE orderId IN 
		(SELECT orderId FROM Orders WHERE totalAmount > 48)
	);

--List all books that cost more than the average price of all books
SELECT * FROM Books WHERE Price > (SELECT AVG(Price) FROM Books);

--Retrieve books published by the publisher with the fewest books
SELECT * FROM Books WHERE PublisherId IN (SELECT TOP 1 PublisherId FROM Books GROUP BY PublisherId ORDER BY COUNT(*));

--Find the average quantity of books per order
SELECT AVG(Quantity) AS Average FROM (SELECT Quantity FROM OrderDetails) AS Result;

--Display each book's title and its rank by price (highest to lowest)
SELECT Title, RANK() OVER(ORDER BY Price DESC) AS Rank FROM Books;

--Find customers who have placed more orders than the average orders per customer
SELECT U.userId, U.userName, COUNT(o.orderId) AS OrderCount
FROM Users AS U
JOIN OrderDetails AS O ON U.userId = O.userId
GROUP BY U.userId, U.userName
HAVING COUNT(O.orderId) > (
    SELECT AVG(OrderCount)
    FROM (SELECT COUNT(orderId) AS OrderCount FROM OrderDetails GROUP BY userId) AS OrderCounts
);

--List all books along with the number of orders Use a correlated subquery to count orders for each book
SELECT B.ISBN, B.Title, 
    (SELECT COUNT(*)
     FROM OrderDetails OD
     WHERE OD.ISBN = B.ISBN) AS OrderCount
FROM Books B;

--
SELECT * from Users;
SELECT * from Orders;
SELECT * from OrderDetails;
SELECT * from Books;
SELECT * from Publisher;
SELECT * from Authors;



