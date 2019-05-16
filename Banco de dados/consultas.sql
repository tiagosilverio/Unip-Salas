select

	alfa.nomeAlfabeto,
	s.numeroSala,
	andar.nomeAndar,
	sigla.nomeSigla,
	alfaturma.nomeAlfabeto,
	t.numeroTurma,
	ds.nomeDiaSemana,
	al.periodoAula,
	al.horarioAula,
	s.capacidade

from tb_aula_local al
	inner join tb_sala s on al.fkSala = s.idSala
	inner join tb_turma t on al.fkTurma = t.idTurma
	inner join tb_dia_semana ds on al.fkDiaSemana = ds.idDiaSemana
	inner join tb_alfabeto alfa on s.fkAlfabeto = alfa.idAlfabeto
	inner join tb_andar andar on s.fkAndar = andar.idAndar
	inner join tb_sigla sigla on t.fkSigla = sigla.idSigla
	inner join tb_alfabeto alfaturma on t.fkAlfabeto = alfaturma.idAlfabeto

where alfa.nomeAlfabeto = '<$variavel>' 
	and s.numeroSala = <$variavel>
	and ds.nomeDiaSemana = '<$variavel>'
	and al.periodoAula = '<$variavel>'

order by alfa.nomeAlfabeto, s.numeroSala;

--Contgem de aluno

select count(*) as qtde from tb_turma_aluno ta
inner join tb_turma t on ta.fkTurma = t.idTurma
inner join tb_aluno a on ta.fkAluno = a.idAluno;

--Buscando turma
select * from tb_turma_aluno ta
inner join tb_turma t on ta.fkTurma = t.idTurma
inner join tb_aluno a on ta.fkAluno = a.idAluno;

--Verificando se cabe os alunos na sala
select * from tb_sala
where capacidade >=  (select count(*) from tb_turma_aluno);