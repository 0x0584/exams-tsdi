--	  FILE: `CREATE.sql`
--  AUTHOR: ANAS RCHID
-- CREATED: 06/03/16

CREATE DATABASE ff2016_v13;
GO

USE ff2016_v13;
GO

CREATE TABLE Famille (idFamille
					  int primary key, 
					  
					  nomFamille
					  nvarchar(30));
GO

CREATE TABLE Planificateur (idPlan
							int primary key, 
							
							nomPlan 
							nvarchar(30), 
							
							prenomPlan
							nvarchar(30), 
							
							emailPlan
							nvarchar(15), 
							
							passPlan
							nvarchar(20));
GO

CREATE TABLE Operation (idOp
						int primary key, 
						
						nomOp
						nvarchar(30), 
						
						descri
						nvarchar(100), 
						
						dateCreation 
						datetime, 
						
						dateFin 
						int, 
						
						montantOp
						money,
						
						nomBeneficiare 
						nvarchar(30), 
						
						prenBeneficiare 
						nvarchar(30), 
						
						idFamille 
						int foreign key references Famille(idFamille),
						
						idPlan
						int foreign key references Planificateur(idPlan),
						
						cumulMontant 
						float);
GO

CREATE TABLE Bienfaisant (idBien
						  int primary key, 
						  
						  nomBien
						  nvarchar(30), 
						  
						  prenomBien
						  nvarchar(30), 
						  
						  emailBien
						  nvarchar(15), 
						  
						  passBien
						  nvarchar(15));
GO

CREATE TABLE Donation (idDonation
					   int primary key identity, 
					   
					   dateDonation
					   datetime, 
					   
					   montantDonation
					   money, 
					   
					   idOp 
					   int foreign key references Operation(idOp),
					   
					   idBien
					   int foreign key references Bienfaisant (idBien));
GO