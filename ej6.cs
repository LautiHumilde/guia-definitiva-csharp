/*using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList listaOrdenada = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.Write("Ingrese el número que desea buscar: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        int resultado = BusquedaBinaria(listaOrdenada, numeroBuscado);

        if (resultado != -1)
        {
            Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {resultado}.");
        }
        else
        {
            Console.WriteLine($"El número {numeroBuscado} no se encuentra en la lista.");
        }
    }

    static int BusquedaBinaria(ArrayList lista, int elemento)
    {
        int inicio = 0;
        int fin = lista.Count - 1;

        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;
            int valorMedio = (int)lista[medio];

            if (valorMedio == elemento)
            {
                return medio;
            }
            else if (valorMedio < elemento)
            {
                inicio = medio + 1;
            }
            else
            {
                fin = medio - 1;
            }
        }

        return -1;
    }
}
*/