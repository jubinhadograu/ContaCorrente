using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class Form1 : Form
    {

        //objetos que serão parte da classe Form1
        //podemos copiar do load
        Conta corretista1 = new Conta
        {
            Numero = 1000,
            Titular = "Julia",
            Saldo = 1000.0
        };
        Conta corretista2 = new Conta
        {
            Numero = 1000,
            Titular = "Geovanna",
            Saldo = 1000.0
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSSaldoCorretista1_Click(object sender, EventArgs e)
        {

        }

        private void lblCorretista2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vamos criar os correntista (objetos) aqui
            Conta corretista1 = new Conta
            {
                Numero = 1000,
                Titular = "Julia",
                Saldo = 1000.0
        };
            Conta corretista2 = new Conta
            {
                Numero = 1000,
                Titular = "Geovanna",
                Saldo = 1000.0
            };

            //para testarmos se os objetos foram criados e tambem apresentarmos
            //as informações vamos utilizar o lbl que mostra o saldo, fica com atividade
            //mostrar tambem o nome do correntista e seu numero.
            //vamos executar devemos ter na tela o saldo de 1000 para cada corretista 

            lblSaldoCorretista1.Text = corretista1.Saldo.ToString();
            lblSaldoCorretista2.Text = corretista2.Saldo.ToString();
        }

        private void btnVerSaldoC1_Click(object sender, EventArgs e)
        {
            //ver o saldo dos corretistas neste caso do corretista 1
            //basta atualizar o label do saldo
            //vamos precisar dos objetos aqui na classe do formulário
            //agora ja temos os objetos correntista 1 e 2
            //faça o mesmo para o botão Ver Saldo do correntista 2.
            lblSaldoCorretista1.Text = corretista1.Saldo.ToString();
        }

        private void btnVerSaldoC2_Click(object sender, EventArgs e)
        {
            lblSaldoCorretista2.Text= corretista2.Saldo.ToString();
        }

        private void btnAddC1_Click(object sender, EventArgs e)
        {
            //vamos adicionar 100 a conta do correntista 1
            corretista1.Depositar(100);
            //faça o mesmo para o correntista 2
        }

        private void btnAddC2_Click(object sender, EventArgs e)
        {
            //vamos adicionar 100 a conta do correntista 2
            corretista1.Depositar(100);
            //vamos sacar 100 da conta dos corretistas
        }

        private void btnSubC1_Click(object sender, EventArgs e)
        {
            corretista1.Sacar(100);
            //faça o mesmo para o corretista 2
        }

        private void btnSubC2_Click(object sender, EventArgs e)
        {
            corretista2.Sacar(100);
            //agora podemos transferir
        }

        private void btnTransC1ToC2_Click(object sender, EventArgs e)
        {
            //para transferir vamos lembrar que o corretista 1 é
            //que irá ter seu saldo reduzido em 100 e co corretista 2
            //terá seu saldo acrescido de 100, nesse caso quem irá
            //chamar o metodo de transferir sera o corretista 1
            //e como parâmetro iremos passar o objeto corretista 2;

            corretista1.Transferir(100, corretista2);

            //o promeiro parâmetro é o valor a ser transferido e o 
            //segundo o objeto correntista2 que irá ter o valor
            //atribuido (somado) ao seu saldo. vamos ver a classe novamente?
        }
    }
}