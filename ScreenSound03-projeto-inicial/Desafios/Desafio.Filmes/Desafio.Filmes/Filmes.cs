namespace Alura.Filmes
{
    public class Filme
    {
        public List<Artista> _elenco {  get; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Filme(string titulo, int duracao, List<Artista>? elenco)
        {
            if (elenco == null)
            {
                _elenco = new List<Artista>();
            }
            else
            {
                _elenco = elenco;
            }

            Titulo = titulo;
            Duracao = duracao;
        }

        public Filme(List<Artista> elenco)
        {
            _elenco = elenco;
        }

        public void AdicionarElenco(Artista artista)
        {
            _elenco.Add(artista);
            
            Console.WriteLine($"{artista} adicionado/a ao elenco.");
                artista.AdicionarFilme(this);
        }

      
        public void ListarElenco()
        {
            if (_elenco.Count == 0)
            {
                Console.WriteLine("Elenco vazio.");
            }
            else
            {
                Console.WriteLine("Elenco... ");
                foreach (var ator in _elenco)
                {
                    Console.WriteLine(ator.Nome);
                }
            }
        }
    }
}