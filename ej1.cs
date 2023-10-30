/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresar numeros");
        string input = Console.ReadLine();
        string[] numStrings = input.Split(' ');

        Stack<int> pila = new Stack<int>();
        foreach (string numString in numStrings)
        {
            if (int.TryParse(numString, out int numero))
            {
                pila.Push(numero);
            }
        }

        Console.WriteLine("\nElementos en orden inverso:");
        while (pila.Count > 0)
        {
            int elemento = pila.Pop();
            Console.Write(elemento + " ");
        }

        Console.ReadLine();
    }
}
*/