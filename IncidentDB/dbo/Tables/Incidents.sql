CREATE TABLE [dbo].[Incidents]
(
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[IncidentName] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[NumberPeople] [int] NOT NULL,
	[IsUrgent] [bit] NOT NULL DEFAULT(0),
	[IncidentType] [int] NULL,
)
