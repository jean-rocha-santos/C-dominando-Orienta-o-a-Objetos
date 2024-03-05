using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        /* override e base= comando para pegar de seu ancestral um método no caso "Executar"*/
        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar o álbum: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            /* Any(): Este método verifica se há algum elemento na coleção que satisfaça uma determinada
             condição. Ele retorna true se pelo menos um elemento satisfizer a condição especificada e false caso contrário*/
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                /*First(): Este método retorna o primeiro elemento da coleção que satisfaça uma determinada condição.
                    Se nenhum elemento satisfizer a condição, ele gera uma exceção.Se a condição não for especificada,
                    ele simplesmente retorna o primeiro elemento na coleção.*/

                Console.Write($"Qual a nota que o banda {nomeDaBanda} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
                /* Any() é usado para verificar se há algum álbum na lista de álbuns da banda com o título 
                     especificado, enquanto First() é usado para obter o primeiro álbum que corresponda 
                     ao título especificado.*/
            }
            else
            {
                Console.WriteLine($"\nO Album {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
