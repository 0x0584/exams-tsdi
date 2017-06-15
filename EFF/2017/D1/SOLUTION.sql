USE ff2017_v11;
GO

-- QUESTION 2:
--------------
SELECT 
	t.prix AS 'PRIX ORIGINAL',
	(t.prix * 1.15) AS 'PRIX AUGMENTEE'
FROM 
	Parking p, 
	Stationnement s, 
	TarifParking t
WHERE
	p.idPark = s.idPark AND 
	t.idPark = p.idPark AND
	p.ville LIKE 'Casablanca'
GO

-- QUESTION 3:
--------------

CREATE PROC SUPP_UTIL
(@idUtil int) AS
BEGIN
	DELETE FROM Stationnement WHERE idUtil = @idUtil;
	DELETE FROM Utilisateur WHERE idUtil = @idUtil;
END
GO

-- QUESTION 4:
--------------

CREATE PROC NB_PLACE_PAR_PARKING
(@ville nvarchar(30)) AS
BEGIN
	SELECT
		p.nbPlace
	FROM
		Parking p
	WHERE
		p.ville = @ville;
END
GO

-- QUESTION 5:
--------------

CREATE FUNCTION NB_STAT_EFFECT
(@idType) RETURNS int AS
BEGIN
	RETURN 
	(SELECT 
		COUNT(s.idType) 
	 FROM
		Stationnement s
	 WHERE
		s.idType = @idType);
END
GO

-- QUESTION 6:
--------------

CREATE TRIGGER TRG_DECR_PLACE_LIBRE
ON Stationnement AFTER INSERT AS
BEGIN
	DECLARE @idPark int;
	
	IF(((SELECT 
			nbPlaceLibre
		 FROM 
			Parking p, 
			Inserted i 
		 WHERE 
			i.idPark = p.idPark) - 1) > 0)
	BEGIN
		SELECT @idPark = i.idPark FROM Inserted i;
		UPDATE Parking SET nbPlaceLibre -= 1 WHERE idPark = @idPark;
	END
END
GO