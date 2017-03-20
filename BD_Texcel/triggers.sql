USE BD_Texcel_SAM_FRAN
GO

IF OBJECT_ID('AjoutJeux') IS NOT NULL
DROP TRIGGER AjoutJeux
GO

CREATE TRIGGER AjoutJeux ON vueJeux INSTEAD OF INSERT AS

BEGIN 
		DECLARE @nom as varchar(50),
		 @developpeur as varchar(50),
		 @descriptionJeu as varchar(50),
		 @configMin as varchar(50),
		 @codeClassification as varchar(50),
		 @codeGenre as varchar(50),
		 @codeTheme as varchar(50),
		 @codePlateforme as varchar(50),
		 @codeJeux as varchar(50)
		 
		
		SELECT @nom = nom, @developpeur = developpeur, @descriptionJeu = descriptionJeu, @configMin = configMin, @codeClassification = (SELECT codeClassification FROM tblClassification), @codeGenre = (SELECT codeGenre FROM tblGenre), @codeTheme = (SELECT codeTheme FROM tblTheme), @codePlateforme = (SELECT codePlateforme	FROM tblPlateforme)
		FROM inserted;

		
		INSERT dbo.tblJeux (nom, developpeur, descriptionJeu, configMin, codeclassification, codeGenre, codeTheme) VALUES (@nom,@developpeur,@descriptionJeu,@configMin,@codeClassification,@codeGenre,@codeTheme)
		SELECT @codeJeux = codeJeux
		FROM tblJeux
		WHERE nom = @nom
		INSERT dbo.tblPlateformeJeux (codeJeux, codePlateforme) VALUES (@codeJeux , @codePlateforme)  
END

INSERT dbo.vueJeux (nom, developpeur, descriptionJeu, configMin, nomGenre, nomClassification , nomTheme) VALUES ('sdfhgntAATEJ','phil','ceci est un train','pas de configmin', 'nomGenre' , 'nomTheme', 'nomClass')
GO

SELECT *
FROM tblJeux

SELECT *
FROM tblPlateformeJeux

SELECT  * 
FROM vueJeux



