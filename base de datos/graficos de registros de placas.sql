--suma total de placas del usuarioselect sum(R_PLACAS) as Total from PLACAS where ID_INTEGRANTE = 1
go

--promedio de placas del usuario
select SUM(R_PLACAS) / COUNT(ID_REGISTRO) as promedio_de_placas from PLACAS where ID_INTEGRANTE = 1
go

--rendimiento
declare @total_registros int
declare @participaciones int
set @total_registros=(select COUNT(R_PLACAS) from PLACAS where ID_INTEGRANTE = 1)
set @participaciones=(select COUNT(R_PLACAS)from PLACAS where R_PLACAS >= 100 and ID_INTEGRANTE = 1)
select @participaciones as participaciones,@total_registros as total
go

--placas del mes
 select SUM(R_PLACAS) as Mes_Actual from PLACAS where ID_INTEGRANTE = 1 and id_mes =  month(getdate())