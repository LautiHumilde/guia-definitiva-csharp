/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de valores que desea alojar en la cola:");
        int cantidadValores;
        
        while (!int.TryParse(Console.ReadLine(), out cantidadValores) || cantidadValores <= 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero válido mayor que 0.");
        }

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

        FiltrarNumerosPares(cola);

        Console.WriteLine("\nCola después de filtrar números pares:");
        foreach (int elemento in cola)
        {
            Console.Write(elemento + " ");
        }

        Console.ReadLine();
    }

    static void FiltrarNumerosPares(Queue<int> cola)
    {
        int elementosOriginales = cola.Count;
        for (int i = 0; i < elementosOriginales; i++)
        {
            int elemento = cola.Dequeue();
            if (elemento % 2 == 0)
            {
                cola.Enqueue(elemento);
            }
        }
    }
}
*/