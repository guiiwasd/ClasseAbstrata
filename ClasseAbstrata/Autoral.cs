public abstract class Universidade
{
    public string Nome { get; set; }
    public int Fundacao { get; set; }
    public string Localizacao { get; set; }

    public Universidade(string nome, int fundacao, string localizacao)
    {
        Nome = nome;
        Fundacao = fundacao;
        Localizacao = localizacao;
    }

    public abstract void RealizarMatricula(string nomeAluno);
}

public class NovaUniversidade : Universidade
{
    public NovaUniversidade(string nome, int fundacao, string localizacao) : base(nome, fundacao, localizacao)
    {
    }
    public override void RealizarMatricula(string nomeAluno)
    {
        Console.WriteLine($"Matrícula realizada com sucesso: {nomeAluno} na universidade {Nome}.");

    }
}

class Program
{
    static void Main()
    {
        NovaUniversidade Universidade1 = new NovaUniversidade("UGB", 1967, "Aterrado");
        Universidade1.RealizarMatricula("Bárbara");

        NovaUniversidade Universidade2 = new NovaUniversidade("ICT", 1972, "Járdim Amália");
        Universidade2.RealizarMatricula("Maria");


    }
}

