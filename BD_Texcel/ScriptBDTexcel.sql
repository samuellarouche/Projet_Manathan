USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_Texcel_SAM_FRAN')
DROP DATABASE BD_Texcel_SAM_FRAN
GO

CREATE DATABASE BD_Texcel_SAM_FRAN
GO

USE BD_Texcel_SAM_FRAN
GO
/****** Object:  Table dbo.tblAdministrateur    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tblAdministrateur') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblAdministrateur

CREATE TABLE [dbo].[tblAdministrateur](
									   [nom] [varchar](50) NOT NULL,
									   [prenom] [varchar](50) NOT NULL,
									   [dateNaissance] [date] NOT NULL,
									   [adresse] [varchar](50) NOT NULL,
								       [telResidentiel] [varchar](50) NOT NULL,
									   [posteTelephonique] [varchar](5) NOT NULL,
									   [matricule] [varchar](1000) NOT NULL,
									   PRIMARY KEY([matricule]),
									   [categorieEmploye] [varchar](50) NOT NULL,
									   ) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table dbo.tblChef    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tblChef') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblChef

CREATE TABLE [dbo].[tblChef](
							[nom] [varchar](50) NOT NULL,
							[prenom] [varchar](50) NOT NULL,
							[dateNaissance] [date] NOT NULL,
							[adresse] [varchar](50) NOT NULL,
							[telResidentiel] [varchar](50) NOT NULL,
							[posteTelephonique] [varchar](5) NOT NULL,
							[matricule] [varchar](1000) NOT NULL,
							PRIMARY KEY([matricule]),
							[categorieEmploye] [varchar](50) NOT NULL
							) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table dbo.tblDirecteur    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tblDirecteur') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblDirecteur

CREATE TABLE [dbo].[tblDirecteur](
								  [nom] [varchar](50) NOT NULL,
								  [prenom] [varchar](50) NOT NULL,
								  [dateNaissance] [date] NOT NULL,
								  [adresse] [varchar](50) NOT NULL,
								  [telResidentiel] [varchar](50) NOT NULL,
								  [posteTelephonique] [varchar](5) NOT NULL,
								  [matricule] [varchar](1000) NOT NULL,
								  PRIMARY KEY([matricule]),
								  [categorieEmploye] [varchar](50) NOT NULL
								  ) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table dbo.tblEmploye    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO	
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tblEmploye') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblEmploye
CREATE TABLE [dbo].[tblEmploye](
								[nom] [varchar](50) NOT NULL,
								[prenom] [varchar](50) NOT NULL,
								[dateNaissance] [date] NOT NULL,
								[adresse] [varchar](50) NOT NULL,
								[telResidentiel] [varchar](50) NOT NULL,
								[posteTelephonique] [varchar](5) NOT NULL,
								[matricule] [varchar](1000) NOT NULL,
								PRIMARY KEY([matricule]),
								[categorieEmploye] [varchar](50) NOT NULL
								) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table dbo.tblJeux    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tblJeux') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblJeux

CREATE TABLE [dbo].[tblJeux](
							 [nom] [varchar](25) NULL,
							 [developpeur] [varchar](15) NULL,
							 [descriptionJeu] [varchar](50) NULL,
							 [configMin] [varchar](50) NULL
							 ) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table dbo.tblOS    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tblOS') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblOS

CREATE TABLE [dbo].[tblOS](
						   [nom] [varchar](10) NOT NULL,
						   [versionOS] [varchar](10) NOT NULL,
						   [code] [varchar](10) NOT NULL,
						   [edition] [varchar](20) NOT NULL
						   ) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table dbo.tblPlateforme    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tblPlateforme') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tblPlateforme

CREATE TABLE [dbo].[tblPlateforme](
								   [nom] [varchar](15) NOT NULL,
								   [configuration] [varchar](25) NOT NULL,
								   [typeConfiguration] [varchar](20) NOT NULL
								   ) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table dbo.tbltesteur    Script Date: 2017-03-08 10:09:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF OBJECT_ID('GestSalles.dbo.tbltesteur') IS NOT NULL
DROP TABLE BD_Texcel_SAM_FRAN.dbo.tbltesteur

CREATE TABLE [dbo].[tbltesteur](
								[nom] [varchar](50) NOT NULL,
								[prenom] [varchar](50) NOT NULL,
								[dateNaissance] [date] NOT NULL,
								[adresse] [varchar](50) NOT NULL,
								[telResidentiel] [varchar](50) NOT NULL,
								[posteTelephonique] [varchar](5) NOT NULL,
								[matricule] [varchar](1000) NOT NULL,
								[categorieEmploye] [varchar](50) NOT NULL
								) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
