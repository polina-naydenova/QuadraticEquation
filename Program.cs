using math;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        
        Console.OutputEncoding = Encoding.UTF8;

        // Създаване на обект от клас QuadraticEquation и извикване на неговия метод за решаване на уравнението
        QuadraticEquation quadraticEquation = new QuadraticEquation();
        quadraticEquation.SolveQuadraticEquation();
    }
}
