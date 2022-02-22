IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_BulkSaveContact')
	DROP PROCEDURE usp_BulkSaveContact
GO
IF EXISTS (SELECT * FROM sys.types WHERE name = 'type_BulkSave')
	DROP TYPE type_BulkSave
GO
CREATE TYPE type_BulkSave AS TABLE
(
	FirstName		nvarchar(100),
	MiddleName		nvarchar(100),
    LastName		nvarchar(100),
	Mobile			nvarchar(100),
    Gender			nvarchar(100)    
)
GO
CREATE PROCEDURE	usp_BulkSaveContact
(
	@CreatedBy NVARCHAR(100),
	@dtContactsForSaving type_BulkSave READONLY
)
AS
SET NOCOUNT OFF
SET XACT_ABORT ON --FORCE ROLLBACK IF RUNTIME ERROR OCCURS
	
	BEGIN TRY
		BEGIN TRANSACTION 

				INSERT INTO Contacts(
										FirstName,
										MiddleName,
										LastName,
										Mobile,
										Gender
										
									)
					
						SELECT 
								FirstName,
								MiddleName,
								LastName,
								Mobile,
								Gender

						FROM @dtContactsForSaving


				

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
