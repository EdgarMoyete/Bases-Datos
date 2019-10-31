create database BD_EComputacion;
use BD_EComputacion;

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