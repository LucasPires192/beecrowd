using System;

class Program
{
    static void Main()
    {
        int a = GetNumero("Digite o primerio número: ");
        int b = GetNumero("Digite o segundo número: ");
        int x = a + b;
        
        Console.WriteLine($"X = {x}");
    }
    static int GetNumero(string mensagem)
    {
        int numero;
        while(true)
        {
            Console.WriteLine(mensagem);
            string n =  Console.ReadLine();
            if(!int.TryParse(n, out numero))
            {
                Console.WriteLine("Valor inváldo");
            }else
            {
                break;    
            }
        }
        return numero;
    }
}
