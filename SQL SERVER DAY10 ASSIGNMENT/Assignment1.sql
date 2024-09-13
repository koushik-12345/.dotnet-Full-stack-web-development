CREATE DATABASE  ShoppingCartDb;

use ShoppingCartDb;

CREATE TABLE ShoppingCartDb.dbo.Users
(
	UserId INT PRIMARY KEY,
	UserName VARCHAR(50),
	password VARCHAR(50),
	ContactNumber INT,
	City VARCHAR(50),
	
);

INSERT INTO Users VALUES (10,'SMITH','abc',9056660,'hyderabad');
INSERT INTO Users VALUES (20,'JON','abcD',910567,'pune');
INSERT INTO Users VALUES (30,'RAVI','aEbc',907562,'chennai');
INSERT INTO Users VALUES (40,'MAHESH','abFc',990560,'USA');
INSERT INTO Users VALUES (50,'RAMESH','abTc',9805660,'nigeraia');

select*from Users;

CREATE TABLE ShoppingCartDb.dbo.Products
(
	ProductId INT PRIMARY KEY,
	ProductName VARCHAR(50) NOT NULL,
	Quantityinstock int NOT NULL,
	Unitprice INT NOT NULL,
	Category VARCHAR(50),
	CONSTRAINT  CHK_Products_Quantityinstock CHECK (Quantityinstock > 0),
	CONSTRAINT  CHK_Products_Unitprice CHECK (Unitprice > 0),


);


INSERT INTO Products VALUES (01,'cooldrinks',100,450,'bevageras');
INSERT INTO Products VALUES (02,'iphone',1,45000,'electronics');
INSERT INTO Products VALUES (03,'smartwatch',5,1000,'electronics');
INSERT INTO Products VALUES (04,'clothes',10,5000,'clothing');
INSERT INTO Products VALUES (05,'dal',2,100,'grocies');


select*from Products;


CREATE TABLE ShoppingCartDb.dbo.Cart
(
	ProductId INT ,
	cartid VARCHAR(50) NOT NULL ,
	Quantity INT,
	CONSTRAINT  PK_Cart_id  PRIMARY KEY (ProductId),
	CONSTRAINT  CHK_cart_Quantity CHECK (Quantity > 1000),
	CONSTRAINT  FK_Cart_Products FOREIGN KEY (ProductId)
	REFERENCES Products(ProductId)	
	ON DELETE CASCADE
	ON UPDATE CASCADE
) 

INSERT INTO Cart VALUES (01,100,2000);
 Select* from Cart;

 INSERT INTO Cart VALUES (02,100,2000);
 INSERT INTO Cart VALUES (04,101,1500);
 INSERT INTO Cart VALUES (05,102,1200);
 INSERT INTO Cart VALUES (03,103,4000);

 select* from Cart;





 ---A)

 select* from Products;
 select*from Products where Category='clothing';
 select*from Products where Quantityinstock=0;
 select*from Products where UnitPrice BETWEEN 1000 AND 10000;
 SELECT * from Products where ProductId=04;


 ---B)

 SELECT * FROM Cart where Cartid=100
SELECT * FROM Cart where Cartid  IN (SELECT ProductId FROM Products)

 --c)

 select* from Users;
 select*from Users where ContactNumber=907562;
 select*from Users where UserId=10;
 