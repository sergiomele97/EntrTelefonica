using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntrTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solo para imprimir resultados:

            // Console.WriteLine(LargestSumConSubarray());
            // FindDuoValue();
            // Console.WriteLine(IsBalanced());

            int[] arrayOrdenar = { 10, 3, 7, 3, 8, 9, 1, 5 , 1, 9, 11, 2};
            Short.QuickShort(arrayOrdenar, 0, arrayOrdenar.Length - 1);
            for (int i = 0; i < arrayOrdenar.Length; i++)   // Print por pantalla
            {
                Console.WriteLine(arrayOrdenar[i]);
            }
        }

        
        public static bool IsBalanced()
        {
            string str = "{[]}()[][][][[{[]}]]"; // Correcto
            string listadoApertura = "";

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '{':
                        listadoApertura += '{';
                        break;
                    case '}':
                        if (listadoApertura.Length >= 1 && listadoApertura[listadoApertura.Length - 1] == '{')
                        {
                            listadoApertura = listadoApertura.Remove(listadoApertura.Length - 1, 1);
                        }
                        else { return false; }
                        break;
                    case '(':
                        listadoApertura += '(';
                        break;
                    case ')':
                        if (listadoApertura.Length >= 1 && listadoApertura[listadoApertura.Length - 1] == '(')
                        {
                            listadoApertura = listadoApertura.Remove(listadoApertura.Length - 1, 1);
                        }
                        else { return false; }
                        break;
                    case '[':
                        listadoApertura += '[';
                        break;
                    case ']':
                        if (listadoApertura.Length >= 1 && listadoApertura[listadoApertura.Length - 1] == '[')
                        {
                            listadoApertura = listadoApertura.Remove(listadoApertura.Length - 1, 1);
                        }
                        else { return false; }
                        break;
                }
            }
            

            if (listadoApertura.Length == 0)
            {
                return true;
            }
            else { return false; }
        }

        public static void FindDuoValue()
        {
            int[] arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };
            int s = 4;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)    // Complejidad O(n^2) (cuadrática)
                {
                    if (arr[i] + arr[j] == s)
                    {
                        Console.WriteLine($"Valor {s} encontrado sumando las posiciones: " +
                                          $"{i} (valor: {arr[i]}) y {j} (valor: {arr[j]}).");
                    }
                }
            }
        }

        public static string LargestSumConSubarray()  // Algoritmo de Kadane’s: Suponemos que hay valores positivos en el array.
        {
            int[] arr = new int[]{ -2, -3, 4, -1, -2, 1, 5, -3 };

            int max_ending_here = 0;
            int max_so_far = 0;
            int newi = 0;
            int imax = 0;
            int jmax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max_ending_here = max_ending_here + arr[i];     // 1

                if (max_ending_here > max_so_far)               // 2 Actualizar MaxSoFar
                {
                    max_so_far = max_ending_here;
                    jmax = i;
                    imax = newi;
                }

                if (max_ending_here < 0)                        // 3 Reseteo si negativo
                {
                    max_ending_here = 0;
                    newi = i + 1;   // Empezamos en el siguiente
                }

            }

            return ($"El subarray con mayor valor empieza en {imax} y acaba en {jmax}. Con una puntuación de {max_so_far}");
        }

    }
}
