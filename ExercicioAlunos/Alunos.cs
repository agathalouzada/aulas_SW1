namespace ExercicioAlunos;

class Alunos
{
    public string nome="";
    
    public double nota1, nota2;

//MEDIA -> RETORNA UM DOUBLE (POR EXEMPLO UM NUMERO COMO 8.3)

public double obterMedia(){
    double media = (nota1+nota2)/2;
    return media;
}

//SITUAÇAO -> RETORNA UMA STRING ("APROVADO" OU "REPROVADO")

public string obterSituacao(double media){
    string situacao="";
    if(media>=6){
        situacao="Aprovado";
    }else{
        situacao="Reprovado";
    }
    return situacao;
}

//MENSAGEM -> NAO RETORNA NADA. SO MOSTRA NA TELA OS DETLAHES (NOME,MEDIA E SITUACAO)

public void mensagem(){
    double mediaCalculadora = obterMedia();
    string resultadosSituacao = obterSituacao(mediaCalculadora);
    Console.WriteLine(nome+" está "+resultadosSituacao+" com média "+mediaCalculadora);
    }
}