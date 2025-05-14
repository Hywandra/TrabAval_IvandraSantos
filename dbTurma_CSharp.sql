CREATE DATABASE dbTurma_CSharp
COLLATE Latin1_General_100_CI_AS_SC_UTF8;
GO

use dbTurma_CSharp

drop table if exists Aluno
go

create table Aluno(
ID_Aluno int identity (1,1) not null constraint [PK_ID_Aluno] primary key,
N_Aluno int not null,
Nome varchar (100) not null,
Morada varchar (200) not null,
Telefone varchar (15) not null,
Data_Nasc date not null,
Nota_Final decimal (4,2) not null
)
go
