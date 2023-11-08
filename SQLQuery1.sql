create database p5
use p5
create table persona(cod int identity primary key not null,
nombre nvarchar (250),
apellido nvarchar (250),
ci nvarchar (250),
cel nvarchar (250),
usuario nvarchar (250),
contrasena nvarchar (250))

insert into persona
(nombre,apellido,ci,cel,usuario,contrasena)
values ('jose','alanoca','111','789','jose','123456');

select*from persona