create database Pizza;

use Pizza;

create table usuarios(
			id_cliente int not null primary key identity(1,1),
			nombre varchar(30),
			contrasena varchar(30),
			t_usuario varchar(15)
			)

insert usuarios(nombre , contrasena ,t_usuario )
values('Ismael' , '2111' ,'administrador' )
insert usuarios(nombre , contrasena ,t_usuario )
values('Jose' , '2116' ,'usuario' )


select *from usuarios;
drop table usuarios;