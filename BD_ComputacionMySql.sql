create database BD_ComputacionMySql;
use BD_ComputacionMySql;

create table Procesadores(
	id_cpu varchar(8) primary key,
	marca varchar(20) not null,
	modelo varchar(20) not null,
	frecuencia smallint not null,
	turboBoost smallint not null,
	nucleos tinyint not null,
	subnucleos tinyint not null,
	cache tinyint not null
);

create table Memorias(
	id_ram varchar(8) primary key,
	marca varchar(20) not null,
	tipo varchar(5) not null,
	capacidad tinyint not null,
	velocidad smallint not null
);

create table TarjetasVideo(
	id_gpu varchar(8) primary key,
	marca varchar(20) not null,
	modelo varchar(10) not null,
	capacidad smallint not null,
	frecuencia smallint not null,
	frecuenciaMaxima smallint
);

create table DiscosDuros(
	id_discoDuro varchar(8) primary key,
	marca varchar(20) not null,
	modelo varchar(10) not null,
	tipo varchar(3) not null,
	capacidad smallint not null,
	velocidad smallint
);

create table Computadoras(
	numSerie varchar(8) primary key,
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
	id_procesador varchar(8) references Procesadores on update cascade,
	id_memoria varchar(8) references Memorias on update cascade,
	id_tarjetaVideo varchar(8) references TarjetasVideo on update cascade,
	id_discoDuro varchar(8) references DiscosDuros on update cascade
);

insert Procesadores values('AAAAAAAA','Intel','3210M',2500,3100,2,4,3)
insert Memorias values('AAAAAAAA','Kigston','DDR3',4,1666)
insert TarjetasVideo values('AAAAAAAA','Nvidia','Titan Z',8192,1000,1200)
insert DiscosDuros values('AAAAAAAA','Intel','HD710','SSD',1024,null)
insert Computadoras values
('AAAAAAAB','ASUS','SVE14','Laptop','Negra','LED',14,1920,1080,'HDMI,VGA,RJ45,3.5mm,Microfono,USB = 4x2.0 y 2x3.0',20000,1,1,0,2.1,'Windows 10','Pro 64 bits','AAAAAAAA','AAAAAAAA','AAAAAAAA','AAAAAAAA')

select * from Procesadores
select * from Memorias
select * from TarjetasVideo
select * from DiscosDuros
select * from Computadoras