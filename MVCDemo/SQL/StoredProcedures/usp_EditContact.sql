IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EditContact')
	DROP PROCEDURE usp_EditContact
GO

CREATE PROCEDURE	usp_EditContact
(
	@UserId				INT,
	@FirstName		nvarchar(255),
	@MiddleName		nvarchar(255),
	@LastName		nvarchar(255),
	@PhoneNumber			nvarchar(255),
	@Gender			nvarchar(10)
)
AS
SET NOCOUNT OFF
	
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM ContactList WHERE firstName = @firstName and 
		middleName = @middleName and lastName = @lastName and gender = @gender and PhoneNumber = @PhoneNumber)
			BEGIN TRANSACTION 
	
				----ADD CREATEDBY and CREATEDATETIME(TIMESTAMP)
					UPDATE		Contacts SET
					FirstName	= @FirstName,
					MiddleName	= @MiddleName,
					LastName	= @LastName,
					Mobile		= @PhoneNumber,
					Gender		= @Gender
					where UserId	= @UserId

			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
GO