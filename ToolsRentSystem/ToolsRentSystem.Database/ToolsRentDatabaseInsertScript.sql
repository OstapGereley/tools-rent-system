USE ToolsRentDatabase
GO

SET IDENTITY_INSERT tblTool ON;

INSERT INTO [dbo].[tblTool]
           ([Id]
		   ,[Model]
           ,[Manufacturer]
           ,[Kind]
           ,[SerialNumber]
           ,[Cost])
     VALUES
           (1,'Proffesional GSB 13 RE', 'Bosch', 'Impact Drill', 'S068712387', 200),
		   (2,'CD714CRESKA', 'Black&Decker', 'Impact Drill', 'S028214767864', 150),
		   (3,'Proffesional GSB 16 RE', 'Bosch', 'Impact Drill', 'S068712390', 225),
		   (4,'KR504RE', 'Black&Decker', 'Impact Drill', 'S028214767964', 200),
		   (5,'ID 500', 'Stark', 'Drill', 'S120015041', 100),
		   (6,'BM-400C', 'DWT', 'Drill', 'S0851498743', 100),
		   (7,'Proffesional GBM 10 RE', 'Bosch', 'Drill', 'S068712237', 150),
		   (8,'Proffesional GERADM 12 RE', 'Bosch', 'Drill', 'S068212237', 120),
		   (9,'Angle GSW 6 100', 'Bosh', 'Grinder', 'S032712387', 175),
		   (10,'Power Tools Angle G10ss 580w', 'Hitachi', 'Grinder', 'S7984156', 145),
		   (11,'Angle DWE4051', 'DeWalt', 'Grinder', 'S45123757', 150),
		   (12,'Angle WS08-125V', 'DWT', 'Grinder', 'S8653134', 140),
		   (13,'WT-1800', 'Intertool Storm', 'Polisher', 'S85613566', 170),
		   (14,'Proffesional PMB 1200CE HD', 'Sparky', 'Polisher', 'S4021757012791', 200),
		   (15,'A7073 6v Cordless', 'Black&Decker', 'Power Screwdriver', 'S2255433', 100),
		   (16,'AS600P 3.5v Cordless', 'Black&Decker', 'Power Screwdriver', 'S2255233', 50),
		   (17,'KC4815 4.8v Ni-Cad Cordless', 'Black&Decker', 'Power Screwdriver', 'S2225233', 70),
		   (18,'IXO Cordless', 'Bosh', 'Power Screwdriver', 'S023712217', 120),
		   (19,'GDR 1080-Li Proffesional Cordless Impact', 'Bosch', 'Power Screwdriver', 'S023712617', 170),
		   (20,'Electric Blue Screw', 'Powermaxx', 'Power Screwdriver', 'S7894153', 30),
		   (21,'Aquatak AQT 35-12', 'Bosch', 'Pressure Washer', 'S022233512', 200),
		   (22, 'AQT 40-13', 'Bosch', 'Pressure Washer', 'S022234013', 250),
		   (23,'PW1570TD', 'Black&Decker', 'Pressure Washer', 'S856348333', 220),
		   (24,'PW1700SPX', 'Black&Decker', 'Pressure Washer', 'S022223112', 280)
SET IDENTITY_INSERT tblTool OFF;
GO

SET IDENTITY_INSERT tblCustomer ON;

INSERT INTO [dbo].[tblCustomer]
           ([Id]
		   ,[Name]
           ,[Surname]
           ,[ContactPhone]
           ,[Adress])
     VALUES
           (1, 'Bill', 'Clinton', '+1-202-555-0197','446 5th Street Olive Branch'),
		   (2, 'Steeven', 'Sheppard', '+1-518-555-0113','393 Church Street North New York'),
		   (3, 'Dillan', 'Glover', '+1-202-555-0151','765 York Street Palos Verdes Peninsula'),
		   (4, 'Makena', 'Logan', '+1-775-555-0119','57 Cedar Street Palos Verdes Peninsula'),
		   (5, 'Yaritza', 'Horn', '+1-202-555-0119','125 Fairview Avenue Manassas'),
		   (6, 'Wyatt', 'Rowland', '+1-518-555-0113','531 Fawn Lane Miami Gardens'),
		   (7, 'Ignacio', 'Klein', '+1-775-555-0146','817 Poplar Street Davenport'),
		   (8, 'Evan', 'Conway', '+1-202-555-0174','984 Cedar Street Farmington')
SET IDENTITY_INSERT tblCustomer OFF;
GO

SET IDENTITY_INSERT tblOperator ON;
INSERT INTO [dbo].[tblOperator]
           ([Id]
		   ,[Login]
           ,[Password]
           ,[Name]
           ,[Surname]
           ,[Disabled])
     VALUES
           (1, 'user1', '24c9e15e52afc47c225b757e7bee1f9d', 'Mallory', 'Armstrong', 0),
		   (2, 'user2', '7e58d63b60197ceb55a1c487989a3720', 'Nolan', 'Lutz', 0),
		   (3, 'user3', '92877af70a45fd6a2ed7fe81e1236b78', 'Yasmine', 'Quinn', 0)
SET IDENTITY_INSERT tblOperator OFF;
GO

SET IDENTITY_INSERT tblRentOrder ON;
INSERT INTO [dbo].[tblRentOrder]
           ([Id]
		   ,[IdTool]
           ,[IdCustomer]
           ,[IdOperator]
           ,[DateStart]
           ,[DateEnd]
           ,[RentStatus]
           ,[RentPrice])
     VALUES
			(1, 1, 1, 1, '2016-03-10', '2016-03-12', 2, 400),
			(2, 9, 1, 1, '2016-03-10', '2016-03-12', 2, 350),
			(3, 21, 1, 1, '2016-03-10', '2016-03-12', 2, 400),
			(4, 18, 2, 1, '2016-03-15', '2016-03-16', 2, 120),
			(5, 22, 3, 1, '2016-03-10', '2016-03-30', 1, 5000),
			(6, 13, 4, 2, '2016-03-12', '2016-03-25', 1, 2210),
			(7, 10, 4, 2, '2016-03-12', '2016-03-25', 1, 1185),
			(8, 2, 5, 2, '2016-03-08', '2016-03-12', 2, 600),
			(9, 11, 5, 2, '2016-03-08', '2016-03-12', 2, 600),
			(10, 20, 5, 2, '2016-03-08', '2016-03-12', 2, 120),
			(11, 3, 6, 3, '2016-03-02', '2016-03-04', 2, 450),
			(12, 15, 6, 3, '2016-03-02', '2016-03-04', 2, 200),
			(13, 4, 7, 3, '2016-02-13', '2016-02-14', 2, 200),
			(14, 8, 8, 3, '2016-03-13', '2016-03-18', 2, 750),
			(15, 16, 8, 3, '2016-03-13', '2016-03-18', 2, 250)
SET IDENTITY_INSERT tblRentOrder OFF;
GO