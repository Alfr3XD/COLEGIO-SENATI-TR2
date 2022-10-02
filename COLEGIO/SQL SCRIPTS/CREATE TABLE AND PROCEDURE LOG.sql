USE Colegio;

CREATE TABLE [ALUMNO](
id int,
dni nvarchar(50),
[name] varchar(100),
p_apellido varchar(50),
m_apellido varchar(50),
telefono nvarchar(50),
celular nvarchar(50),
[address] varchar(100),
email varchar(50),
nacimiento date,
primary key(id)
);

CREATE TABLE NOTAS(
alumno_id int,
nota int,
primary key(alumno_id)
);

GO
CREATE PROCEDURE sp_alumno_log
@wheres varchar(150)
as begin
	select 
	alm.id, alm.dni, alm.[name], alm.p_apellido, alm.m_apellido, alm.telefono, alm.celular, alm.[address], alm.email, alm.nacimiento, NT.nota
	from ALUMNO alm
	INNER JOIN NOTAS nt ON NT.alumno_id = alm.id
	where
	alm.id like @wheres+'%' or
	alm.dni like @wheres+'%' or
	[alm].[name] like  @wheres+'%' or
	alm.p_apellido like @wheres+'%' or
	alm.m_apellido like @wheres+'%'
	end;