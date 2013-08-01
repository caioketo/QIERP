using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIERPDatabase.Classes
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
        public bool Obrigatorio { get; set; }
        public string Tabela { get; set; }
        public bool Edita { get; set; }
        public string[] Opcoes { get; set; }
        public string CampoRel { get; set; }
        public string DisplayRel { get; set; }
        public string TabelaRel { get; set; }
        public bool ButtonInGrid { get; set; }


        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho, int precisao, bool mostraGrid, bool obrigatorio)
        {
            Nome = nome;
            Titulo = titulo;
            Formatacao = formatacao;
            Tipo = tipo;
            Tamanho = tamanho;
            Opcoes = new string[tamanho];
            MostraGrid = mostraGrid;
            Obrigatorio = obrigatorio;
            Edita = true;
        }

        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho) :
            this(nome, titulo, formatacao, tipo, tamanho, 0, true, true)
        {
        }

        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho, bool mostraGrid) :
            this(nome, titulo, formatacao, tipo, tamanho, 0, mostraGrid, true)
        {
        }

        public Campo(string nome, string titulo, string formatacao, TiposDeCampo tipo, int tamanho, int precisao) :
            this(nome, titulo, formatacao, tipo, tamanho, precisao, true, true)
        {
        }
    }
}
