using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("here ex1 will be encoded");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
        }
        public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
        }
        public static void Exercicio5()
        {
            Console.WriteLine("here ex5 will be encoded");
        }
        public static void Exercicio6()
        {
            Console.WriteLine("here ex6 will be encoded");
        }
        public static void Exercicio7()
        {
            Console.WriteLine("here ex7 will be encoded");
        }

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("=================MENU=================");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para executar o exercício 5 - digite 5");
                Console.WriteLine("para executar o exercício 6 - digite 6");
                Console.WriteLine("para executar o exercício 7 - digite 7");
                Console.WriteLine("para sair do programa    -    digite 0");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("thank you for using my system!");

                        break;

                    case 1:
                        Exercicio1();

                        int[] vet;

                        Console.WriteLine("digite a quantidade de variaveis:");
                        int q = int.Parse(Console.ReadLine());

                        vet = new int[q];
                        Random rand = new Random();

                        float soma = 0;

                        for (int i = 0; i < q; i++)
                        {
                            vet[i] = rand.Next(10, 50);
                            soma = soma + vet[i];
                        }
                        Console.WriteLine("a média aritmética é = " + soma / (float)q);


                        for (int i = 0; i < q; i++)
                        {
                            Console.WriteLine("posicão[{0}] = {1}", i, vet[i]);
                        }

                        break;

                    case 2:
                        Exercicio2();
                        int[] vetq;
                        int num = 0, somap = 0, somai = 0;

                        Console.WriteLine("digite a quantidade de variaveis:");
                        int t = int.Parse(Console.ReadLine());
                        vetq = new int[t];
                        Random r = new Random();

                        for (int i = 0; i < t; i++)
                        {
                            vetq[i] = r.Next(0, 50);
                            if (vetq[i] % 2 == 0)
                            {
                                somap = somap + i;
                            }
                            else
                            {
                                somai = somai + i;
                            }
                        }
                        Console.WriteLine("a soma dos numeros pares é: " + somap + " e a soma dos numeros impares é: " + somai);

                        break;

                    case 3:
                        Exercicio3();
                        int[] vet1;

                        Console.WriteLine("digite a quantidade de variaveis:");
                        int qq = int.Parse(Console.ReadLine());

                        vet1 = new int[qq];
                        Random randd = new Random();

                        for (int i = 0; i < qq; i++)
                        {
                            vet1[i] = randd.Next(0, 50);
                            Console.WriteLine("posicão[{0}] = {1}", i, vet1[i]);
                        }

                        Console.WriteLine("\n");

                        for (int i = qq - 1; i >= 0; i--)
                        {
                            Console.WriteLine("posicão[{0}] = {1}", i, vet1[i]);
                        }
                        break;

                    default:
                        Console.WriteLine("programa inválido!");
                        break;

                    case 4:
                        Exercicio4();
                        int[] vet2;

                        Console.WriteLine("digite a quantidade de variaveis:");
                        int qqq = int.Parse(Console.ReadLine());

                        vet = new int[qqq];
                        Random rr = new Random();

                        float soma1 = 0;

                        for (int i = 0; i < qqq; i++)
                        {
                            vet[i] = rr.Next(0, 100);
                        }

                        for (int j = 0; j < qqq; j++)
                        {
                            if (vet[j] % 3 == 0 && vet[j] % 5 == 0)
                            {
                                soma1 = soma1 + vet[j];
                            }
                            Console.WriteLine("posicão[{0}] = {1}", j, vet[j]);
                        }

                        Console.WriteLine("a média aritmética é = " + soma1 / qqq);



                        break;
                }

            } while (option != 0);

        }
    }
}