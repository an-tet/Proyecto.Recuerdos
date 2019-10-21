USE master
CREATE DATABASE recuerdos
GO
USE recuerdos
GO
CREATE TABLE directorio
(
id BIGINT IDENTITY PRIMARY KEY NOT NULL,
id_padre BIGINT,
nombre NVARCHAR(MAX),
id_usuarios BIGINT NOT NULL
 );
GO
CREATE TABLE archivo
(
id BIGINT IDENTITY PRIMARY KEY NOT NULL,
nombre NVARCHAR(MAX),
contenido NVARCHAR(MAX),
id_directorio BIGINT,
pendiente BIT,
id_usuarios BIGINT NOT NULL
);

CREATE TABLE usuarios
(
	id BIGINT IDENTITY PRIMARY KEY NOT NULL,
	usuario VARCHAR(16),
	contracena VARCHAR(20)
)

ALTER TABLE directorio ADD FOREIGN KEY(id_usuarios) REFERENCES usuarios(id);
ALTER TABLE archivo ADD FOREIGN KEY(id_usuarios) REFERENCES usuarios(id);


select d.id,d.nombre,d.id_padre,a.id,a.nombre,a.id_directorio,a.contenido from directorio d full join  archivo a
on a.id_directorio=d.id

select d.id,d.nombre,d.id_padre from directorio d inner join usuarios u on d.id_usuarios=u.id where d.id_usuarios=1
select a.id,a.nombre,a.id_directorio,a.contenido from archivo a inner join usuarios u on u.id=a.id_directorio where a.id_usuarios=1
-- ALTER TABLE archivo ADD FOREIGN KEY(id_directorio) REFERENCES directorio(id);