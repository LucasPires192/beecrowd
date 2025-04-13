using System;

class Program
{
    static void Main()
    {
        int num1 = GetNumero("Digite o primero número: ");
        int num2 = GetNumero("Digite o segundo número: ");
        int produto = Multiplicar(num1, num2);
        
        Console.WriteLine($"PROD = {produto}");
    }
    static int GetNumero(string mensagem){
        int numero;

        while(true)
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();

            if(!int.TryParse(entrada, out  numero))
            {
                Console.WriteLine("Valor Inválido");
            }else
            {
                break;
            }
        }
        return numero;
    }

    static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
}
