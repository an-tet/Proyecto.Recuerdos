USE master
CREATE DATABASE recuerdos
GO
USE recuerdos
GO
CREATE TABLE directorio
(
id BIGINT PRIMARY KEY NOT NULL,
id_padre BIGINT,
nombre NVARCHAR(MAX)
 );
GO
CREATE TABLE archivo
(
id BIGINT NOT NULL,
nombre NVARCHAR(MAX),
id_directorio BIGINT,
contenido NVARCHAR(MAX),
pendiente BIT
);

ALTER TABLE archivo ADD FOREIGN KEY(id_directorio) REFERENCES directorio(id);