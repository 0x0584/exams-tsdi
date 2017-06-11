USE master;
GO

CREATE DATABASE ff2017_v11;
GO

USE ff2017_v11;
GO

CREATE TABLE Utilisateur (idUtil
						  int primary key,
						  
						  nomUtil
						  nvarchar(30),
						  
						  prenUtil
						  nvarchar(30),
						  
						  addressUtil
						  nvarchar(30),
						  
						  pass
						  nvarchar(30));
GO

CREATE TABLE Parking (idPark
					  int primary key,
					  
					  nomPark
					  nvarchar(30),
					  
					  adPark
					  nvarchar(30),
					  
					  ville
					  nvarchar(30),
					  
					  nbPlace
					  int,
					  
					  nbPlaceLibre
					  int);
GO

CREATE TABLE TypeTarif (idType
						int primary key,
						
						nomType
						nvarchar(30));
GO

CREATE TABLE TarifParking (idPark
						   int identity foreign key references Parking(idPark),
						   
						   idType
						   int foreign key references TypeTarif(idType),
						   
						   prix
						   money
						   
						   constraint PK_TarPar primary key (idPark, idType));
GO

CREATE TABLE Stationnement (idStat
							int primary key,
							
							dateStat
							datetime,
							
							idUtil
							int foreign key references Utilisateur(idUtil),
							
							idPark
							int foreign key references Parking(idPark),
							
							idType
							int foreign key references TypeTarif(idType),
							
							nbUnit
							int);
GO