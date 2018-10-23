CREATE DATABASE ParcialeDB
GO
USE ParcialeDB
GO
CREATE TABLE Parciale
(
    VendedoresId int primary key identity (1,1),
	Nombres varchar (30),
	Sueldo decimal,
	PorcentajeRetencion decimal,
	Retencion varchar,
	Fecha datetime


  );