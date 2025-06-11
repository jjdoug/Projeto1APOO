using System;

namespace Projeto1APOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Etapa 1: Usando o Builder para criar objetos Tema complexos ###");
            
            Tema temaEscuro = new Tema.TemaBuilder()
                .ComCorDeFundo("#2d2d2d")
                .ComCorDaFonte("#e0e0e0")
                .ComFonte("Consolas", 14)
                .Build();

            Tema temaClaro = new Tema.TemaBuilder()
                .ComCorDeFundo("#fafafa")
                .ComCorDaFonte("#333333")
                .ComFonte("Arial", 12)
                .Build();

            Console.WriteLine("Temas criados com sucesso.\n");

            Console.WriteLine("### Etapa 2: Configurando o Gerenciador (Singleton) e usando a Fábrica (Factory Method) ###");
            
            GerenciadorDeTemas gerenciador = GerenciadorWindows.GetInstance();

            // ---- Teste com Tema Escuro ----
            Console.WriteLine("\n--- Usando o Tema Escuro ---");
            gerenciador.SetTemaAtivo(temaEscuro);

            Botao botaoEscuro = gerenciador.CriarBotao();
            Console.Write("--> Resultado: ");
            botaoEscuro.Renderizar();

            // ---- Teste com Tema Claro ----
            Console.WriteLine("\n--- Usando o Tema Claro ---");
            gerenciador.SetTemaAtivo(temaClaro);

            Botao botaoClaro = gerenciador.CriarBotao();
            Console.Write("--> Resultado: ");
            botaoClaro.Renderizar();
        }
    }
}
