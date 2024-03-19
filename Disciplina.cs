using System;

namespace ProjetoPBTP7Cs
{
    internal class Disciplina
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int NumeroCreditos { get; set; }
        public string Descricao { get; set; }

        public Disciplina(string codigo, string nome, int cargaHoraria, int numeroCreditos, string descricao)
        {
            Codigo = codigo;
            Nome = nome;
            CargaHoraria = cargaHoraria;
            NumeroCreditos = numeroCreditos;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nome: {Nome}, Carga Horária: {CargaHoraria} horas, Número de Créditos: {NumeroCreditos}, Descrição: {Descricao}";
        }
    }
}
