namespace EscolaPOO_DIA_23.Classes_Escola
{
    public class Administrativo : Funcionario
    {
        //Atributos
        public string Setor { get; set; }

        //Metodo Construtor
        public Administrativo(string nome, int idade, double salario, string setor)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            Setor = setor;
        }

        //Metodo Abstrato
        public override void CalcularSalario()
        {
            Salario += Salario * 0.5;
        }
    }
}