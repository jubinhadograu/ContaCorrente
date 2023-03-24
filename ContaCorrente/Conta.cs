using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public string VerSaldo()
        {
            return $"O saldo do corretista: {Titular}, conta número {Numero} é de: {Saldo.ToString()}";
        }

        //adicionar valor a conta dos corretistas
        /*
         Obs. podemos fazer dessa forma porem o recomendado é utilizar
        o padrao com os tributos, então vou trocar a variavel de parametro
        "valor" pelo tributo Saldo e ai o "this" fará sentido.
         */
        public void Depositar(double valor)
        {
            //this.Saldo = this.Saldo + Saldo; //modo tradiconal
            //agora utilizando operador de atribuição
            this.Saldo += valor; //aqui ja atribui a soma ao atributo
        }

        // Sacar valores dos corretistas
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                Console.WriteLine("Saque negado. Saldo insuficiente.");
            this.Saldo -= Saldo; //o mesmo so que subtraindo
        }

        //g. transferir o valor de R$100,oo do correntista 1 para o correntista 2;

        /*
         nesse caso iremos utilizar o recurso de parâmetro com um objeto
        onde Conta é a classe e o destino o correntista que irá receber o valor
        da transferencia, lembre que neste caso vamos passaar o objeto correntista.
         */
        public void Transferir(double Saldo, Conta destino)
        {
            //primeiro vamos retirar da conta do correntista o valor a 
            //ser transferido, isso ocorrera ao correntista (objeto) que fará a chamada
            //do método.
            this.Saldo -= Saldo;

            //agora podemos depositar no atributo Saldo do corretista 2 que esta
            //recebendo o deposito.
            destino.Saldo += Saldo;
            //lembre que o destino (parâmetro) esta recebendo o obj correntista 2
            // e neste caso ficaria como:
            //correntista2.Saldo += Saldo;

            //podemos testar tudo agora.
        }
    }
}
