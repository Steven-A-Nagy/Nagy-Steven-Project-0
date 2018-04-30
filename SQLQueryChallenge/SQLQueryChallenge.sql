--create database SQLChallengeDB;
--go

use SQLChallengeDB
go

--create schema challenge
--go

--drop table if exists challenge.Orders
--drop table if exists challenge.Products
--drop table if exists challenge.Customers
--go

--create table challenge.Products(
--ID int primary key identity(1,1),
--[name] varchar(100), 
--price varchar(100)
--);
--go

--create table challenge.Customers(
--ID int primary key identity(1,1),
--FirstName varchar(100),
--LastName varchar(100),
--cardnumber varchar(20)
--);
--go

--create table challenge.Orders(
--ID int primary key identity(1,1),
--ProductID int not null,
--CustomerID int not null,
--foreign key(ProductID) references challenge.Products(ID),
--foreign key(CustomerID) references challenge.Customers(ID) 
--);
--go

--insert into challenge.Products ([name],price) values('fakeProduct1','$2000')
--insert into challenge.Products ([name],price) values('fakeProduct2','$300')
--insert into challenge.Products ([name],price) values('fakeProduct3','$10')
--go

--insert into challenge.Customers (FirstName,LastName,cardnumber) values('FakeFirst1','FakeLast1','FakeNumber1')
--insert into challenge.Customers (FirstName,LastName,cardnumber) values('FakeFirst12','FakeLast12','FakeNumber12')
--insert into challenge.Customers (FirstName,LastName,cardnumber) values('FakeFirst123','FakeLast123','FakeNumber123')
--go

--insert into challenge.Orders (ProductID,CustomerID) values(1,1)
--insert into challenge.Orders (ProductID,CustomerID) values(2,2)
--insert into challenge.Orders (ProductID,CustomerID) values(2,2)
--go

--insert into challenge.Products ([name],price) values('IPhone','$200')
--insert into challenge.Customers (FirstName,LastName,cardnumber) values('Tina','Smith','FakeNumber')
--insert into challenge.Orders (ProductID,CustomerID) values(4,4)

