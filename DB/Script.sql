--CREATE DATABASE DO
--GO

Use DO


GO 
CREATE TABLE [User](
ID	NVARCHAR(50),
[UserName]			NVARCHAR(50),
[Email]			NVARCHAR(50),
[password]		NVARCHAR(50),
FirstName		NVARCHAR(50),
LastName		NVARCHAR(50),
Gender			NVARCHAR(50),
[RoleID]		NVARCHAR(50)
)


CREATE TABLE UserRole(
ID	NVARCHAR(50),
[Role]			NVARCHAR(50),
[Desc]			NVARCHAR(50)
)

CREATE TABLE Staff (
UserID		NVARCHAR(50),
ID			NVARCHAR(50),
StaffName	NVARCHAR(50),
Gender		NVARCHAR(50),
BirthDate	DATE,
Position	NVARCHAR(50),
Salary		DECIMAL(16,4),
[Address]	NVARCHAR(MAX),
Phone		NVARCHAR(50),
HiredDate	DATE,
Contact		NVARCHAR(MAX),
StopWork	bit
)
CREATE TABLE MotoDriver (
UserID		NVARCHAR(50),
ID			NVARCHAR(50),
StaffName	NVARCHAR(50),
Gender		NVARCHAR(50),
BirthDate	DATE,
drivingLicenceNumber NVARCHAR(50),
expiryDate	DATE,
Working	bit
)

CREATE TABLE CarDriver (
UserID		NVARCHAR(50),
ID			NVARCHAR(50),
StaffName	NVARCHAR(50),
Gender		NVARCHAR(50),
BirthDate	DATE,
drivingLicenceNumber NVARCHAR(50),
expiryDate	DATE,
Working	bit
)



CREATE TABLE CoperateUser (
UserID		NVARCHAR(50),
Name	NVARCHAR(50),
Gender		NVARCHAR(50),
CopID		NVARCHAR(50),
CopDate		DATE,
ComLocation NVARCHAR(50),
ComName	NVARCHAR(50),
ComContact		NVARCHAR(50),
)

--drop TABLE Product
CREATE TABLE Product (
ID					NVARCHAR(50),
Name				NVARCHAR(50),
[Description]		NVARCHAR(50),
ProductType			NVARCHAR(50),
SalerID				NVARCHAR(50),
SalerName			NVARCHAR(50),
CheckInDate			DATE,
ToLocation			NVARCHAR(MAX),
CusPhone			NVARCHAR(50),
CusAddress			NVARCHAR(MAX),
TakeBy				NVARCHAR(50),
TakeDate			DATE,
CloseDate			DATE,
[Status]			NVARCHAR(50),
Note				NVARCHAR(50)
)
select * from Product