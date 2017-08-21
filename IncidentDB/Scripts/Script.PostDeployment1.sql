/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

CREATE USER [IIS APPPOOL\IncidentApi] FOR LOGIN [IIS APPPOOL\IncidentApi] --WITH DEFAULT_SCHEMA=[dbo]
GO

EXEC sp_addrolemember N'db_owner', N'IIS APPPOOL\IncidentApi'

GO

INSERT INTO [dbo].[Incidents]
           ([IncidentName]
           ,[CreatedDate]
           ,[NumberPeople]
           ,[IsUrgent]
           ,[IncidentType])
VALUES ('Incident 1', '20170819 10:34:09 AM', 2, 1, 1)

GO

INSERT INTO [dbo].[Incidents]
           ([IncidentName]
           ,[CreatedDate]
           ,[NumberPeople]
           ,[IsUrgent]
           ,[IncidentType])
VALUES ('Incident 2', '20170820 12:20:05 AM', 10, 0, 1)

GO

INSERT INTO [dbo].[Incidents]
           ([IncidentName]
           ,[CreatedDate]
           ,[NumberPeople]
           ,[IsUrgent]
           ,[IncidentType])
VALUES ('Incident 3', '20170821 08:10:05 AM', 8, 1, 2)
