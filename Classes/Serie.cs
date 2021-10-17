 using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase //Serie herda EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descrição { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        // Métodos

        public Serie (int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id; //id não está em Série, mas está em EntidadeBase
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descricao;
            this.Ano = ano;
            this.Excluido = false; //isso faz com que a informação não desapareça, pois se caso for realmente excluído vai mudar todo o vetor
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine; //Environment.NewLine quebrar linha
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descrição + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}