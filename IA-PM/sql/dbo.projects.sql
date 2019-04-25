CREATE TABLE [dbo].[projects] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (50) NOT NULL,
    [descreption] NVARCHAR (50) NOT NULL,
    [date]        DATE          NULL,
    [status]      INT           NOT NULL,
    [price]       FLOAT (53)    NULL,
    [customerid]  INT           NOT NULL,
    [progressid]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([progressid]) REFERENCES [dbo].[progress] ([Id])
);

