IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_BulkUpdateContact')
	DROP PROCEDURE usp_BulkUpdateContact
GO
IF EXISTS (SELECT * FROM sys.types WHERE name = 'type_BulkUpdate')
	DROP TYPE type_BulkUpdate
GO
CREATE TYPE type_BulkUpdate AS TABLE
(
	UserId			int,
	FirstName		nvarchar(100),
	MiddleName		nvarchar(100),
    LastName		nvarchar(100),
	PhoneNumber		nvarchar(100),
    Gender			nvarchar(100)    
)
GO
CREATE PROCEDURE	usp_BulkUpdateContact
(
	@dtContactsForUpdating type_BulkUpdate READONLY
)
AS
SET NOCOUNT OFF
SET XACT_ABORT ON --FORCE ROLLBACK IF RUNTIME ERROR OCCURS
	
	BEGIN TRY
		BEGIN TRANSACTION 
				
				MERGE INTO ContactList con
				USING @dtContactsForUpdating dtc
				ON con.UserId = dtc.UserId
				WHEN MATCHED THEN
				UPDATE SET	con.FirstName = dtc.FirstName,
							con.MiddleName = dtc.MiddleName,
							con.LastName = dtc.LastName,
							con.PhoneNumber = dtc.PhoneNumber,
							con.Gender = dtc.Gender;


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