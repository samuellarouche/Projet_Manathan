USE MASTER
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_Texcel')
DROP DATABASE BD_Texcel

GO
CREATE DATABASE BD_Texcel ON PRIMARY
(NAME = 'BD_Texcel_ppal', FILENAME = 'c:\BD\BD_Texcel_ppal.mdf', SIZE = 10MB, MAXSIZE = UNLIMITED, FILEGROWTH = 1MB)
LOG ON
(NAME = 'BD_Texcel_log', FILENAME = 'c:\BD\BD_Texcel_log.ldf', SIZE = 5MB, MAXSIZE = 25MB, FILEGROWTH = 10%)
GO


-- Cr�ation des tables concernant les employ�es 

PRINT('Cr�ation de la table tblAdministrateur')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblAdministrateur') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblAdministrateur

CREATE TABLE tblAdministrateur		(nom					varchar(10)			NOT NULL,
									 prenom					varchar(10)			NOT NULL,
									 dateNaissance			date				NOT NULL,
									 adresse				varchar(40)			NOT NULL,
									 telResidentiel			char(10)			NOT NULL,
									 posteTelephonique		char(5)				NOT NULL,
									 matricule				char(8)				NOT NULL,
									 categorieEmploye		char(10)			NOT NULL
									);
GO


PRINT('Cr�ation de la table tblChef')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblChef') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblChef

CREATE TABLE tblChef		(nom					varchar(10)			NOT NULL,
							 prenom					varchar(10)			NOT NULL,
							 dateNaissance			date				NOT NULL,
							 adresse				varchar(40)			NOT NULL,
							 telResidentiel			char(10)			NOT NULL,
							 posteTelephonique		char(5)				NOT NULL,
							 matricule				char(8)				NOT NULL,
							 categorieEmploye		char(10)			NOT NULL
							);
GO


PRINT('Cr�ation de la table tblDirecteur')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblDirecteur') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblDirecteur

CREATE TABLE tblDirecteur		(nom					varchar(10)			NOT NULL,
								 prenom					varchar(10)			NOT NULL,
								 dateNaissance			date				NOT NULL,
								 adresse				varchar(40)			NOT NULL,
								 telResidentiel			char(10)			NOT NULL,
								 posteTelephonique		char(5)				NOT NULL,
								 matricule				char(8)				NOT NULL,
								 categorieEmploye		char(10)			NOT NULL
								);
GO


PRINT('Cr�ation de la table tblEmploye')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblEmploye') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblEmploye

CREATE TABLE tblEmploye		(nom					varchar(10)			NOT NULL,
							 prenom					varchar(10)			NOT NULL,
							 dateNaissance			date				NOT NULL,
							 adresse				varchar(40)			NOT NULL,
							 telResidentiel			char(10)			NOT NULL,
							 posteTelephonique		char(5)				NOT NULL,
							 matricule				char(8)				NOT NULL,
							 categorieEmploye		char(10)			NOT NULL
							);
GO


/* PRINT('Cr�ation de la table tblEquipe')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblEquipe') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblEquipe

CREATE TABLE tblEquipe		(
							);
GO */


PRINT('Cr�ation de la table tblTesteur')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblTesteur') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblTesteur

CREATE TABLE tbltesteur		(nom					varchar(10)			NOT NULL,
							 prenom					varchar(10)			NOT NULL,
							 dateNaissance			date				NOT NULL,
							 adresse				varchar(40)			NOT NULL,
							 telResidentiel			char(10)			NOT NULL,
							 posteTelephonique		char(5)				NOT NULL,
							 matricule				char(8)				NOT NULL,
							 categorieEmploye		char(10)			NOT NULL
							);
GO


-- Cr�ation des tables pour les jeux

PRINT('Cr�ation de la table tblJeux')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblJeux') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblJeux

CREATE TABLE tblJeux		(nom				varchar(25),
							 developpeur		varchar(15),
							 descriptionJeu		varchar(50),
							 configMin			varchar(50)
							);
GO


PRINT('Cr�ation de la table tblOS')
-- ----------------------------------------------------------
USE BD_Texcel
GO
IF OBJECT_ID('BD_Texcel.dbo.tblOS') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblOS

CREATE TABLE tblOS		(nom					varchar(10)				NOT NULL,
						 versionOS				varchar(10)				NOT NULL,
						 code					char(10)				NOT NULL,
						 edition				varchar(20)				NOT NULL		
						);
GO


-- Cr�ation des table pour les tests
PRINT('Cr�ation de la table tblPlateforme')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblPlateforme') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblPlateforme

CREATE TABLE tblPlateforme		(nom							varchar(15)						NOT NULL,
								 configuration					varchar(25)						NOT NULL,
								 typeConfiguration				varchar(20)						NOT NULL
								);
GO


/* PRINT('Cr�ation de la table tblTypeTests')
-- ----------------------------------------------------------
USE BD_Texcel
GO

IF OBJECT_ID('BD_Texcel.dbo.tblTypeTests') IS NOT NULL
DROP TABLE BD_Texcel.dbo.tblTypeTests

CREATE TABLE tblTypeTests		(
									);
GO */


