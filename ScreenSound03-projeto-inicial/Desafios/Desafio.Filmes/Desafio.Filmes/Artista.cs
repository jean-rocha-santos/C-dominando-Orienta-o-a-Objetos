namespace Alura.Filmes
{

    public class Artista
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Filme> _filmesAtuados { get; set; }
        public int QuantidadeDeFilmes => _filmesAtuados.Count;


        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            _filmesAtuados = new List<Filme>();
        }


        public void AdicionarFilme(Filme filme)
        {
            _filmesAtuados.Add(filme);
            
        }
        

        public void MostrarFilmesAtuados()
        {

            if (this._filmesAtuados.Count == 0)
            {
                Console.WriteLine($"Nenhum filme encontrado na base para {Nome}");
                return;
            }

            Console.WriteLine($"Filmes de {Nome}...");
            foreach (var filme in _filmesAtuados)
            {
                Console.WriteLine($"Filme: {filme.Titulo}");
            }
        }
    }
}