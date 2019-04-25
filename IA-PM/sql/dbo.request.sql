CREATE TABLE [dbo].[request] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [type] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

