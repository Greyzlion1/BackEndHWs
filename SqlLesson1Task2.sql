CREATE DATABASE Market 
Use Market
CREATE TABLE Products

(
    Id int, 
	Name nvarchar(25), 
	Price int
)
Alter Table Products 
Add Brand nvarchar(25)

Insert into Products
Values
(1,'Cucumber',1,'Kend'),
(2,'Tomato',2,'Kend'),
(3,'Cola',4,'Cola'),
(4,'Pepsi',4,'Cola'),
(5,'Cips',3,'Lays'),
(6,'Cips',5,'Pringles'),
(7,'Bread',1,'Bine Zavod'),
(8,'Sousage',7,'Miratorg'),
(9,'Fanta',2,'Fanta'),
(10,'Sandwich',6,'Bravo kitchen'),
(11,'Rise',15,'Miat'),
(12,'Milk',12,'Azersud')

Select * From Products Where (Select AVG(Price)From Products) <  Price 

Select * From Products Where Price > 10

Select Id, (Name+' '+Brand)As'ProductInfo',Price From Products Where LEN(Brand)>5
