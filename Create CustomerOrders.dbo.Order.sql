USE [CustomerOrders]
GO

/****** Object: Table [dbo].[Order] Script Date: 5/7/2021 9:19:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Order] (
    [OrderId]    INT        NOT NULL,
    [CustomerId] INT        NOT NULL,
    [Amount]     FLOAT (53) NOT NULL,
    [VAT]        FLOAT (53) NOT NULL
);


