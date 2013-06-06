using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase.Classes;
using VERP.Classes;
using VERP.Utils;
using VERPDatabase;
using System.Collections.Generic;
using System.Linq;
using VERPDatabase.Repositorios;

namespace VERP
{
    public partial class FEdicao : BaseForm, IEdicao
    {
        protected List<Control> Controles;
        private List<Label> Labels;

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
            foreach (Control ctr in Controles)
            {
                if (ctr.Name.ToUpper().Equals(nome.ToUpper()))
                {
                    return ctr;
                }
            }
            return null;
        }

        protected void Mapear()
        {
            Utils.Edicao.Mapear(Objeto, this);
        }

        protected void MapearTela()
        {
            Utils.Edicao.MapearTela(Objeto, this);
        }


        private void FEdicao_Load(object sender, EventArgs e)
        {
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
            if (UControles.Count == 3)
            {
                Control ctr = UControles[UControles.Count - 1].control;
                screenWidth = ctr.Left + ctr.Width + 60;
            }

            if (UControles.Count == CRUD.Campos.Count)
            {
                Control ctr = UControles[UControles.Count - 1].control;
                screenHeight = ctr.Top + ctr.Height + 150;
                if (UControles.Count < 3)
                {
                    screenWidth = ctr.Left + ctr.Width + 100;
                }
            }
            
            foreach (Controle controle in UControles)
            {
                try
                {
                    Controls.Remove(controle.label);
                    Controls.Remove(controle.control);
                }
                catch
                {
                }
            }

            foreach (Controle controle in UControles)
            {
                Controles.Add(controle.control);
                Labels.Add(controle.label);
                Controls.Add(controle.label);
                Controls.Add(controle.control);
            }

            this.ResizeRedraw = true;
            if (Controls.Count - 1 == Labels.Count + Controles.Count)
            {
                this.Size = new Size(screenWidth, screenHeight);
            }

            this.Text = "Inserção/Edição de " + CRUD.tabela.Descricao;
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
            foreach (Control ctr in Controles)
            {
                if (ctr is TextBox)
                {
                    tbx_Leave(ctr, null);
                }
            }

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
            if (Controles == null)
            {
                return;
            }
            foreach (Control ctr in Controles)
            {
                if (ctr is cmpEdicao)
                {
                    ((cmpEdicao)ctr).estado = estado;
                }
            }

            if (Controles != null && Controles.Count > 0)
            {
                Controles[0].Focus();
            }
        }

        public ExtRepository GetRepo()
        {
            return this.Repo;
        }
    }
}
