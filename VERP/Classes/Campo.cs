using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERP.Classes
{
    public class Campo
    {
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Formatacao { get; set; }
        public TiposDeCampo Tipo { get; set; }
        public int Tamanho { get; set; }
        public int Precisao { get; set; }
        public bool MostraGrid { get; set; }
        public object Valor { get; set; }

        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho, int precisao, bool mostraGrid)
        {
            Nome = nome;
            Titulo = titulo;
            Formatacao = formatacao;
            Tipo = tipo;
            Tamanho = tamanho;
            MostraGrid = mostraGrid;
        }

        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho) :
            this(nome, titulo, formatacao, tipo, tamanho, 0, true)
        {
        }

        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho, bool mostraGrid) :
            this(nome, titulo, formatacao, tipo, tamanho, 0, mostraGrid)
        {
        }

        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho, int precisao) :
            this(nome, titulo, formatacao, tipo, tamanho, precisao, true)
        {
        }
    }
}
