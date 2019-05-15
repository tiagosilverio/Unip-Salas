CREATE DATABASE unip_sala
go
use unip_sala
go

create table tb_curso
(
	idCurso int identity,
	nomeCurso varchar(70) not null

	constraint PK_CURSO primary key (idCurso),
	constraint UQ_CURSO unique (nomeCurso)
);
go

create table tb_sigla
(
	idSigla int identity,
	nomeSigla varchar(8) not null

	constraint PK_SIGLA primary key (idSigla),
	constraint UQ_SIGLA unique (nomeSigla)
);
go

create table tb_alfabeto
(
	idAlfabeto int identity,
	nomeAlfabeto char(1)

	constraint PK_ALFABETO primary key (idAlfabeto),
	constraint UQ_ALFABETO unique (nomeAlfabeto)
);
go

create table tb_tipo_sala
(
	idTipoSala int identity,
	nomeTipoSala varchar(50) not null

	constraint PK_TIPOSALA primary key (idTipoSala),
	constraint UQ_TIPOSALA unique (nomeTipoSala)
);
go

create table tb_campus
(
	idCampus int identity,
	nomeCampus varchar(50) not null,
	numeroCampus int not null

	constraint PK_CAMPUS primary key (idCampus),
	constraint UQ_NOME_NUMERO_CAMPUS unique (nomeCampus, numeroCampus)
);
go

create table tb_andar
(
	idAndar int identity,
	nomeAndar varchar (40) not null

	constraint PK_ANDAR primary key (idAndar),
	constraint UQ_ANDAR unique (nomeAndar)
);
go

create table tb_dia_semana
(
	idDiaSemana int identity,
	nomeDiaSemana varchar(15) not null

	constraint PK_DIA_SEMANA primary key (idDiaSemana),
	constraint UQ_DIA_SEMANA unique (nomeDiaSemana)
);
go

create table tb_turma
(
	idTurma int identity,
	fkSigla int,
	fkAlfabeto int,
	fkCampus int,
	fkCurso int,
	anoInicio date not null,
	semestreInicio int not null,
	numeroTurma int not null,

	constraint PK_TURMA primary key (idTurma),
	constraint UQ_TURMA unique (fkSigla, fkAlfabeto, fkCampus, anoInicio, semestreInicio)
);
go

create table tb_aluno
(
	idAluno int identity,
	raAluno char(7) not null,
	nomeAluno varchar(50) not null,
	statusAluno bit not null

	constraint PK_ALUNO primary key (idAluno),
	constraint UQ_ALUNO unique (raAluno)
);
go

create table tb_turma_aluno
(
	idTurmaAluno int identity,
	fkTurma int,
	fkAluno int

	constraint PK_TURMA_ALUNO primary key (idTurmaAluno),
	constraint UQ_TURMA_ALUNO unique (fkTurma, fkAluno)
);
go

create table tb_sala
(
	idSala int identity,
	numeroSala int not null,
	capacidade int not null,
	fkAlfabeto int,
	fkTipoSala int,
	fkAndar int

	constraint PK_SALA primary key (idSala),
	constraint UQ_SALA unique (numeroSala, capacidade, fkAlfabeto, fkTipoSala, fkAndar)
);
go

create table tb_aula_local
(
	idAulaLocal int identity,
	fkSala int,
	fkTurma int,
	fkDiaSemana int,
	periodoAula varchar(10) not null,
	horarioAula tinyint not null

	constraint PK_AULA_LOCAL primary key (idAulaLocal),
	constraint UQ_AULA_LOCAL unique (fkSala, fkTurma, fkDiaSemana, horarioAula)
);

-- ADICIONANDO CHAVE ESTRANGEIRA 

alter table tb_turma add 
	constraint FK_TB_TURMA_SIGLA  foreign key (fkSigla) references tb_sigla (idSigla),
	constraint FK_TB_TURMA_CAMPUS foreign key (fkCampus) references tb_campus (idCampus),
	constraint FK_TB_TURMA_CURSO foreign key (fkCurso) references tb_curso (idCurso),
	constraint FK_TB_TURMA_ALFABETO foreign key (fkAlfabeto) references tb_alfabeto(idAlfabeto);
go

alter table tb_turma_aluno add
	constraint FK_TB_TURMAALUNO_TURMA foreign key (fkTurma) references tb_turma (idTurma),
	constraint FK_TB_TURMAALUNO_ALUNO foreign key (fkAluno) references tb_aluno (idAluno);
go

alter table tb_sala add
	constraint FK_TB_SALA_ALFABETO foreign key (fkAlfabeto) references tb_alfabeto (idAlfabeto),
	constraint FK_TB_SALA_ANDAR foreign key (fkAndar) references tb_andar (idAndar),
	constraint FK_TB_SALA_TIPOSALA foreign key (fkTipoSala) references tb_tipo_sala (idTipoSala);
go

alter table tb_aula_local add
	constraint FK_TB_AULALOCAL_SALA foreign key (fkSala) references tb_sala (idSala),
	constraint FK_TB_AULALOCAL_TURMA foreign key (fkTurma) references tb_turma (idTurma),
	constraint FK_TB_AULALOCAL_DIASEMANA foreign key (fkDiaSemana) references tb_dia_semana (idDiaSemana);
go