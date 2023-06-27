CREATE DATABASE BibliotecaMayor;
USE BibliotecaMayor;

-- Tabla USUARIO
CREATE TABLE USUARIO (
    id_usuario VARCHAR(20) PRIMARY KEY,
    nombre_usuario VARCHAR(50),
	apellido_usuario VARCHAR(50),
    correo_usuario VARCHAR(50),
	contraseña VARCHAR(50)
);
-- Tabla MATERIA
CREATE TABLE MATERIA (
    id_materia VARCHAR(20) PRIMARY KEY,
    nombre_materia VARCHAR(50)
);
-- Tabla AUTOR
CREATE TABLE AUTOR (
    id_autor VARCHAR(20) PRIMARY KEY,
    nombre VARCHAR(50)
);
-- Tabla EDITORIAL
CREATE TABLE EDITORIAL (
    id_editorial VARCHAR(20) PRIMARY KEY,
    nombre VARCHAR(100)
);

-- Tabla MATERIAL
CREATE TABLE MATERIAL (
    id_material VARCHAR(20) PRIMARY KEY,
    titulo VARCHAR(100),
	descripcion VARCHAR(200),
	fecha_publicacion DATE,
	unidades_existentes INT,
	deposito_o_reserva VARCHAR(10),
	id_materia VARCHAR(20),
	id_autor VARCHAR(20),
	id_editorial VARCHAR(20),
	idioma VARCHAR(20),
	disponible BIT,
	portada VARCHAR(100),
    FOREIGN KEY (id_materia) REFERENCES MATERIA(id_materia),
	FOREIGN KEY (id_autor) REFERENCES AUTOR(id_autor),
	FOREIGN KEY (id_editorial) REFERENCES EDITORIAL(id_editorial)
);

-- Tabla COPIA
CREATE TABLE COPIA (
    id_copia VARCHAR(20) PRIMARY KEY,
	id_material VARCHAR(20),
    FOREIGN KEY (id_material) REFERENCES MATERIAL(id_material)
);

-- Tabla PRESTAMO
CREATE TABLE PRESTAMO (
    id_prestamo VARCHAR(20) PRIMARY KEY,
    fecha_prestamo DATE,
    fecha_devolucion DATE,
	id_material VARCHAR(20),
	FOREIGN KEY (id_material) REFERENCES MATERIAL(id_material)
);

--Tabla Historial
CREATE TABLE HISTORIAL(
	id_prestamo VARCHAR(20),
	id_usuario VARCHAR(20),
	FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario),
	FOREIGN KEY (id_prestamo) REFERENCES PRESTAMO(id_prestamo)
);
	

-- Tabla DEPARTAMENTO
CREATE TABLE DEPARTAMENTO (
    id_departamento VARCHAR(20) PRIMARY KEY,
	presupuesto DECIMAL,
    nombre VARCHAR(50),
);
-- Tabla NUCLEO
CREATE TABLE NUCLEO (
    id_nucleo VARCHAR(20) PRIMARY KEY,
    nombre VARCHAR(50)
);

-- Tabla ALUMNO
CREATE TABLE ALUMNO (
    id_usuario VARCHAR(20),
	sede VARCHAR(20)
    FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

-- Tabla PROFESOR
CREATE TABLE PROFESOR (
    id_usuario VARCHAR(20),
    id_nucleo VARCHAR(20),
    FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario),
    FOREIGN KEY (id_nucleo) REFERENCES NUCLEO(id_nucleo)
);

-- Tabla FUNCIONARIO
CREATE TABLE FUNCIONARIO (
	id_funcionario VARCHAR(20) PRIMARY KEY,
    id_usuario VARCHAR(20),
	contraseña_c VARCHAR(10),
    FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);
-- Tabla RELACION_FUNCIONARIO_DEPARTAMENTO
CREATE TABLE RELACION_FUNCIONARIO_DEPARTAMENTO (
    id_departamento VARCHAR(20),
	id_funcionario VARCHAR(20),
	FOREIGN KEY (id_departamento) REFERENCES DEPARTAMENTO(id_departamento),
	FOREIGN KEY (id_funcionario) REFERENCES FUNCIONARIO(id_funcionario)
);
-- Tabla ATRASO
CREATE TABLE ATRASO (
    id_atraso VARCHAR(20) PRIMARY KEY,
    id_prestamo VARCHAR(20),
	multa DECIMAL(10, 2),
	pagado BIT,
    FOREIGN KEY (id_prestamo) REFERENCES PRESTAMO(id_prestamo)
);

-- Tabla EXTERNO
CREATE TABLE EXTERNO (
    id_usuario VARCHAR(20),
    certificado_externo VARCHAR(50),
    FOREIGN KEY (id_usuario) REFERENCES USUARIO(id_usuario)
);

-- Tabla AUDIOVISUAL
CREATE TABLE AUDIOVISUAL (
    id_material VARCHAR(20),
    duracion INT,
    FOREIGN KEY (id_material) REFERENCES MATERIAL(id_material)
);
-- Tabla LIBRO
CREATE TABLE LIBRO (
    id_material VARCHAR(20),
    isbn VARCHAR(20),
    num_pag int,
    FOREIGN KEY (id_material) REFERENCES MATERIAL(id_material)
);

-- Tabla REVISTA
CREATE TABLE REVISTA (
    id_material VARCHAR(20),
    num_revista INT,
    vol_revista INT,
    FOREIGN KEY (id_material) REFERENCES MATERIAL(id_material)
);

--Tabla OTRO
CREATE TABLE OTRO(
	id_material VARCHAR(20),
	categoria VARCHAR(20),
	FOREIGN KEY (id_material) REFERENCES MATERIAL(id_material)
);

