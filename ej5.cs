/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Solicitar al usuario la cantidad de valores que desea alojar en la cola
        int cantidadValores;

        do
        {
            Console.WriteLine("Ingrese la cantidad de valores que desea alojar en la cola (debe ser mayor que 0):");
        } while (!int.TryParse(Console.ReadLine(), out cantidadValores) || cantidadValores <= 0);

        // Solicitar cada uno de los valores vía consola
        Queue<int> cola = new Queue<int>();
        for (int i = 0; i < cantidadValores; i++)
        {
            int valor;

            do
            {
                Console.WriteLine($"Ingrese el valor {i + 1}:");
            } while (!int.TryParse(Console.ReadLine(), out valor));

            cola.Enqueue(valor);
        }

        // Solicitar el valor n (1 o -1)
        int n;
        do
        {
            Console.WriteLine("Ingrese el valor n (1 para orden ascendente, -1 para orden descendente):");
        } while (!int.TryParse(Console.ReadLine(), out n) || (n != 1 && n != -1));

        // Llamar al método para ordenar la cola
        Queue<int> colaOrdenada = OrdenarCola(cola, n);

        // Mostrar la cola resultante
        Console.WriteLine("\nCola ordenada:");
        foreach (int elemento in colaOrdenada)
        {
            Console.Write(elemento + " ");
        }

        Console.ReadLine(); // Para que la consola no se cierre inmediatamente
    }

    static Queue<int> OrdenarCola(Queue<int> cola, int n)
    {
        if (n == 1 || n == -1)
        {
            int factor = (n == 1) ? 1 : -1;

            // Convertir la cola a una lista para facilitar la manipulación
            List<int> listaCola = cola.ToList();

            // Utilizar el método de selección para ordenar la lista
            for (int i = 0; i < listaCola.Count - 1; i++)
            {
                int extremaIndex = i;

                // Encontrar el índice del mínimo (o máximo) en la porción restante de la lista
                for (int j = i + 1; j < listaCola.Count; j++)
                {
                    if (listaCola[j] * factor < listaCola[extremaIndex] * factor)
                    {
                        extremaIndex = j;
                    }
                }

                // Intercambiar elementos
                int temp = listaCola[i];
                listaCola[i] = listaCola[extremaIndex];
                listaCola[extremaIndex] = temp;
            }

            // Convertir la lista ordenada de nuevo a una cola
            cola = new Queue<int>(listaCola);
        }
        else
        {
            // Si n no es 1 ni -1, retornar -1 y no realizar ordenación
            return cola;
        }

        return cola;
    }
}
*/