using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERP.Classes;
using QIERPDatabase.Repositorios;
using QIERPDatabase.Classes;

namespace QIERP.Utils
{
    public partial class cmpEdicao : UserControl, IEdicao
    {
        protected List<Controle> Controles = new List<Controle>();
        public Estado estado { get; set; }
        public ClasseBase Objeto { get; set; }
        public ExtRepository Repo { get; set; }
        public Tabela tabela { get; set; }


        public cmpEdicao()
        {
            InitializeComponent();
        }

        private Control MaxWidth()
        {
            int w = 0;
            Control retorno = null;
            foreach (Controle ctr in Controles)
            {
                if ((ctr.control.Width + ctr.control.Left) > w)
                {
                    w = ctr.control.Width + ctr.control.Left;
                    retorno = ctr.control;
                }
            }
            return retorno;
        }

        private Control MaxHeight()
        {
            int h = 0;
            Control retorno = null;
            foreach (Controle ctr in Controles)
            {
                if ((ctr.control.Width + ctr.control.Top) > h)
                {
                    h = (ctr.control.Height + ctr.control.Top);
                    retorno = ctr.control;
                }
            }
            return retorno;
        }
        
        public void cmpEdicao_Load(object sender, EventArgs e)
        {
            if (tabela != null)
            {
                gbxGeral.Text = tabela.Descricao;
                if (this.Parent == null)
                {
                    Controles = Utils.Edicao.getControles(tabela.Campos, ((Control)sender).Width, this);
                }
                else
                {
                    Controles = Utils.Edicao.getControles(tabela.Campos, this.Parent.Width, this);
                }

                int screenWidth = this.Width;
                int screenHeight = this.Height;

                if (Controles.Count == tabela.Campos.Count)
                {
                    Control ctr = MaxWidth();
                    screenWidth = ctr.Left + ctr.Width + 15;
                    ctr = MaxHeight();
                    screenHeight = ctr.Top + ctr.Height + 10;
                }

                if (gbxGeral.Controls.Count == 0)
                {
                    foreach (Controle controle in Controles)
                    {
                        gbxGeral.Controls.Add(controle.label);
                        gbxGeral.Controls.Add(controle.control);
                    }

                    this.ResizeRedraw = true;
                    if (gbxGeral.Controls.Count == (Controles.Count * 2))
                    {
                        this.Size = new Size(screenWidth + 20, screenHeight + 20);
                    }
                }
            }
        }

        public Control GetControl(string nome)
        {
            foreach (Controle ctr in Controles)
            {
                if (ctr.control.Name.ToUpper().Equals(nome.ToUpper()))
                {
                    return ctr.control;
                }
            }
            return null;
        }

        public ExtRepository GetRepo()
        {
            return Repo;
        }

        public Campo GetCampo(string nome)
        {
            foreach (Campo campo in tabela.Campos)
            {
                if (campo.Nome.ToUpper().Equals(nome.ToUpper()))
                {
                    return campo;
                }
            }

            return null;
        }

        public void tbx_Leave(object sender, EventArgs e)
        {
            if (GetCampo(((TextBox)sender).Name.Substring(3)).Tipo == TiposDeCampo.Integer ||
                    GetCampo(((TextBox)sender).Name.Substring(3)).Tipo == TiposDeCampo.Numeric)
            {
                double value = 0;
                string texto = ((TextBox)sender).Text;
                if (((TextBox)sender).Text.Contains("R$"))
                {
                    texto = ((TextBox)sender).Text.Substring(2);
                }

                double.TryParse(texto, out value);
                ((TextBox)sender).Text = value.ToString(GetCampo(((TextBox)sender).Name.Substring(3)).Formatacao);
            }
        }

        public void Mapear()
        {
            Utils.Edicao.Mapear(Objeto, this);
        }

        public void MapearTela()
        {
            Utils.Edicao.MapearTela(Objeto, this);
        }

        public bool Validar()
        {
            return Utils.Edicao.Validar(Objeto, this);
        }

        public void Gravar()
        {
            Mapear();
            if (estado == Estado.Inserir)
            {
                Repo.Inserir(Objeto);
            }
            else if (estado == Estado.Modificar)
            {
                Repo.Salvar(Objeto);
            }
        }

    }
}
