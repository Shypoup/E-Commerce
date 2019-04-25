CREATE TABLE [dbo].[hiring] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [userid]    INT NOT NULL,
    [requestid] INT NOT NULL,
    [projectid] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([userid]) REFERENCES [dbo].[user] ([Id]),
    FOREIGN KEY ([projectid]) REFERENCES [dbo].[projects] ([Id]),
    FOREIGN KEY ([requestid]) REFERENCES [dbo].[request] ([Id])
);

