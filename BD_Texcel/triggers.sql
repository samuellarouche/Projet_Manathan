USE BD_Texcel_SAM_FRAN
GO

--IF OBJECT_ID('vueJeuxAll') IS NOT NULL
--DROP TRIGGER vueJeuxAll
--GO

--CREATE TRIGGER vueJeuxAll ON vueJeux INSTEAD OF INSERT AS

--BEGIN 
--		DECLARE @nom as varchar(50),
--		 @developpeur as varchar(50),
--		 @descriptionJeu as varchar(50),
--		 @configMin as varchar(50),
--		 @codeClassification as varchar(50),
--		 @codeGenre as varchar(50),
--		 @codeTheme as varchar(50),
--		 @codePlateforme as varchar(50),
--		 @codeJeux as varchar(50)
		 
		
--		SELECT DISTINCT @nom = nom, @developpeur = developpeur, @descriptionJeu = descriptionJeu, @configMin = configMin, @codeClassification = (SELECT codeClassification FROM tblClassification), @codeGenre = (SELECT codeGenre FROM tblGenre), @codeTheme = (SELECT codeTheme FROM tblTheme), @codePlateforme = (SELECT codePlateforme	FROM tblPlateforme)
--		FROM inserted;

		
--		INSERT dbo.tblJeux (nom, developpeur, descriptionJeu, configMin, codeclassification, codeGenre, codeTheme) VALUES (@nom,@developpeur,@descriptionJeu,@configMin,@codeClassification,@codeGenre,@codeTheme)
--END

GO
IF OBJECT_ID('AjoutPlateformeJeux') IS NOT NULL
DROP TRIGGER AjoutPlateformeJeux
GO

CREATE TRIGGER AjoutPlateformeJeux ON vueJeux INSTEAD OF INSERT AS

BEGIN 
		DECLARE @JeuxNom as varchar(50),
		 @codePlateforme as varchar(50),
		 @codeJeux as varchar(50),
		 @nomPlateforme as varchar(50)
		 
		
		SELECT @codePlateforme = codePlateforme 
		FROM tblPlateforme AS P 
		WHERE P.nom = @nomPlateforme

		SELECT @codeJeux = codeJeux
		FROM tblJeux AS J
		WHERE J.nom = @JeuxNom

		INSERT dbo.tblPlateformeJeux (codeJeux, codePlateforme) VALUES (@codeJeux , @codePlateforme)
END

INSERT dbo.vueJeux(nom, developpeur, descriptionJeu, configMin) VALUES ('gfdsgsdfg','phil','ceci est un train','pas de configmin')
GO

INSERT dbo.tblPlateforme (nom, configuration, typeConfiguration,codeOS) VALUES ('sdaf','config','typeconfig','codeOS')
GO

SELECT *
FROM tblJeux

SELECT *
FROM tblPlateformeJeux

SELECT  * 
FROM vueJeux



