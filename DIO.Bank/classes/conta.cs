using System;

namespace DIO.Bank
{
    public class Conta
    {
        private Tipoconta Tipoconta {get; set;} 
        private double Saldo {get; set;}
        private double Credito {get; set;}
        private string Nome {get; set;}

        public Conta (Tipoconta Tipoconta, double Saldo, double Credito, string Nome)
        {
            this.Tipoconta = Tipoconta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }

        public bool Sacar(double valorSaque)
        {
            if(this.Saldo - valorSaque < (this.Credito*-1)){
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            this.Saldo -= valorSaque;
                Console.WriteLine("Saldo atual da conta de {0} é {1}",this.Nome,this.Saldo);
                return true;


        }

        public void Depositar(double valorDepposito)
        {
            this.Saldo += valorDepposito;
            Console.WriteLine("Saldoatual da conta de {0} é {1}",this.Nome,this.Saldo);
        }

        public void Tranferir(double valorTransferencia,Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {

            string retorno = "";
            retorno += "Tipoconta" + this.Tipoconta + " | ";
            retorno += "Nome" + this.Nome + " | ";
            retorno += "Saldo"+this.Saldo + " | ";
            retorno += "Credito"+this.Credito + " | ";
            return retorno;

            
        }

            

    }
}