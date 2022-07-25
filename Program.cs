using System;
using Operacoes_banco;


namespace Estudo.Net
{
    class Programa
    {

        static void Main()
        {
            //cria uma instancia nova_conta recebendo as propriedades da classe operacao_banco
            Operacoes_banco.opcao nova_conta = new Operacoes_banco.opcao();

            //entra com os dados para o novo usuario antes de prosseguir com as operações
            nova_conta.Atualizarcadastro();


            //Chama menu de opções e aguarda o usuario realizar uma escolhar
            nova_conta.mostar_Menu();





        }

    }
               

}