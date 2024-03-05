using Alura.Filmes;


List<Artista> elenco1 = new List<Artista>()
{
    new Artista("Jean Rocha",23),
    new Artista("Kaue Ghefi",20),
    new Artista("Gabriel Oliveira",21),
    new Artista("Silvyo",24)
};
List<Artista> elenco2 = new List<Artista>()
{
    new Artista("Jean Rocha",23),
    new Artista("Kaue Ghefi",20),
    new Artista("Gabriel Oliveira",21),
};
    

Filme filme1 = new Filme("O Senhor dos Anéis", 300, elenco1);
Filme filme2 = new Filme("Interestelar", 290,elenco2 );
Filme filme3 = new Filme("Toy Story", 200,elenco1 );
Filme filme4 = new Filme("Matrix", 237 , elenco2);
Filme filme5 = new Filme("Piratas dos Caribes", 220, elenco2);

List<Filme> meusFilmesFavoritos = new List<Filme>();
meusFilmesFavoritos.Add(filme1);
meusFilmesFavoritos.Add(filme2);
meusFilmesFavoritos.Add(filme3);
meusFilmesFavoritos.Add(filme4);
meusFilmesFavoritos.Add(filme5);


foreach (Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"\nFilme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
   
}




