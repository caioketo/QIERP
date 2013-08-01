using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERPDatabase.Classes;
using QIERP.Classes;
using QIERP.Utils;
using QIERPDatabase;
using System.Collections.Generic;
using System.Linq;
using QIERPDatabase.Repositorios;

namespace QIERP
{
    public partial class FEdicao : BaseForm, IEdicao
    {
        public FCRUD CRUD;
        public Estado estado;
        public ClasseBase Objeto;
        public ExtRepository Repo;

        public FEdicao()
        {
            InitializeComponent();
        }

        protected virtual bool Validar()
        {
            return Utils.Edicao.Validar(Objeto, this);
        }

        protected virtual void Fechar()
        {
            this.Close();
        }

        protected virtual void Gravar()
        {
            this.Close();
        }

        public Campo GetCampo(string nome)
        {
            foreach (Campo campo in CRUD.Campos)
            {
                if (campo.Nome.ToUpper().Equals(nome.ToUpper()))
                {
                    return campo;
                }
            }

            return null;
        }

        public Control GetControl(string nome)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr.Name.ToUpper().Equals(nome.ToUpper()))
                {
                    return ctr;
                }
            }
            return null;
        }

        protected virtual void Mapear()
        { }


        private void FEdicao_Load(object sender, EventArgs e)
        {
            /*this.Size = new Size(334, 346);
            if (CRUD == null)
            {
                return;
            }

            Controles = new List<Control>();
            Labels = new List<Label>();
            int t = 0;
            foreach (Control ctr in Controls)
            {
                ctr.TabIndex = CRUD.Campos.Count + t;
            }

            List<Controle> UControles = Utils.Edicao.getControles(CRUD.Campos, this.Width, this);

            int screenWidth = this.Width;
            int screenHeight = this.Height;

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].Name.Equals("pnlGeral"))
                {
                    Controls.Remove(Controls[i]);
                }                
            }

            Panel pnlGeral = new Panel();
            pnlGeral.Name = "pnlGeral";
            pnlGeral.Dock = DockStyle.Fill;
            pnlGeral.BorderStyle = BorderStyle.None;

            foreach (Controle controle in UControles)
            {
                Controles.Add(controle.control);
                Labels.Add(controle.label);
                pnlGeral.Controls.Add(controle.label);
                pnlGeral.Controls.Add(controle.control);
            }

            if (UControles.Count == CRUD.Campos.Count)
            {
                Control ctr = MaxWidth();
                screenWidth = ctr.Left + ctr.Width + 100;
                ctr = MaxHeight();
                screenHeight = ctr.Top + ctr.Height + 150;
            }

            this.ResizeRedraw = true;
            if (pnlGeral.Controls.Count == Labels.Count + Controles.Count)
            {
                this.Size = new Size(screenWidth, screenHeight);
            }
            Controls.Add(pnlGeral);*/

            if (CRUD != null)
            {
                this.Text = "Inserção/Edição de " + CRUD.tabela.Descricao;
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /*foreach (Control ctr in Controles)
            {
                if (ctr is TextBox)
                {
                    tbx_Leave(ctr, null);
                }
            }*/

            Mapear();
            if (Validar())
            {
                Gravar();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void FEdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Mensagem.MostrarMsg(30000) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void FEdicao_Shown(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is cmpEdicao)
                {
                    ((cmpEdicao)ctr).estado = estado;
                }
            }

            if (Controls != null && Controls.Count > 0)
            {
                Controls[0].Focus();
            }
        }

        public ExtRepository GetRepo()
        {
            return this.Repo;
        }
    }
}
