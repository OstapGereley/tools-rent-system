USE ToolsRentDatabase
GO;

SET IDENTITY_INSERT tblTool ON;

INSERT INTO [dbo].[tblTool]
           ([Id]
		   ,[Model]
           ,[Manufacturer]
           ,[Kind]
           ,[SerialNumber]
           ,[Cost])
     VALUES
           (1,'Some name', 'Black&Decker', 'Electric Drill', 'S068712387', 200)
SET INDENTITY_INSERT tblTool OFF;
GO


SET IDENTITY_INSERT tblCustomer ON;

INSERT INTO [dbo].[tblCustomer]
           ([Id]
		   ,[Name]
           ,[Surname]
           ,[ContactPhone]
           ,[Adress])
     VALUES
           (1, 'Bill', 'Clinton', '+15874524712','Struyska str, 12, 9')
SET IDENTITY_INSERT tblCustomer OFF;
GO

SET IDENTITY_INSERT tblRentOrder ON;

INSERT INTO [dbo].[tblRentOrder]
           ([Id]
		   ,[IdTool]
           ,[IdCustomer]
           ,[DateStart]
           ,[DateEnd]
           ,[RentStatus]
           ,[RentPrice])
     VALUES
           (1, 1, 1, '2016-03-10', '2016-03-12', 2, 400)
GO