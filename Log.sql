/* ------------------------  26/08/21  ------------------------ */
alter table Produto add tipo varchar(50) null, grupo varchar (50), codbarras int, dtultcompra date;
alter table Produto add precocompra decimal(4,4);


alter table fornecedor add ie varchar(10), telefone2 varchar(12);
alter table fornecedor drop column telefone2;	 /* Exclui a coluna "telefone2 na table "Fornecedor" */


exec sp_rename 'Fornecedor.fCod', 'cod', 'COLUMN';    /* Renomeia a coluna "Nome" na table "Fornecedor */
exec sp_rename 'cliente.cod', 'id', 'COLUMN';
exec sp_rename 'cliente.cNome', 'nome', 'COLUMN';
exec sp_rename 'cliente.cEmail', 'email', 'COLUMN';		
exec sp_rename 'cliente.cTelefone', 'telefone1', 'COLUMN';		
exec sp_rename 'cliente.cCelular', 'telefone2', 'COLUMN';		
exec sp_rename 'cliente.cRG', 'rg', 'COLUMN';	
exec sp_rename 'cliente.cCPF', 'cpfcnpj', 'COLUMN';		
exec sp_rename 'cliente.cEndereco', 'endereco', 'COLUMN';		


alter table Estoque alter column prodcod int not null;

create table ItensVenda
(
	id int not null,
	idprod int not null,
	descri varchar (80),
	valorun decimal (4,2),
	qtdprod decimal (4,2),
	valortotal decimal (4,2)
);
alter table ItensVenda add constraint PK_ItensVenda
primary key clustered (id);

/* -------------------  ------------------  ------------------- */

/* ------------------------  26/08/21  ------------------------ */

create table Venda
(
	id int not null,
	datavenda date null,
	idcliente int,
	cliente varchar (80) not null,
	vendedor int null,
	valortotal decimal (4,2),
	desctoltal decimal (4,2)
);
alter table Venda add constraint PK_Venda
primary key clustered (id);

alter table venda add constraint FK_Venda_Cliente foreign key (idcliente)
references cliente (id);


create table movestoque
(
	id int not null,
	idprod int not null,
	quantidade decimal (4,2),
	tipomov int
);
alter table movestoque add constraint PK_movestoque
primary key clustered (id);


create table tipomov 
(
	id int not null,
	tipo varchar (30)
);
alter table tipomov add constraint PK_tipomov
primary key clustered (id);


create table movcaixa
(
	id int not null,
	tipomov int,
	datamov date,
	valor decimal (6,2),
	idvenda int
);
alter table movcaixa add constraint PK_movcaixa
primary key clustered (id);

alter table movcaixa add constraint FK_movcaixa_venda foreign key (idvenda)
references venda (id);

alter table movcaixa add constraint FK_movcaixa_tipomov foreign key (tipomov)
references tipomov (id);


/* -------------------  ------------------  ------------------- */

/* ------------------------  10/11/21  ------------------------ */

drop table Estoque;

create table Estoque
(
	id integer identity primary key,
	mov decimal (3,2),
	produto INTEGER,
	idvenda integer,
	idos integer,
	idcompra integer
	CONSTRAINT FK_QUANT_PROD FOREIGN KEY (PRODCOD) REFERENCES PRODUTO (PRODCOD)
);


drop table Produto;

create table Produto
(
	id integer identity primary key not null,
	descricao varchar (250) not null,
	preco decimal (5,2),
	tipo varchar (50),
	grupo varchar (50),
	barras varchar (15),
	dtultcompra date
	precocompra decima (4,4)
);

