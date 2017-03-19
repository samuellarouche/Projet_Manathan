USE BD_Texcel_SAM_FRAN
GO

IF OBJECT_ID('AjoutOS') IS NOT NULL
DROP TRIGGER AjoutOS
GO

CREATE TRIGGER AjoutOS ON tblOS INSTEAD OF INSERT AS

BEGIN 
		DECLARE @nom as varchar(50)
		DECLARE @versionOS as varchar(50)
		DECLARE @codeOS as varchar(50)
		DECLARE @edition as varchar(50)
		DECLARE @tagOS	as varchar(200)
		
		SELECT @nom = nom, @versionOS = versionOS, @codeOS = codeOS, @edition = edition
		FROM inserted;
		SELECT CONCAT(@nom,@versionOS,@codeOS,@edition)

END

INSERT dbo.vueOS (nom, versionOS, codeOS, edition) VALUES ('nom','versionOS','codeOs','edition')
GO
