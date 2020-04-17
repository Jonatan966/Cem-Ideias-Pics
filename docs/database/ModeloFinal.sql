/*Modelo Final - Banco de Dados PTCC - Cem Idéias Pics*/
CREATE DATABASE cem_ideias_pics;
USE cem_ideias_pics;
DROP DATABASE cem_ideias_pics;
/*Criação das tabelas---------------------------*/
/*Principais Tabelas---------------*/
CREATE TABLE usuarios(
	id INT UNSIGNED AUTO_INCREMENT,
    cpf VARCHAR(14) UNIQUE,
    nome VARCHAR(350) NOT NULL,
    sexo TINYINT(1) NOT NULL,
    telefone VARCHAR(15),
    email VARCHAR(200),
    login VARCHAR(50) UNIQUE NOT NULL,
    senha VARCHAR(50) NOT NULL,
    bloqueio BOOLEAN DEFAULT 0,
    PRIMARY KEY(id, cpf)
)ENGINE=INNODB;
CREATE TABLE clientes(
	cpf VARCHAR(14) PRIMARY KEY,
    nome VARCHAR(300) NOT NULL,
    sexo TINYINT(1) NOT NULL,
    datanasc DATE NOT NULL,
    telefone VARCHAR(15),
    email VARCHAR(200),
    cep INT(8) UNSIGNED NOT NULL,
    numresidencia varchar(25) NOT NULL,
    complemento VARCHAR(20) NOT NULL,
    CONSTRAINT cep_fk FOREIGN KEY(cep) REFERENCES enderecos(cep)
)ENGINE=INNODB;
CREATE TABLE ensaios(
	id INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    clicpf VARCHAR(14), /*No*/
    userid INT UNSIGNED, /*No*/
    codtipo INT UNSIGNED, /*No*/
    codalbum INT UNSIGNED, /*No*/
    cep INT(8) UNSIGNED, /*No*/
    numlocal INT(5) UNSIGNED,
    dataensaio DATETIME,
    precototal DECIMAL(6,2),
    diretorio VARCHAR(300),
    CONSTRAINT clicpf_fk FOREIGN KEY(clicpf) REFERENCES clientes(cpf),
    CONSTRAINT userid_fk FOREIGN KEY(userid) REFERENCES usuarios(id),
    CONSTRAINT codensaio_fk FOREIGN KEY(codtipo) REFERENCES tipos_ensaios(codensaio),
    CONSTRAINT codalbum_fk FOREIGN KEY(codalbum) REFERENCES tipos_albuns(codalbum),
    CONSTRAINT cep_fk2 FOREIGN KEY(cep) REFERENCES enderecos(cep)
)ENGINE=INNODB;
/*----------------------------------*/
/*Complementares--------------------*/
CREATE TABLE enderecos(
	cep INT(8) UNSIGNED PRIMARY KEY,
    estado VARCHAR(50) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    bairro VARCHAR(150) NOT NULL,
    logradouro VARCHAR(100) NOT NULL,
    edificio VARCHAR(150)
)ENGINE=INNODB; INSERT INTO ENDERECOS VALUES(11111111, "SP", "São Paulo", "City Jaraguá", "A", null);
CREATE TABLE tipos_ensaios(
	codensaio INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(75) NOT NULL
)ENGINE=INNODB;
CREATE TABLE tipos_albuns(
	codalbum INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(50),
    valor DECIMAL(8,2)
)ENGINE=INNODB;

insert into tipos_albuns values(1, "Comum", 250);
/*-----------------------------------*/
/*-----------------------------------------------*/

/*Inserção de Dados para Testes------------------*/
INSERT INTO clientes VALUES
("111.222.333-44", "João", "M", '2003-02-24', "3943-2850", "jooj@jooj.com", 02998200, 286);

INSERT INTO enderecos VALUES
(02998200, "SP", "São Paulo", "City Jaraguá", "Casa", null);

INSERT INTO ensaios VALUES
(1, "111.222.333-44", 1, 1, 1, 02998200, 286, now());

INSERT INTO tipos_albuns VALUES
(1, "Álbum de fotografias", 2);

INSERT INTO usuarios VALUES
(1, "111.222.333-44", "Jooj", 1, "3943-2850", "jooj@jooj.com", "A", md5("a"), 0);

update usuarios set senha = md5('a') where id = 1;
select * from usuarios;
create table a (a enum("a", "b"));
insert into a values(1);

/*-----------------------------------------------*/