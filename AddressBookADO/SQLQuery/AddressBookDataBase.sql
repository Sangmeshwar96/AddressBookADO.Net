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
Select * From AddressBook;

--Inserting Data Into AddressBook Table
Insert into AddressBook (FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values('Sangmeshwar', 'Patil', 'Udgir', 'Latur', 'MH', '413519', '8956231245', 'sangmeshwar@gmail.com')
Insert into AddressBook (FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values('Pramod', 'Pawar', 'Ausa', 'Latur', 'MH', '413518', '2222222222', 'pramod@gmail.com')
Insert into AddressBook (FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values('Apurva', 'Shinde', 'Kharadi', 'Pune', 'MH', '413517', '5623897425', 'Apurva@gmail.com')
Insert into AddressBook (FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values('Shubham', 'Deshpande', 'Nilanga', 'Akola', 'MH', '496895', '888888888', 'Shubhamd@gmail.com')
Insert into AddressBook (FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values('Nagesh', 'Nawade', 'Nanded', 'Nanded', 'MH', '413256', '8529637894', 'Nageshn@gmail.com')
Insert into AddressBook (FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email) values('Rajkumar', 'Bhosle', 'Latur', 'Latur', 'MH', '413516', '8523697412', 'raju@gmail.com')
Select * From AddressBook

--Editing/Updating Existing Record
Update AddressBook Set Address='Karamchedu' Where FirstName='Bharath'

--Deleting Existing Record From AddressBook Table
Delete from AddressBook Where FirstName='Nagesh';

--Retrieve Contact Belongs To City Or State
Select * From AddressBook Where City='Latur' or State='MH';

--Size Of AddressBook By City
Select Count(City) as 'NumberOfContacts' from AddressBook Where City='Latur' Group by City;
Select Count(State) as 'NumberOfContacts' from AddressBook Where State='MH' Group by State;
