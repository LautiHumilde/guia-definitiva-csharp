/*using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList lista = new ArrayList { 5, 2, 8, 1, 7, 3, 9, 4, 6 };

        Console.WriteLine("Lista original:");
        MostrarLista(lista);

        SelectionSort(lista);

        Console.WriteLine("\nLista ordenada:");
        MostrarLista(lista);
    }

    static void SelectionSort(ArrayList lista)
    {
        int n = lista.Count;

        for (int i = 0; i < n - 1; i++)
        {
            int indiceMinimo = i;
            for (int j = i + 1; j < n; j++)
            {
                if ((int)lista[j] < (int)lista[indiceMinimo])
                {
                    indiceMinimo = j;
                }
            }

            int temp = (int)lista[indiceMinimo];
            lista[indiceMinimo] = lista[i];
            lista[i] = temp;
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