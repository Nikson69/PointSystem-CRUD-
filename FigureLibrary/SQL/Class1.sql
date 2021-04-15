--Подготовка данных
CREATE TABLE #Product (
id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
  name char(50) NOT NULL,
  categoryId uniqueidentifier)

CREATE TABLE #Category (id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
  name char(50) NOT NULL)

  DECLARE @id1 UNIQUEIDENTIFIER, @id2 UNIQUEIDENTIFIER

SET @id1  = NEWID();
set @id2 = NEWID();

INSERT INTO #Category VALUES (@id1, 'Category1'), (@id2, 'Category2')

INSERT INTO #Product VALUES (DEFAULT, 'Product1', @id2), (DEFAULT, 'Product2', @id1), (DEFAULT, 'Product3', @id2), (DEFAULT, 'Product4', null)


--Требуемый результат
select P.name as ProductName, C.name as CategoryName from #Product as P
left join #Category as C on C.id = P.categoryId 
Order by CategoryName 