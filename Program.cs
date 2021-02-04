using System;

namespace SalariosGenero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            int cantHombres = 0;
            int cantMujeres = 0;
            
            // Proceso
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el número de folio");
                Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo que gana");
                double sueldo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el sexo (femenino: 1, Masculino: 2");
                int genero = Convert.ToInt32(Console.ReadLine());

                if(genero == 1 && sueldo >= 900000)
                {
                    cantMujeres += 1;
                }
                else if(genero == 2 && sueldo <= 1000000)
                {
                    cantHombres += 1;
                }

            }
            // 2 hombre 2 mujer
            // Salida

            Console.WriteLine($"La cantidad de mujeres que ganan más de 900.000 son: {cantMujeres}");
            Console.WriteLine($"La cantidad de hombres que ganan menos de 1.000.000 son: {cantHombres}");


            
        }
    }
}
