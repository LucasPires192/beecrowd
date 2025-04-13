using System;

class Program
{
    static void Main()
    {
        float notaA = GetNota("Digite a primeira nota: ");
        float notaB = GetNota("Digite a segunda nota: ");
        float notaC = GetNota("Digite a terceira nota: ");
        double media = Media(notaA, notaB, notaC);

        Console.WriteLine($"MEDIA = {media.ToString("F1")}");
    }
    static float GetNota(string mensagem)
    {
        float nota;

        while(true)
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();

            if(float.TryParse(entrada, out nota))
            {
                if(nota < 0 || nota > 10)
                {
                    Console.WriteLine("Valor Inválido! Digite uma nota de 0 a 10!");
                    continue;
                }else{
                    break;
                }
            }else
            {
                Console.WriteLine("Valor Inválido!");
                continue;
            }
        }
        return nota;
    }

    static double Media(float nA, float nB, float nC)
    {
        double pesoA = 2;
        double pesoB = 3;
        double pesoC = 5;

        double media = ((nA * pesoA) + (nB * pesoB) + (nC * pesoC)) / (pesoA + pesoB + pesoC);
        return media; 
    }
}
