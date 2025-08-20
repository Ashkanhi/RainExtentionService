USE [RWP_Sale_DB_Bakhshi]
GO

/****** Object:  StoredProcedure [dbo].[Usp_GetItemList]    Script Date: 8/20/2025 1:39:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*

/****** Object:  UserDefinedTableType [dbo].[GuidType]    Script Date: 8/20/2025 1:20:12 PM ******/
CREATE TYPE [dbo].[GuidType] AS TABLE(
	[ID] [uniqueidentifier] NULL
)
GO
*/




CREATE procedure [dbo].[Usp_GetItemList]

as 
begin 

			SET NOCOUNT ON

   

		IF OBJECT_ID ( 'Tempdb..#GetCurrentPrices' )  IS NOT NULL DROP TABLE #GetCurrentPrices

		DECLARE @DateNow DATETIME  = GETDATE ()

    -- Insert statements for procedure here
	 
		
		/*------------------------------------------------------*/


	SELECT 
			  I.ItemID 
			  , ParentID
			, ItemName =  I.Name 
			, SalePrice =  I.CurrentPrice 
			, I.Barcode 			
			, StockName = S.Name 
			, StockID =  ISQ.StockID
			, StockQuantity = ISQ.CurrentUnitCount 						
			, DepartmentCode=IDAV.DepartmentCode
			, DepartmentName = IDAV.Name 
			, CurrentDiscount = I.CurrentDiscount
			

		FROM Item I 			
			INNER JOIN ItemStockQuantity ISQ
				ON I.ItemID = ISQ.ItemID 

			INNER  JOIN Stock S 
				ON S.StockID = ISQ.StockID

			 LEFT  JOIN ItemDepartmentAssignmentView IDAV
			  	ON IDAV.ItemID = I.ItemID 
			 	AND IDAV.TypeID = 1

	 
 end 


GO


