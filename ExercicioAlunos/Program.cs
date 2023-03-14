namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("*****************************");

        Console.WriteLine("Digite um número real");
        double numero = double.Parse(Console.ReadLine());
        Console.WriteLine("O número digitado é: " + numero);
    }
}
