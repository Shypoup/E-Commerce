CREATE TABLE [dbo].[projrequest] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [projectid]  INT NOT NULL,
    [progressid] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([projectid]) REFERENCES [dbo].[projects] ([Id]),
    FOREIGN KEY ([progressid]) REFERENCES [dbo].[progress] ([Id])
);

