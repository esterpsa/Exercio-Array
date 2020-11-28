using System;

namespace Função_A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Array");
            // Console.WriteLine("CADASTRO: KATA POR EQUIPE");
            // Console.WriteLine("---------------");

            // string[] nomes = new string [3];
            // int [] idade = new int [3];
            // string [] estilo = new string [3];
            // string [] academia = new string [3];
            // string [] graduacao = new string [3];

            // for(var contador = 0; contador <3;contador++)
            // {
            //     Console.WriteLine($"Digite o {contador+1}º nome:");
            //     nomes [contador] =Console.ReadLine();
            //     Console.WriteLine("Digite a idade: ");
            //     idade [contador] = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Digite o estilo: ");
            //     estilo [contador] = Console.ReadLine();
            //     Console.WriteLine("Digite o nome da academia: ");
            //     academia [contador] = Console.ReadLine();
            //     Console.WriteLine("Digite a sua graduação: ");
            //     graduacao [contador] = Console.ReadLine();
            // }

            // Console.WriteLine("Equipe cadastrada");
            // Console.WriteLine("-------------------");

            // for(var contador = 0; contador <3; contador++)
            // {
            //     Console.WriteLine("nomes: "+nomes[contador]);
            //     Console.WriteLine("idade: "+idade[contador]);
            //     Console.WriteLine("estilo: "+estilo[contador]);
            //     Console.WriteLine("academia: "+academia[contador]);
            //     Console.WriteLine("graduacao: "+graduacao[contador]);
            // }
       

          Console.WriteLine("Está precisando de luvas? ");
          string material = Console.ReadLine();

             string [] cores = {"Ao, Aka",};
             string [] tamanhos = {"G,GG, M, P"};

          if( material  == "não"){
              Console.WriteLine("Boa sorte no campeonato! oss");
          }else{
              Console.WriteLine("Conheça a loja da federação");
              Console.WriteLine("---------------------");
              Console.WriteLine("Qual cor você precisa?");

                for(int contador = 0; contador < cores.Length; contador++)
            {
                Console.WriteLine("Selecione uma opção: "+cores[contador]);
                 string respostacores = Console.ReadLine();
            }

        Console.WriteLine("Selecione o tamanho");
         for(int contador = 0; contador < tamanhos.Length; contador++)
            {
                Console.WriteLine("Selecione uma opção: "+tamanhos[contador]);
                 string resptam = Console.ReadLine();
            }

        Console.WriteLine("Prontinho! Pedido feito, aguarde para o pagamento. ");
        Console.WriteLine("Boa sorte! Oss");

        }
    }
}

}
