using System;

class Program
{
    static void Main()
    {
        int A = GetValor("Digite o primeiro valor:");
        int B = GetValor("Digite o segundo valor:");
        int C = GetValor("Digite o terceiro valor:");
        int D = GetValor("Digite o quarto valor:");

        Console.WriteLine($"DIFERENCA = {GetDiferenca(A, B, C, D)}");
    }
    static int GetValor(string mensagem = "Digite um valor:"){
        int valor;
        while(true)
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();

            if(!int.TryParse(entrada, out valor))
            {
                Console.WriteLine("Valor Inválido!");
            }else
            {
                break;
            }
        }
        return valor;
    }
    static int GetDiferenca(int v1, int v2, int v3, int v4)
    {
        int resultado = (v1 * v2) - (v3 * v4);
        return resultado;
    }
}
