create procedure spUpdateContactInformation

@First_Name varchar(200),
@Last_Name varchar(200),
@Phone bigint
As
Update addressbook set First_Name = @First_Name where Last_Name = @Last_Name and Phone = @phone;

use address_book_service_DB;

 select * from addressbook;

 ALTER TABLE addressbook
ADD Date varchar(255);