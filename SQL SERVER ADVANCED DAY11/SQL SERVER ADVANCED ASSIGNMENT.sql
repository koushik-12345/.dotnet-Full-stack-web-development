use SalesDb;
select*from Products;
---1.
--A)
CREATE VIEW  ProductLessThanAveragePriceView AS
     SELECT * FROM Products where price<(select avg(price) from Products) ;

 --B)
 SELECT *   FROM ProductLessThanAveragePriceView 

--C)
EXEC sp_rename 'ProductLessThanAveragePriceView', 'LowCostProducts';
SELECT *   FROM LowCostProducts

--D)
DROP VIEW LowCostProducts;




 ----2.
 use northwind;
 --A)
CREATE PROCEDURE  usdProducts
AS
BEGIN
	 SELECT * FROM Products  ;

END;
EXEC usdProducts;

--B)
CREATE PROCEDURE  kProducts
AS
BEGIN
	 SELECT sum(UnitPrice),ProductName from Products GROUP BY ProductName ;

END;
EXEC kProducts;

--C)D)E)

DECLARE cursor_pro CURSOR
FOR SELECT ProductName, UnitPrice*UnitsOnOrder as TotalAmount FROM  Products;
DECLARE @ProductName VARCHAR(MAX),  @TotalAmount   DECIMAL(10,2),  @Grandsum  DECIMAl(10,2) ;
set @Grandsum=0.00;
OPEN cursor_pro;
FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;

WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @ProductName + ' - ' +  CAST(@TotalAmount AS varchar);
        FETCH NEXT FROM cursor_pro INTO @ProductName, @TotalAmount;
		set @Grandsum=@Grandsum+@TotalAmount;
    END;


 PRINT 'Grandsum' + ' - ' +  CAST(@Grandsum AS varchar);
	CLOSE cursor_pro;

deallocate cursor_pro;



