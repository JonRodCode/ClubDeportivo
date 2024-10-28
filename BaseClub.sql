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
    
     set filas = (select count(*) from clientes);
     if filas = 0 then
		set filas = 452; /* consideramos a este numero como el primer numero de postulante */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de postulante almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(NCliente) + 1 from clientes);
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
		set existe = (select count(*) from clientes where TdocC = Tip and DocC = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into clientes values(filas,Nom,Ape,Tip,Doc,Mail,Celular,AptoFisico); 
         if EsSocio = true then
            insert into socios(NCliente) values(filas);
		 else
			insert into nosocios(NCliente) values(filas);
         end if;
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
     end //

DELIMITER ;

CREATE TABLE clientes (
  NCliente int(11) NOT NULL,
  NombreC varchar(30),
  ApellidoC varchar(40),
  TDocC varchar(20),
  DocC int(11),
  Mail varchar(80),
  Celular int(20),
  AptoFisico boolean not NULL,
  constraint pk_cliente primary key (NCliente)
);

INSERT INTO clientes VALUES
(452, 'Lucre', 'Lucre', 'DNI', 11222333, 'lucre@lucre.com', 112233, true);

CREATE TABLE socios (
  IdSocio int(11) AUTO_INCREMENT,
  NCliente int(11) DEFAULT NULL,
  constraint pk_socio primary key (IdSocio),
  constraint fk_clienteSocio foreign key(NCliente) references cliente(NCliente)
) ;

INSERT INTO socios(NCliente) VALUES
(452);

CREATE TABLE nosocios (
  Idnosocio int(11) AUTO_INCREMENT,
  NCliente int(11) DEFAULT NULL,
  constraint pk_nosocio primary key (Idnosocio),
  constraint fk_clienteNoSocio foreign key(NCliente) references cliente(NCliente)
) ;

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

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(26,'Mari2023','123456',120);






