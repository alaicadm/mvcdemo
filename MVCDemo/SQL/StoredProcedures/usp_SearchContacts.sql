
IF EXISTS (SELECT * FROM SYS.PROCEDURES WHERE NAME = 'usp_SearchContacts')
	DROP PROCEDURE usp_SearchContacts
GO
CREATE PROCEDURE usp_SearchContacts
(
	@Keyword nvarchar(255) = null
)
AS 
BEGIN
		SELECT	UserId,
				FirstName,
				MiddleName,
				LastName,
				Mobile,
				Gender 
		FROM	Contacts
		WHERE	(
					FirstName like '%'+@Keyword+'%'
					OR
					MiddleName like '%'+@Keyword+'%'
					OR
					LastName like '%'+@Keyword+'%'
					OR
					Mobile like '%'+@Keyword+'%'
				)
				
END
GO
