USE BD_Texcel
GO

ALTER TABLE tblEquipe ADD CONSTRAINT fk_matricule FOREIGN KEY (matricule) REFERENCES tblEmploye (matricule)

ALTER TABLE tblTest ADD CONSTRAINT fk_codeType FOREIGN KEY (codeType) REFERENCES tblTypeTests (codeType)

ALTER TABLE tblEquipeTest ADD CONSTRAINT fk_codeEquipe FOREIGN KEY (codeEquipe) REFERENCES tblEquipe (codeEquipe)

ALTER TABLE tblEquipeTest ADD CONSTRAINT fk_codeTest FOREIGN KEY (codeTest) REFERENCES tblTest (codeTest)

ALTER TABLE tblTestProjetTest ADD CONSTRAINT fk_codeProjetTest FOREIGN KEY (codeProjetTest) REFERENCES tblProjetTest (codeProjetTest)

ALTER TABLE tblTestProjetTest ADD CONSTRAINT fk_codeTestProjetTest FOREIGN KEY (codeTest) REFERENCES tblTest (codeTest)

ALTER TABLE tblProjetTest ADD CONSTRAINT fk_codeJeux FOREIGN KEY (codeJeux) REFERENCES tblJeux (codeJeux)

ALTER TABLE tblJeux ADD CONSTRAINT fk_codeclassification FOREIGN KEY (codeclassification) REFERENCES tblClassification (codeclassification)

ALTER TABLE tblJeux ADD CONSTRAINT fk_codeGenre FOREIGN KEY (codeGenre) REFERENCES tblGenre (codeGenre)

ALTER TABLE tblJeux ADD CONSTRAINT fk_codeTheme FOREIGN KEY (codeTheme) REFERENCES tblTheme (codeTheme)

ALTER TABLE tblPlateformeJeux ADD CONSTRAINT fk_codePlateforme FOREIGN KEY (codePlateforme) REFERENCES tblPlateforme (codePlateforme)

ALTER TABLE tblPlateformeJeux ADD CONSTRAINT fk_codeJeuxPlateforme FOREIGN KEY (codeJeux) REFERENCES tblJeux (codeJeux)
  
ALTER TABLE tblPlateforme ADD CONSTRAINT fk_codeOS FOREIGN KEY (codeOS) REFERENCES tblOS (codeOS)