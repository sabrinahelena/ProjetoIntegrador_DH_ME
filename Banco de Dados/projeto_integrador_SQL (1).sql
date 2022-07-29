create database [Projeto integradorteste];


create table estoque (
id_estoque int primary key identity,
data_validade date null,
quantidade_estoque int not null

);

create table usuario (
id_usuario int primary key identity ,
nome_usuario varchar(45) not null,
sobrenome varchar(45) not null,
telefone varchar(15) null,
data_nascimento date not null,
email varchar(80) unique not null,
foto_perfil varchar(45) null,


); 

create table acesso (
id_acesso int primary key identity,
[Login] varchar(20) unique not null,
senha varchar(20) not null,
acesso_usuario int not null,

constraint FK_acesso_usuario foreign key (acesso_usuario) references usuario (id_usuario) -- FK para usuario
);

create table residencias (
id_residencias int primary key identity,
nome_residencias varchar (45) not null,
descricao_residencias varchar(80) null,
foto_residencias varchar(80) null,
residencias_estoque int null,
residencias_usuario int not null,

constraint FK_residencias_estoque foreign key (residencias_estoque) references estoque (id_estoque), -- FK para estoque
constraint FK_residencia_usuario foreign key (residencias_usuario) references usuario (id_usuario), -- FK para usuario
);

create table produtos_listaDeCompras (
id_produtos int primary key identity,
nome_produtos varchar(45) not null,
descricao_produtos varchar(80) null,
preco decimal(5,2) not null,
quantidade_produtos int not null ,
produtos_usuario int null,
produtos_estoque int null,

constraint FK_produtos_usuario foreign key (produtos_usuario) references usuario (id_usuario), -- FK para usuario
constraint FK_produtos_estoque foreign key (produtos_estoque) references estoque (id_estoque) -- FK para estoque

);
