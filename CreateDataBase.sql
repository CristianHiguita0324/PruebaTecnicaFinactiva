create database RegionesBD;
go
use RegionesBD
go

CREATE TABLE tblMunicipio(
	IdMunicipio int primary key IDENTITY(1,1) NOT NULL,
	NombreMunicipio varchar(100) NOT NULL,
	Estado bit NOT NULL
	)

go

CREATE TABLE tblRegion(
	IdRegion int primary key IDENTITY(1,1) NOT NULL,
	NombreRegion varchar(100) NOT NULL
	)

go

CREATE TABLE tblRegionMunicipio(
	IdRegionMunicipio  int primary key IDENTITY(1,1) NOT NULL,
	IdMunicipio int NOT NULL,
	IDRegion int NOT NULL,
	FOREIGN KEY (IdMunicipio) REFERENCES tblMunicipio(IdMunicipio),
	FOREIGN KEY (IDRegion) REFERENCES tblRegion(IDRegion)
	)