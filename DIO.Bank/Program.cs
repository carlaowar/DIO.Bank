using System;
using System.Collections.Generic;

namespace DIO.Bank
{

    class Program
    {
        static List<Conta> listContas = new List<Conta>();

        static void Main(string[] args)
        {
         string opcaoUsuario = ObterOpcaoUsuario();

         while (opcaoUsuario.ToUpper()!= "x")
         {
             switch(opcaoUsuario)
             {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                             
             }

             opcaoUsuario = ObterOpcaoUsuario();

            }
             Console.WriteLine("Obrigado por utilizar nossos serviços.");
             Console.ReadLine();
            }

            private static void Depositar()
            {
                Console.Write("Digite o número da conta:");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser deppositado:");
                double valorDeposito = double.Parse(Console.ReadLine());
            listContas[indiceConta].Depositar(valorDeposito);
            }

            private static void Sacar()
            {
                Console.Write("Digite o número da conta:");
                int indiceConta = int.Parse(Console.ReadLine());

                Console.Write("Informe valor do saque:");
                double valorSaque = double.Parse(Console.ReadLine());
            listContas[indiceConta].Sacar(valorSaque);
            }  

            private static void Transferir()
            {
                Console.Write("Digite o numero da conta de origem:");
                int indiceContaOrigem = int.Parse(Console.ReadLine());

                Console.Write("Digite o número da conta de destino:");
                int indiceContaDestino = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser transfirido:");
                double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Tranferir(valorTransferencia, listContas[indiceContaDestino]);
            }

            private static void InserirConta()
            {
                Console.WriteLine("Inserir nova conta");
                Console.Write("Digite 1 para Conta Fisica ou 2 para Conta Juridica:");
                int entradaTipoConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do cliente:");
                string entradaNome = Console.ReadLine();

                Console.Write("Digite saldo inicial:");
                double entradaSaldo = double.Parse(Console.ReadLine());

                Console.Write("Digite o crédito:");
                double entradaCredito = double.Parse(Console.ReadLine());

                Conta novaConta = new Conta(Tipoconta:(Tipoconta)entradaTipoConta, Saldo:entradaSaldo, Credito: entradaCredito, Nome:entradaNome);

                listContas.Add(novaConta);
            }

            private static void ListarContas()
            {
                Console.WriteLine("Listar contas");


                if (listContas.Count == 0)
                {
                    Console.WriteLine("Nenhuma conta cadastrada.");
                    return;
                }

                for (int i = 0; i <listContas.Count; i++)
                {
                    
                    Conta conta = listContas[i];
                    Console.Write("#{0}-",i);
                    Console.WriteLine(conta);

                }
            }

    

            private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Bank a seu dipor");
                Console.WriteLine("Informe a opçãp desejada:");
            
                Console.WriteLine("1- Listar contas");
                Console.WriteLine("2- Inserir nova conta");
                Console.WriteLine("3- Transferir");
                Console.WriteLine("4- Sacar");
                Console.WriteLine("5- Deposito");
                Console.WriteLine("C- Limpar tela");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
        }

    }
}