using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERP.CRUD;
using VERPDatabase;
using VERPDatabase.Classes;

namespace VERP.Utils
{
    public class Util
    {
        public static string GetNomeReal(string nomeCampo)
        {
            if (nomeCampo.Contains("cao"))
            {
                nomeCampo.Replace("cao", "ção");
            }

            if (nomeCampo.ToUpper().Equals("CODIGO"))
            {
                nomeCampo = "Código";
            }

            return nomeCampo;
        }

        public static void AdicionaGridColumns(DataGridView dgv, List<Campo> Campos)
        {
            dgv.Columns.Clear();
            foreach (Campo campo in Campos)
            {
                if (campo.MostraGrid)
                {
                    DataGridViewColumn col = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    col.DataPropertyName = campo.Nome;
                    col.DefaultCellStyle = new DataGridViewCellStyle();
                    if (!campo.Formatacao.Equals(""))
                    {
                        col.DefaultCellStyle.Format = campo.Formatacao;
                    }
                    col.HeaderText = campo.Titulo;
                    col.Name = campo.Titulo;
                    dgv.Columns.Add(col);
                }
            }

            dgv.AutoGenerateColumns = false;
        }

        internal static FCRUD GetCRUD(string p)
        {
            switch (p)
            {
                case "FormasDePagamento":
                    return new FCRUDFormaDePagamento();
            }
            return null;
        }

        internal static VERPDatabase.Repositorios.ExtRepository GetRepo(string p)
        {
            switch (p)
            {
                case "FormasDePagamento":
                    return DB.GetInstance().FPRepo;
                case "Telefones":
                    return DB.GetInstance().TelefoneRepo;
                case "Enderecos":
                    return DB.GetInstance().EndRepo;
                case "Cidades":
                    return DB.GetInstance().CidadeRepo;
                case "UFs":
                    return DB.GetInstance().UFRepo;
            }

            return null;
        }
    }
}
