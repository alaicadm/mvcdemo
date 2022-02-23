IF EXISTS (SELECT * FROM sys.procedures WHERE name = 'usp_SaveContact')
	DROP PROCEDURE usp_SaveContact
GO

CREATE PROCEDURE	usp_SaveContact
(
	@FirstName		nvarchar(255),
	@MiddleName		nvarchar(255),
	@LastName		nvarchar(255),
	@PhoneNumber	nvarchar(255),
	@Gender			nvarchar(10)
)
AS
SET NOCOUNT OFF
	
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM ContactList WHERE firstName = @firstName and 
		middleName = @middleName and lastName = @lastName and gender = @gender and PhoneNumber = @PhoneNumber)
			BEGIN TRANSACTION 
	
				----ADD CREATEDBY and CREATEDATETIME(TIMESTAMP)
					INSERT INTO Contacts(FirstName,MiddleName,LastName,PhoneNumber,Gender)
					values(@FirstName,@MiddleName,@LastName,@PhoneNumber,@Gender)

			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
GO