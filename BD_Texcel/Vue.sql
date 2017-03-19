USE BD_Texcel_SAM_FRAN
GO

IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueJeux') IS NOT NULL
DROP VIEW vueJeux
GO
CREATE VIEW vueJeux AS
SELECT codeJeux, nom, developpeur, descriptionJeu, configMin, nomGenre, nomClassification, nomTheme
FROM tblJeux AS J
JOIN tblGenre AS G
ON J.codeGenre=G.codeGenre
JOIN tblClassification AS C
ON J.codeclassification = C.codeclassification
JOIN tblTheme AS T
ON J.codeTheme=T.codeTheme
GO

SELECT codeJeux, nom, developpeur, descriptionJeu, configMin, nomGenre, nomClassification, nomTheme,
CONCAT(codeJeux, nom, developpeur, descriptionJeu, configMin, nomGenre, nomClassification, nomTheme) AS tagJeux
FROM vueJeux


IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vuePlateforme') IS NOT NULL
DROP VIEW vuePlateforme
GO
CREATE VIEW vuePlateforme AS
SELECT *
FROM tblPlateforme
GO

SELECT nom, configuration, typeConfiguration, codePlateforme, codeOS, tagPlateforme,
CONCAT(nom, configuration, typeConfiguration, codePlateforme, codeOS, tagPlateforme) AS tagPlateforme
FROM vuePlateforme


IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueOS') IS NOT NULL
DROP VIEW vueOS
GO
CREATE VIEW vueOS AS
SELECT *
FROM tblOS
GO

SELECT nom, versionOS, codeOS, edition,
CONCAT(nom, versionOS, codeOS, edition) AS tagOS
FROM vueOS


IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueEmploye') IS NOT NULL
DROP VIEW vueEmploye
GO
CREATE VIEW vueEmploye AS
SELECT *
FROM tblEmploye
GO

SELECT matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse,
CONCAT(matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) AS tagEmploye
FROM vueEmploye


IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueClassification') IS NOT NULL
DROP VIEW vueClassification
GO
CREATE VIEW vueClassification AS
SELECT *
FROM tblClassification
GO

SELECT 	nomClassification, descriptionClassification,
CONCAT(nomClassification, descriptionClassification) AS tagClassification
FROM vueClassification


IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueGenre') IS NOT NULL
DROP VIEW vueGenre
GO
CREATE VIEW vueGenre AS
SELECT *
FROM tblGenre
GO

SELECT nomGenre, descriptionGenre,
CONCAT(nomGenre, descriptionGenre) AS tagGenre
FROM vueGenre


IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueTheme') IS NOT NULL
DROP VIEW vueTheme
GO
CREATE VIEW vueTheme AS
SELECT *
FROM tblTheme
GO

SELECT nomTheme, descriptionTheme,
CONCAT(nomGenre, descriptionGenre) AS tagTheme
FROM vueTheme


IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueEquipe') IS NOT NULL
DROP VIEW vueEquipe
GO
CREATE VIEW vueEquipe AS
SELECT *
FROM tblEquipe
GO

SELECT matricule,
CONCAT(matricule) AS tagEquipe
FROM vueEquipe
