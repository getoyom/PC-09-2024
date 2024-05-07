using System.Collections.Concurrent;
using System.Diagnostics;

namespace Parcial
{
    public class Parcial
    {
        public string[] nomalumn = new string[10];
        public int[] notalum = new int[10];

        public int suma = 0;
        public static void Main()
        {
            /** El programa debe solicitar el usuario el ingreso de 10 nombre y 10 valores numericos que respresentaran 
            notas de un curso (ente 0 - 100)
            * Utilizar arreglos para almacenar los datos
            * Validar que los datos ingresados por el usuario sean del tipo correcto sino preguntar a usuario que ingrese de nuevo.
            * Mostrar un menu con las siguientes opciones:*/
            System.Console.WriteLine("Bienvenido");
            System.Console.WriteLine("----------------------------------");
            Parcial llamado = new Parcial();
            llamado.solicitar();
            llamado.menu();
        }


        public void solicitar()
        {
            for (int i = 0; i < nomalumn.Length; i++)
            {
                System.Console.WriteLine($"\nIngrese eL nombre del alumno {i+1}");
                nomalumn[i] = Console.ReadLine();
                System.Console.WriteLine($"\nIngrese la nota del alumno {i+1}");
                notalum[i] = Convert.ToInt32(Console.ReadLine());

                switch (notalum[i])
                {
                    case >= 0 and <= 100:
                    System.Console.WriteLine(" ");
                    suma += notalum[i];
                    break;
                    default:
                    Console.WriteLine("Valor no aceptado, coloque un valor númerico entre 0 y 100");
                    notalum[i] = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            }
        }

        public void menu()
        {
            bool Salir = false;
            do
            {
            System.Console.WriteLine("Menú de opciones");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("Seleccione la opción deseada \n a) Mostrar datos de los alumnos que aprobaron\n b) Mostrar datos y nombres de los que no aprobaron \n c) Nota promedio \n d) Salir");
            char op = Console.ReadLine().ToLower()[0];

            switch (op)
            {
                case 'a':
                foreach (string nom1 in nomalumn)
                foreach (int num1 in notalum)
                {   
                        if (num1 >=60 || num1 <= 100)
                        {
                        int ganar = num1;
                        System.Console.WriteLine($"{nom1} gano con {ganar}");
                        break;
                        }
                }
                break;
                case 'b':
                foreach (string nom1 in nomalumn)
                foreach (int num1 in notalum)
                {   
                        if (num1 >=60 || num1 <= 100)
                        {
                        int perder = num1;
                        System.Console.WriteLine($"{nom1} perdio con {perder}");
                        break;
                        }
                }
                break;
                case 'c':
                int promedio = suma/notalum.Length;
                System.Console.WriteLine($"El promedio de las notas es de {promedio}.");
                break;
                case 'd':
                System.Console.WriteLine("Gracias por utilizar el codigo, feliz día");
                Salir = true;
                break;
                default:
                System.Console.WriteLine("Opción no valida, seleccione una valida");
                break;
            }
            } while (!Salir);

        }
    }
}