IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_BulkDeleteContact')
	DROP PROCEDURE usp_BulkDeleteContact
GO
IF EXISTS (SELECT * FROM sys.types WHERE name = 'type_BulkDelete')
	DROP TYPE type_BulkDelete
GO
CREATE TYPE type_BulkDelete AS TABLE
(
	FirstName		nvarchar(100),
	MiddleName		nvarchar(100),
    LastName		nvarchar(100),
	Mobile			nvarchar(100),
    Gender			nvarchar(100)    
)
GO
CREATE PROCEDURE	usp_BulkDeleteContact
(
	@dtContactsForSaving type_BulkDelete READONLY
)
AS
SET NOCOUNT OFF
SET XACT_ABORT ON --FORCE ROLLBACK IF RUNTIME ERROR OCCURS
	
	BEGIN TRY
		BEGIN TRANSACTION 

				
				
				
				SELECT UserId FROM @dtContactsForSaving as dtc;
				DELETE FROM Contacts WHERE UserId = dtc

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		
	        DECLARE @ErrorNum INT = ERROR_NUMBER();  
	        DECLARE @ErrorLine INT = ERROR_LINE();  
	        DECLARE @ErrorMsg NVARCHAR(4000) = ERROR_MESSAGE();  
	        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();  
	        DECLARE @ErrorState INT = ERROR_STATE();  
			THROW 51000,@ErrorMsg,1;
			--RAISERROR(@ErrorMsg, @ErrorSeverity, @ErrorState);  --RAISERROR NOT SUPPORTED BY XACT_ABORT
	END CATCH
GO
