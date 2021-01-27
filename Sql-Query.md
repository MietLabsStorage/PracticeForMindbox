Задание:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

Решение:
Допустим база данных состоит из таблиц Product(Id, Name), Cathegory(Id, Name) и свзующей таблицы Product_Cathegory(ProductId, CathegoryId), 
тогда

SELECT 
Product.Id AS ProductId, Product.Name AS ProductName, Cathegory.Id AS CathegoryId, Cathegory.Name AS CathegoryName
FROM Product LEFT JOIN (
SELECT * FROM Product, Cathegory, Product_Cathegory
WHERE Cathegory.Код = Product_Cathegory.CathegoryId AND Product.Id = Product_Cathegory.ProductId
) AS Pairs 
ON Product.Id = Pairs.Id
ORDER BY Product.Id, Cathegory.Id

комментарий к запросу: исполбзуем левое соединение для таблиц Product (благодаря левому соединению, продукты не имеющие категорий, будут также добалены) и представление полученное связыванием таблиц Product и Cathegory (в которой соответственно есть только продукуты имеющие категории)