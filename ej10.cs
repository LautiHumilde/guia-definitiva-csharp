using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de listas
        List<List<int>> matriz1 = new List<List<int>>
        {
            new List<int> {1, 2, 3},
            new List<int> {4, 5, 6},
            new List<int> {7, 8, 9}
        };

        List<List<int>> matriz2 = new List<List<int>>
        {
            new List<int> {9, 8, 7},
            new List<int> {6, 5, 4},
            new List<int> {3, 2, 1}
        };

        List<List<int>> resultado = MultiplicarMatrices(matriz1, matriz2);

        // Mostrar la matriz resultante en la consola
        MostrarMatriz(resultado);
    }

    static List<List<int>> MultiplicarMatrices(List<List<int>> matriz1, List<List<int>> matriz2)
    {
        int filasMatriz1 = matriz1.Count;
        int columnasMatriz1 = matriz1[0].Count;
        int filasMatriz2 = matriz2.Count;
        int columnasMatriz2 = matriz2[0].Count;

        if (columnasMatriz1 != filasMatriz2)
        {
            throw new ArgumentException("Las matrices no pueden multiplicarse debido a dimensiones incorrectas.");
        }

        List<List<int>> resultado = new List<List<int>>(filasMatriz1);

        for (int i = 0; i < filasMatriz1; i++)
        {
            resultado.Add(new List<int>(columnasMatriz2));

            for (int j = 0; j < columnasMatriz2; j++)
            {
                int suma = 0;

                for (int k = 0; k < columnasMatriz1; k++)
                {
                    suma += matriz1[i][k] * matriz2[k][j];
                }

                resultado[i].Add(suma);
            }
        }

        return resultado;
    }

    static void MostrarMatriz(List<List<int>> matriz)
    {
        int filas = matriz.Count;
        int columnas = matriz[0].Count;

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
