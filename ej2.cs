/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la notación postfija:");
        string expresion = Console.ReadLine();

        int resultado = EvaluarExpresionPostfija(expresion);

        Console.WriteLine($"\nResultado: {resultado}");
        Console.ReadLine();
    }

    static int EvaluarExpresionPostfija(string expresion)
    {
        Stack<int> pila = new Stack<int>();

        string[] elementos = expresion.Split(' ');

        foreach (string elemento in elementos)
        {
            if (int.TryParse(elemento, out int numero))
            {
                pila.Push(numero);
            }
            else
            {
                int operand2 = pila.Pop();
                int operand1 = pila.Pop();
                int resultadoOperacion = RealizarOperacion(operand1, operand2, elemento);
                pila.Push(resultadoOperacion);
            }
        }

        return pila.Peek();
    }

    static int RealizarOperacion(int operand1, int operand2, string operador)
    {
        switch (operador)
        {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "*":
                return operand1 * operand2;
            case "/":
                return operand2 != 0 ? operand1 / operand2 : 0;
            default:
                throw new ArgumentException($"Operador no válido: {operador}");
        }
    }
}
*/