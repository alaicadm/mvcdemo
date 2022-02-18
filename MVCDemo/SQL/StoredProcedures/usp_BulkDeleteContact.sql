IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_BulkDeleteContact')
	DROP PROCEDURE usp_BulkDeleteContact
GO

IF EXISTS (SELECT * FROM sys.types WHERE name = 'type_BulkDelete')
	DROP TYPE type_BulkDelete
GO

CREATE TYPE type_BulkDelete AS TABLE
(
	User_ID INT
)

GO
CREATE PROCEDURE usp_BulkDeleteContact
(
	@dtContactsForDelete type_BulkDelete READONLY
)
AS
SET NOCOUNT OFF
SET XACT_ABORT ON 


	BEGIN TRY
		BEGIN TRANSACTION

			
		--DELETE FROM Contacts(
		--		User_ID
		--		)
		UPDATE c
		SET c.FirstName = 'gian'
		
		FROM @dtContactsForDelete dt
		LEFT JOIN Contacts c
		on c.User_ID = dt.User_ID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION


			DECLARE @ErrorNum INT = ERROR_NUMBER();
			DECLARE @ErrorLine INT = ERROR_LINE();
			DECLARE @ErrorMsg NVARCHAR (4000) = ERROR_MESSAGE();
			DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
			DECLARE @ErrorState INT = ERROR_STATE();
			THROW 51000, @ErrorMsg,1;
	END CATCH
GO
	