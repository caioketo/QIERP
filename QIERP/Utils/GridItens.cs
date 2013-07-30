using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase.Classes;

namespace VERP.Utils
{
    public delegate void AddItem(object[] item);
    public delegate void RemoveItem(object item);

    public partial class GridItens : UserControl
    {
        private List<Control> Controles;
        private List<Label> Labels;
        public List<Campo> Campos { get; set; }
        public List<Campo> CamposEdicao { get; set; }
        public ClasseBase ObjetoEdicao;
        public BindingSource bindingSource = new BindingSource();
        public event AddItem addItem;
        public event RemoveItem removeItem;
        public GridItens()
        {
            InitializeComponent();
        }

        private void GridItens_Load(object sender, EventArgs e)
        {
        }

        public void onLoad()
        {
            if (Campos != null)
            {
                Util.AdicionaGridColumns(dgvItens, Campos);
                dgvItens.DataSource = bindingSource;
            }

            if (Controles != null && Controles.Count > 0)
            {
                foreach (Control ctr in Controles)
                {
                    Controls.Remove(ctr);
                }
            }

            if (Labels != null && Labels.Count > 0)
            {
                foreach (Control ctr in Labels)
                {
                    Controls.Remove(ctr);
                }
            }

            Controles = new List<Control>();
            Labels = new List<Label>();


            int screenWidth = this.Width;
            int screenHeight = this.Height;
            int x = 359;
            int y = 0;
            int i = 0;

            foreach (Campo campo in CamposEdicao)
            {
                if (!campo.Edita)
                {
                    continue;
                }
                if ((x + (int)(campo.Tamanho / 13) * 100) > screenWidth)
                {
                    x = 13;
                    y += 52;
                }
                Label lbl = new Label();
                lbl.Text = campo.Titulo;
                lbl.Name = "lbl" + campo.Nome;
                lbl.Location = new Point(x, y + 9);
                lbl.AutoSize = true;
                lbl.Size = new Size(38, 13);
                Labels.Add(lbl);
                Control ctr = null;

                TextBox tbx = new TextBox();
                tbx.Name = "tbx" + campo.Nome;
                tbx.Location = new Point(x, y + 24);
                tbx.CharacterCasing = CharacterCasing.Upper;
                tbx.TabIndex = i;
                tbx.Size = new Size((int)(campo.Tamanho / 13) * 100, 20);
                if (campo.Tipo == TiposDeCampo.Integer || campo.Tipo == TiposDeCampo.Numeric)
                {
                    tbx.Validating += tbx_Leave;
                }

                ctr = tbx;
                Controles.Add(tbx);

                x += ((int)(campo.Tamanho / 13) * 100) + 5;
                i++;

                if (i == 3)
                {
                    screenWidth = ctr.Left + ctr.Width + 60;
                }

                if (i == CamposEdicao.Count)
                {
                    screenHeight = ctr.Top + ctr.Height + 150;
                    if (i < 3)
                    {
                        screenWidth = ctr.Left + ctr.Width + 100;
                    }
                }

            }


            foreach (Label lbl in Labels)
            {
                Controls.Add(lbl);
            }

            foreach (Control ctr in Controles)
            {
                Controls.Add(ctr);
            }

            this.ResizeRedraw = true;
            if (Controls.Count - 1 == Labels.Count + Controles.Count)
            {
                this.Size = new Size(screenWidth, screenHeight);
            }

            pesPesquisa.onLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] adds = new object[Controles.Count + 1];
            adds[0] = pesPesquisa.Objeto;
            for (var i = 0; i < Controles.Count; i++)
            {
                adds[i + 1] = Controles[i].Text;
            }
                        
            addItem.Invoke(adds);   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeItem.Invoke(bindingSource.Current);
        }

        void tbx_Leave(object sender, EventArgs e)
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

        private Campo GetCampo(string nome)
        {
            foreach (Campo campo in CamposEdicao)
            {
                if (campo.Nome.ToUpper().Equals(nome.ToUpper()))
                {
                    return campo;
                }
            }

            return null;
        }
    }
}
