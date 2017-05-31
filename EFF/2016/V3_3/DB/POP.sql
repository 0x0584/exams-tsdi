--    FILE: POP.sql
--  AUTHOR: ANAS RCHID
-- CREATED: 05/31/16

INSERT INTO Formateur -- (num_formateur, nom_formateur, prenom_formateur,
					  --  télephone, adresse, type). 
VALUES (1, 'AA', 'aa', 00112233, NULL, 'permanant'),
	   (2, 'BB', 'bb', 00112233, NULL, 'vacataire'),
	   (3, 'CC', 'cc', 00112233, NULL, 'permanant');
GO

INSERT INTO Formation -- (num_formation, nom_formation, nombre_UV, motdepasse).
VALUES (1, 'Fromation_0', 20, 'passwdwd'),
	   (2, 'Fromation_1', 30, 'passwdwd'),
	   (3, 'Fromation_2', 40, 'passwdwd');
GO


INSERT INTO UV -- (num_UV, nom_UV, masse_horaire_prevue, 
			   --  #num_formateur_enseignant, #num_formateur_responsable,
			   --  # num_formation).
VALUES (1, 'UV0',  5, 1, 1, 2),
	   (2, 'UV1', 20, 2, 1, 1),
	   (3, 'UV2', 10, 3, 2, 3);
GO

INSERT INTO Chapitre -- (num_chapitre, nom_chapitre, #num_uv)
VALUES (1, 'Chap0', 3),
	   (2, 'Chap1', 2),
	   (3, 'Chap2', 2);
GO

INSERT INTO Section -- (num_section, nom_section, #num_formation).
VALUES (1, 'Sec0', 1),
	   (2, 'Sec1', 2),
	   (3, 'Sec2', 3);
GO

INSERT INTO Inscrit -- (num_section, nom_section, #num_formation).
VALUES (1, 'Person0', 1),
	   (2, 'Person1', 1),
	   (3, 'Person2', 2);
	   
-- CONSTRAINT
--------------

ALTER TABLE Formateur 
ADD CONSTRAINT CONS_TYPE 
CHECK (typeFormateur = 'permanant' OR typeFormateur = 'vacataire');

