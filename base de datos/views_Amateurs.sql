
create view v_PLAC_MES
AS
SELECT USUARIO,R_PLACAS,MES,SEMANA,PARTICIPACIONES,FECHA_PARTICIPACION,COMENTARIO FROM INTEGRANTES AS I
INNER JOIN PLACAS AS PL ON I.ID_INTEGRANTE = PL.ID_INTEGRANTE
INNER JOIN PARTICIPACION AS PA ON I.ID_INTEGRANTE = PA.ID_INTEGRANTE
WHERE I.ESTADO = 'ACTIVO' 
GO

