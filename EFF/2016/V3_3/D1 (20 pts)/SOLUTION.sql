--    FILE: SOLUTION.sql
--  AUTHOR: ANAS RCHID
-- CREATED: 31/05/16

-- QUESTION 1: SEE ../DB/{CREATE.sql, POP.sql}
--------------

-- QUESTION 2: SEE ../DB/POP.sql
--------------

-- QUESTION 3: 
--------------

SELECT
	c.nomChapitre, 
	u.numEnsei, 
	u.numRespo
FROM
	Chapitre c, 
	UV u
WHERE 
	u.nomUV = 'anglais' AND u.numUV = c.numUV;
GO

-- QUESTION 4:
--------------

CREATE PROC COUNT_ENSEI_RESPO_DE_FORMATEUR
(@numFormateur int, @nbUV_Ensei int output, @nbUV_Respo int output) AS
BEGIN
	SELECT 
		@nbUV_Ensei = COUNT(u.numEnsei)
	FROM
		UV u
	WHERE
		u.numEnsei = @numFormateur;
	---
	SELECT 
		@nbUV_Respo = COUNT(u.numRespo)
	FROM
		UV u
	WHERE
		u.numRespo = @numFormateur;
END
GO

DECLARE @n int, @m int;

EXEC COUNT_ENSEI_RESPO_DE_FORMATEUR 1, @n output, @m output;
PRINT @n 
PRINT @m
GO
 
-- Question 5:
--------------

CREATE FUNCTION TOTAL_MASS_HORAIRE_FORMATION
(@numFormation int) RETURNS int AS 
BEGIN
	DECLARE @total int;
	SELECT 
		@total = SUM(u.massHoraire)
	FROM
		UV u;
		
	RETURN @total;
END
GO

DECLARE @tmp int;
SELECT @tmp = dbo.TOTAL_MASS_HORAIRE_FORMATION(1);
PRINT @tmp
GO

-- Question 6:
--------------
 -- ??

-- D3/Service :
---------------

CREATE PROC info 
(@idf int) AS
BEGIN
	DECLARE @c_per int;
	DECLARE @c_vac int;

	SELECT 
		@c_per = COUNT(f.numFormateur) 
	FROM 
		Formateur f, 
		UV u 
	WHERE 
		(u.numEnsei = f.numFormateur OR u.numRespo = f.numFormateur) 
		AND f.typeFormateur LIKE 'permanant' AND u.numFormation = @idf
	---
	SELECT 
		@c_vac = COUNT(f.numFormateur) 
	FROM 
		Formateur f, 
		UV u 
	WHERE 
		(u.numEnsei = f.numFormateur or u.numRespo = f.numFormateur) 
		AND f.typeFormateur LIKE 'vacataire' AND u.numFormation = @idf

	---
	SELECT 
		nombreUV, 
		@c_per AS 'nb_per', 
		@c_vac AS 'nb_vac' 
	FROM 
		Formation 
	WHERE 
		numFormation = @idf
END
GO
EXEC info 2
