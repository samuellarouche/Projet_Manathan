USE BD_Texcel_SAM_FRAN
GO

ALTER TABLE tblEquipe ADD CONSTRAINT fk_matricule FOREIGN KEY (matricule) REFERENCES tblEmploye (matricule) ON DELETE CASCADE

ALTER TABLE tblTest ADD CONSTRAINT fk_codeType FOREIGN KEY (codeType) REFERENCES tblTypeTests (codeType) ON DELETE CASCADE

ALTER TABLE tblEquipeTest ADD CONSTRAINT fk_codeEquipe FOREIGN KEY (codeEquipe) REFERENCES tblEquipe (codeEquipe) ON DELETE CASCADE

ALTER TABLE tblEquipeTest ADD CONSTRAINT fk_codeTest FOREIGN KEY (codeTest) REFERENCES tblTest (codeTest) ON DELETE CASCADE

ALTER TABLE tblTestProjetTest ADD CONSTRAINT fk_codeProjetTest FOREIGN KEY (codeProjetTest) REFERENCES tblProjetTest (codeProjetTest) ON DELETE CASCADE

ALTER TABLE tblTestProjetTest ADD CONSTRAINT fk_codeTestProjetTest FOREIGN KEY (codeTest) REFERENCES tblTest (codeTest) ON DELETE CASCADE

ALTER TABLE tblProjetTest ADD CONSTRAINT fk_codeJeuProjetTest FOREIGN KEY (codeJeu) REFERENCES tblJeu (codeJeu) ON DELETE CASCADE

ALTER TABLE tblJeu ADD CONSTRAINT fk_codeclassification FOREIGN KEY (codeclassification) REFERENCES tblClassification (codeclassification) ON DELETE CASCADE

ALTER TABLE tblJeu ADD CONSTRAINT fk_codeGenre FOREIGN KEY (codeGenre) REFERENCES tblGenre (codeGenre) ON DELETE CASCADE

ALTER TABLE tblJeu ADD CONSTRAINT fk_codeTheme FOREIGN KEY (codeTheme) REFERENCES tblTheme (codeTheme) ON DELETE CASCADE

ALTER TABLE tblJeu ADD CONSTRAINT fk_codeJeu FOREIGN KEY (codeJeuAssocie) REFERENCES tblJeu (codeJeu)

ALTER TABLE tblPlateformeJeu ADD CONSTRAINT fk_codePlateforme FOREIGN KEY (codePlateforme) REFERENCES tblPlateforme (codePlateforme) ON DELETE CASCADE

ALTER TABLE tblPlateformeJeu ADD CONSTRAINT fk_codeJeuxPlateforme FOREIGN KEY (codeJeu) REFERENCES tblJeu (codeJeu) ON DELETE CASCADE
  
ALTER TABLE tblPlateforme ADD CONSTRAINT fk_codeOS FOREIGN KEY (codeOS) REFERENCES tblOS (codeOS) ON DELETE CASCADE