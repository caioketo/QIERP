using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERP.Properties;

namespace QIERP.Utils
{
    public partial class FConfiguracao : Form
    {
        public FConfiguracao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Server=";
            conn += tbxHost.Text;
            conn += "\\" + tbxInstancia.Text;
            conn += ";Database=" + tbxDatabase.Text;
            conn += ";User Id=" + tbxUsuario.Text;
            conn += ";Password=" + tbxSenha.Text + ";";
            if (conn.Equals("Server=\\;Database=;User Id=;Password=;"))
            {
                conn = "Server=127.0.0.1\\SQLSERVER;Database=qierp;User Id=sa;Password=vd001989;";
            }
            Settings.Default.ConnectionStr = conn;
            Settings.Default.Save();
            Close();
        }
    }
}
