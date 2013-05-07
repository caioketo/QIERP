using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERP.Classes;

namespace VERP
{
    public partial class FEdicao : Form
    {
        private List<Control> Controles;
        private List<Label> Labels;
        public FCRUD CRUD;

        public FEdicao()
        {
            InitializeComponent();
        }

        private void FEdicao_Load(object sender, EventArgs e)
        {
            Controles = new List<Control>();
            Labels = new List<Label>();
            if (CRUD == null)
            {
                return;
            }

            int i = 0;
            foreach (Campo campo in CRUD.Campos)
            {
                Label lbl = new Label();
                lbl.Text = campo.Titulo;
                lbl.Name = "lbl" + campo.Nome;
                lbl.Location = new Point(13, 13 + (i * 40));
                lbl.AutoSize = true;
                lbl.Size = new Size(38, 13);
                Labels.Add(lbl);

                TextBox tbx = new TextBox();
                tbx.Name = "tbx" + campo.Nome;
                tbx.Location = new Point(13, 28 + (i * 40));
                tbx.CharacterCasing = CharacterCasing.Upper;
                tbx.Size = new Size((int)(campo.Tamanho/13) * 100, 20);
                Controles.Add(tbx);

                i += 1;
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
    }
}
