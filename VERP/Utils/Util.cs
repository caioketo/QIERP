using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VERP.CRUD;
using QIERP.Properties;
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
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F10);
                case Keys.F11:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F11);
                case Keys.F2:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F2);
                case Keys.F3:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F3);
                case Keys.F4:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F4);
                case Keys.F5:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F5);
                case Keys.F6:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F6);
                case Keys.F7:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F7);
                case Keys.F8:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F8);
                case Keys.F9:
                    return DB.GetInstance().FPRepo.GetById(Settings.Default.F9);
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
