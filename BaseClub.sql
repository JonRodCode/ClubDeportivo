drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;


DELIMITER //

CREATE PROCEDURE VerClientes()
begin
	select * from clientes;
end//

CREATE PROCEDURE IngresoLogin (IN Usu VARCHAR(20), IN Pass VARCHAR(15))   begin
  
  select NomRol
	from usuarios u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass
			and Activo = 1; 
end//

CREATE PROCEDURE NuevoCliente (IN Nom VARCHAR(30), IN Ape VARCHAR(40), IN Tip VARCHAR(20), IN Doc INT,
IN Mail varchar(80),IN Celular int(20), IN AptoFisico boolean, IN EsSocio boolean, OUT rta INT) 
begin
     declare filas int default 0;
	 declare existe int default 0;
     declare IdNuevoCliente int default 0;
    
     set filas = (select count(*) from socios);
     if filas = 0 then
		set filas = 452; /* consideramos a este numero como el primer numero de Socio */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de Socio almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(IdSocio) + 1 from socios);
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el Cliente
		------------------------------------------------------- */	
		set existe = (select count(*) from clientes where TdocC = Tip and DocC = Doc);
     end if;
	 
	  if existe = 0 then	
			/* Insertamos el nuevo cliente y luego capturamos su ID*/
		 insert into clientes values(null,Nom,Ape,Tip,Doc,Mail,Celular,AptoFisico); 
		 set IdNuevoCliente = (select max(nCliente) from clientes);
         
         /* Insertamos el nuevo cliente en la tabla correspondiente si quiere ser Socio o No Socio*/
         if EsSocio = true then
            insert into socios values(filas, IdNuevoCliente);
		 else
			insert into nosocios(NCliente) values(IdNuevoCliente);
         end if;
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
end //

CREATE PROCEDURE NuevaCuota (IN Tipo VARCHAR(40), IN Fecha date, IN FechaVencimiento date,
IN NCliente int,IN Precio decimal(20,2), OUT rta INT) 
begin      
		 insert into pagos values(null,Tipo,Fecha,FechaVencimiento,NCliente,Precio); 
		 set rta  = (select max(CodPago) from pagos);	 
end //
DELIMITER ;

CREATE TABLE clientes (
  NCliente int(11) auto_increment,
  Nombre varchar(30),
  Apellido varchar(40),
  TDocC varchar(20),
  DocC int(11),
  Mail varchar(80),
  Celular int(20),
  AptoFisico boolean not NULL,
  constraint pk_cliente primary key (NCliente)
);

INSERT INTO clientes VALUES
(null,'Lucre', 'Lucre', 'DNI', 111, 'lucre@lucre.com', 112233, true),
(null,'Joni', 'Joni', 'DNI', 222, 'joni@joni.com', 112233, true),
(null,'Sara', 'Sara', 'DNI', 333, 'sara@sara.com', 112233, false);

CREATE TABLE socios (
  IdSocio int(11),
  NCliente int(11) DEFAULT NULL,
  constraint pk_socio primary key (IdSocio),
  constraint fk_clienteSocio foreign key(NCliente) references clientes(NCliente)
) ;

INSERT INTO socios VALUES
(452,1),
(453, 2);

CREATE TABLE nosocios (
  Idnosocio int(11) AUTO_INCREMENT,
  NCliente int(11) DEFAULT NULL,
  constraint pk_nosocio primary key (Idnosocio),
  constraint fk_clienteNoSocio foreign key(NCliente) references clientes(NCliente)
) ;
INSERT INTO nosocios(NCliente) VALUES
(3);

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuarios(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuarios(CodUsu,NombreUsu,PassUsu,RolUsu) values
(26,'Mari2023','123456',120);

create table pagos(
CodPago int auto_increment,
Tipo varchar(30),
Fecha date,
FechaVencimiento date,
NCliente int,
Precio decimal(20,2),
constraint pk_pagos primary key (CodPago),
constraint fk_pagos foreign key(NCliente) references Clientes(NCliente)
);

insert into pagos values
(null, 'Cuota Mensual', '2024/07/07', '2024/08/07', 1, 55);

create table cuotamensual(
Id int auto_increment,
Precio decimal(20,2),
constraint pk_cuotamensual primary key (Id)
);

insert into cuotamensual values
(null, 12541.99);

create table profesores(
NProfesor int auto_increment,
Nombre varchar(30),
Apellido varchar(40),
constraint pk_profesores primary key (NProfesor)
);

insert into profesores values
(null, 'Leo', 'Messi'),
(null, 'Manu', 'Ginobili'),
(null, 'Tiger', 'Woods'),
(null, 'Serena', 'Williams');

create table actividades(
Id int auto_increment,
Nombre varchar(50),
Precio decimal(20,2),
NProfesor int,
constraint pk_actividad primary key (Id)
);

insert into actividades values
(null, 'Tenis', 3934.1, 2),
(null, 'Futbol', 5401.2, 3),
(null, 'Basquet', 4608.3, 4),
(null, 'MiniGolf', 9925.4, 1)
;







