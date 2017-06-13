USE ff2015_v11;
GO

INSERT INTO Region			-- (code_region, nom_region, population_region,
							--  total_region)
VALUES(1, 'R1', 11, 160),
	  (2, 'R2', 30, 120),
	  (3, 'R3', 80, 160); 
GO

INSERT INTO Syndic			-- (code_syndic, nom_syndic, prenom_syndic , 
							--  telephone_syndic, mot_depasse)
VALUES(1, 'S11', 'S12', '123456789', '987654321'),
	  (2, 'S21', 'S22', '123456789', '987654321'),
	  (3, 'S31', 'S32', '123456789', '987654321');
GO

INSERT INTO Ville			-- (code_ville,nom_ville, #code_region, total_ville)
VALUES(1, 'V1', 1, 600),
	  (2, 'V2', 2, 900),
	  (3, 'V3', 3, 794); 
GO

INSERT INTO Quartier		-- (code_quartier, nom_quartier, population_quartier 
							-- ,#code_ville,total_quartier)
VALUES(1, 'Q1', 555, 1, 600),
	  (2, 'Q2', 666, 2, 1874),
	  (3, 'Q3', 9999, 3, 600); 
GO

INSERT INTO Bien_immobilier -- (code_bien , adresse_bien, num_enregistrement,
							--  superficie, type, #code_Quartier, 
							--  date_construction)
VALUES(1, 'ADDR_1', 1, 11, 'maison', 1, GETDATE()),
	  (2, 'ADDR_2', 2, 22, 'autre', 2, GETDATE()),
	  (3, 'ADDR_3', 3, 33, 'appartement', 3, GETDATE());
GO

INSERT INTO Contrat			-- (numcontrat, datecontrat, prix_mensuel, #code_bien
							--  #code_syndic, etat)
VALUES(1, GETDATE(), 500, 1, 2, 'en cours'),
	  (2, GETDATE(), 900, 2, 1, 'en cours'),
	  (3, GETDATE(), 1600, 3, 2, 'résilié');
GO





