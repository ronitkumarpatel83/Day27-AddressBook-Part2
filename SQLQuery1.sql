

create procedure spAddContact
@First_Name varchar(200),
@Last_Name varchar(200),
@Address varchar(200),
@Phone bigint,
@Type varchar(50),
@City varchar(50),
@State varchar(50),
@Email varchar(50),
@Zip int
as
insert into addressbook(First_Name,Last_Name,Address,Type,City,State,Email,Zip,Phone)
values(@First_Name,@Last_Name,@Address,@Type,@City,@State,@Email,@Zip,@Phone);