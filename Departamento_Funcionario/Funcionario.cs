namespace Departamento_Funcionario
{
    class Funcionario
    {

        //Atributos da Classe Funcionario
        public string Nome;
        public int Idade;
        public double Salario;
        public Departamento Departamento;




        //Metodo Construtor da Classe Funcionario
        public Funcionario(string nome, int idade, double salario, Departamento departamento)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            Departamento = departamento;
        }



        // Metodo da classe Funcionario, Calculo do Aumento Salarial
        public static void AumentarSalario(Funcionario funcionario, double percentual)
        {
            funcionario.Salario += (funcionario.Salario * percentual / 100);
        }

        public static void DiminuirSalario(Funcionario funcionario, double percentual)
        {
            funcionario.Salario -= (funcionario.Salario * percentual / 100);
        }
    }

}
