using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrTelefonica
{
    internal class EstructurasDatos
    {
        public static void Estructuras()
        {
            // 1. Diccionario:
            Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Manzana");
            diccionario.Remove(1);

            // 2. Listas:

            List<int> lista = new List<int>();  
            lista.Add(1);
            lista.Remove(1);
            lista.Add(1);

            // 3. Pila: Lista con LIFO. Solo puedes añadir y quitar desde la parte superior LIFO

            Stack<int> pila = new Stack<int>();
            pila.Push(1);
            pila.Pop();

            // 4. Cola: Lista con FIFO

            Queue<int> cola = new Queue<int>(); 
            cola.Enqueue(1);
            cola.Enqueue(4);
            cola.Dequeue();
            
            // 5. Lista enlazada (Cada elemento referencia al siguiente, puede ser circular)

            LinkedList<int> li = new LinkedList<int>(); 

            // 6. Arbol

            // 7. Arbol binario (solo puede tener 2 hijos)

            // 8. Arbol binario de búsqueda.

            // 9. Grafos

            // 10. Heap: un arbol de prioridad
        }
    }
}
