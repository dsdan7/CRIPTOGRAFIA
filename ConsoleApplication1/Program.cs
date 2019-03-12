using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1, escolha = 0;
            do
            {
                Console.WriteLine("1)ENCRPITAR\n2)DESCRIPTAR\n3)DESCRIPTOGRAFAR SEM CHAVE");
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    string txt = "", resultado = "";
                    int key;
                    Console.WriteLine("Digite o texto a ser encrpitado");
                    txt = (Console.ReadLine()).ToUpper();
                    do
                    {
                        Console.WriteLine("Digite a chave númerica entre 1 e 26");
                        key = int.Parse(Console.ReadLine());
                        if (key > 25)
                        {
                            key = key - 26;
                        }
                    } while (key > 25);

                    for (int x = 0; x < txt.Length; x++)
                    {
                        int ascitxt = (int)txt[x];

                        int ascikey = ascitxt + key;
                        if (ascikey > 90) ascikey = (ascikey - 25) - 1;
                        resultado += Char.ConvertFromUtf32(ascikey);

                    }

                    Console.Write("Resultado: " + resultado);
                }
                else if (escolha == 2)
                {
                    string txt = "", resultado = "";
                    int key;
                    Console.WriteLine("Digite o texto a ser Descrpitado");
                    txt = (Console.ReadLine()).ToUpper();
                    do
                    {
                        Console.WriteLine("Digite a chave númerica entre 0 e 25");
                        key = int.Parse(Console.ReadLine());
                        if (key > 25)
                        {
                            key = key - 25;
                        }
                    } while (key > 25);

                    for (int x = 0; x < txt.Length; x++)
                    {
                        int ascitxt = (int)txt[x];
                        int ascikey = ascitxt - key;
                        if (ascikey < 65) ascikey = ascikey + 26;
                        resultado += Char.ConvertFromUtf32(ascikey);
                    }
                    Console.Write("Resultado: " + resultado);
                }
                else if (escolha == 3)
                {
                    string txt = "", resultado = "";
                    int key = 1;
                    Console.WriteLine("Digite o texto a ser Descrpitado");
                    txt = (Console.ReadLine()).ToUpper();
                    while (key < 26)
                    {
                        for (int x = 0; x < txt.Length; x++)
                        {
                            int ascitxt = (int)txt[x];
                            int ascikey = ascitxt - key;
                            if (ascikey < 65) ascikey = ascikey + 26;
                            resultado += Char.ConvertFromUtf32(ascikey);
                        }
                        Console.WriteLine("Resultado: " + key + "º " + resultado);
                        resultado = "";
                        key++;
                    }
                }
                Console.WriteLine("\nDeseja continuar Sim[1] Não[0]");
                y = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (y != 0);
        }
    }
}
