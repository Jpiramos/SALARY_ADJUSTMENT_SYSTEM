namespace Departamento_Funcionario
{
    class Funcionario
    {

        //Atributos da Classe Funcionario
        public string _Nome;
        public int _Idade;
        public double _Salario;
        public Departamento _Departamento;




        //Metodo Construtor da Classe Funcionario
        public Funcionario(string nome, int idade, double salario, Departamento departamento)
        {
            _Nome = nome;
            _Idade = idade;
            _Salario = salario;
            _Departamento = departamento;
        }



        // Metodo da classe Funcionario, Calculo do Aumento Salarial
        public static void AumentarSalario(Funcionario funcionario, double percentual)
        {
            funcionario._Salario += (funcionario._Salario * percentual / 100);
        }

        public static void DiminuirSalario(Funcionario funcionario, double percentual)
        {
            funcionario._Salario -= (funcionario._Salario * percentual / 100);
        }
    }

}
