namespace exercicio02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Agatha";
        cf.Email = " agathalouzada@gmail.com";
        cf.Telefone = "99570-6085";
        cf.Idade = 16;
        cf.Cpf = 11121314150;
        cj.Nome = "Amanda";
        cj.Email = "amandaloud@gmail.com";
        cj.Telefone = "97374-7445";
        cj.Cnpj = 21222324250;
        cj.Inscricao =0400065438;

        Console.WriteLine(cf.MostraDados());
        Console.WriteLine(cj.MostraDados());
    }
} 

