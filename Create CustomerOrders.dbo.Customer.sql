USE [CustomerOrders]
GO

/****** Object: Table [dbo].[Customer] Script Date: 5/7/2021 9:19:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer] (
    [CustomerId]  INT           NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [DateOfBirth] DATE          NOT NULL,
    [Country]     NVARCHAR (50) NOT NULL
);


