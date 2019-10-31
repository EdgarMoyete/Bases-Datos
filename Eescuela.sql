create database BD_EEscuela;
use BD_EEscuela;

create table Carreras(
	id_carrera varchar(8) constraint pk_idCar primary key,
	nombreCarrera varchar(30) not null,
	constraint uk_nomCar unique(nombreCarrera)
);

create table Especialidades(
	id_especialidad varchar(8) constraint pk_idEsp primary key,
	nombreEspecialidad varchar(50) not null,
	id_carrera varchar(8) constraint fk_idEspCar foreign key references Carreras on update cascade on delete set null
);

create table Materias(
	id_materia smallint identity(1,1) constraint pk_idMat primary key,
	nombreMateria varchar(50) not null,
	id_carrera varchar(8) constraint fk_idMatCar foreign key references Carreras on update cascade on delete set null
);

create table Alumnos(
	numControl varchar(8) constraint pk_idAlu primary key,
	apePat varchar(20) not null,
	apeMat varchar(20) not null,
	nombre varchar(20) not null,
	sexo varchar(1) not null,
	curp varchar(18) not null,
	id_carrera varchar(8) constraint fk_idAluCar foreign key references Carreras on update cascade on delete set null,
	id_especialidad varchar(8) constraint fk_idAluEsp foreign key references Especialidades on delete set null,
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