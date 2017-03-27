USE BD_Texcel_SAM_FRAN
GO

-- Insertion dans tblClassification
INSERT dbo.tblClassification (nomClassification, descriptionClassification) VALUES ('Secret','Top secret')
GO
-- Insertion dans tblGenre
INSERT dbo.tblGenre (nomGenre, descriptionGenre) VALUES ('Masculin','épais')
GO
-- Insertion dans tblTheme
INSERT dbo.tblTheme (nomTheme, descriptionTheme) VALUES ('Jurassic park','Park de jurassique')
GO
-- Insertion dans tblOS
INSERT dbo.tblOS (nom, versionOS, codeOS, edition) VALUES ('Android','6.0.1','SAM2TT','Limité')
GO
-- Insertion dans tblPlateforme
INSERT dbo.tblPlateforme (nom, configuration, typeConfiguration,codeOS) VALUES ('Samsung','2T','très grande place','SAM2TT')
GO
-- Insertion dans tblJeu
INSERT dbo.vueJeu (nom, developpeur, descriptionJeu, configMin, nomClassification, nomGenre, nomTheme, nomJeuAssocie) VALUES ('Game of Thumbs','Totema','fight de pouce epic','un ami et un pouce', 'Masculin', 'Jurassic park', '1', '')
GO
-- Insertion dans tblProjetTest
INSERT dbo.tblProjetTest (codeJeu) VALUES ('1')
GO
-- Insertion dans tblTypeTests
INSERT dbo.tblTypeTests (categorie, descriptionCategorie) VALUES ('video','test les graphique')
GO
-- Insertion dans tblTest
INSERT dbo.tblTest (nom, descriptionTest, codeType) VALUES ('mur','test les mur pour la resistance','1')
GO
-- Insertion dans tblEmploye
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('admin','admin','Mr','2005-04-8','1800 admin avenue','1-800-ADMIN','ADMIN','Administrateur','admin')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('directeur1','directeur','Mr','2005-04-8','1800 directeur avenue','1-800-DIRECTEUR','DIREC','Directeur','directeur')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('directeur2','Matin','Martin','2005-04-8','1800 directeur avenue','1-800-DIRECTEUR','DIREC','Directeur','directeur')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('directeur3','Luther','Mr','2005-04-8','1800 directeur avenue','1-800-DIRECTEUR','DIREC','Directeur','directeur')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('directeur4','King','Mr','2005-04-8','1800 directeur avenue','1-800-DIRECTEUR','DIREC','Directeur','directeur')
GO
-- Insertion dans tblEquipe
INSERT dbo.tblEquipe (nomEquipe) VALUES ('Admin et Directeur')
GO