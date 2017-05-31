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
(@id int, @nbUV_Ensei int output, @nbUV_Respo int output) AS
BEGIN
	SELECT 
		@nbUV_Ensei = COUNT(u.numEnsei)
	FROM
		UV u
	WHERE
		u.numEnsei = @id;
	---
	SELECT 
		@nbUV_Respo = COUNT(u.numRespo)
	FROM
		UV u
	WHERE
		u.numRespo = @id;
END
GO
	
