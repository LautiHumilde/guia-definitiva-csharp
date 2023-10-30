/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int>();

        Console.WriteLine("Ingrese valores para la lista (ingrese un valor no numérico para finalizar):");
        while (true)
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int valor))
            {
                lista.Add(valor);
            }
            else
            {
                break;
            }
        }

        BubbleSort(lista);

        Console.WriteLine("Lista ordenada:");
        foreach (var elemento in lista)
        {
            Console.Write(elemento + " ");
        }
    }

    static void BubbleSort(List<int> list)
    {
        int n = list.Count;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (list[j] > list[j + 1])
                {
                    // Realizar el intercambio
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }
}
*/