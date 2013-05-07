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

            int screenWidth = this.Width;
            int screenHeight = this.Height;
            int x = 13;
            int y = 0;
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
                tbx.Size = new Size((int)(campo.Tamanho/13) * 100, 20);
                Controles.Add(tbx);

                x += ((int)(campo.Tamanho / 13) * 100) + 5;
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
