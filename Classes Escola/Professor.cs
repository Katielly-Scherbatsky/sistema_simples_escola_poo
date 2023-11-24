namespace EscolaPOO_DIA_23.Classes_Escola
{
    internal class Professor : Funcionario
    {
        //Atributos
        public string Disciplina { get; set; }

        //Metodo Construtor
        public Professor (string nome, int idade, double salario, string disciplina)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            Disciplina = disciplina;
        }

        //Metodo Abstrato
        public override void CalcularSalario()
        {
            Salario += Salario * 0.10;
        }

    }
}