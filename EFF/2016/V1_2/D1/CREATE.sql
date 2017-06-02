CREATE DATABASE ff2016_v12;
GO

USE ff2016_v12;
GO

CREATE TABLE Typee (idType 
				    int primary key, 
				   
				    nomType 
				    nvarchar(30));
GO

CREATE TABLE Responsable (idResp 
						  int primary key, 
						 
						  nomResp 
						  nvarchar(30), 
						 
						  prenomResp 
						  nvarchar(30), 
						 
						  emailResp 
						  nvarchar(30), 
						 
						  passResp 
						  nvarchar(15));
GO						 

CREATE TABLE Actionn (idAct 
					 int primary key, 
					 
					 nomAct 
					 nvarchar(30), 
					 
					 descri 
					 nvarchar(30), 
					 
					 dateCreation 
					 datetime, 
					 
					 dateFin 
					 int, 
					 
					 montantAct 
					 money, 
					 
					 nomBeneficiare 
					 nvarchar(30),
					 
					 prenBeneficiare 
					 nvarchar(30), 
					 
					 dateDerniereDon 
					 datetime, 
					 
					 idType 
					 int foreign key references Typee(idType),
					 
					 idResp
					 int foreign key references Responsable(idResp));
GO

CREATE TABLE Donateur (idD
					   int primary key, 
					   
					   nomD 
					   nvarchar(30), 
					   
					   prenomD 
					   nvarchar(30), 
					   
					   emailD
					   nvarchar(30), 
					   
					   passD
					   nvarchar(30));
GO

CREATE TABLE Don (idDon 
				  int primary key identity, 
				  
				  dateDon 
				  datetime, 
				  
				  montantDon 
				  money, 
				  
				  idAct 
				  int foreign key references Actionn(idAct), 
				  
				  idD
				  int foreign key references Donateur(idD));
GO