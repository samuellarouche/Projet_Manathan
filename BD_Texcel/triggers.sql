USE BD_Texcel_SAM_FRAN
GO

-- --------------------------------------------------------------------
-- Un trigger permettant de suprimmer un jeu à partir de la vue vueJeux
-- --------------------------------------------------------------------
IF OBJECT_ID('trigger_DeleteJeu') IS NOT NULL
DROP TRIGGER trigger_DeleteJeu
GO

CREATE TRIGGER trigger_DeleteJeu ON vueJeux INSTEAD OF DELETE AS
BEGIN
	DECLARE @nom AS varchar(50)

	SELECT @nom = nom
	FROM deleted

	DELETE FROM tblJeux WHERE nom = @nom
END
GO

-- -------------------------------------------------------------------------------------------------------------------------
-- Un trigger permettant d'insérer les informations dans la table d'intersection tblPlateformeJeux lors de l'ajout d'un jeu.
-- -------------------------------------------------------------------------------------------------------------------------
IF OBJECT_ID('trigger_InsertJeuIntersection') IS NOT NULL
DROP TRIGGER trigger_InsertJeuIntersection
GO

CREATE TRIGGER trigger_InsertJeuIntersection ON vueJeux INSTEAD OF INSERT AS
BEGIN
	DECLARE @nomPlateforme AS varchar(50)
	DECLARE @nomJeu AS varchar(50)
	DECLARE @developpeur AS varchar(50)
	DECLARE @description AS varchar(50)
	DECLARE @configMin AS varchar(50)
	DECLARE @nomTheme AS varchar(50)
	DECLARE @nomClass AS varchar(50)
	DECLARE @nomGenre AS varchar(50)
	DECLARE @codeClass AS int
	DECLARE @codeGenre AS int
	DECLARE @codeTheme AS int
	DECLARE @codePlateforme AS int
	DECLARE @codeJeux AS int

	-- Récupère les données insérées.
	SELECT @nomPlateforme = nomPlateforme, @nomJeu = nom, @developpeur = developpeur, @description = descriptionJeu,
		   @configMin = configMin, @nomClass = nomClassification, @nomTheme = nomTheme, @nomGenre = nomGenre
	FROM inserted

	-- Récupère les codes (genre, thème, classification) selon les noms insérés.
	SELECT @codeClass = codeClassification
	FROM tblClassification
	WHERE nomClassification = @nomClass

	SELECT @codeGenre = codeGenre
	FROM tblGenre
	WHERE nomGenre = @nomGenre

	SELECT @codeTheme = codeTheme
	FROM tblTheme
	WHERE nomTheme = @nomTheme

	-- Insère les informations dans la table tblJeux.
	INSERT INTO tblJeux (nom, developpeur, descriptionJeu, configMin, codeClassification, codeGenre, codeTheme) VALUES(@nomJeu, @developpeur, @description, @configMin, @codeClass, @codeGenre, @codeTheme)

	-- Sélectionne le code plateforme et le code jeux selon leur nom.
	SELECT @codePlateforme = codePlateforme
	FROM vuePlateforme
	WHERE nom = @nomPlateforme

	SELECT @codeJeux = codeJeux
	FROM tblJeux
	WHERE nom = @nomJeu

	-- Insère les codes dans la table d'intersection tblPlateformeJeux.
	INSERT INTO tblPlateformeJeux VALUES (@codePlateforme, @codeJeux)
END
GO