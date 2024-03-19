using System;

namespace ProjetoPBTP7Cs
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Matrícula: {Matricula}";
        }
    }
}
