using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PruebaPushUp.Retos;
public class RetoTres
{
    public void retoTres()
    {
        int limiteInferior = 1000;
        int limiteSuperior = 1500;

        for (int num1 = limiteInferior; num1 <= limiteSuperior; num1++)
        {
            int div1 = 0;
            int div2 = 0;
            int num2 = SumaDivisores(num1);

            // Evitar números iguales
            if (num1 != num2)
            {
                div1 = SumaDivisores(num1);
                div2 = SumaDivisores(num2);

                if (num1 == div2 && num2 == div1)
                {
                    Console.WriteLine($"Números amistosos: {num1}, {num2}");
                    Console.ReadKey();
                    return; // Termina la ejecución después de encontrar el primer par en el rango.
                }
            }
        }

        Console.WriteLine("No se encontraron números amistosos en el rango.");
        Console.ReadKey();
    }

    private int SumaDivisores(int num)
    {
        int suma = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                suma += i;
            }
        }
        return suma;
    }

}
