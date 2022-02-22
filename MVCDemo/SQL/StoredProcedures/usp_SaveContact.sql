IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_SaveContact')
	DROP PROCEDURE usp_SaveContact
GO

CREATE PROCEDURE	usp_SaveContact
(
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
					INSERT INTO Contacts(FirstName,MiddleName,LastName,Mobile,Gender, createdBy)
					values(@FirstName,@MiddleName,@LastName,@Mobile,@Gender, @UserName)

			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
GO