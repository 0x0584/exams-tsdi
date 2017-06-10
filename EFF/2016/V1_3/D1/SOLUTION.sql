--	  FILE: `SOLUTION.sql`
--	AUTHOR: ANAS RCHID
-- CREATED: 06/03/16

USE ff2016_v13;
GO

-- QUESTION 1: 
--------------
-- SEE DB/{CREATE, POP}.sql

-- QUESTION 2:
--------------

SELECT
	COUNT(*), o.nomOp
FROM
	Bienfaisant b, 
	Operation o, 
	Donation d
WHERE
	d.idOp = o.idOp AND
	b.idBien = d.idBien
GROUP BY
	o.nomOp;
GO

-- QUESTION 3:
--------------

CREATE PROC LST_DONATIONS
(@idOp int) AS
BEGIN
	SELECT
		b.nomBien, 
		d.montantDonation
	FROM
		Donation d, 
		Bienfaisant b
	WHERE
		d.idOp = @idOp AND
		d.idBien = b.idBien AND
		YEAR(d.dateDonation) = YEAR(GETDATE())
	ORDER BY d.montantDonation
END
GO

EXEC LST_DONATIONS 1
GO

-- QUESTION 4:
--------------

CREATE TRIGGER TRG_UPDATE_CUMUL_MONTANT
ON Donation AFTER INSERT AS
BEGIN
	DECLARE @Don money;
	DECLARE @idO int;
	SELECT 
		@Don = i.montantDonation,
		@idO = i.idOp 
	FROM 
		inserted i;
	---
	UPDATE Operation
	SET cumulMontant += @Don
	WHERE idOp = @idO
END
GO

-- QUESTION 5:
--------------

CREATE PROC AJOUTER_DONATION
(@montantDonation money, @idOp int, @idBien int) AS
BEGIN
	INSERT INTO Donation 
	VALUES(GETDATE(), @montantDonation, @idOp, @idBien);
END
GO

EXEC AJOUTER_DONATION 135, 1, 1
GO

-- QUESTION 6:
--------------

CREATE FUNCTION TOTAL_DONATIONS 
(@idF int) RETURNS money AS
BEGIN 
	RETURN (SELECT 
				SUM(o.montantOp) 
			FROM 
				Operation o, 
				Famille f
			WHERE
				o.idFamille = f.idFamille);
END
GO

PRINT dbo.TOTAL_DONATIONS (1)
GO

-- D3/QUESTION 6: SERVICE-WEB:
------------------------------

CREATE PROC NB_BIENFAISANTS
AS 
BEGIN
	SELECT 
		COUNT(*)
	FROM 
		Bienfaisant
END