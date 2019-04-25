CREATE TABLE [dbo].[team] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [projectid] INT NOT NULL,
    [userid]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([projectid]) REFERENCES [dbo].[projects] ([Id]),
    FOREIGN KEY ([userid]) REFERENCES [dbo].[user] ([Id])
);

