/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena para verificar si es un palíndromo:");
        string cadena = Console.ReadLine();

        bool esPalindromo = EsPalindromo(cadena);

        Console.WriteLine($"La cadena '{cadena}' es un palíndromo: {esPalindromo}");

        Console.ReadLine();
    }

    static bool EsPalindromo(string cadena)
    {
        cadena = cadena.Replace(" ", "").ToLower();

        Queue<char> cola = new Queue<char>();
        foreach (char caracter in cadena)
        {
            cola.Enqueue(caracter);
        }

        Stack<char> pila = new Stack<char>();
        foreach (char caracter in cadena)
        {
            pila.Push(caracter);
        }

        while (cola.Count > 0)
        {
            char caracterCola = cola.Dequeue();
            char caracterPila = pila.Pop();
            
            if (caracterCola != caracterPila)
            {
                return false;
            }
        }

        return true;
    }
}
*/