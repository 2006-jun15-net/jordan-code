CREATE Table Products (
    Id INT  IDENTITY(1,1) NOT NULL,
    Name NVARCHAR,
    Price MONEY

);
GO
CREATE Table Customers (
    Id INT  IDENTITY(1,1) NOT NULL,
    FirstName NVARCHAR,
    LastName NVARCHAR,
    CardNumber INT

);


GO
CREATE Table Orders (
    Id INT  IDENTITY(1,1) NOT NULL,
    ProductId INT,
    CustomerId INT,
    CONSTRAINT FK_Orders_Products_ProductID FOREIGN KEY (ProductId)
    REFERENCES Products(Id)
    ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Orders_Customers_CustomerID FOREIGN KEY (CustomerId)
    REFERENCES Customers(Id)
    ON DELETE CASCADE ON UPDATE CASCADE

);

GO

INSERT INTO Products (Name, Price) VALUES
	('iPhone', 200),
	('Guitar', 300),
    ('Bass', 350);

GO


INSERT INTO Customers (FirstName, LastName, CardNumber) VALUES
	('Tina','Smith', 1234567),
	('Fred','Robertson', 987765544),
    ('Mac','Demarco', 444442222);

GO

INSERT INTO Orders (ProductId, CustomerId) VALUES
	(1, 1);

GO

SELECT Customers.FirstName, Customers.LastName, Orders.Id, Products.Name, Products.Price
FROM Customers 
LEFT JOIN Orders ON Customers.Id = Orders.CustomerId
LEFT JOIN Products ON Orders.ProductId = Products.Id;


GO

SELECT COUNT(ProductId) * (SELECT Price FROM Products WHERE ID =1)
From Orders GROUP BY ProductId;

GO
UPDATE Products
SET Price = 250
WHERE Id = 1;