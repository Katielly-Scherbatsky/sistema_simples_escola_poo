namespace EscolaPOO_DIA_23.Classes_Escola
{
    public abstract class Funcionario
    {
        //Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        //Metodo Abstrato
        public abstract void CalcularSalario();

    }
}