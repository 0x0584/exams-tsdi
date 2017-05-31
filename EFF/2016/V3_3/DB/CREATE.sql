--    FILE: CREATE.sql
--  AUTHOR: ANAS RCHID
-- CREATED: 05/31/16

CREATE DATABASE ff2016_v33;
GO

USE ff2016_v33;
GO

CREATE TABLE Formateur(numFormateur 
					   int primary key, 
					   
					   nomFormateur 
					   varchar(20) NOT NULL, 
					   
					   prenFormateur 
					   varchar(20) NOT NULL,
					   
					   teleFormateur 
					   varchar(15) NOT NULL,
					   
					   AddrFormateur 
					   varchar(30),
					   
					   typeFormateur 
					   varchar(10) NOT NULL);
GO

CREATE TABLE Formation(numFormation 
				       int primary key,
					   
					   nomFormation 
					   varchar(30) NOT NULL,
					   
					   nombreUV 
					   int NOT NULL,
					   
					   motdepass 
					   varchar(15) NOT NULL);
GO

CREATE TABLE UV(numUV 
				int primary key,
				
				nomUV 
				varchar(20) NOT NULL,
				
				massHoraire 
				int NOT NULL,
				
				numEnsei 
				int foreign key references Formateur(NumFormateur) NOT NULL,
				
				numRespo 
				int foreign key references Formateur(NumFormateur) NOT NULL,
				
				nomFormation 
				int foreign key references Formation(numFormation) NOT NULL);
GO

CREATE TABLE Chapitre(numChapitre 
					  int primary key,
				      
				      nomChapitre 
				      varchar(15) NOT NULL,
				      
				      numUV 
				      int foreign key references UV(numUV) NOT NULL);
GO

CREATE TABLE Section(numSection 
					  int primary key,
					  
					  nomSection
					  varchar(15) NOT NULL,
					  
					  numFormation 
					  int foreign key references Formation(numFormation) NOT NULL);
GO

CREATE TABLE Inscrit(numInscrit 
					 int primary key,
					 
					 nomInscrit 
					 varchar(20) NOT NULL,
					 
					 numSection
					 int foreign key references Section(numSection) NOT NULL);
GO

