using System;

namespace ProjetoPBTP7Cs
{
    internal class Professor
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Titulacao { get; set; }
        public string FormaContratacao { get; set; }
        public string CurriculoResumido { get; set; }

        public Professor(string nome, int matricula, string endereco, string telefone, string titulacao, string formaContratacao, string curriculoResumido)
        {
            Nome = nome;
            Matricula = matricula;
            Endereco = endereco;
            Telefone = telefone;
            Titulacao = titulacao;
            FormaContratacao = formaContratacao;
            CurriculoResumido = curriculoResumido;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Matrícula: {Matricula}, Endereço: {Endereco}, Telefone: {Telefone}, Titulação: {Titulacao}, Forma de Contratação: {FormaContratacao}, Currículo Resumido: {CurriculoResumido}";
        }
    }
}
