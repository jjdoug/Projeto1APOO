using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1APOO
{
    internal class Tema
    {
        private string CorDeFundo { get; }
        private string CorDaFonte { get; }
        private string NomeDaFonte { get; }
        private int TamanhoDaFonte { get; }

        private Tema (TemaBuilder builder)
        {
            CorDeFundo = builder.CorDeFundo;
            CorDaFonte = builder.CorDaFonte;
            NomeDaFonte = builder.NomeDaFonte;
            TamanhoDaFonte = builder.TamanhoDaFonte;
        }

        public override string ToString()
        {
            return $"Tema [Fundo: {CorDeFundo}, Fonte: {CorDaFonte}, Nome da Fonte: {NomeDaFonte}, Tamanho: {TamanhoDaFonte}]";
        }

        public class TemaBuilder
        {
            // Mesmos atributos, porém com setters públicos
            public string CorDeFundo { get; private set; }
            public string CorDaFonte { get; private set; }
            public string NomeDaFonte { get; private set; }
            public int TamanhoDaFonte { get; private set; }

            public TemaBuilder ComCorDeFundo(string cor)
            {
                CorDeFundo = cor;
                return this;
            }

            public TemaBuilder ComCorDaFonte(string cor)
            {
                CorDaFonte = cor;
                return this;
            }

            public TemaBuilder ComFonte(string nomeFonte, int tamanhoFonte)
            {
                NomeDaFonte = nomeFonte;
                TamanhoDaFonte = tamanhoFonte;
                return this;
            }

            public Tema Build()
            {
                return new Tema(this);
            }
        }
    }
}
