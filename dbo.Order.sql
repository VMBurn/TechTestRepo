CREATE TABLE [dbo].[Order] (
    [OrderId]    INT        NOT NULL,
    [CustomerId] INT        NOT NULL,
    [Amount]     FLOAT (50) NOT NULL,
    [VAT]        FLOAT (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_CustomerOrder] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId])
);

