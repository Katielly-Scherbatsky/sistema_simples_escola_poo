using EscolaPOO_DIA_23.Classes_Escola;

int opcao;
List<Funcionario> funcionarios = new List<Funcionario>();

Console.WriteLine("Bem vindo ao Sistema Simples para Modelar uma Escola");
do
{
    Console.WriteLine("\nQual o tipo de funcionário:");
    Console.WriteLine("Insira 1 para Professor");
    Console.WriteLine("Insira 2 para Administrativo");
    Console.WriteLine("Insira 0 para Sair");

    Console.Write("Insira a Opção Desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    if(opcao == 1)
    {
        Console.WriteLine("\nInsira os dados do Professor: \n");

        Console.Write("Insira o Nome: ");
        string nomeProfessor = Console.ReadLine();

        Console.Write("Insira a Idade: ");
        int idadeProfessor = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o Salário: ");
        double salarioProfessor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira a Disciplina: ");
        string disciplinaProfessor = Console.ReadLine();

        Professor professor = new Professor(nomeProfessor, idadeProfessor, salarioProfessor, disciplinaProfessor);
        professor.CalcularSalario();
        funcionarios.Add(professor);
    }
    if (opcao == 2)
    {
        Console.Write("\nInsira os dados do Administrativo: \n");

        Console.Write("Insira o Nome: ");
        string nomeAdministrativo = Console.ReadLine();

        Console.Write("Insira a Idade: ");
        int idadeAdministrativo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o Salário: ");
        double salarioAdministrativo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o Setor: ");
        string setorAdministrativo = Console.ReadLine();

        Administrativo administrativo = new Administrativo(nomeAdministrativo, idadeAdministrativo, salarioAdministrativo, setorAdministrativo);
        administrativo.CalcularSalario();
        funcionarios.Add(administrativo);
    }
} while (opcao != 0);

foreach (var funcionario in funcionarios)
{
    if(funcionario is Professor)
    {
        Professor professor = (Professor)funcionario;
        Console.WriteLine("Professor:");
        Console.WriteLine($"Nome: {professor.Nome}, Idade: {professor.Idade}, Salário: {professor.Salario}, Disciplina: { professor.Disciplina}");
    } else if( funcionario is Administrativo)
    {
        Administrativo administrativo = (Administrativo)funcionario;
        Console.WriteLine("Administrativo:");
        Console.WriteLine($"Nome: {administrativo.Nome}, Idade: {administrativo.Idade}, Salário: {administrativo.Salario}, Setor: {administrativo.Setor}");
    }
    Console.WriteLine();
}