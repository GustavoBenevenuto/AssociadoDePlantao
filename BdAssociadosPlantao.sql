CREATE DATABASE BdAssociadosPlantao
GO

-- DROP DATABASE BdAssociadosPlantao

USE BdAssociadosPlantao
GO

CREATE TABLE Contato(
	codContato	INT IDENTITY(1,1) PRIMARY KEY,
	endereco	VARCHAR(80) NOT NULL,
	numero		INT NOT NULL,
	complemento	VARCHAR(50) NOT NULL,
	bairro		VARCHAR(50) NOT NULL,
	cidade		VARCHAR(30) NOT NULL,
	estado		VARCHAR(2) NOT NULL,
	pais		VARCHAR(20) NOT NULL,
	telFixo		VARCHAR(15),
	celular		VARCHAR(15),
	email		VARCHAR(50)
)

CREATE TABLE Funcionario(
	codFuncionario	INT IDENTITY(1,1) PRIMARY KEY,
	nome			VARCHAR(50) NOT NULL,
	cpf				VARCHAR(15) NOT NULL,
	dataNasc		VARCHAR(15)	NOT NULL,
	tipoFuncionario	INT NOT NULL,
	loginFunc		VARCHAR(30) NOT NULL,
	senha			VARCHAR(10) NOT NULL,
	statusFunc		SMALLINT NOT NULL,
	CONTATO_codContato	INT,
	FUNC_codFuncResp	INT,
	FOREIGN KEY (CONTATO_codContato) REFERENCES Contato(codContato),
	FOREIGN KEY (FUNC_codFuncResp) REFERENCES Funcionario(codFuncionario),	 
)


CREATE TABLE Loja (
	codLoja			INT IDENTITY(1,1) PRIMARY KEY,
	razaoSocial		VARCHAR(70) NOT NULL,
	nomeFantasia	VARCHAR(60) NOT NULL,
	cpnj			VARCHAR(30) NOT NULL,
	siteLoja		VARCHAR(40),
	inauguracao		VARCHAR(10),
	tipoLoja		VARCHAR(10) NOT NULL,
	CONTATO_codContato	INT,
	FUNC_codFuncResp	INT,
	FOREIGN KEY (CONTATO_codContato) REFERENCES Contato(codContato),
	FOREIGN KEY (FUNC_codFuncResp) REFERENCES Funcionario(codFuncionario)
)

CREATE TABLE Sala(
	codSala		INT IDENTITY(1,1) PRIMARY KEY,
	descricao	VARCHAR(60) NOT NULL,
	LOJA_codLoja	INT,
	FUNC_codFuncResp	INT,
	FOREIGN KEY (FUNC_codFuncResp) REFERENCES Funcionario(codFuncionario),
	FOREIGN KEY (LOJA_codLoja) REFERENCES Loja(codLoja)
)

CREATE TABLE RelatorioAcesso(
	codRelatorio	INT IDENTITY(1,1) PRIMARY KEY,
	dataAcesso		VARCHAR(15),
	horaAcesso		VARCHAR(15),
	FUNC_codFuncResp	INT,
	SALA_codSala		INT,
	FOREIGN KEY (FUNC_codFuncResp) REFERENCES Funcionario(codFuncionario),
	FOREIGN KEY (SALA_codSala) REFERENCES Sala(codSala)
)

CREATE TABLE FuncLoja(
	FUNC_codFuncResp	INT,
	LOJA_codLoja		INT,
	FOREIGN KEY (FUNC_codFuncResp) REFERENCES Funcionario(codFuncionario),
	FOREIGN KEY (LOJA_codLoja) REFERENCES Loja(codLoja)
)

CREATE TABLE QuemEstaLogado(
	usuario VARCHAR(30)
)

CREATE TABLE AcessoSala(
	codAcesso			INT IDENTITY(1,1) PRIMARY KEY,
	FUNC_codFuncResp	INT,
	SALA_codSala		INT,
	FOREIGN KEY (FUNC_codFuncResp) REFERENCES Funcionario(codFuncionario),
	FOREIGN KEY (SALA_codSala) REFERENCES Sala(codSala)
)

INSERT INTO QuemEstaLogado VALUES ('nada')
INSERT INTO Contato VALUES ('Rua Benjamin',15,'Casa','Upitu','Belo Horizonte','MG','Brasil','3435-1150','31-99999-9999','admin@hotmail.com')
INSERT INTO Funcionario VALUES ('admin','019-019-245-91','21/06/1991',1,'ADMIN','admin',1,1,1)

