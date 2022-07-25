using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacoes_banco
{
    internal class opcao
    {

        //Variavais utilizadas somente dentro da classe opcao 
        
        private string nome;
        private string sobrenome;
        private string endereço;
        private int idade;
        private decimal saldo;
        private decimal senha;
        


        public void Atualizarcadastro()
        {

            // recebe do usuario os dados dadastrais do novo participante do banco que sao armazenadas nas variaveis privadas

            Console.WriteLine("Bem vindo a tela de cadastro \n");

            Console.Write("Digite seu nome.........: ");
            nome = Console.ReadLine();


            Console.Write("Digite seu sobrenome....: ");
            sobrenome = Console.ReadLine();


            Console.Write("Digite seu endereço.....: ");
            endereço = Console.ReadLine();


            Console.Write("Digite sua idade........: ");
            idade = Convert.ToInt32(Console.ReadLine());


            Console.Write("Digite uma nova senha...: ");
            senha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");




        }

        public void cadastro()
        {

            //Mostra para o usuario todos os dados ja cadastrados anterioamente para o novo cliente 

            Console.WriteLine("Dados cadastrias\n");

            Console.WriteLine("Nome................: {0}", nome);

            Console.WriteLine("Sobrenome...........: {0}", sobrenome);

            Console.WriteLine("Endereço............: {0}", endereço);

            Console.WriteLine("Idade...............: {0}\n", idade);

            mostar_Menu();


        }

        public void MostrarSaldo()
        {
            //Retorna para o usuario apenas menssagem com saldo da conta
            Console.WriteLine("Olá {0}" , nome  );

            Console.WriteLine("O saldo atual da sua conta e de.........: {0:c} \n", saldo);

            mostar_Menu();

        }

        public void Fazerdesposito()
        {

            // Recebe do usuario valor que deve ser somado ao valor ja existente armazenado na variavel deposito e retorna o usuaro saldo apos operação

        

            Console.Write("Digite o valor a ser depositado:");
            int valor_deposito = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("voce esta fazendo um deposito de:.........: {0:c}", valor_deposito);
            
            Console.WriteLine("O saldo atual da sua conta e de:..........: {0:c}\n", saldo += valor_deposito);

            mostar_Menu();

        }


        public void Fazersaque()
        {
            // Recebe do usuario valor que deve ser subtraido do valor ja existente armazenado na variavel deposito e retorna o usuaro saldo apos operação
           
          

            Console.Write("Digite o valor a ser retirado: ");
            int valor_saque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Voce esta realizano um saque de.........: {0:c}" , valor_saque);
         
            Console.WriteLine("O saldo atual da sua conta e de.........: {0:c}\n", saldo -= valor_saque);

            mostar_Menu();
        }



        public void mostar_Menu()
        {
            // exibe opcoes do menu na tela
            // valida senha para operaçõs de SALDO, TRANSFERENCIA e SAQUE



            string[] menu = {"1 - cadastro", "2 - saldo", "3 - Saque", "4 - Deposito \n" };

            Console.Write("digite o numero da transação que deseja realizar ou 5 para mostrar opções: ");
            int id_selecionado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");



            if (id_selecionado == 1)
                cadastro();


            if (id_selecionado == 2)
                if (Autorizaoperacao(out bool Autoriza_saldo) == true)
                    MostrarSaldo();

            if (id_selecionado == 3)
                    if (Autorizaoperacao(out bool Autoriza_saque) == true)
                        Fazersaque();

            if (id_selecionado == 4)
                if (Autorizaoperacao(out bool Autoriza_deposito) == true)
                    Fazerdesposito();


            if (id_selecionado == 5)
                foreach (string s in menu)
                    Console.WriteLine(s);


            else
                Console.WriteLine("numero da transação invalido!!! \n");

            mostar_Menu();





        }

        public bool Autorizaoperacao(out bool validacaosenha)
        {
            // valida se o usuario digitou a senha corretamente e valida a operação
            
            Console.Write("Digite sua Senha: ");
            int entardasenha = Convert.ToInt32(Console.ReadLine());
            

            if (entardasenha == senha)
                validacaosenha = true;
            

            else
                validacaosenha = false;

                 
            
            if (validacaosenha == false)
                Console.WriteLine("Senha Invalida!!! \n");


            return validacaosenha;


        }

    }
}



