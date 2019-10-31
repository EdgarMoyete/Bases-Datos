--Edgar Moises
use BD_VIDEOCLUB;

select * from TBL_CLASIFICACIONES
select * from TBL_CLIENTES
select * from TBL_DETALLE_RENTA
select * from TBL_FECHAS
select * from TBL_FORMATOS
select * from TBL_GENEROS
select * from TBL_INVENTARIO_PELICULAS
select * from TBL_RENTAS
select * from TBL_SUCURSALES
select * from TBL_TITULOS
--1.-select, where

--1.A
select id_cliente,nombre+' '+apepat+' '+apemat as NombreCompleto,edad from TBL_CLIENTES
where edad between 25 and 30

select id_cliente,apepat,apemat,nombre,edad from TBL_CLIENTES
where edad between 25 and 30

--1.B
select apepat+' '+apemat+' '+nombre as NombreCompleto,sexo from TBL_CLIENTES
where apepat in('PABLO','LOPEZ','GUTIERREZ') and edad < 30

select apepat,apemat,nombre,sexo from TBL_CLIENTES
where apepat in('PABLO','LOPEZ','GUTIERREZ') and edad < 30

--1.C
select titulo from TBL_TITULOS
where (id_genero=1 or id_clasificacion=3) and duracion>100

--1.D
select nombre_genero from TBL_GENEROS
where nombre_genero like 'A%'

--1.E
select titulo from TBL_TITULOS
where titulo like '%T%' and id_genero between 1 and 5

--2.-Unión,Intersección,Diferencia,Producto Cartesiano

--2.A
select * from TBL_CLASIFICACIONES
cross join TBL_GENEROS
where id_genero in(1,3,5)

--2.B
select nombre_genero from TBL_GENEROS
where id_genero >= 5
union
select titulo from TBL_TITULOS
where duracion > 100
union
select nombre_formato from TBL_FORMATOS
where id_formato in(1,3)
union
select nombre_clasificacion from TBL_CLASIFICACIONES

--2.C
select nombre_formato from TBL_FORMATOS
where id_formato in(
	select id_formato from TBL_INVENTARIO_PELICULAS)

--2.D
select titulo from TBL_TITULOS
where id_titulo in(
	select id_titulo from TBL_INVENTARIO_PELICULAS) and duracion between 90 and 100

--2.E
select nombre_formato from TBL_FORMATOS
where id_formato not in(
	select id_formato from TBL_INVENTARIO_PELICULAS)

--3.-Funciones de Agregación

--3.A
select sum(duracion) as DuracionTotal from TBL_TITULOS
where id_genero=2

--3.B
select avg(edad) as PromedioEdad from TBL_CLIENTES
where sexo='F' and edad>25

--3.C
select count(*) as TotalPeliculas from TBL_INVENTARIO_PELICULAS
where id_sucursal=3

--3.D
select min(edad) as EdadMinima from TBL_CLIENTES
where apepat='PEREZ' or sexo = 'M'

--3.E
select id_genero from TBL_TITULOS group by id_genero

--4.-Sentencias de Ordenamiento

--4.A
select apepat,apemat,nombre,edad from TBL_CLIENTES
order by edad desc,sexo

--4.B
select * from TBL_INVENTARIO_PELICULAS
order by id_sucursal

--4.C
select apepat,apemat,nombre from TBL_CLIENTES
order by apepat,apemat,nombre

select apepat+' '+apemat+' '+nombre as NombreCompleto from TBL_CLIENTES
order by apepat,apemat,nombre

--4.D
select * from TBL_GENEROS
where id_genero in(1,5,6)
order by nombre_genero desc

--4.E
select * from TBL_SUCURSALES
where id_sucursal in (1,3)
order by localidad desc

--5.-Sub-Consultas

--5.A
select titulo from TBL_TITULOS
where duracion >= (
	select avg(duracion) from TBL_TITULOS)

--5.B
select nombre from TBL_CLIENTES
where edad=(select min(edad) from TBL_CLIENTES)

select apepat,apemat,nombre from TBL_CLIENTES
where edad=(select min(edad) from TBL_CLIENTES)

--5.C
select apepat,apemat,nombre,edad,sexo from TBL_CLIENTES
where edad<(
	select avg(edad) from TBL_CLIENTES
	where sexo='F' and edad between 25 and 30)

--5.D
select titulo,duracion from TBL_TITULOS
where id_clasificacion in(1,4) and duracion > (
	select avg(duracion) from TBL_TITULOS 
	where id_genero = 1)

--5.E
select *from TBL_CLIENTES
where sexo = 'F' and edad < 25
order by apepat,apemat,nombre

select count(*) as Total from TBL_CLIENTES
where sexo = 'F' and edad < 25