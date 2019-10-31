use BD_VIDEOCLUB;
--consultas
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

--union
select * from TBL_FORMATOS
union
select * from TBL_GENEROS

--diferencia
select id_formato from TBL_FORMATOS
except
select id_formato from TBL_INVENTARIO_PELICULAS

--interseccion
select id_formato from TBL_FORMATOS
intersect
select id_formato from TBL_INVENTARIO_PELICULAS

--reunion natural
select id_titulo,titulo,nombre_genero
from TBL_TITULOS as t
inner join TBL_GENEROS as g on t.id_genero=g.id_genero