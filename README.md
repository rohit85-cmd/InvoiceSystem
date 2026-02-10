This Project involves Invoice API and related frontend code.

For adding data in related tables in the database, follow the sample insert queries.

INSERT INTO [InvoiceSystem].[dbo].[Invoices] (InvoiceId, CustomerName)
VALUES 
(1, 'John Doe'),
(2, 'Alice Smith'),
(3, 'Michael Brown');
 
 
INSERT INTO [InvoiceSystem].[dbo].[InvoiceItems] (ItemId, InvoiceId, Name, Price)
VALUES
(1, 1, 'Laptop', 55000),
(2, 1, 'Mouse', 500),
(3, 2, 'Mobile Phone', 25000),
(4, 2, 'Charger', 1200),
(5, 3, 'Desk Chair', 8000);
