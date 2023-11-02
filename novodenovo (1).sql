create database novodenovo;
use novodenovo;

create table tb_funcionario(
id int auto_increment,
nome varchar (50),
cpf char (11),
telefone char (11),
constraint pk_funcionario primary key (id)
);

create table tb_cliente(
id int auto_increment,
nome varchar (50),
telefone varchar (11),
constraint pk_cliente primary key (id)
);

create table tb_servico(
id int auto_increment,
nomeservico varchar(50),
constraint pk_servico primary key (id)
);

create table tb_peca(
	id int auto_increment,
	nomepeca varchar(50),
	valor_peca int,
	constraint pk_peca primary key (id)
);

create table tb_pedido(
	id int auto_increment,
    id_cliente int,
    data_registro date,
    constraint pk_pedido primary key(id),
    constraint fk_pedido_cliente foreign key (id_cliente)
	references tb_cliente (id)
);

create table tb_pedido_itens(
	id int auto_increment,
    id_pedido int,
    id_servico int,
    id_peca int,
    valor_servico numeric(10,2),
    valor_desconto numeric(10,2),
    constraint pk_pedido_itens primary key(id),
    constraint fk_pedido_itens_pedido foreign key (id_pedido)
    references tb_pedido(id),
    constraint fk_pedido_itens_servico foreign key (id_servico)
    references tb_servico(id),
    constraint fk_pedido_itens_peca foreign key (id_peca)
    references tb_peca(id)
);










