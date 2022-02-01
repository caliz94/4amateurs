/* insertar usuario/integrante */
create proc sp_insertar_integrante
(
@USUARIO VARCHAR(100),
@CELULAR VARCHAR(30),
@PAIS_NACIONALIDAD VARCHAR (100),
@FECHA_INGRESO DATETIME,
@COMENTARIO VARCHAR(100),
@ESTADO VARCHAR(100)
)
as
INSERT INTO INTEGRANTES VALUES(@USUARIO,@CELULAR,@PAIS_NACIONALIDAD,@FECHA_INGRESO,@COMENTARIO,@ESTADO)
go

/*insertar reg de placas*/
create proc sp_reg_placas
(
@ID_INTEGRANTE INT,
@R_PLACAS INT,
@MES VARCHAR(100),
@SEMANA VARCHAR(100)
)
as
INSERT INTO PLACAS VALUES(@ID_INTEGRANTE,@R_PLACAS,@MES,@SEMANA)
GO

/*insertar reg de PARTICIPACIONES*/
create proc sp_reg_participaciones
(
@ID_INTEGRANTE INT,
@PARTICIPACIONES INT,
@FECHA_PARTICIPACION DATETIME,
@TIPO_DE_SALA VARCHAR(100)
)
as
INSERT INTO PARTICIPACION VALUES(@ID_INTEGRANTE,@PARTICIPACIONES,@FECHA_PARTICIPACION,@TIPO_DE_SALA)
GO
--placas del mes de cada uno de los integrantes
ALTER proc placas_mes
as
select i.USUARIO,sum(P.R_PLACAS) as PlacasMes from INTEGRANTES as I
inner join PLACAS AS P ON P.ID_INTEGRANTE = I.ID_INTEGRANTE where p.id_mes=month(getdate()) AND I.ESTADO = 'ACTIVO' GROUP BY i.USUARIO,p.R_PLACAS order by R_PLACAS desc
go

--placas del mes de cada uno de los integrantes
ALTER proc mejores_5_mes
as
select top 5 i.USUARIO,sum(P.R_PLACAS) as PlacasMes from INTEGRANTES as I
inner join PLACAS AS P ON P.ID_INTEGRANTE = I.ID_INTEGRANTE where p.id_mes=month(getdate()) AND I.ESTADO = 'ACTIVO' GROUP BY i.USUARIO order by COUNT(5) desc
go

--vistan de placas anuales para conbinar con sp_anual
ALTER view vw_placas_anuales
as
select f.id_mes,sum(R_PLACAS) as total from PLACAS as p  
inner join  fecha as f on f.id_mes = P.id_mes Group by f.id_mes 
go

--procedimiento almacenado de placas del año
alter proc sp_anual
as
select total,mes from vw_placas_anuales as p 
inner join fecha as f on p.id_mes =f.id_mes   order by f.id_mes 
go

--sp para mostrar integrantes
create proc sp_MostrarIntegrantes
as
select ID_INTEGRANTE,USUARIO from INTEGRANTES where ESTADO = 'activo'
go

--placas de usuario al año
select i.ID_INTEGRANTE,i.USUARIO,i.CELULAR,i.PAIS_NACIONALIDAD,p.R_PLACAS,f.mes,p.id_semana from INTEGRANTES as i
inner join PLACAS as p on i.ID_INTEGRANTE=p.ID_INTEGRANTE
inner join fecha as f on p.id_mes = f.id_mes where i.ID_INTEGRANTE = 1

go
--placas de usuario en el mes
alter proc int_mes_graf
(
@id_integrante int
)
as
select i.ID_INTEGRANTE,i.USUARIO,i.CELULAR,i.PAIS_NACIONALIDAD,p.R_PLACAS,f.mes,p.id_semana from INTEGRANTES as i
inner join PLACAS as p on i.ID_INTEGRANTE=p.ID_INTEGRANTE
inner join fecha as f on p.id_mes = f.id_mes where i.ID_INTEGRANTE = 1 and f.id_mes = month(getdate()) order by f.id_mes desc 
go

--placas de usuario en el mes
alter proc grafi_mes_inte
(
@id_integrante int
)
as
select R_PLACAS, p.id_semana from PLACAS as p
inner join fecha as f on p.id_mes = f.id_mes where p.ID_INTEGRANTE = @id_integrante and f.id_mes = month(getdate()) order by f.id_mes desc
go

create proc grafi_año_inte
(
@id_integrante int
)
as
select sum(R_PLACAS), f.mes from PLACAS as p
inner join fecha as f on p.id_mes = f.id_mes where p.ID_INTEGRANTE = @id_integrante group by mes
go


--mostrar todos los usuarios
create proc verusuarios
as
select * from integrantes
go

select month(getdate())