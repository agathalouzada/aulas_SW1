namespace Ex_Aeroporto;
class Program
{
    static void Main(string[] args)
    {
        Aeroporto a1 = new Aeroporto();
        a1.AlteraCodigo(1);
        a1.AlteraEmpresa("Paper Airplanes");
        //a1.AlteraEntrada("New York");
        //a1.AlteraSaida("Rússia");
        a1.MostraDados();
        
    }
}
