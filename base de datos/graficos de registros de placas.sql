--suma total de placas del usuario
alter proc tt_placas
(
@Id_Integrante int
)
as
select sum(R_PLACAS) as Total from PLACAS where ID_INTEGRANTE = @Id_Integrante
go

--promedio de placas del usuario
alter PROC pm_placas
(
@id_integrante int
)AS
select (SUM(R_PLACAS) / COUNT(ID_REGISTRO)) as promedio_de_placas from PLACAS where ID_INTEGRANTE =@id_integrante
go


--placas del mes
alter proc sp_placasmes
(@id_integrante int
)as
 select SUM(R_PLACAS) as Mes_Actual from PLACAS where ID_INTEGRANTE = @id_integrante and id_mes =  month(getdate())
go

 --promedio de placas del mes
create PROC pm_placas_mes
(
@id_integrante int
)AS
select (SUM(R_PLACAS) / COUNT(ID_REGISTRO)) as promedio_de_placas from PLACAS where id_mes =  month(getdate()) and  ID_INTEGRANTE = @id_integrante
go
