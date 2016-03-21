CREATE PROCEDURE spCheckLoginOperator 
	@login VARCHAR(30), 
	@password VARCHAR(40),
	@exists BIT OUTPUT,
	@operatorId INT OUTPUT
AS
SET @exists = 0
If(EXISTS ( SELECT o.Id 
		FROM dbo.tblOperator o
		WHERE o.[Login] = @login and o.[Password] = @password and o.[Disabled] <> 1))
		SET @exists = 1
SELECT @operatorId = Id
	FROM dbo.tblOperator 
	WHERE [Login] = @login
GO