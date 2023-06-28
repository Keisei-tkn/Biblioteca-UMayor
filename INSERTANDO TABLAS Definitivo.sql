
USE BibliotecaMayor;

--AGREGANDO USUARIOS A AL TABLA
INSERT INTO USUARIO(id_usuario,nombre_usuario, apellido_usuario, correo_usuario, contraseña,tipo_usuario)
VALUES ('15.712.131-6','Pedro','Araya','pedro.araya@mayor.cl','9Sxa13','Profesor'),
       ('17.987.622-K','Daniela','Miranda','daniela.miranda@mayor.cl','dm1022','Profesor'),
	   ('14.812.621-2','Lorena','Acuña','lorena.acuña@mayor.cl','lorena55','Profesor'),
       ('21.007.687-5','Vicente','del Hierro','vicente.delhierro@mayor.cl','trentre','Alumno'),
	   ('21.258.356-9','Jonathan','Contreras','jonathan.contreras@mayor.cl','yoni123','Alumno'),
	   ('13.178.024-9','Maria','Muñoz','maria.muñoz@mayor.cl','mari942','Funcionario'),
	   ('14.979.037-6','Edmundo','Pérez','edmundo.perez@mayor.cl','contraseña','Funcionario'),
	   ('16.418.647-3','Benjamín','Droguett','benjamin.droguett@mayor.cl','eldrogas69','Funcionario'),
	   ('19.455.358-4','Jorge','Reyes','jorge.reyes@mayor.cl','12345678','Externo'),
	   ('19.959.065-7','Tomas','Gonzalez','tomas.gonzalez@mayor.cl','tomasg19','Externo');

--AGREGANDO NUCLEOS
INSERT INTO NUCLEO(id_nucleo,nombre)
VALUES('XWH774','Mátematica'),
      ('JGG346','Informatica');

--AGREGANDO DEPARTAMENTOS
INSERT INTO DEPARTAMENTO(id_departamento,nombre,presupuesto)
VALUES('RJE801','Restauracion',1000000),
      ('WXE831','Logística',1000000);

--AGREDANDO PROFESORES
INSERT INTO PROFESOR(id_usuario, id_nucleo)
VALUES ('15.712.131-6','XWH774'),
       ('17.987.622-K','XWH774'),
	   ('14.812.621-2','JGG346');

--AGREGANDO ALUMNOS
INSERT INTO ALUMNO(id_usuario,sede)
VALUES ('21.007.687-5','Manuel Montt'),
	   ('21.258.356-9','Manuel Montt');

-- AGREGANDO FUNCIONARIOS
INSERT INTO FUNCIONARIO(id_funcionario,id_usuario,contraseña_c)
VALUES ('CIA723','13.178.024-9','4456M7'),
	   ('ADG688','14.979.037-6','1512E1'),
	   ('NMM805','16.418.647-3','6969B7');

--AGREGANDO RELACION_FUNCIONARIO_DEPARTAMENTO
INSERT INTO RELACION_FUNCIONARIO_DEPARTAMENTO(id_departamento,id_funcionario)
VALUES('RJE801','CIA723'),
      ('RJE801','ADG688'),
      ('WXE831','NMM805');

--AGREGANDO EXTERNOS
INSERT INTO EXTERNO(id_usuario,certificado_externo)
VALUES ('19.455.358-4','Verificado'),
       ('19.959.065-7','Verificado');

--AGREGANDO EDITORIALES
INSERT INTO EDITORIAL(id_editorial,nombre)
VALUES('CQZ387','RA-MA'),
	  ('DDR457','STARBOOK'),
	  ('PDR182','CENGAGE'),
	  ('AFV030','Zinet Media Global'),
	  ('ASK123','Francisco Fernandez'),
	  ('VGS492','The New York Festivals'),
	  ('JQW332','Zig-Zag');

--AGREGANDO AUTORES
INSERT INTO AUTOR(id_autor,nombre)
VALUES('UJQ726','Ron Larson'),
	  ('KFC817','Francisco J. Martin Manriquez'),
	  ('LAL192','Julio Gómez López'),
	  ('RLA637','Zinet Media Global'),
	  ('ABC821','Francisco Fernandez'),
	  ('KAS192','The New York Festivals'),
	  ('OOP123','Zig-Zag');

--AGREGANDO MATERIA
INSERT INTO MATERIA(id_materia,nombre_materia)
VALUES('ZQW779','Informática'),
      ('ZWA707','Matemática'),
	  ('OEI519','Ciencia'),
	  ('PQL223','Otro');

--AGREGANDO MATERIAL
INSERT INTO MATERIAL(id_material,titulo,descripcion,fecha_publicacion,unidades_existentes,deposito_o_reserva,idioma,disponible,portada,id_autor,id_editorial,id_materia)
VALUES('ESM176','Cálculo Tomo 1','Libro de cálculo 1','2004/12/05',3,'Deposito','Español',1,'Multimedia\calculo1.jpg','UJQ726','PDR182','ZWA707'),
       ('JKA118','Administración de sistemas GNU/Linux','Libro informatica sobre GNU/Linux','2010/10/05',2,'Deposito','Español',1,'Multimedia\Administracion.jpg','LAL192','DDR457','ZQW779'),
	   ('GFT723','Muy interesante','Revista cientifica','2023/06/02',4,'Reserva','Español',1,'Multimedia\muy interesante.jpg','RLA637','AFV030','OEI519'),
	   ('QFW883','Nature','Revista cientifica','2023/06/02',4,'Reserva','Ingles',1,'Multimedia\nature.jpg','RLA637','AFV030','OEI519'),
	   ('BNH199','New York festivals','Grand award y medallas de oro 02/03','2002/07/03',1,'Deposito','español',1,'Multimedia\newyork.jpg','KAS192','VGS492','PQL223'),
	   ('QIW723','Diccionario traducción ingles','Diccionario de traduccion de ingles-español / español-ingles','2001/02/21',8,'Deposito','español',1,'Multimedia\diccionario.png','OOP123','JQW332','PQL223');

--AGREGANDO LIBROS
INSERT INTO LIBRO(id_material,num_pag,isbn)
VALUES('ESM176',784,'9786075220154'),
      ('JKA118',308,'978-8492650460');

--AGREGANDO REVISTAS
INSERT INTO REVISTA(id_material,num_revista,vol_revista)
VALUES('GFT723',96,06),
      ('QFW883',56,07);

--AGREGANDO AUDIOVISUALES
INSERT INTO AUDIOVISUAL(id_material,duracion)
VALUES('BNH199',12);

--AGREGANDO OTRO
INSERT INTO OTRO(id_material,categoria)
VALUES ('QIW723','Textos varios');


--AGREGANDO PRESTAMOS
INSERT INTO PRESTAMO(id_prestamo,fecha_prestamo,fecha_devolucion,activo,id_material)
VALUES('FTO542','2023/06/08','2023/06/04',0,'ESM176'),
      ('GYJ209','2023/06/05','2023/06/06',0,'GFT723'),
	  ('QCH348','2023/05/14','2023/05/22',0,'JKA118');

--AGREGANDO ATRASOS
INSERT INTO ATRASO(id_atraso,id_prestamo,multa, pagado)
VALUES('JJH227','QCH348',1000,0)


--AGREGANDO COPIAS
INSERT INTO COPIA(id_copia,id_material)
VALUES('A1','ESM176'),
      ('B1','QIW723'),
	  ('C1','JKA118'),
	  ('D1','GFT723'),
	  ('E1','QFW883');

--AGREGANDO HISTORIALES
INSERT INTO HISTORIAL(id_prestamo,id_usuario)
VALUES('FTO542','15.712.131-6'),
      ('GYJ209','21.007.687-5'),
	  ('QCH348','14.812.621-2');

