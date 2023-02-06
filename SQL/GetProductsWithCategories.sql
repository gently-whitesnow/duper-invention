
SELECT p.ProductName AS 'Product name', p.CategoryName AS 'Category name'
FROM Products AS p WITH(NOLOCK)
     LEFT JOIN ProductCategories ON p.ProductID = pc.ProductID as pc WITH(NOLOCK)
     LEFT JOIN Categories ON c.CategoryID = pc.CategoryID as c WITH(NOLOCK)
