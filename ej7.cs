/*using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList lista = new ArrayList { 5, 2, 8, 1, 7, 3, 9, 4, 6 };

        Console.Write("Ingrese el número que desea buscar: ");
        int numeroBuscado = int.Parse(Console.ReadLine());

        int resultado = BusquedaLineal(lista, numeroBuscado);

        if (resultado != -1)
        {
            Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {resultado}.");
        }
        else
        {
            Console.WriteLine($"El número {numeroBuscado} no se encuentra en la lista.");
        }
    }

    static int BusquedaLineal(ArrayList lista, int elemento)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            if ((int)lista[i] == elemento)
            {
                return i;
            }
        }

        return -1;
    }
}
*/