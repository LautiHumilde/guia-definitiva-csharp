/*using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList lista = new ArrayList { 5, 2, 8, 1, 7, 3, 9, 4, 6 };

        Console.WriteLine("Lista original:");
        MostrarLista(lista);

        BubbleSort(lista);

        Console.WriteLine("\nLista ordenada:");
        MostrarLista(lista);
    }

    static void BubbleSort(ArrayList lista)
    {
        int n = lista.Count;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if ((int)lista[j] > (int)lista[j + 1])
                {
                    int temp = (int)lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
    }

    static void MostrarLista(ArrayList lista)
    {
        foreach (int elemento in lista)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
*/