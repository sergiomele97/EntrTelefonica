using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrTelefonica
{
    internal class Algoritmo_grafo
    {
        /* Dado un grafo no dirigido y ponderado, se te pide que implementes un algoritmo para encontrar el camino más corto entre dos nodos dados 
            Debes devolver la longitud del camino más corto y una lista que contenga los nodos que forman parte de ese camino.

Ejemplo:

Supongamos que tenemos el siguiente grafo:

css
Copy code
A---B
|  /| \
| / |  \
C---D---E
Donde las aristas tienen los siguientes pesos:

        */

        // FALTA POR TERMINAR

        // 1º Vamos a modelizar el grafo

        public static void FindShortestPath()
        {
            Dictionary<char, Dictionary<char, int>> nodosDestino = new Dictionary<char, Dictionary<char, int>>();

            nodosDestino.Add('A', new Dictionary<char, int> { { 'B', 2 }, { 'C', 1 } } );
            nodosDestino.Add('B', new Dictionary<char, int> { { 'C', 3 }, { 'D', 1 }, { 'E', 4 } });
            nodosDestino.Add('C', new Dictionary<char, int> { { 'B', 3 }, { 'D', 7 } });
            nodosDestino.Add('D', new Dictionary<char, int> { { 'E', 2 } });
            nodosDestino.Add('E', new Dictionary<char, int> { });

            List<char> activeNodes = new List<char>{'A'};
            
            for (int i = 0; i < nodosDestino.Count - 1; i++)
            {
                int min = 0;
                char minKey = 'A';
                foreach (char nodo in activeNodes)
                {
                    foreach (KeyValuePair<char, int> destino in nodosDestino[nodo])
                    {
                        if (!activeNodes.Contains(destino.Key) & (destino.Value < min || min == 0))
                        {
                            min = destino.Value;
                            minKey = destino.Key;
                            
                        }
                    }
                }
                Console.WriteLine($"Destino más bajo acumulado es: {min}, hacia el nodo {minKey}");
                activeNodes.Add(minKey);
                Console.WriteLine(minKey);
                
            }
        }   


    }
}
