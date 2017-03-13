USE MASTER
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_Texcel')
DROP DATABASE BD_Texcel

GO
CREATE DATABASE BD_Texcel/*ON PRIMARY
(NAME = 'BD_Texcel_ppal', FILENAME = 'c:\BD\BD_Texcel_ppal.mdf', SIZE = 10MB, MAXSIZE = UNLIMITED, FILEGROWTH = 1MB)
LOG ON
(NAME = 'BD_Texcel_log', FILENAME = 'c:\BD\BD_Texcel_log.ldf', SIZE = 5MB, MAXSIZE = 25MB, FILEGROWTH = 10%)
GO*/


/*-- Création des tables concernant les employées*/
GO
PRINT('Création de la table tblEmploye')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblEmploye') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblEmploye

CREATE TABLE tblEmploye		(matricule				varchar(1000)		NOT NULL,
							 PRIMARY KEY([matricule]),
							 nom					varchar(50)			NOT NULL,
							 prenom					varchar(50)			NOT NULL,
							 dateNaissance			datetime			NOT NULL,
							 adresse				varchar(50)			NOT NULL,
							 telResidentiel			varchar(50)			NOT NULL,
							 posteTelephonique		varchar(5)			NOT NULL,
							 titreEmploye			varchar(50)			NOT NULL,
							 categorieEmploye		varchar(50)			NOT NULL,
							 motPasse				varchar(50)			NOT NULL
							);
GO


PRINT('Création de la table tblEquipe')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblEquipe') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblEquipe

CREATE TABLE tblEquipe		(codeEquipe VARCHAR(50)	NOT NULL,
							 PRIMARY KEY(codeEquipe),
							 matricule	varchar(1000)	NULL
							);
GO

PRINT('Création de la table tblEquipeTest')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblEquipeTest') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblEquipeTest

CREATE TABLE tblEquipeTest	(codeEquipe VARCHAR(50)	NOT NULL,
							 codeTest	varchar(50)	NOT NULL,
							 PRIMARY KEY(codeEquipe, codeTest)
							);
GO


-- Création des tables pour les jeux

PRINT('Création de la table tblJeux')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblJeux') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblJeux

CREATE TABLE tblJeux		(codeJeux			varchar(50)		NOT NULL,
							 PRIMARY KEY(codeJeux),
							 nom				varchar(50)		NOT NULL,
							 developpeur		varchar(50)		NOT NULL,
							 descriptionJeu		varchar(50)		NOT NULL,
							 configMin			varchar(50)		NOT NULL,
							 codeclassification	varchar(50)		NOT NULL,
							 codeGenre	varchar(50)				NOT NULL,
							 codeTheme	varchar(50)				NOT NULL
							);
GO


PRINT('Création de la table tblOS')
-- ----------------------------------------------------------
USE BD_Texcel
GO
IF OBJECT_ID('BD_Texcel.dbo.tblOS') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblOS

CREATE TABLE tblOS		(codeOS					varchar(50)				NOT NULL,
						 PRIMARY KEY(codeOS),
						 nom					varchar(50)				NOT NULL,
						 versionOS				varchar(50)				NOT NULL,
						 edition				varchar(50)				NOT NULL		
						);
GO


-- Création des table pour les tests
PRINT('Création de la table tblPlateforme')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblPlateforme') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblPlateforme

CREATE TABLE tblPlateforme		(
								 codePlateforme					varchar(50)						NOT NULL,
								 PRIMARY KEY(codePlateforme),
								 nom							varchar(50)						NOT NULL,
								 configuration					varchar(50)						NOT NULL,
								 typeConfiguration				varchar(50)						NOT NULL,
								 codeOS							varchar(50)						NOT NULL
								);
GO


PRINT('Création de la table tblPlateformeJeux')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblPlateformeJeux') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblPlateformeJeux

CREATE TABLE tblPlateformeJeux	(
								 codePlateforme	varchar(50)	NOT NULL,
								 codeJeux	varchar(50)	NOT NULL,
								 PRIMARY KEY(codePlateforme, codeJeux)
								);
GO 


PRINT('Création de la table tblTypeTests')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblTypeTests') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblTypeTests

CREATE TABLE tblTypeTests		(
								 codeType varchar(50)	NOT NULL,
								 PRIMARY KEY(codeType),
								 categorie	varchar(50)		NOT NULL,
								 descriptionCategorie	varchar(50)
								);
GO 


PRINT('Création de la table tblTest')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblTest') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblTest

CREATE TABLE tblTest			(
								 codeTest	varchar(50)	NOT NULL,
								 PRIMARY KEY(codeTest),
								 Nom	varchar(50)		NOT NULL,
								 descriptionTest	varchar(50),
								 codeType varchar(50)	NOT NULL
								);
GO 

PRINT('Création de la table tblProjetTest')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblProjetTest') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblProjetTest

CREATE TABLE tblProjetTest		(
								 codeProjetTest	varchar(50)	NOT NULL,
								 PRIMARY KEY(codeProjetTest),
								 codeJeux			varchar(50)		NOT NULL
								);
GO 


PRINT('Création de la table tblTestProjetTest')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblTestProjetTest') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblTestProjetTest

CREATE TABLE tblTestProjetTest	(
								 codeProjetTest	varchar(50)	NOT NULL,
								 codeTest	varchar(50)	NOT NULL,
								 PRIMARY KEY(codeProjetTest, codeTest)
								);
GO 


PRINT('Création de la table tblTheme')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblTheme') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblTheme

CREATE TABLE tblTheme			(
								 codeTheme	varchar(50)	NOT NULL,
								 PRIMARY KEY(codeTheme),
								 nomTheme	varchar(50)	NOT NULL,
								 descriptionTheme	varchar(50) NULL
								);
GO 

PRINT('Création de la table tblGenre')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblGenre') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblGenre

CREATE TABLE tblGenre			(
								 codeGenre	varchar(50)	NOT NULL,
								 PRIMARY KEY(codeGenre),
								 nomGenre	varchar(50)	NOT NULL,
								 descriptionGenre	varchar(50) NULL

								);
GO 

PRINT('Création de la table tblClassification')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblClassification') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblClassification

CREATE TABLE tblClassification			(
										 codeclassification	varchar(50)	NOT NULL,
										 PRIMARY KEY(codeclassification),
										 nomClassification	varchar(50)	NOT NULL,
										 descriptionClassification	varchar(50) NULL
										);
GO 