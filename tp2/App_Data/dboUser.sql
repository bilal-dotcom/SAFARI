CREATE TABLE [dbo].[user] (
    [Id]  INT           IDENTITY (1, 1) NOT NULL,
    [nom] NVARCHAR (50) NOT NULL,
    [usn] NVARCHAR (50) NOT NULL,
    [pw]  NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

