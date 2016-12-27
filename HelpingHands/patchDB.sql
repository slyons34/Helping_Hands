select * into Categories2 from Categories;
drop table categories;
insert into Categories (description) select item from categories2;


select * into Locations2 from Locations;
drop table Locations;
insert into Locations select * from Locations2;

USE [HelpingHands]
GO

Insert into donations (
       [UserName]
      ,[Item]
      ,[Quantity]
      ,[DateTime]
      ,[Location]
      ,[Description] )
SELECT 
       [UserName]
      ,[Item]
      ,[Quantity]
      ,[DateTime]
      ,[Location]
      ,[Description]
  FROM [dbo].[donations2];

