namespace ScreenSound.Modelos;
/*
 Cada “segmento” do namespace utiliza PascalCase;

Os segmentos são conectados pelo caractere . (ponto);

Uma regra geral para a nomeação de namespaces com diferentes segmentos 
é começar com o nome da empresa, em seguida o produto ou tecnologia, 
depois o módulo ou função e eventualmente um quarto segmento para o 
submódulo. Exemplo: Microsoft.AspnetCore.Mvc.
 */

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}