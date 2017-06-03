INSERT INTO Typee
VALUES (1, 'T1'),
	   (2, 'T2');
GO

INSERT INTO Responsable
VALUES (1, 'R11', 'R12', 'R11@R12.com','1233321'),
	   (2,'R21', 'R22', 'R21@R22.com','1233321');
GO

INSERT INTO Actionn
VALUES (1, 'A1', 'blabla', GETDATE(), 12, 1352.12, 'B11', 'B12', GETDATE(), 1, 1),
	   (2, 'A2', 'blabla', GETDATE(), 12, 1442.12, 'B21', 'B22', GETDATE(), 2, 2);
GO	

INSERT INTO Donateur
VALUES (1, 'D11', 'D12', 'D11@D12.com','1233321'),
	   (2,'D21', 'D22', 'D21@D22.com','1233321');
GO

INSERT INTO Don
VALUES (GETDATE(), 50.45, 1, 1), 
	   (GETDATE(), 75.45, 2, 2); 
GO