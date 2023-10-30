/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena:");
        string input = Console.ReadLine();

        bool espalindromo = Palidromo(input);

        if (espalindromo)
        {
            Console.WriteLine("Es un palíndromo");
        }
        else
        {
            Console.WriteLine("No es un palíndromo");
        }

        
        Queue<int> cola = CargarColaDesdeConsola();

    Console.WriteLine("Ingrese 1 para ordenar de manera ascendente, -1 para ordenar de manera descendente:");
    int orden = int.Parse(Console.ReadLine());

    Queue<int> colaOrdenada = OrdenarCola(cola, orden);

    Console.WriteLine("Cola ordenada:");

    foreach (var elemento in colaOrdenada)
    {
        Console.Write(elemento + " ");
    }

    }

    static bool Palidromo(string cadena)
    {
        cadena = cadena.Replace(" ", "").ToLower();

        Queue<char> cola = new Queue<char>();

        foreach (char c in cadena)
        {
            cola.Enqueue(c);
        }
        while (cola.Count > 0)
        {
            if (cola.Dequeue() != cadena[cadena.Length - 1])
            {
                return false;
            }

            cadena = cadena.Substring(0, cadena.Length - 1);
        }

        return true;
    }


    static Queue<int> CargarColaDesdeConsola()
    {
        Console.WriteLine("Ingrese valores para la cola (ingrese un valor no numérico para finalizar):");
        Queue<int> cola = new Queue<int>();

        while (true)
        {
            string entrada = Console.ReadLine();
            int valor;

            if (int.TryParse(entrada, out valor))
            {
                cola.Enqueue(valor);
            }
            else
            {
                break;
            }
        }

        return cola;
    }

    static Queue<int> OrdenarCola(Queue<int> cola, int orden)
{
    List<int> lista = new List<int>(cola);

    if (orden == 1)
    {
        lista.Sort();
    }
    else if (orden == -1)
    {
        lista.Sort((a, b) => b.CompareTo(a));
    }

    return new Queue<int>(lista);
}

}
*/