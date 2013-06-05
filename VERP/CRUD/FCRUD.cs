using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERPDatabase;
using VERPDatabase.Classes;
using VERP.Classes;
using VERP.Utils;

namespace VERP
{
    public partial class FCRUD : BaseForm
    {
        protected FEdicao Edicao;
        public string TextoInicial { get; set; }
        public object Resultado { get; set; }

        public List<Campo> Campos
        {
            get
            {
                if (tabela != null)
                {
                    return tabela.Campos;
                }
                else
                {
                    return new List<Campo>();
                }
            }
        }
        public Tabela tabela;
        public BindingSource bindingSource = new BindingSource();

        public FCRUD()
        {
            TextoInicial = "";
            InitializeComponent();
        }

        protected virtual void GetRecords()
        {
        }


        private void FCRUD_Shown(object sender, EventArgs e)
        {
            Util.AdicionaGridColumns(dgvCRUD, Campos);
            dgvCRUD.DataSource = bindingSource;

            if (Edicao != null)
            {
                Edicao.CRUD = this;
            }

            tbxPesquisa.Text = TextoInicial;


            GetRecords();

            if (tabela != null)
            {
                if (!tabela.Edita)
                {
                    btnEditar.Enabled = false;
                }
                else
                {
                    btnEditar.Enabled = true;
                }

                this.Text = tabela.Descricao;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Edicao.estado = Estado.Inserir;
            Edicao.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edicao.estado = Estado.Modificar;
            try
            {
                Edicao.Objeto = (ClasseBase)bindingSource.Current;
                Edicao.ShowDialog();
            }
            catch
            {
            }
        }

        private void FCRUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Mensagem.MostrarMsg(30000) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void tbxPesquisa_TextChanged(object sender, EventArgs e)
        {
            GetRecords();
        }

        private void FCRUD_Activated(object sender, EventArgs e)
        {
            GetRecords();
        }

        public object Selecionar()
        {
            this.Resultado = null;
            this.btnSelecionar.Visible = true;
            this.btnSelecionar.TabIndex = 12;
            this.tbxPesquisa.Size = new Size(482, 31);
            this.ShowDialog();
            this.btnSelecionar.Visible = false;
            this.tbxPesquisa.Size = new Size(580, 31);
            this.btnInserir.TabIndex = 12;
            return Resultado;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Resultado = bindingSource.Current;
            this.Close();
        }
    }
}
