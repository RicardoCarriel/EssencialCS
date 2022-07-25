using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoCSharp
{
    internal class Program
    {
        //enum Cor { Azul, Verde, Amarelo, Vermelho } // pode indicar o valor para indice com Azul=33
        //enum Opcao { Criar=1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args)
        {
            // constante (so pode ser definido uma unica vez)
            //const float PI = 3.1415f;

            // VARIAVEIS (var)
            // int - numeros inteiros (+/-)
            // float - numeros quebrados (+/-)
            // bool - verdadeiro ou falso
            // string - texto ("Aspas duplas")
            // char - caracter ('a') deve ser unico

            //caracteres de A a Z, numeros de 0 a 9 (NAO PODE SER NO INICIO)
            //proibido caracteres especiais (exceto _ ) e palavras reservadas
            /*int segundaGuerraMundial = 1942;
            string corFavorita = "Roxo";
            float velocidadeF1 = 294.98f;
            bool segundaGuerraMundialAconteceu = true;      
            char inicialNome = 'R';
            Console.WriteLine(corFavorita);
            Console.WriteLine(segundaGuerraMundialAconteceu);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segundaGuerraMundial);
            velocidadeF1 = 302.80f;
            Console.WriteLine(velocidadeF1);*/

            // VARIAVEL dynamic pode ser alterada em tipo (NAO RECOMENDADO)
            /*dynamic carro = "Model S";
            Console.WriteLine(carro);
            carro = 2;
            Console.WriteLine(carro);*/

            // leitura do usuario com (readline)
            /*Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Seu nome é: ");
            Console.WriteLine(nome);*/

            // operacoes aritmeticas
            /*int numeroQualquer = 20 + 20 - 80;
            int numeroMult = 10 * 90;
            int numeroDiv = 90 / 10;
            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);*/

            // estruturas condicionais (T/F)
            /*if (10 > 200)
            {
                Console.WriteLine("dez é maior que 200");
            }
            else
            {
                Console.WriteLine("dez nao é maior que 200");*/

            // exercicio teste idade
            /*Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade < 12)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else if (idade >= 12 && idade < 18)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else if (idade >= 18 && idade < 60)
            {
                Console.WriteLine("Você é um adulto.");
            }
            else
            {
                Console.WriteLine("Você é um idoso.");
            }*/

            // Chamada da funcao
            // GerarPreco(-500);

            // Arrays
            /*string produto1 = "Sea of Thieves";
            string produto2 = "Grounded";
            string produto3 = "Little Nightmares";

            string[] produtos = new string[3] { "Sea of Thieves",//0
                "Grounded",//1
                "Little Nightmares"//2
            };
            Console.WriteLine(produtos[2]);

            int[] valores = {1, 2, 3, 4, 5};
            Console.WriteLine(valores[0]);*/

            // Switch (substituir varios IFs)
            /*
            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho.");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo.");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul.");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita eu não sei.");
                    break;
            }*/

            // Enum (feito na Class Program)
            /*Cor corFavorita = Cor.Vermelho;
            Cor corFavoritaCarla = Cor.Azul;

            Console.WriteLine((int)corFavorita);
            Console.WriteLine(corFavoritaCarla);*/

            // Enum com Switch para menus
            /*Console.WriteLine("Selecione uma das opcoes abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");

            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Voce quer criar!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Voce quer deletar!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Voce quer editar!");
                    break;
                default:
                    Console.WriteLine("Opcao nao encontrada..."):
                    break;
            }*/

            // While

            /*int contador = 0;

            while(contador < 10)
            {
                Console.WriteLine("Rodando o while.");
                contador++;
            }*/

            // Do While

            /*do
            {
                Console.WriteLine("Do While");
            } while (100 < 10);*/

            // Foreach
            /*string[] nomeCompleto = { "Ricardo", "Carriel", "de", "Oliveira", "Filho" };
            foreach(string nome in nomeCompleto)
            {
                Console.Write(nome + " ");
            }
            Console.WriteLine("\nFim do loop");

            // For

            for(int contador = 0; contador < nomeCompleto.Length; contador++)
            {
                Console.Write(nomeCompleto[contador] + " ");
            }
            Console.WriteLine("\nfim do loop");

            // for invertido

            for(int contador2 = 4; contador2 >= 0; contador2--)
            {
                Console.Write(nomeCompleto[contador2] + " ");
            }
            Console.WriteLine("\nfim do loop");*/
        }
        //Funcoes
        /*static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando funcoes.\nBem vindo!");
        }*/
        /*static void GerarPreco(int preco)
        {
            int precoAbs = Math.Abs(preco);
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + valorFinal);
        }*/
    }
}
