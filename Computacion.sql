create database BD_Computacion;
use BD_Computacion;

create schema Computacion;

create login LoginComputo
with password='arquicompu'

create user yo
for login LoginComputo

grant select
on schema::Computacion
to yo

grant exec
on schema::Computacion
to yo

--Tablas
create table Computacion.Procesadores(
	id_cpu varchar(8) constraint pk_idPro primary key,
	marca varchar(20) not null,
	modelo varchar(20) not null,
	frecuencia float not null,
	turboBoost float not null,
	nucleos tinyint not null,
	subnucleos tinyint not null,
	cache tinyint not null
);

create table Computacion.Memorias(
	id_ram varchar(8) constraint pk_idMem primary key,
	marca varchar(20) not null,
	tipo varchar(5) not null,
	capacidad tinyint not null,
	velocidad smallint not null
);

create table Computacion.TarjetasVideo(
	id_gpu varchar(8) constraint pk_idTaV primary key,
	marca varchar(20) not null,
	modelo varchar(10) not null,
	capacidad smallint not null,
	frecuencia smallint not null,
	frecuenciaMaxima smallint
);

create table Computacion.DiscosDuros(
	id_discoDuro varchar(8) constraint pk_idDiD primary key,
	marca varchar(20) not null,
	modelo varchar(10) not null,
	tipo varchar(3) not null,
	capacidad smallint not null,
	velocidad smallint
);

create table Computacion.Computadoras(
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
	id_procesador varchar(8) constraint fk_idComPro foreign key references Computacion.Procesadores on update cascade on delete set null,
	id_memoria varchar(8) constraint fk_idComMem foreign key references Computacion.Memorias on update cascade on delete set null,
	id_tarjetaVideo varchar(8) constraint fk_idComTaV foreign key references Computacion.TarjetasVideo on update cascade on delete set null,
	id_discoDuro varchar(8) constraint fk_idComDiD foreign key references Computacion.DiscosDuros on update cascade on delete set null
);

--Vistas
create view Computacion.vw_Procesadores
(Clave_CPU,Marca,Modelo,Frecuencia,TurboBoost,Nucleos,Subnucleos,Cache)
	as
	select * from Computacion.Procesadores

create view Computacion.vw_Memorias
(Clave_RAM,Marca,Tipo,Capacidad,Velocidad)
	as
	select * from Computacion.Memorias

create view Computacion.vw_TarjetasVideo
(Clave_GPU,Marca,Modelo,Capacidad,Frecuencia,FrecuenciaMaxima)
	as
	select * from Computacion.TarjetasVideo

create view Computacion.vw_DiscosDuros
(Clave_DiscoDuro,Marca,Modelo,Tipo,Capacidad,Velocidad)
	as
	select * from Computacion.DiscosDuros

create view Computacion.vw_Computadoras
(Numero_Serie,Marca,Modelo,Tipo,Color,Pantalla,Pulgadas_Pantalla,Ancho_Pantalla,Alto_Pantalla,Ranuras,Bateria,Unidad_Optica,Teclado_Iluminado,Detector_Huella,Peso,Sistema_Operativo,Version_Sistema_Operativo,Procesador,Marca_CPU,Modelo_CPU,Frecuencia_CPU,Memoria,Capacidad_RAM,Tarjeta_Video,Marca_GPU,Modelo_GPU,Capacidad_GPU,Disco_Duro,Tipo_Disco_Duro,Capacidad_Disco_Duro)
	as
	select c.numSerie,c.marca,c.modelo,c.tipo,c.color,c.tipoPantalla,c.pulgadasPantalla,c.anchoPantalla,c.altoPantalla,c.ranuras,c.bateria,c.unidadOptica,c.tecladoIluminado,c.detectorHuella,c.peso,c.sistemaOperativo,c.versionSO,p.id_cpu,p.marca,p.modelo,p.frecuencia,m.id_ram,m.capacidad,t.id_gpu,t.marca,t.modelo,t.capacidad,d.id_discoDuro,d.tipo,d.capacidad
	from Computacion.Computadoras as c
	inner join Computacion.Procesadores as p on c.id_procesador=p.id_cpu
	inner join Computacion.Memorias as m on c.id_memoria=m.id_ram
	inner join Computacion.TarjetasVideo as t on c.id_tarjetaVideo=t.id_gpu
	inner join Computacion.DiscosDuros as d on c.id_discoDuro=d.id_discoDuro

--Procedimientos Almacenados
--Procesadores
create proc Computacion.usp_ActualizarProcesadores
	@id_cpu varchar(8),
	@marca varchar(20),
	@modelo varchar(20),
	@frecuencia float,
	@turboBoost float,
	@nucleos tinyint,
	@subnucleos tinyint,
	@cache tinyint
	as 
	update Computacion.Procesadores
	set marca=@marca,modelo=@modelo,frecuencia=@frecuencia,turboBoost=@turboBoost,nucleos=@nucleos,subnucleos=@subnucleos,cache=@cache
	where id_cpu=@id_cpu

create proc Computacion.usp_AgregarProcesadores
	@id_cpu varchar(8),
	@marca varchar(20),
	@modelo varchar(20),
	@frecuencia float,
	@turboBoost float,
	@nucleos tinyint,
	@subnucleos tinyint,
	@cache tinyint
	as 
	insert Computacion.Procesadores values (@id_cpu,@marca,@modelo,@frecuencia,@turboBoost,@nucleos,@subnucleos,@cache)

create proc Computacion.usp_BuscarxIdProcesadores
	@id_cpu varchar(8)
	as
	select * from Computacion.vw_Procesadores where Clave_CPU=@id_cpu

create proc Computacion.usp_ConsultarProcesadores
	as
	select * from Computacion.vw_Procesadores

create procedure Computacion.usp_EliminarProcesadores
	@id_cpu varchar(8)
	as
	delete from Computacion.Procesadores where id_cpu=@id_cpu

--Memorias
create proc Computacion.usp_ActualizarMemorias
	@id_ram varchar(8),
	@marca varchar(20),
	@tipo varchar(5),
	@capacidad tinyint,
	@velocidad smallint
	as 
	update Computacion.Memorias
	set marca=@marca,tipo=@tipo,capacidad=@capacidad,velocidad=@velocidad
	where id_ram=@id_ram

create proc Computacion.usp_AgregarMemorias
	@id_ram varchar(8),
	@marca varchar(20),
	@tipo varchar(5),
	@capacidad tinyint,
	@velocidad smallint
	as 
	insert Computacion.Memorias values (@id_ram,@marca,@tipo,@capacidad,@velocidad)

create proc Computacion.usp_BuscarxIdMemorias
	@id_ram varchar(8)
	as
	select * from Computacion.vw_Memorias where Clave_RAM=@id_ram

create proc Computacion.usp_ConsultarMemorias
	as
	select * from Computacion.vw_Memorias

create procedure Computacion.usp_EliminarMemorias
	@id_ram varchar(8)
	as
	delete from Computacion.Memorias where id_ram=@id_ram

--Tarjetas Video
create proc Computacion.usp_ActualizarTarjetasVideo
	@id_gpu varchar(8),
	@marca varchar(20),
	@modelo varchar(10),
	@capacidad smallint,
	@frecuencia smallint,
	@frecuenciaMaxima smallint
	as 
	update Computacion.TarjetasVideo
	set marca=@marca,modelo=@modelo,capacidad=@capacidad,frecuencia=@frecuencia,frecuenciaMaxima=@frecuenciaMaxima
	where id_gpu=@id_gpu

create proc Computacion.usp_AgregarTarjetasVideo
	@id_gpu varchar(8),
	@marca varchar(20),
	@modelo varchar(10),
	@capacidad smallint,
	@frecuencia smallint,
	@frecuenciaMaxima smallint
	as 
	insert Computacion.TarjetasVideo values (@id_gpu,@marca,@modelo,@capacidad,@frecuencia,@frecuenciaMaxima)

create proc Computacion.usp_BuscarxIdTarjetasVideo
	@id_gpu varchar(8)
	as
	select * from Computacion.vw_TarjetasVideo where Clave_GPU=@id_gpu

create proc Computacion.usp_ConsultarTarjetasVideo
	as
	select * from Computacion.vw_TarjetasVideo

create procedure Computacion.usp_EliminarTarjetasVideo
	@id_gpu varchar(8)
	as
	delete from Computacion.TarjetasVideo where id_gpu=@id_gpu

--Discos Duros
create proc Computacion.usp_ActualizarDiscosDuros
	@id_discoDuro varchar(8),
	@marca varchar(20),
	@modelo varchar(10),
	@tipo varchar(3),
	@capacidad smallint,
	@velocidad smallint
	as 
	update Computacion.DiscosDuros
	set marca=@marca,modelo=@modelo,tipo=@tipo,capacidad=@capacidad,velocidad=@velocidad
	where id_discoDuro=@id_discoDuro

create proc Computacion.usp_AgregarDiscosDuros
	@id_discoDuro varchar(8),
	@marca varchar(20),
	@modelo varchar(10),
	@tipo varchar(3),
	@capacidad smallint,
	@velocidad smallint
	as 
	insert Computacion.DiscosDuros values (@id_discoDuro,@marca,@modelo,@tipo,@capacidad,@velocidad)

create proc Computacion.usp_BuscarxIdDiscosDuros
	@id_discoDuro varchar(8)
	as
	select * from Computacion.vw_DiscosDuros where Clave_DiscoDuro=@id_discoDuro

create proc Computacion.usp_ConsultarDiscosDuros
	as
	select * from Computacion.vw_DiscosDuros

create procedure Computacion.usp_EliminarDiscosDuros
	@id_discoDuro varchar(8)
	as
	delete from Computacion.DiscosDuros where id_discoDuro=@id_discoDuro

--Computadoras
create proc Computacion.usp_ActualizarComputadoras
	@numSerie varchar(8),
	@marca varchar(20),
	@modelo varchar(20),
	@tipo varchar(10),
	@color varchar(10),
	@tipoPantalla varchar(5),
	@pulgadasPantalla tinyint,
	@anchoPantalla smallint,
	@altoPantalla smallint,
	@ranuras varchar(200),
	@bateria smallint,
	@unidadOptica bit,
	@tecladoIluminado bit,
	@detectorHuella bit,
	@peso float,
	@sistemaOperativo varchar(10),
	@versionSO varchar(20),
	@id_procesador varchar(8),
	@id_memoria varchar(8),
	@id_tarjetaVideo varchar(8),
	@id_discoDuro varchar(8)
	as 
	update Computacion.Computadoras
	set marca=@marca,modelo=@modelo,tipo=@tipo,color=@color,tipoPantalla=@tipoPantalla,pulgadasPantalla=@pulgadasPantalla,anchoPantalla=@anchoPantalla,altoPantalla=@altoPantalla,ranuras=@ranuras,bateria=@bateria,unidadOptica=@unidadOptica,tecladoIluminado=@tecladoIluminado,detectorHuella=@detectorHuella,peso=@peso,sistemaOperativo=@sistemaOperativo,versionSO=@versionSO,id_procesador=@id_procesador,id_memoria=@id_memoria,id_tarjetaVideo=@id_tarjetaVideo,id_discoDuro=@id_discoDuro
	where numSerie=@numSerie

create proc Computacion.usp_AgregarComputadoras
	@numSerie varchar(8),
	@marca varchar(20),
	@modelo varchar(20),
	@tipo varchar(10),
	@color varchar(10),
	@tipoPantalla varchar(5),
	@pulgadasPantalla tinyint,
	@anchoPantalla smallint,
	@altoPantalla smallint,
	@ranuras varchar(200),
	@bateria smallint,
	@unidadOptica bit,
	@tecladoIluminado bit,
	@detectorHuella bit,
	@peso float,
	@sistemaOperativo varchar(10),
	@versionSO varchar(20),
	@id_procesador varchar(8),
	@id_memoria varchar(8),
	@id_tarjetaVideo varchar(8),
	@id_discoDuro varchar(8)
	as 
	insert Computacion.Computadoras values (@numSerie,@marca,@modelo,@tipo,@color,@tipoPantalla,@pulgadasPantalla,@anchoPantalla,@altoPantalla,@ranuras,@bateria,@unidadOptica,@tecladoIluminado,@detectorHuella,@peso,@sistemaOperativo,@versionSO,@id_procesador,@id_memoria,@id_tarjetaVideo,@id_discoDuro)

create proc Computacion.usp_BuscarxIdComputadoras
	@numSerie varchar(8)
	as
	select * from Computacion.vw_Computadoras where Numero_Serie=@numSerie

create proc Computacion.usp_ConsultarComputadoras
	as
	select * from Computacion.vw_Computadoras

create procedure Computacion.usp_EliminarComputadoras
	@numSerie varchar(8)
	as
	delete from Computacion.Computadoras where numSerie=@numSerie