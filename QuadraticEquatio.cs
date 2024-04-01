using System;
using System.Collections.Generic;
using System.Text;

namespace math
{
    class QuadraticEquation
    {
        public void SolveQuadraticEquation()
        {
           
            Console.WriteLine("Метод SolveQuadraticEquation/ Въведете коефициентите");

            // Въвеждане на коефициентите a, b и c
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Изчисляване на дискриминантата
            double discriminant = b * b - 4 * a * c;

            // Проверка за реални корени
            if (discriminant >= 0)
            {
                // Изчисляване на корените
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                // Извеждане на корените
                Console.WriteLine("Корените на уравнението са:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                // Извеждане на съобщение за комплексни корени
                Console.WriteLine("Уравнението няма реални корени. Корените са комплексни числа.");
            }
        }
    }
}
