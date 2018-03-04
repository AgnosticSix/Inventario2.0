/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2/10/2018 10:17:08 PM                        */
/*==============================================================*/

/*CREATE DATABASE inventario;*/
use inventario;

alter table inventarios drop foreign key if exists fk_reference_1;

alter table detalle_inventario drop foreign key if exists fk_reference_3;

alter table detalle_inventario drop foreign key if exists fk_reference_4;

alter table salones drop foreign key if exists fk_reference_2;

drop table if exists articulos;

drop table if exists detalle_inventario;

drop table if exists edificios;

drop table if exists inventarios;

drop table if exists salones;

/*==============================================================*/
/* Table: articulos                                             */
/*==============================================================*/
create table articulos
(
   id_articulo          int not null auto_increment,
   nombre               varchar(50) not null,
   descripcion          varchar(255),
   primary key (id_articulo)
);

/*==============================================================*/
/* Table: detalle_inventario                                    */
/*==============================================================*/
create table detalle_inventario
(
   id_inventario        int not null,
   id_articulo          int not null,
   cantidad             int not null,
   primary key (id_inventario, id_articulo)
);

/*==============================================================*/
/* Table: edificios                                             */
/*==============================================================*/
create table edificios
(
   id_edificio          int not null auto_increment,
   nombre               varchar(50) not null,
   descripcion          varchar(255),
   primary key (id_edificio)
);

/*==============================================================*/
/* Table: inventarios                                           */
/*==============================================================*/
create table inventarios
(
   id_inventario        int not null auto_increment,
   id_salon					int,
   encargado            varchar(50) not null,
   observaciones        varchar(400),
   fecha_creacion       datetime not null,
   fecha_actualizado    datetime not null,
   primary key (id_inventario)
);

/*==============================================================*/
/* Table: salones                                               */
/*==============================================================*/
create table salones
(
   id_salon             int not null auto_increment,
   id_edificio          int,
   nombre               varchar(50) not null,
   codigo               varchar(15),
   descripcion          varchar(255),
   primary key (id_salon)
);


alter table inventarios add constraint fk_reference_1 foreign key (id_salon)
      references salones (id_salon) on delete restrict on update restrict;
      
alter table detalle_inventario add constraint fk_reference_3 foreign key (id_inventario)
      references inventarios (id_inventario) on delete restrict on update restrict;

alter table detalle_inventario add constraint fk_reference_4 foreign key (id_articulo)
      references articulos (id_articulo) on delete restrict on update restrict;

alter table salones add constraint fk_reference_2 foreign key (id_edificio)
      references edificios (id_edificio) on delete restrict on update restrict;


/*creating views*/
create view listar_edificios as 
select e.*, count(distinct s.id_salon) as "salones" from edificios as e left join salones as s on e.id_edificio=s.id_edificio group by e.id_edificio, e.nombre;

create view listar_salones as 
select e.nombre as edificio, s.* from edificios as e inner join salones as s on e.id_edificio=s.id_edificio;

create view listar_inventarios as 
select s.nombre as salon, s.id_salon, s.codigo as codSalon, e.nombre as edificio, e.id_edificio, i.id_inventario, i.encargado, i.fecha_creacion, i.fecha_actualizado, sum(di.cantidad) as totales, COUNT(di.id_articulo) as diferentes, i.observaciones from detalle_inventario as di inner join inventarios as i on  di.id_inventario=i.id_inventario inner join salones as s on i.id_salon=s.id_salon inner join edificios as e on e.id_edificio=s.id_edificio group by i.id_inventario;