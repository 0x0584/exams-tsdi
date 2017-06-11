USE ff2017_v11;
GO

INSERT INTO Utilisateur
VALUES(1, 'U-11', 'U-12', 'SOME_ADDR', '123456'),
	  (2, 'U-21', 'U-22', 'SOME_ADDR', '123456'),
	  (3, 'U-31', 'U-32', 'SOME_ADDR', '123456');
GO

INSERT INTO Parking
VALUES(1, 'Park-1', 'SOME_ADDR', 'Casablanca', 30, 15),
	  (2, 'Park-2', 'SOME_ADDR', 'Rabat', 45, 25),
	  (3, 'Park-3', 'SOME_ADDR', 'Tanger', 13, 10);
GO

INSERT INTO TypeTarif
VALUES(1, 'Par Heure'), (2, 'Par Journee entiere');
GO	  

INSERT INTO TarifParking(idType, prix)
VALUES(1, 30),(2, 50);
GO

INSERT INTO Stationnement
VALUES(1, GETDATE(), 1, 1, 1, 5), 
	  (2, GETDATE(), 2, 2, 2, 10);
GO 
		