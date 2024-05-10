
using System;

public class UNIDAD_4_ISNP088623_ISNP152823
{
     public static void Main(string[] args)
        {
int sum=0; 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Por favor ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            float promedio = sum / 5;
            Console.WriteLine("Su promedio es el siguiente: " + promedio); 
        }
}

