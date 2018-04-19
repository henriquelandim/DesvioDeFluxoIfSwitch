using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //  comentário in-line(em linha)
            /*
                comentário in-block(em bloco)
            */
            //declaração da variável opereação. Ela será do tipo inteira
            int opereacao;
            //Declaração das variáveis n1 e n2. Elas serão do tipo DOUBLE
            double n1, n2;

            /*
            Para limpar a tela de comando a cada execução,
            utilizaremos o comando Console.Clear();
            obs.: CLEAR -> LIMPAR
             */
             Console.Clear();
             Console.WriteLine("    Qual operação deseja utilizar? :)   ");
             /*
             Para a exibição das opções de operação, usaremos o comando Console.WriteLine e nele vamos utilizar um comando 
             de quebra de linha \n (contra-barra) n(new lin)). assim as opçoes ficarão uma abaixo da outra.
              */

              Console.WriteLine("1 -Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
              opereacao = int.Parse(Console.ReadLine());
              
              Console.WriteLine("Digite um Número:");
              n1 = double.Parse(Console.ReadLine());

              Console.WriteLine("Digite outro Número:");
              n2 = double.Parse(Console.ReadLine());

        }
    }
}
