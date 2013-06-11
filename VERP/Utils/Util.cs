using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERP.CRUD;
using VERP.Properties;
using VERPDatabase;
using VERPDatabase.Classes;

namespace VERP.Utils
{
    public class Util
    {
        public static FormaDePagamento GetFP(Keys key)
        {
            switch (key)
            {
                case Keys.F1:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F1);
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F3:
                    break;
                case Keys.F4:
                    break;
                case Keys.F5:
                    break;
                case Keys.F6:
                    break;
                case Keys.F7:
                    break;
                case Keys.F8:
                    break;
                case Keys.F9:
                    break;
                default:
                    break;
            }
            return null;
        }

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
                case "Cidades":
                    return new FCRUDCidade();
                case "UFs":
                    return new FCRUDUF();
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
