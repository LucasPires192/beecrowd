using System;

class Program
{
    static void Main()
    {
        double pesoA = 3.5;
        double pesoB = 7.5;
        float notaA = GetNota("Digite a primeira nota: ");
        float notaB = GetNota("Digite a segunda nota: ");

        double media = (notaA * pesoA + notaB * pesoB) / (pesoA + pesoB);

        Console.WriteLine($"MEDIA = {media.ToString("F5")}");
    }
    static float GetNota(string mensagem)
    {
        float nota;

        while(true)
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();

            if(!float.TryParse(entrada, out nota))
            {
                Console.WriteLine("Valor Inválido!");
            }else
            {
                break;
            }
        }
        return nota;
    }
}
