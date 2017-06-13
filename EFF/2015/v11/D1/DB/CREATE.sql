USE MASTER;
GO

CREATE DATABASE ff2015_v11;
GO

USE ff2015_v11;
GO

CREATE TABLE Region(code_region
					int primary key, 
					
					nom_region
					varchar(30), 
					
					population_region
					int, 
					
					total_region
					money default 0);
GO

CREATE TABLE Syndic(code_syndic 
					int primary key, 
					
					nom_syndic
					varchar(30), 
					
					prenom_syndic 
					varchar(30),  
					
					telephone_syndic
					varchar(30), 
					
					mot_depasse
					varchar(30));
GO

CREATE TABLE Ville(code_ville
				   int primary key,
				   
				   nom_ville
				   varchar(30),
				   
				   code_region
				   int foreign key references Region(code_region), 
				   
				   total_ville
				   money default 0);
GO

CREATE TABLE Quartier(code_quartier
				      int primary key, 
				      
				      nom_quartier
				      varchar(30), 
				      
				      population_quartier 
				      int, 
				      
				      code_ville
				      int foreign key references Ville(code_ville),
				      
				      total_quartier
				      money default 0);
GO				      

CREATE TABLE Bien_immobilier(code_bien 
							 int primary key, 
							 
							 adresse_bien
							 varchar(50), 
							 
							 num_enregistrement
							 int,
							 
							 superficie
							 int, 
							 
							 typee
							 varchar(20) 
							 check (typee = 'appartement' OR 
									typee = 'villa' OR 
									typee = 'maison' OR 
									typee = 'commercial' OR 
									typee = 'autre'), 
							 
							 code_Quartier
							 int foreign key references Quartier(code_Quartier), 
							 
							 date_construction
							 datetime);
GO

CREATE TABLE Contrat (numcontrat
					  int primary key, 
					  
					  datecontrat
					  datetime, 
					  
					  prix_mensuel
					  money, 
					  
					  code_bien
					  int foreign key references Bien_immobilier(code_bien),
					  
					  code_syndic
					  int foreign key references Syndic(code_syndic), 
					  
					  etat
					  varchar(30) 
					  check (etat = 'en cours' OR 
						     etat = 'résilié'));
GO