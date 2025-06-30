IF OBJECT_ID('dbo.Products', 'U') IS NOT NULL
    DROP TABLE dbo.Products;

CREATE TABLE Products (
    ProductID INT,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Products VALUES
(1, 'iPhone 15 Pro', 'Electronics', 1500),
(2, 'Samsung S23', 'Electronics', 1400),
(3, 'Dell XPS Laptop', 'Electronics', 1500),
(4, 'Nike Air Max', 'Footwear', 200),
(5, 'Adidas Runner', 'Footwear', 180),
(6, 'Puma Sneakers', 'Footwear', 180),
(7, 'HP Spectre', 'Electronics', 1300);

SELECT 
    Category,
    ProductName,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceDenseRank
FROM Products;

SELECT *
FROM (
    SELECT 
        Category,
        ProductName,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) Ranked
WHERE RowNum <= 3;
