using System;

public class UNIDAD_4_ISNP088623_ISNP152823
{
        public static void Main(string[] args)
        {
int sum = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Ingrese la edad del estudiante: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            float promedio = sum / 15;
            Console.WriteLine("El promedio de edades de los estudiantes ingreados es: " + promedio);
}
}