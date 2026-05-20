CREATE database Diretoria;
GO

use Diretoria;
go

create table curso (
cod_curso int identity(1,1) primary key,
nome_curso varchar (80) not null,
cod_professor_fk int references professor(cod_professor)
);
go

create table aluno (
cod_aluno int identity(1,1) primary key,
nome_aluno varchar (80) not null,
cod_curso_fk int references curso(cod_curso)
);
go

create table professor (
cod_professor int identity(1,1) primary key,
nome_professor varchar (80) not null
);
go

create or alter view dados_diretoria as 
select a.cod_aluno, a.nome_aluno, c.nome_curso, p.nome_professor from aluno as a inner join curso as 
c on c.cod_curso = a.cod_curso_fk inner join professor as p on p.cod_professor = c.cod_professor_fk;
go

select * from dados_diretoria;