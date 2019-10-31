create database BD_Escuela;
use BD_Escuela;

create schema Universidad;
create schema Estudiantes;

create login LoginEscuela
with password='estudioconocimiento12'

create user usuario
for login LoginEscuela

grant select
on schema::Universidad
to usuario

grant exec
on schema::Universidad
to usuario

grant select
on schema::Estudiantes
to usuario

grant exec
on schema::Estudiantes
to usuario

create table Universidad.Carreras(
	id_carrera varchar(8) constraint pk_idCar primary key,
	nombreCarrera varchar(30) not null,
	constraint uk_nomCar unique(nombreCarrera)
);

create table Universidad.Especialidades(
	id_especialidad varchar(8) constraint pk_idEsp primary key,
	nombreEspecialidad varchar(50) not null,
	id_carrera varchar(8) constraint fk_idEspCar foreign key references Universidad.Carreras on update cascade on delete set null
);

create table Universidad.Materias(
	id_materia smallint identity(1,1) constraint pk_idMat primary key,
	nombreMateria varchar(50) not null,
	id_carrera varchar(8) constraint fk_idMatCar foreign key references Universidad.Carreras on update cascade on delete set null
);

create table Estudiantes.Alumnos(
	numControl varchar(8) constraint pk_idAlu primary key,
	apePat varchar(20) not null,
	apeMat varchar(20) not null,
	nombre varchar(20) not null,
	sexo varchar(1) not null,
	curp varchar(18) not null,
	id_carrera varchar(8) constraint fk_idAluCar foreign key references Universidad.Carreras on update cascade on delete set null,
	id_especialidad varchar(8) constraint fk_idAluEsp foreign key references Universidad.Especialidades on delete set null,
	constraint uk_curAlu unique(curp),
	constraint ck_nuCAlu check(numControl like '[0-9][0-9][A-Z][A-Z][0-9][0-9][0-9][0-9]'),
	constraint ck_sexAlu check(sexo in('M','F')),
	constraint ck_curAlu check(curp like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][0-9][0-9]')
);

create table Estudiantes.Calificaciones(
	id_calificacion bigint identity(1,1) constraint pk_idCal primary key,
	calificacion tinyint not null,
	id_alumno varchar(8) constraint fk_idCalAlu references Estudiantes.Alumnos on update cascade on delete set null,
	id_materia smallint constraint fk_idCalMat references Universidad.Materias on delete set null,
	constraint ck_calCal check(calificacion < 100)
);

create view Universidad.vw_Carreras
(Clave_Carrera,Nombre)
	as
	select * from Universidad.Carreras

create view Universidad.vw_Especialidades
(Clave_Especialidad,Nombre,Carrera)
	as
	select e.id_especialidad,e.nombreEspecialidad,c.nombreCarrera
	from Universidad.Especialidades as e
	inner join Universidad.Carreras as c on e.id_carrera=c.id_carrera

create view Universidad.vw_Materias
(Clave_Materia,Nombre,Carrera)
	as
	select m.id_materia,m.nombreMateria,c.nombreCarrera
	from Universidad.Materias as m
	inner join Universidad.Carreras as c on m.id_carrera=c.id_carrera

create view Estudiantes.vw_Alumnos
(Numero_Control,Apellido_Paterno,Apellido_Materno,Nombre,Sexo,CURP,Carrera,Especialidad)
	as
	select a.numControl,a.apePat,a.apeMat,a.nombre,a.sexo,a.curp,c.nombreCarrera,e.nombreEspecialidad
	from Estudiantes.Alumnos as a
	inner join Universidad.Carreras as c on a.id_carrera=c.id_carrera
	inner join Universidad.Especialidades as e on a.id_especialidad=e.id_especialidad

create view Estudiantes.vw_Calificaciones
(Clave_Calificacion,Numero_Control,Apellido_Paterno,Apellido_Materno,Nombre,Materia,Calificacion)
	as
	select c.id_calificacion,a.numControl,a.apePat,a.apeMat,a.nombre,m.nombreMateria,c.calificacion
	from Estudiantes.Calificaciones as c
	inner join Estudiantes.Alumnos as a on c.id_alumno=a.numControl
	inner join Universidad.Materias as m on c.id_materia=m.id_materia

create proc Universidad.usp_ActualizarCarreras
	@id_carrera varchar(8),
	@nombreCarrera varchar(30)
	as 
	update Universidad.Carreras
	set nombreCarrera=@nombreCarrera
	where id_carrera=@id_carrera

create proc Universidad.usp_AgregarCarreras
	@id_carrera varchar(8),
	@nombreCarrera varchar(30)
	as
	insert Universidad.Carreras values (@id_carrera,@nombreCarrera)
		
create proc Universidad.usp_BuscarxIdCarreras
	@id_carrera varchar(8)
	as
	select * from Universidad.vw_Carreras
	where Clave_Carrera=@id_carrera

create proc Universidad.usp_ConsultarCarreras
	as
	select * from Universidad.vw_Carreras

create procedure Universidad.usp_EliminarCarreras
	@id_carrera varchar(8)
	as
	delete from Universidad.Carreras
	where id_carrera=@id_carrera

create proc Universidad.usp_ActualizarEspecialidades
	@id_especialidad varchar(8),
	@nombreEspecialidad varchar(50),
	@id_carrera varchar(8)
	as 
	update Universidad.Especialidades
	set nombreEspecialidad=@nombreEspecialidad,id_carrera=@id_carrera
	where id_especialidad=@id_especialidad

create proc Universidad.usp_AgregarEspecialidades
	@id_especialidad varchar(8),
	@nombreEspecialidad varchar(50),
	@id_carrera varchar(8)
	as
	insert Universidad.Especialidades values (@id_especialidad,@nombreEspecialidad,@id_carrera)
		
create proc Universidad.usp_BuscarxIdEspecialidades
	@id_especialidad varchar(8)
	as
	select * from Universidad.vw_Especialidades
	where Clave_Especialidad=@id_especialidad

create proc Universidad.usp_ConsultarEspecialidades
	as
	select * from Universidad.vw_Especialidades

create procedure Universidad.usp_EliminarEspecialidades
	@id_especialidad varchar(8)
	as
	delete from Universidad.Especialidades
	where id_especialidad=@id_especialidad

create proc Universidad.usp_ActualizarMaterias
	@id_materia smallint,
	@nombreMateria varchar(50),
	@id_carrera varchar(8)
	as 
	update Universidad.Materias
	set nombreMateria=@nombreMateria,id_carrera=@id_carrera
	where id_materia=@id_materia

create proc Universidad.usp_AgregarMaterias
	@nombreMateria varchar(50),
	@id_carrera varchar(8)
	as
	insert Universidad.Materias values (@nombreMateria,@id_carrera)
		
create proc Universidad.usp_BuscarxIdMaterias
	@id_materia smallint
	as
	select * from Universidad.vw_Materias
	where Clave_Materia=@id_materia

create proc Universidad.usp_ConsultarMaterias
	as
	select * from Universidad.vw_Materias

create procedure Universidad.usp_EliminarMaterias
	@id_materia smallint
	as
	delete from Universidad.Materias
	where id_materia=@id_materia

create proc Estudiantes.usp_ActualizarAlumnos
	@numControl varchar(8),
	@apePat varchar(20),
	@apeMat varchar(20),
	@nombre varchar(20),
	@sexo varchar(1),
	@curp varchar(18),
	@id_carrera varchar(8),
	@id_especialidad varchar(8)
	as 
	update Estudiantes.Alumnos
	set apePat=@apePat,apeMat=@apeMat,nombre=@nombre,sexo=@sexo,curp=@curp,id_carrera=@id_carrera,id_especialidad=@id_especialidad
	where numControl=@numControl

create proc Estudiantes.usp_AgregarAlumnos
	@numControl varchar(8),
	@apePat varchar(20),
	@apeMat varchar(20),
	@nombre varchar(20),
	@sexo varchar(1),
	@curp varchar(18),
	@id_carrera varchar(8),
	@id_especialidad varchar(8)
	as
	insert Estudiantes.Alumnos values (@numControl,@apePat,@apeMat,@nombre,@sexo,@curp,@id_carrera,@id_especialidad)
		
create proc Estudiantes.usp_BuscarxIdAlumnos
	@numControl varchar(8)
	as
	select * from Estudiantes.vw_Alumnos
	where Numero_Control=@numControl

create proc Estudiantes.usp_ConsultarAlumnos
	as
	select * from Estudiantes.vw_Alumnos

create procedure Estudiantes.usp_EliminarAlumnos
	@numControl varchar(8)
	as
	delete from Estudiantes.Alumnos
	where numControl=@numControl

create proc Estudiantes.usp_ActualizarCalificaciones
	@id_calificacion bigint,
	@calificacion tinyint,
	@id_alumno varchar(8),
	@id_materia smallint
	as 
	update Estudiantes.Calificaciones
	set calificacion=@calificacion,id_alumno=@id_alumno,id_materia=@id_materia
	where id_calificacion=@id_calificacion

create proc Estudiantes.usp_AgregarCalificaciones
	@calificacion tinyint,
	@id_alumno varchar(8),
	@id_materia smallint
	as
	insert Estudiantes.Calificaciones values (@calificacion,@id_alumno,@id_materia)
		
create proc Estudiantes.usp_BuscarxIdCalificaciones
	@id_calificacion bigint
	as
	select * from Estudiantes.vw_Calificaciones
	where Clave_Calificacion=@id_calificacion

create proc Estudiantes.usp_ConsultarCalificaciones
	as
	select * from Estudiantes.vw_Calificaciones

create procedure Estudiantes.usp_EliminarCalificaciones
	@id_calificacion bigint
	as
	delete from Estudiantes.Calificaciones
	where id_calificacion=@id_calificacion