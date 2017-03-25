USE BD_Texcel_SAM_FRAN
GO

-- --------------------------------------------------------------------------------------------------------
-- Un trigger permettant de suprimmer un jeu � partir de la vue vueJeux (Plusieurs table dans la m�me vue.)
-- --------------------------------------------------------------------------------------------------------
IF OBJECT_ID('trigger_DeleteJeu') IS NOT NULL
DROP TRIGGER trigger_DeleteJeu
GO
CREATE TRIGGER trigger_DeleteJeu ON vueJeu INSTEAD OF DELETE AS
BEGIN
	DECLARE @nom AS varchar(50)

	SELECT @nom = nom
	FROM deleted

	-- Supprime le jeu associ�.
	UPDATE tblJeu SET codeJeuAssocie = NULL, nomJeuAssocie = NULL
	WHERE nomJeuAssocie = @nom

	DELETE FROM tblJeu WHERE nom = @nom
END
GO

-- -------------------------------------------------------------------------------------------------------------------------
-- Un trigger permettant d'ins�rer les informations dans la table d'intersection tblPlateformeJeux lors de l'ajout d'un jeu.
-- -------------------------------------------------------------------------------------------------------------------------
IF OBJECT_ID('trigger_InsertJeuIntersection') IS NOT NULL
DROP TRIGGER trigger_InsertJeuIntersection
GO
CREATE TRIGGER trigger_InsertJeuIntersection ON vueJeu INSTEAD OF INSERT AS
BEGIN
	DECLARE @nomPlateforme AS varchar(50),	@nomJeu AS varchar(50),		@developpeur AS varchar(50),
			@description AS varchar(50),	@configMin AS varchar(50),	@nomTheme AS varchar(50),
			@nomClass AS varchar(50),		@nomGenre AS varchar(50),	@nomJeuAssocie AS varchar(50),
			@codeClass AS int,				@codeGenre AS int,			@codeTheme AS int,
			@codePlateforme AS int,			@codeJeu AS int,			@codeJeuAssocie AS int

	-- R�cup�re les donn�es ins�r�es.
	SELECT @nomPlateforme = nomPlateforme, @nomJeu = nom, @developpeur = developpeur, @description = descriptionJeu,
		   @configMin = configMin, @nomClass = nomClassification, @nomTheme = nomTheme, @nomGenre = nomGenre, @nomJeuAssocie = nomJeuAssocie
	FROM inserted

	-- R�cup�re les codes (genre, th�me, classification, jeu associ�) selon les noms ins�r�s.
	SELECT @codeClass = codeClassification
	FROM tblClassification
	WHERE nomClassification = @nomClass

	SELECT @codeGenre = codeGenre
	FROM tblGenre
	WHERE nomGenre = @nomGenre

	SELECT @codeTheme = codeTheme
	FROM tblTheme
	WHERE nomTheme = @nomTheme

	SELECT @codeJeuAssocie = codeJeu
	FROM tblJeu
	WHERE nom = @nomJeuAssocie

	-- Ins�re les informations dans la table tblJeux.
	IF @codeJeuAssocie <> ''
		INSERT INTO tblJeu (nom, developpeur, descriptionJeu, configMin, codeClassification, codeGenre, codeTheme, codeJeuAssocie, nomJeuAssocie) VALUES(@nomJeu, @developpeur, @description, @configMin, @codeClass, @codeGenre, @codeTheme, @codeJeuAssocie, @nomJeuAssocie);
	ELSE
		INSERT INTO tblJeu (nom, developpeur, descriptionJeu, configMin, codeClassification, codeGenre, codeTheme) VALUES(@nomJeu, @developpeur, @description, @configMin, @codeClass, @codeGenre, @codeTheme);

	-- S�lectionne le code plateforme et le code jeux selon leur nom.
	SELECT @codePlateforme = codePlateforme
	FROM vuePlateforme
	WHERE nom = @nomPlateforme

	SELECT @codeJeu = codeJeu
	FROM tblJeu
	WHERE nom = @nomJeu

	-- Ins�re les codes dans la table d'intersection tblPlateformeJeux.
	INSERT INTO tblPlateformeJeu VALUES (@codePlateforme, @codeJeu)
END
GO