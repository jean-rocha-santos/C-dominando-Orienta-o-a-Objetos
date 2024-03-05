namespace ScreenSound.Modelos;
/*
 Cada “segmento” do namespace utiliza PascalCase;
Os segmentos são conectados pelo caractere . (ponto);
Uma regra geral para a nomeação de namespaces com diferentes segmentos 
é começar com o nome da empresa, em seguida o produto ou tecnologia, 
depois o módulo ou função e eventualmente um quarto segmento para o 
submódulo. Exemplo: Microsoft.AspnetCore.Mvc.
 */

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }
}