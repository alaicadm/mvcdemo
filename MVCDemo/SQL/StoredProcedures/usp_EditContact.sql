IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_EditContact')
	DROP PROCEDURE usp_EditContact
GO

CREATE PROCEDURE	usp_EditContact
(
	@UserId			INT,
	@FirstName		nvarchar(255),
	@MiddleName		nvarchar(255),
	@LastName		nvarchar(255),
	@Mobile			nvarchar(255),
	@Gender			nvarchar(10),
	@UserName		nvarchar(100)
)
AS
SET NOCOUNT OFF
	
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM Contacts WHERE firstName = @firstName and 
		middleName = @middleName and lastName = @lastName and gender = @gender and mobile = @mobile)
			BEGIN TRANSACTION 
	
				----ADD CREATEDBY and CREATEDATETIME(TIMESTAMP)
					UPDATE		Contacts SET
					FirstName	= @FirstName,
					MiddleName	= @MiddleName,
					LastName	= @LastName,
					Mobile		= @Mobile,
					Gender		= @Gender,
					UpdatedDateTime = GETDATE(),
					updatedBy	= @UserName
					where UserId	= @UserId

			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
GO