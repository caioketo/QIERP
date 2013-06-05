using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase.Repositorios;
using VERPDatabase.Classes;

namespace VERP.Utils
{
    public partial class Pesquisa : UserControl
    {
        public FCRUD CRUD { get; set; }
        public string Campo { get; set; }
        public string CampoDisplay { get; set; }
        public string Titulo { get; set; }
        public ExtRepository Repo { get; set; }
        public ClasseBase Objeto { get; set; }

        public Pesquisa()
        {
            InitializeComponent();
        }

        public void Selecionar()
        {
            if (Objeto != null)
            {
                foreach (var prop in Objeto.GetType().GetProperties())
                {
                    if (prop.Name.ToUpper().Equals(CampoDisplay.ToUpper()))
                    {
                        tbxPesquisa.Text = (string)prop.GetValue(Objeto, null);
                        tbxPesquisa.BackColor = Color.LightGray;
                    }
                }
            }
        }

        public void Procurar()
        {
            Objeto = Repo.GetByText(tbxPesquisa.Text);
            if (Objeto != null)
            {
                foreach (var prop in Objeto.GetType().GetProperties())
                {
                    if (prop.Name.ToUpper().Equals(CampoDisplay.ToUpper()))
                    {
                        tbxPesquisa.Text = (string)prop.GetValue(Objeto, null);
                        tbxPesquisa.BackColor = Color.LightGray;
                    }
                }
                return;
            }
            else
            {
                CRUD.TextoInicial = tbxPesquisa.Text;
                object resultado = CRUD.Selecionar();
                if (resultado != null)
                {
                    Objeto = (ClasseBase)resultado;
                    foreach (var prop in Objeto.GetType().GetProperties())
                    {
                        if (prop.Name.ToUpper().Equals(CampoDisplay.ToUpper()))
                        {
                            tbxPesquisa.Text = (string)prop.GetValue(Objeto, null);
                            tbxPesquisa.BackColor = Color.LightGray;
                        }
                    }
                    SendKeys.Send("{TAB}");
                    return;
                }
            }
        }

        private void tbxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Procurar();
            }
            else
            {
                if (e.KeyCode == Keys.Back)
                {
                    tbxPesquisa.Clear();
                    tbxPesquisa.BackColor = Color.White;
                    Objeto = null;
                }
            }
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            onLoad();
        }

        public void onLoad()
        {
            if (Titulo.Equals(""))
            {
                Titulo = Campo;
            }
            lblCampo.Text = Titulo + ":";
            Objeto = null;
        }

        private void tbxPesquisa_Leave(object sender, EventArgs e)
        {
            if (Objeto == null)
            {
                Procurar();
            }
        }
    }
}
