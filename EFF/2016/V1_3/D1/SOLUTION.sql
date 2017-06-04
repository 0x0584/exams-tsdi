--	  FILE: `SOLUTION.sql`
--	AUTHOR: ANAS RCHID
-- CREATED: 06/03/16

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
