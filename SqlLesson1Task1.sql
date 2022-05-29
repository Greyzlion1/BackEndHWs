CREATE DATABASE Company

USE Company

CREATE TABLE Employees
(
    Name nvarchar(25), 
	SurName nvarchar(25), 
	Position nvarchar(25), 
	Salary int
)
Insert into Employees
Values
('Hamid','Alakbarli','Software Developer',4300),
('Aydin','Alakbarli','Teacher',1200),
('Murad','Aliyev','Sistem Administrator',3000),
('Yusif','Alekberzade','Cyber Security',3800)

SELECT AVG(Salary) FROM Employees

SELECT Name , SurName,Salary From Employees Where (Select AVG(Salary)From Employees) >  Salary 

SELECT MIN(Salary) FROM Employees

Select Max(Salary) From Employees
