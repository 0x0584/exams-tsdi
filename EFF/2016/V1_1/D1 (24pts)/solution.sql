USE ff2016; -- if(!(isdbcreated)) createdb(); 
GO
--  Question 2
---------------

SELECT
	COUNT(*), c.nomCamp
FROM 
	Participant p, 
	Participation pp, 
	Campagne c
WHERE
	p.idP = pp.idP AND 
	pp.idComp = c.idCamp
GROUP BY c.nomCamp;
GO

-- Question 3
--------------

ALTER PROC LST_PARTICI (@idC int) AS
BEGIN
	SELECT 
		pp.montantPart, 
		p.nomP
	FROM 
		Campagne c, 
		Participant p, 
		Participation pp
	WHERE 
		c.idCamp = @idC AND
		pp.idP = p.idP AND
		pp.idPart = c.idCamp AND
		YEAR(pp.datePartt) = YEAR(GETDATE());
END
-- EXEC LST_PARTICI 2 -- TESTING
GO

-- Question 4
--------------

CREATE TRIGGER TRG_AJT_PARTICI 
ON Participation AFTER INSERT AS
BEGIN
	DECLARE @id int, @_date datetime;

	SELECT 
		@id = idComp, 
		@_date = datePartt
	FROM
		inserted;

	UPDATE 
		Campagne 
	SET 
		dateDernierePart = @_date
	WHERE
		idCamp = @id;
END
GO

-- Question 5
--------------

CREATE PROC ADD_PARTICI(@montantPart int, @idCamp int, @idP int) AS
BEGIN
	INSERT INTO 
		Participation (datePartt, montantPart, idComp, idP) 
	VALUES
		(GETDATE(), @montantPart, @idCamp, @idP);
END
GO

-- Question 6
--------------

ALTER FUNCTION FUNC_MONTOTAL_CATEG(@idCateg int)
RETURNS int AS
BEGIN
	DECLARE @total int;
	SET @total = 0;
	
	SELECT
		@total = SUM(montantPart)
	FROM
		Participation p,
		Campagne c
	WHERE 
		c.idCamp = p.idComp AND
		c.idCategorie = @idCateg;
	
	RETURN @total;
END
GO

--	AUTHOR: ANAS RCHID - TSDI 202
--	UPATED: 05/24/17