--Create DataBase AddressBookSystem
Create Database AddressBookSystem;
Use AddressBookSystem;

--Create Table In AddressBookSystem DataBase
Create Table AddressBook(
ContactId int identity(1,1) Primary Key,
FirstName varchar(20) not null,
LastName varchar(20) not null,
Address varchar(100) not null, 
City varchar(50) not null,
State varchar(200) not null,
Zip bigint not null ,
PhoneNumber bigint not null,
Email varchar(50)not null
)
Select * From AddressBook