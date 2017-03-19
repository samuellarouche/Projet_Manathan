USE BD_Texcel_SAM_FRAN
GO

-- Insertion dans tblClassification
INSERT dbo.tblClassification (nomClassification, descriptionClassification) VALUES ('nomClass','descClass')
GO
-- Insertion dans tblGenre
INSERT dbo.tblGenre (nomGenre, descriptionGenre) VALUES ('nomGenre','descGenre')
GO
-- Insertion dans tblTheme
INSERT dbo.tblTheme (nomTheme, descriptionTheme) VALUES ('nomTheme','desctheme')
GO
-- Insertion dans tblOS
INSERT dbo.tblOS (nom, versionOS, codeOS, edition) VALUES ('nom','versionOS','codeOs','edition')
GO
-- Insertion dans tblPlateforme
INSERT dbo.tblPlateforme (nom, configuration, typeConfiguration,codeOS) VALUES ('nom','config','typeconfig','codeOS')
GO
-- Insertion dans tblJeux
INSERT dbo.tblJeux (nom, developpeur, descriptionJeu, configMin, codeclassification, codeGenre, codeTheme) VALUES ('nom','dev','desc','configmin', '1', '1', '1')
GO
-- Insertion dans tblProjetTest
INSERT dbo.tblProjetTest (codeJeux) VALUES ('1')
GO
-- Insertion dans tblTypeTests
INSERT dbo.tblTypeTests (categorie, descriptionCategorie) VALUES ('cat','desCat')
GO
-- Insertion dans tblTest
INSERT dbo.tblTest (nom, descriptionTest, codeType) VALUES ('nom','desc','1')
GO
-- Insertion dans tblEmploye
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('matricule','nom','prenom','2005-04-8','adresse','telRes','12345','Administrateur','motPasse')
GO
-- Insertion dans tblEquipe
INSERT dbo.tblEquipe (matricule) VALUES ('matricule')
GO