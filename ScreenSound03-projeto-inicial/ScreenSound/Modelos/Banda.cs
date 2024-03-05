namespace ScreenSound.Modelos;
/*
 Cada “segmento” do namespace utiliza PascalCase;

Os segmentos são conectados pelo caractere . (ponto);

Uma regra geral para a nomeação de namespaces com diferentes segmentos 
é começar com o nome da empresa, em seguida o produto ou tecnologia, 
depois o módulo ou função e eventualmente um quarto segmento para o 
submódulo. Exemplo: Microsoft.AspnetCore.Mvc.
 */
internal class Banda: IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }
    public string? Resumo { get; set; }
    public string Nome { get; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}