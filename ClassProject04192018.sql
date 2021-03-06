USE master

IF (SELECT COUNT(*) FROM master.dbo.syslogins WHERE Name = 'AdvWorks2012') > 0


DROP LOGIN AdvWorks2012
CREATE LOGIN AdvWorks2012 WITH PASSWORD = '1234'
ALTER LOGIN AdvWorks2012 WITH DEFAULT_DATABASE = AdventureWorks2012

USE AdventureWorks2012

DROP USER AdvWorks2012
CREATE USER AdvWorks2012 FOR LOGIN AdvWorks2012


ALTER ROLE db_datareader ADD Member Advworks2012
ALTER ROLE db_datawriter ADD Member Advworks2012

DENY SELECT, UPDATE, DELETE, INSERT, ALTER  ON SCHEMA :: HumanResources TO AdvWorks2012
DENY UPDATE, DELETE, INSERT, ALTER  ON SCHEMA :: Person TO Advworks2012

--DROP PROCEDURE sp_SalesBS1
Go
CREATE PROCEDURE sp_SalesBS1
(
@customerID int
)
AS
BEGIN

	Select soh.SalesOrderID [Sales Order ID], soh.OrderDate [Order Date],
	soh.ShipDate [Ship Date], e.FirstName+ '  ' + e.LastName [Sales Person], a.City, stp.Name,soh.TotalDue
	From Sales.SalesOrderHeader soh
	left join Sales.SalesPerson sp
	on soh.SalesPersonID = sp.BusinessEntityID
	left join HumanResources.Employee e
	on soh.SalesPersonID = e.BusinessEntityID
	left join Sales.Customer c
	on soh.CustomerID = c.CustomerID
	left join Person.Address a
	on soh.ShipToAddressID = a.AddressID
	left join Person.StateProvince stp
	on stp.StateProvinceID = a.StateProvinceID
	Where c.CustomerID = @customerID
END

--DROP PROCEDURE sp_CustomerList
GO
CREATE PROCEDURE sp_CustomerList
AS
BEGIN
	SELECT c.CustomerID [CUSTOMER ID], p.LastName+ ', '+ p.FirstName  [CUSTOMER NAME] FROM Sales.Customer c
	Join Person.Person p
	on p.BusinessEntityID = c.PersonID
	
END

--EXECUTE sp_CustomerList
--EXECUTE sp_SalesBS1 14776

select * from sales.Customer