namespace exercicio03;
class Program
{
    static void Main(string[] args)
    {
        

        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Agatha";
        cf.Email = "agathalouzada@gmail.com";
        cf.Telefone = "99324-2006";
        cf.Idade = 16;
        cf.Cpf = 03132343537;
        cj.Nome = "Ester";
        cj.Email = "ester@gmail.com";
        cj.Telefone = "94114-9876";
        cj.Cnpj = 01413121125;
        cj.Inscricao = 404142434445;
        cj.Prazo = 15;
        cf.Prazo = 15;

        Console.WriteLine(cf.MostraDados());
         Console.WriteLine(cf.CalcularPrestacao());
        Console.WriteLine(cj.MostraDados());
         Console.WriteLine(cj.CalcularPrestacao());
       
        
    }
} 

