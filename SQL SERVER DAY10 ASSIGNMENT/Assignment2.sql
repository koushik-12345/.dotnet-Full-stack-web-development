use ShoppingCartDb;

select*from Products;
select* from Cart;
--A)
SELECT CartId,  ProductName, Quantity, UnitPrice
FROM Products
INNER JOIN Cart
ON  Products.ProductId = Cart.ProductId;

SELECT CartId,  ProductName, Quantity, UnitPrice
FROM Products
RIGHT OUTER JOIN Cart
ON  Products.ProductId = Cart.ProductId;

SELECT CartId,  ProductName, Quantity, UnitPrice
FROM Products
LEFT OUTER JOIN Cart
ON  Products.ProductId = Cart.ProductId;

SELECT CartId,  ProductName, Quantity, UnitPrice
FROM Products
FULL OUTER JOIN Cart
ON  Products.ProductId = Cart.ProductId;

--B)
CREATE TABLE ShoppingCartDb.dbo.Students
(
	StudentId INT PRIMARY KEY,
	StudentName VARCHAR(50),
	CourseName VARCHAR(50),
	CityName VARCHAR(50),
	ContactNumber INT,
	
);

 INSERT INTO Students VALUES (10,'tanishq','angular','hyd',9055);
  INSERT INTO Students VALUES (11,'tan','c','mumbai',9051);
   INSERT INTO Students VALUES (12,'tram','react','chennai',9085);
    INSERT INTO Students VALUES (13,'suresh','angualar','hyd',9035);
	 INSERT INTO Students VALUES (14,'bhargav','.net','hyd',9065);
	  INSERT INTO Students VALUES (15,'mahesh','.net','chennai',9075);
	   INSERT INTO Students VALUES (16,'manish','angular','hyd',9058);
	    INSERT INTO Students VALUES (17,'sarik','react','pune',9095);
		 INSERT INTO Students VALUES (18,'satwik',',net','hyd',9855);
		  INSERT INTO Students VALUES (19,'mohan','angular','switerland',9255);
		  
select*from Students;
select count(*) from Students where CourseName='Angular';
select count(*) from Students where CityName='hyd';
select CityName as Cityname,count(*) as studentnumbers from Students group by CityName;
select Count(*) as Courseid,CourseName as coursename from Students group by CourseName;
select 	CityName as City,CourseName as Course,count(*) as no_of_students from Students group by CityName,CourseName;

---c)
select*from Products where ProductId IN(select ProductId from Cart)
select*from Cart where ProductId IN (select ProductId from Products where Unitprice>5000)

