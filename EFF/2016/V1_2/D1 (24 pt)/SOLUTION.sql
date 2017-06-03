-- FILE: `SOLUTIOn.sql`
-- AUTHOR: ANAS RCHID
-- CREATED: 06/02/16

-- QUESTION 2:
--------------

SELECT 
	COUNT(d.idD), a.nomAct
FROM
	Actionn a, 
	Don d,
	Donateur dd
WHERE
	d.idD = dd.idD AND
	d.idAct = a.idAct
GROUP BY a.nomAct;
GO

-- QUESTION 3:
--------------

CREATE PROC LIST_DONS 
(@idAct int) AS
BEGIN
	SELECT
		dd.nomD,
		d.montantDon
	FROM
		Don d, 
		Donateur dd
	WHERE
		d.idAct = @idAct AND
		YEAR(d.dateDon) = YEAR(GETDATE());
END
GO

EXEC LIST_DONS 1;
GO

-- QUESTION 4:
--------------

CREATE TRIGGER TRG_UPDATE_ACTIONN
ON Don AFTER INSERT AS
BEGIN
	DECLARE @idAct int;
	DECLARE @date datetime;
	
	SELECT 
		@idAct = i.idAct, 
		@date = i.dateDon 
	FROM
		inserted i;
	---
	
	UPDATE 
		Actionn 
	SET 
		dateDerniereDon = @date 
	WHERE 
		Actionn.idAct = @idAct; 
END
GO

-- QUESTION 5:
--------------

CREATE PROC ADD_DON
(@montantDon money, @idAct int, @idD int) AS
BEGIN
	INSERT INTO Don 
	VALUES (GETDATE(), @montantDon, @idAct, @idD);
END

EXEC ADD_DON 880.23, 1, 1
GO

-- QUESTION 6:
--------------

CREATE FUNCTION TOTAL_DES_DONS
(@idType int) RETURNS money AS
BEGIN
	DECLARE @total money;
	SELECT 
		@total = SUM(d.montantDon)
	FROM
		Don d, 
		Actionn a
	WHERE
		d.idAct = a.idAct AND
		a.idType = @idType;
	---
	RETURN @total;
END
GO

PRINT dbo.TOTAL_DES_DONS(2)
GO
