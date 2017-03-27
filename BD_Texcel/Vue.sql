USE BD_Texcel_SAM_FRAN
GO

IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueJeu') IS NOT NULL
DROP VIEW vueJeu
GO
CREATE VIEW vueJeu AS
SELECT J.codeJeu, J.nom, developpeur, descriptionJeu, configMin, P.nom AS nomPlateforme, nomGenre, nomClassification, nomTheme,codeJeuAssocie, nomJeuAssocie
FROM tblJeu AS J
JOIN tblGenre AS G
ON J.codeGenre=G.codeGenre
JOIN tblClassification AS C
ON J.codeclassification = C.codeclassification
JOIN tblTheme AS T
ON J.codeTheme=T.codeTheme
JOIN tblPlateformeJeu as PJ
ON PJ.codeJeu = J.codeJeu
JOIN tblPlateforme AS P
ON P.codePlateforme = PJ.codePlateforme
GO

SELECT codeJeu, nom, developpeur, descriptionJeu, configMin, nomGenre, nomClassification, nomTheme, nomJeuAssocie,
CONCAT(codeJeu, nom, developpeur, descriptionJeu, configMin, nomGenre, nomClassification, nomTheme, nomJeuAssocie) AS tagJeu
FROM vueJeu

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
CONCAT(nomTheme, descriptionTheme) AS tagTheme
FROM vueTheme

IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueEquipe') IS NOT NULL
DROP VIEW vueEquipe
GO
CREATE VIEW vueEquipe AS
SELECT E.codeEquipe, nomEquipe, T.nom AS nomTest, EM.matricule AS Employe1, EM.matricule AS Employe2, EM.matricule AS Employe3, EM.matricule AS Employe4, EM.matricule AS Employe5
FROM tblEquipe AS E
JOIN tblEquipeEmploye AS EE
ON E.codeEquipe = EE.codeEquipe
JOIN tblEmploye AS EM
ON EE.matricule = EM.matricule
JOIN tblEquipeTest AS ET
ON ET.codeEquipe = E.codeEquipe
JOIN tblTest AS T
ON T.codeTest = ET.codeTest
GO

IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.vueTest') IS NOT NULL
DROP VIEW vueTest
GO
CREATE VIEW vueTest AS
SELECT nom, descriptionTest, codeType
FROM tblTest
GO