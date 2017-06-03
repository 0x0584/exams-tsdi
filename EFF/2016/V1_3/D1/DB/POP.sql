--    FILE: `POP.sql`
--  AUTHOR: ANAS RCHID
-- CREATED: 06/03/16

USE ff2016_v13;
GO

INSERT INTO Famille -- (idFamille, nomFamille)
VALUES (1, 'F1'), (2, 'F2'), (3, 'F3');
GO

INSERT INTO Planificateur -- idPlan, nomPlan , prenomPlan, emailPlan, passPlan
VALUES (1, 'P11', 'P12', 'P11@P12.com', '1233321'),
	   (2, 'P21', 'P22', 'P21@P22.com', '1233321');
GO

INSERT INTO Operation -- idOp, nomOp, description , dateCreation, dateFin,
                      -- montantOp, nomBeneficiare , prenBeneficiare , 
                      -- #idFamille , #idPlan, cumulMontant
VALUES (1, 'Op1', 'foo', GETDATE(), 30, 1752.36, 'B11', 'B12', 1, 2, 30.11),
	   (2, 'Op2', 'bar', GETDATE(), 27, 1217.30, 'B21', 'B22', 2, 1, 656.01);
GO

INSERT INTO Bienfaisant -- idBien, nomBien, prenomBien, emailBien, passBien
VALUES (1, 'B11', 'B12', 'B11@B12.com', '1233321'),
	   (2, 'B21', 'B22', 'B21@B22.com', '1233321');
GO

INSERT INTO Donation -- idDonation, dateDonation, montantDonation, 
					 -- #idOp , #idBien
VALUES (GETDATE(), 122.3, 1, 2), (GETDATE(), 322.1, 2, 1);
GO

SELECT * FROM Famille;
SELECT * FROM Planificateur;
SELECT * FROM Operation;
SELECT * FROM Bienfaisant;
SELECT * FROM Donation;