namespace Departamento_Funcionario
{
    class Departamento
    {
        //Atributos da Classe Departamento
        public string _Nome;
        public string _Localizacao;
        public int _Numero;



        //Metodo Construtor da Classe Departamento
        public Departamento(string nome, string localizacao, int numero)
        {
            _Nome = nome;
            _Localizacao = localizacao;
            _Numero = numero;
            
        }
    }
}
