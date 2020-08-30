USE MercuryDb
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GenerateMockProducts] (@rowsCount int = 100000)
AS
BEGIN
	SET NOCOUNT ON;

	declare @rowName nvarchar(50);
	declare @rowComm nvarchar(50);
	declare @rowColl nvarchar(50);
	declare @rowMaterial int;
	declare @rowModel int;
	declare @rowColor int;
	declare @rowCreate datetime2;
	declare @rowModify datetime2;
	declare @rowSell datetime2;
	declare @rowVip bit;
	declare @rowPrivate bit;
	declare @rowBestSeller bit;
	declare @index int;

	set @index = 0;

	while (@index < @rowsCount)
	begin

	set @rowName = N'Name #' + CAST(@index AS NVARCHAR(10));
	set @rowColl = N'Collection #' + CAST( @index % 16 AS NVARCHAR(10));
	set @rowComm = N'Comment #' + CAST( @index % 23 AS NVARCHAR(10));
	set @rowModel = CAST( @index % 9  AS int);
	set @rowMaterial = CAST( @index % 8  AS int);
	set @rowColor = CAST( @index % 5 AS int);
	set @rowCreate = DATEADD(dd, -ABS(@rowMaterial * 23), GETDATE());
	set @rowModify = DATEADD(dd, @rowModel + RAND(11), @rowCreate);
	set @rowSell = DATEADD(dd, @rowColor, @rowModify);
	set @rowVip = CAST( @index % 2 as bit);
	set @rowPrivate = CAST( @index % 3 as bit);
	set @rowBestSeller = CAST( @index % 5 as bit);

	insert into dbo.Product
        ([Model]
        ,[Material]
        ,[Color]
        ,[Name]
        ,[Collection]
        ,[Comment]
        ,[CreateDate]
        ,[ModifyDate]
        ,[SellDate]
        ,[BestSeller]
        ,[VIP]
        ,[Private])
     VALUES
		(@rowModel
		,@rowMaterial
        ,@rowColor
        ,@rowName
		,@rowColl
		,@rowComm
		,@rowCreate
		,@rowModify
		,@rowSell
		,@rowBestSeller
		,@rowVip
		,@rowPrivate)

		set @index = @index + 1;
	end
END
