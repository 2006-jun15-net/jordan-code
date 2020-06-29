SELECT * 
FROM dbo.Customer 
WHERE (Country <> 'USA');

SELECT* 
FROM dbo.Customer 
WHERE (Country = 'Brazil');

SELECT* 
FROM dbo.Employee
WHERE (Title = 'Sales Support Agent');

SELECT DISTINCT BillingCountry
FROM dbo.Invoice;

SELECT COUNT(*) AS 'Invoices', SUM(Total) AS 'Total'
FROM Invoice
WHERE YEAR (InvoiceDate) = 2009;

SELECT SUM(Quantity) AS 'Quantity'
FROM dbo.InvoiceLine 
WHERE (InvoiceId = '37');

SELECT BillingCountry , COUNT(Total) AS 'Quantity' 
FROM dbo.Invoice;

SELECT DISTINCT BillingCountry FROM Invoice;

SELECT DISTINCT BillingCountry, SUM(Total) AS 'Total'
FROM Invoice
ORDER BY 'Total' DESC;

SELECT*
FROM Invoice INNER JOIN CUSTOMER 
ON Customer.Country = Invoice.BillingCountry
WHERE (Customer.Country = 'Brazil');


SELECT InvoiceId , Employee.FirstName
FROM Invoice INNER JOIN Customer  
ON Invoice.CustomerId = Customer.CustomerId
INNER JOIN Employee 
ON Customer.SupportRepId = Employee.EmployeeId;

SELECT* 
FROM Playlist INNER JOIN PlaylistTrack ON Playlist.PlaylistId = PlaylistTrack.PlaylistId
ORDER BY COUNT(PlaylistTrack.TrackId);

SELECT Artist.Name, Album.AlbumId
FROM Artist
LEFT JOIN Album ON Artist.ArtistId = Album.ArtistId
WHERE Album.AlbumId IS NULL;

SELECT Artist.Name , Genre.Name
FROM Artist
INNER JOIN  Album ON Artist.ArtistId = Album.ArtistId
INNER JOIN Track ON Album.AlbumId = Track.AlbumId
INNER JOIN Genre ON Track.GenreId = Genre.GenreId
WHERE Genre.Name NOT LIKE 'Latin';

SELECT Artist.Name , Genre.Name
FROM Artist

INSERT INTO Track (TrackId, Name, MediaTypeId, Milliseconds, UnitPrice) 
VALUES (0101010101, 'Freaking Out The Neighborhood', 102102123, 300000, 29.99),
	(0201010102, 'This Old Dog',1021021278, 300000, 29.99); 

SELECT*
FROM Track;

CREATE TABLE EmpDetails (
	Id int Primary Key,
	EmployeeId int Foreign Key References NewEmployee(Id),
	Salary int,
	Address1 varchar(255),
	Address2 varchar (255),
	City varchar,
	State varchar,
	Country varchar
	);

INSERT INTO EmpDetails(Id, EmployeeId, Salary)
VALUES (001, 'Marketing', 'NY');
SELECT*
FROM InvoiceLine;