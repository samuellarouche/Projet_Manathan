USE BD_Texcel_SAM_FRAN
GO


INSERT dbo.tblClassification (nomClassification, descriptionClassification) VALUES ('M','Jeunes Adultes ')
GO

INSERT dbo.tblGenre (nomGenre, descriptionGenre) VALUES ('Medieval','pouce chevalier')
GO

INSERT dbo.tblTheme (nomTheme, descriptionTheme) VALUES ('Fanta','Fantastique')
GO

INSERT dbo.tblOS (nom, versionOS, codeOS, edition) VALUES ('Windows 10','7.4.5.3','WIN10PRO','PRO')
GO

INSERT dbo.tblPlateforme (nom, configuration, typeConfiguration,codeOS) VALUES ('PC','Rapide','Beginner','WIN10PRO')
GO

INSERT dbo.tblJeux (nom, developpeur, descriptionJeu, configMin, codeclassification, codeGenre, codeTheme) VALUES ('Game of Thumbs','Totema Studio','gerre des pouce','1 ami et 1 pouce', '1', '1', '1')
GO

INSERT dbo.tblProjetTest (codeJeux) VALUES ('1')
GO

INSERT dbo.tblTypeTests (categorie, descriptionCategorie) VALUES ('som','test de son')
GO

INSERT dbo.tblTest (nom, descriptionTest, codeType) VALUES ('Son supersonic','tester le son pour savoir si un danger est','1')
GO

INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('admin','Sioud','Aymen','2005-04-8','3505 Rue Fortin','418-695-1976','12345','Administrateur','Salut123')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('directeur','Dalaire','Eric','2005-04-8','3505 Rue Fortin','418-695-1976','12345','Directeur','Salut123')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('admin2','Dalaire','Eric','2005-04-8','3505 Rue Fortin','418-695-1976','12345','Directeur','Salut123')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('admin3','Dalaire','Eric','2005-04-8','3505 Rue Fortin','418-695-1976','12345','Directeur','Salut123')
GO
INSERT dbo.tblEmploye (matricule, nom, prenom, dateNaissance, adresse, telResidentiel, posteTelephonique, titreEmploye, motPasse) VALUES ('directeur2','Dalaire','Eric','2005-04-8','3505 Rue Fortin','418-695-1976','12345','Directeur','Salut123')
GO

INSERT dbo.tblEquipe (matricule, nomEquipe, tache) VALUES ('admin', 'Manathan God', 'Testeur')
GO
INSERT dbo.tblEquipe (matricule, nomEquipe, tache) VALUES ('directeur', 'Manathan God', 'Testeur')
GO
INSERT dbo.tblEquipe (matricule, nomEquipe, tache) VALUES ('admin2', 'Manathan God', 'Testeur')
GO
INSERT dbo.tblEquipe (matricule, nomEquipe, tache) VALUES ('admin3', 'Manathan God', 'Testeur')
GO
INSERT dbo.tblEquipe (matricule, nomEquipe, tache) VALUES ('directeur2', 'Manathan God', 'Testeur')
GO