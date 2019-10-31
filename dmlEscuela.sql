create database dmlEscuela;
use dmlEscuela;

create table Carreras(
	id_carrera varchar(3) constraint pk_idCar primary key,
	nombreCarrera varchar(30) not null,
	constraint uk_nomCar unique(nombreCarrera)
);

create table Especialidades(
	id_especialidad varchar(5) constraint pk_idEsp primary key,
	nombreEspecialidad varchar(50) not null,
	id_carrera varchar(3) constraint fk_idEspCar foreign key references Carreras on update cascade on delete set null
);

create table Materias(
	id_materia smallint identity(1,1) constraint pk_idMat primary key,
	nombreMateria varchar(50) not null,
	id_carrera varchar(3) constraint fk_idMatCar foreign key references Carreras on update cascade on delete set null
);

create table Alumnos(
	numControl varchar(8) constraint pk_idAlu primary key,
	apePat varchar(20) not null,
	apeMat varchar(20) not null,
	nombre varchar(20) not null,
	sexo varchar(1) not null,
	curp varchar(18) not null,
	id_carrera varchar(3) constraint fk_idAluCar foreign key references Carreras on update cascade on delete set null,
	id_especialidad varchar(5) constraint fk_idAluEsp foreign key references Especialidades on delete set null,
	constraint uk_curAlu unique(curp),
	constraint ck_nuCAlu check(numControl like '[0-9][0-9][A-Z][A-Z][0-9][0-9][0-9][0-9]'),
	constraint ck_sexAlu check(sexo in('M','F')),
	constraint ck_curAlu check(curp like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][0-9][0-9]')
);

create table Calificaciones(
	id_calificacion bigint identity(1,1) constraint pk_idCal primary key,
	calificacion tinyint not null,
	id_alumno varchar(8) constraint fk_idCalAlu references Alumnos on update cascade on delete set null,
	id_materia smallint constraint fk_idCalMat references Materias on delete set null,
	constraint ck_calCal check(calificacion < 100)
);

insert Carreras values
	('LAC','Licenciatura en Actuaria'),
	('ISC','Ing en Sistemas Compu'),
	('IQU','Ingenieria en Quimica')

select * from Carreras

insert Especialidades values
	('EDAE','Estadistica Descriptiva Aplicada a la Economia','LAC'),
	('APA','Algoritmos y Programacion Avanzada','LAC')

select * from Especialidades

insert Alumnos values
	('13TE0999','Lopez','Hernandez','Diana','F','HEGE909045QWERTY12','LAC','EDAE'),
	('13TE0111','Ramirez','Martinez','Jose','M','HEGE909045QWERTY11','ISC','EDAE'),
	('13TE0001','Lopez','Hernandez','Juan','M','HEGE909045QWERTY10','ISC','APA'),
	('13TE9901','Lopez','Hernandez','Edgar','M','HEGE909045QWERTY13','IQU','APA')

select * from Alumnos

delete from Carreras where id_carrera='IQU'

update Carreras
set id_carrera = 'LMP', nombreCarrera='Matematicas Puras'
where id_carrera like 'ISC'

select * into Alumnos_Backup1
from Alumnos where id_carrera is null

select * from Alumnos_Backup1