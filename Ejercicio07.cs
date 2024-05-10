using System;

public class UNIDAD_4_ISNP088623_ISNP152823
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ingrese el número: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("¡¡¡ERROR!!! El número debe ser mayor que 0.");
            }
            else
            {
                int potencia = num * num;
                Console.WriteLine("El cuadrado de " + num + " es " + potencia);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("¡¡¡ERROR!!! Por favor ingrese un número válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("¡¡¡ERROR!!! " + ex.Message);
        }
    }
}
