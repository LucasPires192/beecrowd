using System;

class Program
{
    static void Main()
    {
        int a = GetNumero("Digite o primeiro número: ");
        int b = GetNumero("Digite o segundo número: ");

        Console.WriteLine($"SOMA = {somar(a , b)}");
    }
    static int somar(int n1, int n2)
    {
        return n1 + n2;
    }
    static int GetNumero(string mensagem)
    {
        int numero;
        while(true)
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();

            if(!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Valor Inválido!");
            }else
            {
                break;
            }
        }
        return numero;
    }
}
