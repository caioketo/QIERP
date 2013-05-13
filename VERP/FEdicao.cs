using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase.Classes;
using VERP.Classes;
using VERP.Utils;

namespace VERP
{
    public partial class FEdicao : Form
    {
        protected List<Control> Controles;
        private List<Label> Labels;
        public FCRUD CRUD;
        public Estado estado;
        public ClasseBase Objeto;

        public FEdicao()
        {
            InitializeComponent();
        }

        protected virtual bool Validar()
        {
            foreach (var prop in Objeto.GetType().GetProperties())
            {
                Campo campo = GetCampo(prop.Name);
                if (campo != null)
                {
                    if (campo.Obrigatorio)
                    {
                        Type tipo = prop.PropertyType;
                        if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.STRING"))
                        {
                            if (((String)prop.GetValue(Objeto, null)).Equals(""))
                            {
                                Mensagem.MostrarMsg(40000, Util.GetNomeReal(prop.Name));
                                GetControl("tbx" + prop.Name).Focus();
                                return false;
                            }
                        }
                        else if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.DOUBLE"))
                        {
                            if (((double)prop.GetValue(Objeto, null)) <= 0)
                            {
                                Mensagem.MostrarMsg(40000, Util.GetNomeReal(prop.Name));
                                GetControl("tbx" + prop.Name).Focus();
                                return false;
                            }
                        }
                        else if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.INTEGER"))
                        {
                            if (((int)prop.GetValue(Objeto, null)) <= 0)
                            {
                                Mensagem.MostrarMsg(40000, Util.GetNomeReal(prop.Name));
                                GetControl("tbx" + prop.Name).Focus();
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        protected virtual void Fechar()
        {
            this.Close();
        }

        protected virtual void Gravar()
        {
            this.Close();
        }

        private Campo GetCampo(string nome)
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

        private Control GetControl(string nome)
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
            foreach (var prop in Objeto.GetType().GetProperties())
            {
                Control ctr = GetControl(("tbx" + prop.Name).ToUpper());
                if (ctr != null)
                {
                    Type tipo = prop.PropertyType;
                    if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.STRING"))
                    {
                        prop.SetValue(Objeto, ctr.Text);
                    }
                    else if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.DOUBLE"))
                    {
                        if (ctr.Text.Contains("R$"))
                        {
                            prop.SetValue(Objeto, Convert.ToDouble(ctr.Text.Substring(2)));
                        }
                        else
                        {
                            prop.SetValue(Objeto, Convert.ToDouble(ctr.Text));
                        }
                    }
                    else if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.INTEGER"))
                    {
                        prop.SetValue(Objeto, Convert.ToInt32(ctr.Text));
                    }                    
                }
            }
        }

        protected void MapearTela()
        {
            foreach (var prop in Objeto.GetType().GetProperties())
            {
                Control ctr = GetControl(("tbx" + prop.Name).ToUpper());
                if (ctr != null)
                {
                    ctr.Text = prop.GetValue(Objeto, null).ToString();
                    tbx_Leave(ctr, null);
                }
            }
        }


        private void FEdicao_Load(object sender, EventArgs e)
        {
            //Controls.Clear();
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
            if (CRUD == null)
            {
                return;
            }

            int screenWidth = this.Width;
            int screenHeight = this.Height;
            int x = 13;
            int y = 0;
            int i = 0;
            btnSalvar.TabIndex = CRUD.Campos.Count;
            btnFechar.TabIndex = CRUD.Campos.Count + 1;
            foreach (Campo campo in CRUD.Campos)
            {
                if ((x + (int)(campo.Tamanho / 13) * 100) > screenWidth)
                {
                    x = 13;
                    y += 52;
                }
                Label lbl = new Label();
                lbl.Text = campo.Titulo;
                lbl.Name = "lbl" + campo.Nome;
                lbl.Location = new Point(x + 13, y + 13);
                lbl.AutoSize = true;
                lbl.Size = new Size(38, 13);
                Labels.Add(lbl);

                TextBox tbx = new TextBox();
                tbx.Name = "tbx" + campo.Nome;
                tbx.Location = new Point(x + 13, y + 28);
                tbx.CharacterCasing = CharacterCasing.Upper;
                tbx.TabIndex = i;
                tbx.Size = new Size((int)(campo.Tamanho / 13) * 100, 20);
                if (campo.Tipo == TiposDeCampo.Integer || campo.Tipo == TiposDeCampo.Numeric)
                {
                    tbx.Validating += tbx_Leave;
                }

                Controles.Add(tbx);

                x += ((int)(campo.Tamanho / 13) * 100) + 5;
                i++;
            }

            foreach (Label lbl in Labels)
            {
                Controls.Add(lbl);
            }

            foreach (Control ctr in Controles)
            {
                Controls.Add(ctr);
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in Controles)
            {
                tbx_Leave(ctr, null);
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
            if (Controles != null && Controles.Count > 0)
            {
                Controles[0].Focus();
            }
        }
    }
}
