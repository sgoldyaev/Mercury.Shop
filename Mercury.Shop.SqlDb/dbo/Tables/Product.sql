Use MercuryDb
GO
CREATE TABLE [dbo].[Product] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [Model]      INT           NOT NULL,
    [Material]   INT           NOT NULL,
    [Color]      INT           NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [Collection] NVARCHAR (50) NOT NULL,
    [Comment]    NVARCHAR (50) NOT NULL,
    [CreateDate] DATETIME2 (7) NOT NULL,
    [ModifyDate] DATETIME2 (7) NOT NULL,
    [SellDate]   DATETIME2 (7) NOT NULL,
    [BestSeller] BIT           NOT NULL,
    [VIP]        BIT           NOT NULL,
    [Private]    BIT           NOT NULL,
    [RowVersion] ROWVERSION    NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ID] ASC)
);

