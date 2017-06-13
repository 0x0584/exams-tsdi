-- QUESTION 1:
--------------

-- SEE DB/{CREATE, POP}.sql file 

-- QUESTION 2:
--------------

SELECT 
	COUNT(b.code_bien), 
	q.nom_quartier
FROM 
	Bien_immobilier b,
	Quartier q
WHERE 
	b.code_Quartier = q.code_quartier 
	AND b.typee = 'appartement'
GROUP BY
	q.nom_quartier
GO

-- QUESTION 3:
--------------

-- already done! but here's how
-- ALTER TABLE Contrat ADD CONSTRAINT con1 CHECK (etat = 'A' OR etat = 'B');

-- QUESTION 4:
--------------
-- THIS QUESTION IS STUPID:
-- ||< Créer une procédure qui retourne dans des paramètres de sortie 
--     le nombre de biens immobiliers ainsi que le chiffre d’affaires 
--     pour un bien de type « villa » saisi comme paramètre. >||
-- I'LL DO WHAT I DID UNDERSTAND. 

CREATE PROC CA_TYPE
(@type varchar(30), @nb_biens int output, @ca_biens int output) AS
BEGIN 
	SELECT
		@nb_biens = COUNT(b.code_bien),      -- AS 'nb_biens', 
		@ca_biens = SUM(c.prix_mensuel * 12) -- AS 'CA'
	FROM
		Bien_immobilier b,
		Contrat c
	WHERE
		b.typee = @type AND 
		c.code_bien = b.code_bien;
END

DECLARE @nb_b int;
DECLARE @ca int;
DECLARE @typee varchar(30);
SET @typee = 'maison';

EXEC CA_TYPE @typee, @nb_b output, @ca output;
SELECT @typee AS 'type', @nb_b AS 'nb_biens', @ca AS 'CA';
GO	

-- QUESTION 5:
--------------
-- ANOTHER DUMB QUESTION!!! FUCK!
--  Créer une fonction qui retourne pour les biens de type « villa » 
--  localisés à Casablanca, Le chiffre d’affaire total réalisé 
--  et ceci pour un quartier saisi comme paramètre.

CREATE FUNCTION LST_BIENS
(@numQ int) RETURNS @tab TABLE (
	code_bien			int				NOT NULL,
	code_Quartier		int				NOT NULL,
	adresse_bien		varchar(30)		NOT NULL,
	date_construction	datetime		NOT NULL,
	num_enregistrement	int				NOT NULL,
	superficie			int				NOT NULL

) AS
BEGIN
	INSERT INTO @tab
	SELECT
		b.code_bien,
		b.code_Quartier,
		b.adresse_bien,
		b.date_construction,
		b.num_enregistrement,
		b.superficie
	FROM
		Bien_immobilier b,
		Quartier q,
		Ville v
	WHERE
		v.nom_ville = 'V1' AND
		b.typee = 'maison' AND
		b.code_Quartier = q.code_quartier AND
		q.code_ville = v.code_ville;
	RETURN;
END
GO

SELECT * FROM dbo.LST_BIENS(1)
GO

-- QUESTION 6:
--------------

CREATE TRIGGER TRG_TOTAL_QUART
ON Contrat
AFTER INSERT, UPDATE, DELETE AS
BEGIN
	DECLARE @total money;

	--  CASE: UPDATE
	IF((EXISTS (SELECT * FROM Inserted)) AND 
	   (EXISTS (SELECT * FROM Deleted)))
	BEGIN
		SELECT 
			@total = SUM((i.prix_mensuel - d.prix_mensuel) * 12) 
		FROM
			Inserted i,
			Deleted d;
		---
		UPDATE Quartier SET total_quartier += @total; -- IT CAN BE NEGATIVE
	END
	
	-- CASE: DELETE
	IF((NOT EXISTS (SELECT * FROM Inserted)) AND 
	   (EXISTS (SELECT * FROM Deleted)))
	BEGIN
		SELECT 
			@total = SUM(d.prix_mensuel * 12) 
		FROM
			Deleted d;
		---
		UPDATE Quartier SET total_quartier -= @total
	END

	-- CASE INSERT
	IF((EXISTS (SELECT * FROM Inserted)) AND 
	   (NOT EXISTS (SELECT * FROM Deleted)))
	BEGIN
		SELECT 
			@total = SUM(i.prix_mensuel * 12) 
		FROM
			Inserted i;
		---
		UPDATE Quartier SET total_quartier += @total
	END
END