CREATE TABLE [dbo].[Products] (
    [ProductID]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [Price]       DECIMAL (8, 2) NOT NULL,
    [Category]    NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductID] ASC)
);

