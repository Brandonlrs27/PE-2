using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lares Dominguez Brandon - 17211532
            Evaluacion eva = new Evaluacion();
            int[] evalu = new int[10] {1,3,5,7,9,11,13,15,17,19 };
            p:
            Console.WriteLine("Escoga un ejercicio: ");
            Console.WriteLine("Ejercicio - 1 ");
            Console.WriteLine("Ejercicio - 2 ");
            Console.WriteLine("Ejercicio - 3 ");
            Console.WriteLine("Cualquier otro valor para salir. ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("\nValor maximo: {0}\n ", eva.Maximo(evalu, 0, evalu[0]));
                    goto p;
                    
                case 2:
                    Console.WriteLine("\nValor minimo: {0}\n ", eva.Minimo(evalu, 0, evalu[0]));
                    goto p;
                    
                case 3:
                    Invertir(evalu, 0, evalu.Length - 1);
                    for (int i = 0; i < evalu.Length; i++)
                    {
                        Console.WriteLine(evalu[i]);
                    }
                    goto p;
                    
                default:
                    Console.WriteLine("\nPresione cualquier tecla para salir.");
                    break;
                    

            }
           
            Console.ReadKey();
        }

        public static void Invertir(int[] numeros, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int ayu = numeros[inicio];
                numeros[inicio] = numeros[fin];
                numeros[fin] = ayu;
                Invertir(numeros, inicio + 1, fin - 1);
            }

        }
    }
    class Evaluacion
    {
        public int Maximo(int[] numeros, int indice, int max)
        {
            if (indice != numeros.Length)
            {
                if (numeros[indice] > max)
                {
                    max = Maximo(numeros, indice + 1, numeros[indice]);
                }
                else
                {
                    max = Maximo(numeros, indice + 1, max);
                }
            }
            return max;
        }
        public int Minimo(int[] numeros, int indice, int min)
        {
            if (indice != numeros.Length)
            {
                if (numeros[indice] < min)
                {
                    min = Minimo(numeros, indice + 1, numeros[indice]);
                }
                else
                {
                    min = Minimo(numeros, indice + 1, min);
                }
            }
            return min;

        }
        
    }
}
