using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrTelefonica
{
    internal class Short
    {

        // The main function that implements QuickSort
        // arr[] --> Array to be sorted,
        // low --> Starting index,
        // high --> Ending index
        public static void QuickShort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Obtener pivote:
                int pi = partition(arr, low, high);

                // Llamada recursiva
                QuickShort(arr, low, pi - 1);
                QuickShort(arr, pi + 1, high);
            }
        }

        static int partition(int[] arr, int low, int high)
        {

            int indexPivote = low;      // Posición inicial pivote
            int valorPivote = arr[high];    // Valor pivote (el de más a la derecha)

           for (int i = low; i < high; i++)
            {
                if (arr[i] < valorPivote)
                {
                    swap(arr, i, indexPivote);
                    indexPivote++;
                    Console.WriteLine($"Swap realizado {i} por {indexPivote}"); // debug
                }
            }
            swap(arr, indexPivote, high);   // Ponemos el pivote en su posición, en este momento el pivote ya no se mueve, está ordenado.

            return indexPivote;
        }

        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
