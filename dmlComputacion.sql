create database dmlComputacion;
use dmlComputacion;

create table Procesadores(
	id_cpu varchar(8) constraint pk_idPro primary key,
	marca varchar(20) not null,
	modelo varchar(20) not null,
	frecuencia smallint not null,
	turboBoost smallint not null,
	nucleos tinyint not null,
	subnucleos tinyint not null,
	cache tinyint not null
);

create table Memorias(
	id_ram varchar(8) constraint pk_idMem primary key,
	marca varchar(20) not null,
	tipo varchar(5) not null,
	capacidad tinyint not null,
	velocidad smallint not null
);

create table TarjetasVideo(
	id_gpu varchar(8) constraint pk_idTaV primary key,
	marca varchar(20) not null,
	modelo varchar(10) not null,
	capacidad smallint not null,
	frecuencia smallint not null,
	frecuenciaMaxima smallint
);

create table DiscosDuros(
	id_discoDuro varchar(8) constraint pk_idDiD primary key,
	marca varchar(20) not null,
	modelo varchar(10) not null,
	tipo varchar(3) not null,
	capacidad smallint not null,
	velocidad smallint
);

create table Computadoras(
	numSerie varchar(8) constraint pk_idCom primary key,
	marca varchar(20) not null,
	modelo varchar(20) not null,
	tipo varchar(10) not null,
	color varchar(10) not null,
	tipoPantalla varchar(5) not null,
	pulgadasPantalla tinyint not null,
	anchoPantalla smallint not null,
	altoPantalla smallint not null,
	ranuras varchar(200) not null,
	bateria smallint not null,
	unidadOptica bit not null,
	tecladoIluminado bit not null,
	detectorHuella bit not null,
	peso float,
	sistemaOperativo varchar(10) not null,
	versionSO varchar(20) not null,
	id_procesador varchar(8) constraint fk_idComPro foreign key references Procesadores on update cascade on delete set null,
	id_memoria varchar(8) constraint fk_idComMem foreign key references Memorias on update cascade on delete set null,
	id_tarjetaVideo varchar(8) constraint fk_idComTaV foreign key references TarjetasVideo on update cascade on delete set null,
	id_discoDuro varchar(8) constraint fk_idComDiD foreign key references DiscosDuros on update cascade on delete set null
);

select * from TarjetasVideo

insert Memorias values 
	('0001AAAB','Kigston','DDR4',8,1800),
	('0001AAAC','HP','DDR3',2,1333),
	('0001AAAD','GIGABYTE','DDR2',1,800),
	('0001AAAE','Kigston','DDR',1,600),
	('0001AAAF','Kigston','DDR',1,800),
	('0001AAAG','Kigston','DDR4',8,2400),
	('0001AAAH','Kigston','DDR4',16,3600)

create table Memorias_CopiaSeguridad(
	id_ram varchar(8) constraint pk_idCoS primary key,
	marca varchar(20) not null,
	tipo varchar(5) not null,
	capacidad tinyint not null,
	velocidad smallint not null
);

select * into Carreras_Backup1
from Memorias where capacidad=1

insert Memorias_CopiaSeguridad select * from Memorias where marca='GIGABYTE'
--insert Memorias_CopiaSeguridad select * from Memorias where marca in('GIGABYTE') otra opcion
--insert Memorias_CopiaSeguridad select * from Memorias where marca like 'GIGABYTE' otra opcion

select * from Memorias
select * from Memorias_CopiaSeguridad
select * from Carreras_Backup1

update Memorias
set marca='Intel',tipo='DDR5',capacidad=32,velocidad=1800
where id_ram='0001AAAC'

delete from Memorias where marca in ('Kigston')