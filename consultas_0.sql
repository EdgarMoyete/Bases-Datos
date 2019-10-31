create database consultas
use consultas

create table Modalidades(
	id_modalidad varchar(3) constraint pk_idM primary key,
	nombre_modalidad varchar(30)
);

create table Carreras(
	id_carrera tinyint constraint pk_idC primary key,
	nombre_Carrera varchar(50),
	nombre_corto varchar(20)
);

create table Alumnos(
	no_control varchar(8) constraint pk_idA primary key,
	apePat varchar(20),
	apeMat varchar(20),
	nombre varchar(20),
	id_modalidad varchar(3) constraint fk_idAluMod foreign key references Modalidades,
	id_carrera tinyint constraint fk_idAluCar foreign key references Carreras,
	semestre tinyint
);

insert Modalidades values
	('ESC','Escolarizado'),
	('ESM','Escolarizado Modular')

insert Carreras values
	(1,'Ingeniería Industrial','II'),
	(2,'Licenciatura en Administración','LA'),
	(3,'Licenciatura en Informática','LI'),
	(4,'Ingeniería en Sistemas Computacionales','ISC')

insert Alumnos values
	('08TE0409','Aburto','Dominguez','David','ESC',3,5),
	('08TE0147','Aburto','Martinez','German','ESM',1,5)

select apePat,apeMat,nombre,nombre_modalidad,nombre_Carrera
from Alumnos cross join Modalidades cross join Carreras
where Modalidades.id_modalidad='ESC' and Carreras.id_carrera<=3