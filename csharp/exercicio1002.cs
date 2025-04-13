using System;

class Program
{
    static void Main()
    {
        double pi = 3.14159;
        float raio;
        
        while(true)
        {
            Console.WriteLine("Digite o raio do circulo: ");
            string entrada = Console.ReadLine();
        
            if(!float.TryParse(entrada, out raio))
            {
                Console.WriteLine("Valor Inválido!");
            }else
            {
                break;
            }
        }
        double area = pi * (raio * raio);
        
        Console.WriteLine($"A={area.ToString("F4")}");
    }
}
