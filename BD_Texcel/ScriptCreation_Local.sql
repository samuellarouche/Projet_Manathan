USE MASTER
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_Texcel_SAM_FRAN')
DROP DATABASE BD_Texcel_SAM_FRAN

GO
CREATE DATABASE BD_Texcel_SAM_FRAN
GO

USE BD_Texcel_SAM_FRAN
GO

/*-- Cr�ation des tables concernant les employ�es*/
GO
PRINT('Cr�ation de la table tblEmploye')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblEmploye') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblEmploye
CREATE TABLE tblEmploye		(matricule				varchar(200)	UNIQUE	NOT NULL,
							 PRIMARY KEY([matricule]),
							 nom					varchar(50)				NOT NULL,
							 prenom					varchar(50)				NOT NULL,
							 dateNaissance			date					NOT NULL,
							 adresse				varchar(50)				NOT NULL,
							 telResidentiel			varchar(50)				NOT NULL,
							 posteTelephonique		varchar(5)				NOT NULL,
							 titreEmploye			varchar(50)				NOT NULL,
							 motPasse				varchar(50)				NOT NULL,
							 tagEmploye				varchar(505)			NULL
							);
GO

PRINT('Cr�ation de la table tblEquipe')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblEquipe') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblEquipe
CREATE TABLE tblEquipe		(codeEquipe int IDENTITY(1,1)	NOT NULL,
							 PRIMARY KEY(codeEquipe),
							 nomEquipe  varchar(50)			NOT NULL,
							);
GO

PRINT('Cr�ation de la table tblEquipeEmploye')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblEquipeEmploye') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblEquipeEmploye
CREATE TABLE tblEquipeEmploye		(codeEquipe	 int	NOT NULL,
									 matricule	 varchar(200)	NOT NULL,
									 PRIMARY KEY(codeEquipe, matricule)
									 );
GO

PRINT('Cr�ation de la table tblEquipeTest')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblEquipeTest') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblEquipeTest
CREATE TABLE tblEquipeTest	(codeEquipe int	NOT NULL,
							 codeTest	int	NOT NULL,
							 PRIMARY KEY(codeEquipe, codeTest)
							);
GO

PRINT('Cr�ation de la table tblJeu')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblJeu') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblJeu
CREATE TABLE tblJeu			(codeJeu			int IDENTITY(1,1)		NOT NULL,
							 PRIMARY KEY(codeJeu),
							 nom				varchar(50) UNIQUE		NOT NULL,
							 developpeur		varchar(50)				NOT NULL,
							 descriptionJeu		varchar(50)				NOT NULL,
							 configMin			varchar(50)				NOT NULL,
							 codeclassification	int						NOT NULL,
							 codeGenre	int								NOT NULL,
							 codeTheme	int								NOT NULL,
							 codeJeuAssocie		int						NULL,
							 nomJeuAssocie		varchar(50)				NULL,
							 tagJeu			varchar(200)				NULL
							);
GO

PRINT('Cr�ation de la table tblOS')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblOS') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblOS
CREATE TABLE tblOS		(nom					varchar(50)				NOT NULL,
						 versionOS				varchar(50)				NOT NULL,
						 codeOS					varchar(50)				NOT NULL,
						 PRIMARY KEY(codeOS),
						 edition				varchar(50)				NOT NULL,
						 tagOS					varchar(200)			NULL,	
						);
GO

PRINT('Cr�ation de la table tblPlateforme')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblPlateforme') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblPlateforme
CREATE TABLE tblPlateforme		(
								 nom							varchar(50) UNIQUE				NOT NULL,
								 configuration					varchar(50)						NOT NULL,
								 typeConfiguration				varchar(50)						NOT NULL,
								 codePlateforme					int IDENTITY(1,1)				NOT NULL,
								 PRIMARY KEY(codePlateforme),
								 codeOS							varchar(50)						NOT NULL,
								 tagPlateforme					varchar(200)						NULL
								);
GO

PRINT('Cr�ation de la table tblPlateformeJeux')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblPlateformeJeu') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblPlateformeJeu
CREATE TABLE tblPlateformeJeu	(
								 codePlateforme	int	NOT NULL,
								 codeJeu	int	NOT NULL,
								 PRIMARY KEY(codePlateforme, codeJeu)
								);
GO 

PRINT('Cr�ation de la table tblTypeTests')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblTypeTests') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblTypeTests
CREATE TABLE tblTypeTests		(
								 codeType int IDENTITY(1,1)	NOT NULL,
								 PRIMARY KEY(codeType),
								 categorie	varchar(50)		NOT NULL,
								 descriptionCategorie	varchar(50)
								);
GO 

PRINT('Cr�ation de la table tblTest')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblTest') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblTest
CREATE TABLE tblTest			(
								 codeTest	int IDENTITY(1,1)	NOT NULL,
								 PRIMARY KEY(codeTest),
								 nom	varchar(50)				NOT NULL,
								 descriptionTest	varchar(50),
								 codeType int					NOT NULL
								);
GO 

PRINT('Cr�ation de la table tblProjetTest')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblProjetTest') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblProjetTest
CREATE TABLE tblProjetTest		(
								 codeProjetTest	int IDENTITY(1,1)	NOT NULL,
								 PRIMARY KEY(codeProjetTest),
								 codeJeu		int	NOT NULL
								);
GO 


PRINT('Cr�ation de la table tblTestProjetTest')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblTestProjetTest') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblTestProjetTest
CREATE TABLE tblTestProjetTest	(
								 codeProjetTest	int	NOT NULL,
								 codeTest	int	NOT NULL,
								 PRIMARY KEY(codeProjetTest, codeTest)
								);
GO 

PRINT('Cr�ation de la table tblTheme')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblTheme') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblTheme
CREATE TABLE tblTheme			(
								 codeTheme	int IDENTITY(1,1)	NOT NULL,
								 PRIMARY KEY(codeTheme),
								 nomTheme	varchar(50)			NOT NULL,
								 descriptionTheme	varchar(50) NULL,
								 tagTheme			varchar(150)NULL
								);
GO 

PRINT('Cr�ation de la table tblGenre')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblGenre') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblGenre
CREATE TABLE tblGenre			(
								 codeGenre	int IDENTITY(1,1)	NOT NULL,
								 PRIMARY KEY(codeGenre),
								 nomGenre	varchar(50)			NOT NULL,
								 descriptionGenre	varchar(50)		NULL,
								 tagGenre			varchar(150)	NULL
								);
GO 

PRINT('Cr�ation de la table tblClassification')
-- ----------------------------------------------------------
IF OBJECT_ID('BD_Texcel_SAM_FRAN.dbo.tblClassification') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblClassification
CREATE TABLE tblClassification			(
										 codeClassification	int IDENTITY(1,1)	NOT NULL,
										 PRIMARY KEY(codeclassification),
										 nomClassification	varchar(50)			NOT NULL,
										 descriptionClassification	varchar(50)		NULL,
										 tagClassification		varchar(150)		NULL
										);

--use master

--alter database BD_Texcel_SAM_FRAN set single_user with rollback immediate

--restore database BD_Texcel_SAM_FRAN 

--alter database BD_Texcel_SAM_FRAN set multi_user