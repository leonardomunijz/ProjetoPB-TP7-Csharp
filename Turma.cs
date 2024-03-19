using System;
using System.Collections.Generic;

namespace ProjetoPBTP7Cs
{
    internal class Turma
    {
        private string codigo;
        private Disciplina disciplina;
        private Professor professor;
        private List<Aluno> alunosInscritos;

        public Turma(string codigo, Disciplina disciplina, Professor professor)
        {
            this.codigo = codigo;
            this.disciplina = disciplina;
            this.professor = professor;
            this.alunosInscritos = new List<Aluno>();
        }

        public string AddAluno(Aluno aluno)
        {
            if (alunosInscritos.Count >= 50)
            {
                return "Turma cheia";
            }
            else
            {
                alunosInscritos.Add(aluno);
                return "Aluno adicionado";
            }
        }

        public bool AbrirTurma()
        {
            // A turma só pode ser aberta se houver pelo menos um aluno matriculado
            return alunosInscritos.Count >= 1;
        }


        public string GerarPauta()
        {
            // Construindo a string com as informações da turma
            string pauta = $"Código da Turma: {codigo}\n";
            pauta += $"Disciplina: {disciplina.Nome}\n";
            pauta += $"Professor: {professor.Nome}\n";
            pauta += "Alunos inscritos:\n";
            foreach (var aluno in alunosInscritos)
            {
                pauta += $"- {aluno.Nome}\n";
            }
            return pauta;
        }
    }
}
