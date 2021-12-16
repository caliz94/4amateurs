CREATE DATABASE AMATEURS
GO
USE AMATEURS
GO

CREATE TABLE INTEGRANTES
(
ID_INTEGRANTE INT IDENTITY NOT NULL,
USUARIO VARCHAR(100) NOT NULL,
CELULAR VARCHAR(30) NOT NULL,
PAIS_NACIONALIDAD VARCHAR (100) NOT NULL,
FECHA_INGRESO DATETIME NOT NULL,
COMENTARIO VARCHAR(100),
ESTADO BIT NOT NULL
)
go

CREATE TABLE PLACAS
(
ID_INTEGRANTE INT NOT NULL,
ID_REGISTRO INT IDENTITY NOT NULL,
R_PLACAS INT NOT NULL,
id_mes int not null,
id_semana int not null
)
go

create table fecha
(
id_mes int not null,
mes varchar(50) not null
)
go

create TABLE PARTICIPACION
(
ID_INTEGRANTE INT NOT NULL,
PARTICIPACIONES INT NOT NULL,
FECHA_PARTICIPACION DATETIME NOT NULL,
TIPO_DE_SALA VARCHAR(100) NOT NULL
)
GO

SELECT * FROM INTEGRANTES
SELECT * FROM PLACAS order by id_mes
SELECT * FROM PARTICIPACION
SELECT * FROM fecha

INSERT INTO INTEGRANTES VALUES('USUARIO24','+505 8888-8888','NICARAGUA',16/11/2021,'NINGUNO','ACTIVO')

INSERT INTO PARTICIPACION VALUES(2,1,'16/11/2021','AMISTOSA')

insert into fecha values (1,'Enero')
insert into fecha values (2,'Febreo')
insert into fecha values (3,'Marzo')
insert into fecha values (4,'Abril')
insert into fecha values (5,'Mayo')
insert into fecha values (6,'Junio')
insert into fecha values (7,'Julio')
insert into fecha values (8,'Agosto')
insert into fecha values (9,'Septiembre')
insert into fecha values (10,'Octubre')
insert into fecha values (11,'Noviembre')

INSERT INTO PLACAS VALUES(22,700,11,1)
INSERT INTO PLACAS VALUES(2,20,11,3)
INSERT INTO PLACAS VALUES(3,30,11,1)
INSERT INTO PLACAS VALUES(4,40,11,1)
INSERT INTO PLACAS VALUES(5,50,11,1)
INSERT INTO PLACAS VALUES(6,60,11,1)
INSERT INTO PLACAS VALUES(7,70,11,1)
INSERT INTO PLACAS VALUES(8,50,11,1)
INSERT INTO PLACAS VALUES(9,90,11,1)
INSERT INTO PLACAS VALUES(3,100,11,1)
INSERT INTO PLACAS VALUES(11,100,11,1)
INSERT INTO PLACAS VALUES(12,140,11,1)