USE master;
GO
CREATE DATABASE ff2016;
GO
USE ff2016;
GO
CREATE TABLE Categorie(idcateg int primary key, 
					   nomcateg varchar(100));
GO
CREATE TABLE Organisateur(idOrg int primary key, 
					      nomOrg varchar(100),
					      prenomOrg varchar(100), 
					      emailOrg varchar(100), 
					      passOrg varchar(100));
GO
CREATE TABLE Campagne(idCamp int primary key,
					  nomCamp varchar(100),
					  descriptionCamp varchar(300),
					  dateCreation datetime,
					  dateFin datetime,
					  montantCamp int,
					  nomBeneficiare varchar(100),
					  prenBeneficiare varchar(100), 
					  dateDernierePart datetime,
					  idCategorie int foreign key references Categorie(idcateg),
					  idOrg int foreign key references Organisateur(idOrg));
GO
CREATE TABLE Participant(idP int primary key,
						 nomP varchar(100),
						 prenomP varchar(100),
						 email varchar(100),
						 passP varchar(100));
GO
CREATE TABLE Participation(idPart int primary key,
						   datePartt datetime,
						   montantPart int,
						   idComp int foreign key references Campagne(idCamp),
						   idP int foreign key references Participant(idP));

-- ANAS RCHID 
-- TSDI 202