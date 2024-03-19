using System;

namespace ProjetoPBTP7Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando professores, disciplinas e alunos com dados fictícios
            Professor professor1 = new Professor("João da Silva", 1001, "Rua das Flores, 123", "(11) 1234-5678", "Doutorado em Matemática", "Efetivo", "Possui mais de 10 anos de experiência no ensino superior");
            Disciplina disciplina1 = new Disciplina("MAT101", "Cálculo I", 60, 4, "Estudo dos fundamentos do cálculo diferencial e integral");
            Aluno aluno1 = new Aluno("Ana", 2001);
            Aluno aluno2 = new Aluno("Pedro", 2002);
            Aluno aluno3 = new Aluno("Mariana", 2003);

            // Criando uma turma
            Turma turma1 = new Turma("T001", disciplina1, professor1);

            // Adicionando alunos à turma
            Console.WriteLine(turma1.AddAluno(aluno1)); // Aluno adicionado
            Console.WriteLine(turma1.AddAluno(aluno2)); // Aluno adicionado
            Console.WriteLine(turma1.AddAluno(aluno3)); // Aluno adicionado

            // Verificando se a turma foi aberta
            if (turma1.AbrirTurma())
            {
                Console.WriteLine("\nTurma aberta com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possível abrir a turma.");
            }

            // Gerando a pauta da turma
            Console.WriteLine("\nPauta da Turma:");
            Console.WriteLine(turma1.GerarPauta());

            // Agora, vamos criar mais duas turmas, disciplinas, professores e alunos
            Professor professor2 = new Professor("Maria Pereira", 1002, "Avenida Paulista, 456", "(11) 2345-6789", "Doutorado em Física", "Efetivo", "Especialista em física quântica");
            Disciplina disciplina2 = new Disciplina("FIS201", "Física Quântica", 60, 4, "Estudo dos princípios da física quântica");
            Aluno aluno4 = new Aluno("Carlos", 2004);
            Aluno aluno5 = new Aluno("Julia", 2005);

            Turma turma2 = new Turma("T002", disciplina2, professor2);
            Console.WriteLine(turma2.AddAluno(aluno4)); // Aluno adicionado
            Console.WriteLine(turma2.AddAluno(aluno5)); // Aluno adicionado

            if (turma2.AbrirTurma())
            {
                Console.WriteLine("\nTurma aberta com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possível abrir a turma.");
            }

            Console.WriteLine("\nPauta da Turma:");
            Console.WriteLine(turma2.GerarPauta());

            Professor professor3 = new Professor("Lucas Ferreira", 1003, "Avenida Brasil, 789", "(11) 3456-7890", "Doutorado em Ciência da Computação", "Efetivo", "Especialista em Inteligência Artificial");
            Disciplina disciplina3 = new Disciplina("CSC301", "Inteligência Artificial", 60, 4, "Estudo dos princípios e técnicas de Inteligência Artificial");

            Aluno aluno6 = new Aluno("Lucas", 2006);
            Aluno aluno7 = new Aluno("Fernanda", 2007);

            Turma turma3 = new Turma("T003", disciplina3, professor3);
            Console.WriteLine(turma3.AddAluno(aluno6)); // Aluno adicionado
            Console.WriteLine(turma3.AddAluno(aluno7)); // Aluno adicionado

            if (turma3.AbrirTurma())
            {
                Console.WriteLine("\nTurma aberta com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNão foi possível abrir a turma.");
            }

            Console.WriteLine("\nPauta da Turma:");
            Console.WriteLine(turma3.GerarPauta());
        }
    }
}
