USE master
CREATE DATABASE recuerdos
GO
USE recuerdos
GO
CREATE TABLE recuerdo
(
id BIGINT IDENTITY  NOT NULL,
id_usuario BIGINT NOT NULL,
id_padre BIGINT,
nombre NVARCHAR(MAX) NOT NULL,
tipo INT NOT NULL,
PRIMARY KEY (id,id_usuario)
 );
GO
CREATE TABLE sueno
(
id BIGINT IDENTITY NOT NULL,
id_usuario BIGINT NOT NULL,
id_recuerdo BIGINT NOT NULL,
nombre NVARCHAR(MAX) NOT NULL,
contenido NVARCHAR(MAX),
pendiente BIT NOT NULL,
PRIMARY KEY (id,id_usuario,id_recuerdo)
);

CREATE TABLE usuario
(
	id BIGINT IDENTITY PRIMARY KEY NOT NULL,
	usuario VARCHAR(16) NOT NULL,
	contracena VARCHAR(20) NOT NULL,
	nombre VARCHAR(20) NOT NULL,
	apellidos VARCHAR(20) NOT NULL,
	correo_electronico VARCHAR(30)
);

ALTER TABLE recuerdo ADD FOREIGN KEY(id_usuario) REFERENCES usuario(id);
ALTER TABLE sueno ADD FOREIGN KEY(id_recuerdo,id_usuario) REFERENCES recuerdo(id,id_usuario);


select d.id,d.nombre,d.id_padre,a.id,a.nombre,a.id_recuerdo,a.contenido from recuerdo d full join  sueno a
on a.id_recuerdo=d.id

select d.id,d.nombre,d.id_padre from recuerdo d inner join sueno u on d.id_usuario=u.id where d.id_usuario=1

select a.id,a.nombre,a.id_recuerdo,a.contenido from sueno a inner join sueno u on u.id=a.id_recuerdo where a.id_usuario=1
-- ALTER TABLE archivo ADD FOREIGN KEY(id_directorio) REFERENCES directorio(id);