using OpenAI_API;
using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public async override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var client = new OpenAIAPI("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");
        /*Criando client e utilizando código da API */
        var chat = client.Chat.CreateConversation();
        /*Começando uma nova conversa com o CHAT*/
        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");
        /*Escrevendo uma mensagem no CHATGPT*/

        string respota = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = respota;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}
