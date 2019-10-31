create database BD_EscuelaMySql;
use BD_EscuelaMySql;

create table Carreras(
	id_carrera varchar(3) primary key,
	nombreCarrera varchar(30) not null,
	unique(nombreCarrera)
);

create table Especialidades(
	id_especialidad varchar(5) primary key,
	nombreEspecialidad varchar(50) not null,
	id_carrera varchar(3) references Carreras on update cascade
);

create table Materias(
	id_materia smallint auto_increment primary key,
	nombreMateria varchar(50) not null,
	id_carrera varchar(3) references Carreras on update cascade
);

create table Alumnos(
	numControl varchar(8) primary key,
	apePat varchar(20) not null,
	apeMat varchar(20) not null,
	nombre varchar(20) not null,
	sexo varchar(1) not null,
	curp varchar(18) not null,
	id_carrera varchar(3) references Carreras on update cascade,
	id_especialidad varchar(5) references Especialidades on delete set null,
	unique(curp),
	check(numControl like '[0-9][0-9][A-Z][A-Z][0-9][0-9][0-9][0-9]'),
	check(sexo in('M','F')),
	check(curp like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][0-9][0-9]')
);

create table Calificaciones(
	id_calificacion bigint auto_increment primary key,
	calificacion tinyint not null,
	id_alumno varchar(8) references Alumnos on update cascade,
	id_materia smallint references Materias on delete set null,
	check (calificacion < 100)
);


insert Carreras values('ISC','Sistemas')
insert Especialidades values('FINU','Física Nuclear','ISC')
insert Materias values(1,'Física Moderna','ISC')
insert Alumnos values('13TE0910','Hernandez','Gonzalez','Edgar Moises','M','HEGE900821QWERTY12','ISC','FINU')
insert Calificaciones values
	(1,90,'13TE0910',1),
    (2,92,'13TE0912',1)

select * from Carreras
select * from Especialidades
select * from Materias
select * from Alumnos
select * from Calificaciones