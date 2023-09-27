using System;
using System.Windows.Forms;

namespace Departamento_Funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            // Criando um departamento
            Departamento departamento = new Departamento(textBox4.Text, textBox5.Text, int.Parse(textBox6.Text));



            // Criando um funcionário
            Funcionario funcionario1 = new Funcionario(textBox1.Text,Convert.ToInt32( textBox2.Text), Convert.ToDouble(textBox3.Text), departamento);



            if (checkBox1.Checked == true)
            {
                // Reajustando o salário do funcionário atraves do Metodo "AumentarSalario" da classe Funcionario
                Funcionario.DiminuirSalario(funcionario1, Convert.ToDouble(textBox7.Text));

            }
            else
            {
                // Reajustando o salário do funcionário atraves do Metodo "AumentarSalario" da classe Funcionario
                Funcionario.AumentarSalario(funcionario1, Convert.ToDouble(textBox7.Text));
            }



            // Exibindo informações do funcionário
            MessageBox.Show($"Nome: {funcionario1._Nome}\nIdade: {funcionario1._Idade}\nDepartamento: {funcionario1._Departamento._Nome}\nSalário Reajustado: {funcionario1._Salario}");
           
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
