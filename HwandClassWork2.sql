Create Database Classwork

use Classwork

Create Table 
Departments
(
 Id int Constraint PK_Departments_ID Primary key identity,
 Name nvarchar (25) default 'Undecided' Not Null Constraint Ck_Departments_Name check(Len(Name)>2)
)

truncate table Departments

Insert into Departments Values
('Credit'),
('Informational Technology'),
('Adminitration'),
('Marketing'),
('Finance')

Create Table 
Employees
(
Id int Primary key identity,
FullName nvarchar(50) default 'Undecided'  not null constraint ck_Employees_Fullname Check(Len(FullName)>3),
Salary money constraint Ck_Employees_Salary Check(Len(Salary)>0),
DepartmentsId int foreign key references  Departments(Id),
Email nvarchar(50) default 'Undecided' not null constraint Uk_Employees_Email  Unique
)



truncate table Employees


Insert into Employees Values
('Hamid Alakbarli',6400,2,'alakbatlihamid1@gmail.com'),
('Parviz Alizade',1000,3,'alizade@gmail.com'),
('Vasif Aliyev',3600,2,'vasiyev@gmail.com'),
('Murad Aliyev',5400,5,'muradaliyev@gmail.com'),
('Aydin Alakbarli',3800,4,'aydinalakbarli@gmail.com')
