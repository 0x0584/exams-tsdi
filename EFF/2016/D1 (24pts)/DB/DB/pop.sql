USE ff2016;
GO
INSERT INTO Categorie VALUES(1, 'A'),
							(2, 'B'),
							(3, 'C');
GO
INSERT INTO Organisateur VALUES(1, 'O!', 'OO1', 'O1@OO1.com', '1111'),
							   (2, 'O2', 'OO2', 'O2@OO2.com', '2222');
GO
SELECT * FROM Campagne
INSERT INTO Campagne VALUES(1, 'C1', ' ', GETDATE(), GETDATE(),  12000, 'B!', 'BB1', GETDATE(), 1, 1),
							(2, 'C2', ' ', GETDATE(), GETDATE(), 32000, 'B2', 'BB2', GETDATE(), 2, 2);
GO
INSERT INTO Participant VALUES(1, 'P1', 'PP1', 'P1@PP1.com', '1111'),
							  (2, 'P2', 'PP2', 'P2@PP2.com', '2222');
GO
INSERT INTO Participation VALUES(1, GETDATE(), 1000, 2, 1),
								(2, GETDATE(), 2000, 1, 2);
GO

SELECT * FROM Categorie;		
SELECT * FROM Organisateur;
SELECT * FROM Campagne;
SELECT * FROM Participant;
SELECT * FROM Participation;

-- Anas Rchid
-- TSDI 202