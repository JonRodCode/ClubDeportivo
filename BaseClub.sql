drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;


DELIMITER //

CREATE PROCEDURE VerClientes()
begin
	select * from cliente;
end//

CREATE PROCEDURE IngresoLogin (IN Usu VARCHAR(20), IN Pass VARCHAR(15))   begin
  
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass
			and Activo = 1; 
end//

CREATE PROCEDURE NuevoCliente (IN Nom VARCHAR(30), IN Ape VARCHAR(40), IN Tip VARCHAR(20), IN Doc INT,
IN Mail varchar(80),IN Celular int(20), IN AptoFisico boolean, IN EsSocio boolean, OUT rta INT) 

begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from cliente);
     if filas = 0 then
		set filas = 452; /* consideramos a este numero como el primer numero de postulante */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de postulante almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(NCliente) + 1 from cliente);
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
		set existe = (select count(*) from cliente where TdocC = Tip and DocC = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into cliente values(filas,Nom,Ape,Tip,Doc,Mail,Celular,AptoFisico); 
         if EsSocio = true then
            insert into socio(NCliente) values(filas);
         end if;
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
     end //

DELIMITER ;

CREATE TABLE cliente (
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

INSERT INTO cliente VALUES
(452, 'Lucre', 'Lucre', 'DNI', 11222333, 'lucre@lucre.com', 112233, true);

CREATE TABLE socio (
  IdSocio int(11) AUTO_INCREMENT,
  NCliente int(11) DEFAULT NULL,
  constraint pk_socio primary key (IdSocio),
  constraint fk_cliente foreign key(NCliente) references cliente(NCliente)
) ;

INSERT INTO socio(NCliente) VALUES
(452);

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
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






