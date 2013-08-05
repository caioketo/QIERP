using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QIERPDatabase;
using QIERPDatabase.Classes;

namespace QIERP.Utils
{
    public class Edicao
    {
        public static void MapearTela(object Objeto, IEdicao edicao)
        {
            foreach (var prop in Objeto.GetType().GetProperties())
            {
                Control ctr = edicao.GetControl(("tbx" + prop.Name).ToUpper()); ;
                if (prop.PropertyType.ToString().ToUpper().Contains("SYSTEM"))
                {
                    if (ctr != null)
                    {
                        if (ctr is GroupBox)
                        {
                            int check = (int)prop.GetValue(Objeto, null);
                            ((RadioButton)ctr.Controls[check]).Checked = true;
                        }
                        else if (ctr is DateTimePicker)
                        {
                            ((DateTimePicker)ctr).Value = (DateTime)prop.GetValue(Objeto, null);
                        }
                        else if (ctr is CheckBox)
                        {
                            ((CheckBox)ctr).Checked = (bool)prop.GetValue(Objeto, null);
                        }
                        else
                        {
                            ctr.Text = prop.GetValue(Objeto, null).ToString();
                            edicao.tbx_Leave(ctr, null);
                        }
                    }
                }
                else
                {
                    if (ctr is Pesquisa)
                    {
                        ((Pesquisa)ctr).Objeto = prop.GetValue(Objeto, null) as ClasseBase;
                        ((Pesquisa)ctr).Selecionar();
                    }
                    else if (ctr is cmpEdicao)
                    {
                        ((cmpEdicao)ctr).Objeto = prop.GetValue(Objeto, null) as ClasseBase;
                        ((cmpEdicao)ctr).MapearTela();
                    }
                }
            }
        }

        public static bool Validar(object Objeto, IEdicao edicao)
        {
            foreach (var prop in Objeto.GetType().GetProperties())
            {
                Campo campo = edicao.GetCampo(prop.Name);
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
                                edicao.GetControl("tbx" + prop.Name).Focus();
                                return false;
                            }
                        }
                        else if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.DOUBLE"))
                        {
                            if (((double)prop.GetValue(Objeto, null)) <= 0)
                            {
                                Mensagem.MostrarMsg(40000, Util.GetNomeReal(prop.Name));
                                edicao.GetControl("tbx" + prop.Name).Focus();
                                return false;
                            }
                        }
                        else if (tipo.ToString().ToString().ToUpper().Equals("SYSTEM.INTEGER"))
                        {
                            if (((int)prop.GetValue(Objeto, null)) <= 0)
                            {
                                Mensagem.MostrarMsg(40000, Util.GetNomeReal(prop.Name));
                                edicao.GetControl("tbx" + prop.Name).Focus();
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }


        public static void Mapear(object Objeto, IEdicao edicao)
        {
            foreach (var prop in Objeto.GetType().GetProperties())
            {
                Control ctr = null;
                ctr = edicao.GetControl(("tbx" + prop.Name).ToUpper());
                if (ctr != null)
                {
                    Type tipo = prop.PropertyType;
                    if (tipo.ToString().ToUpper().Equals("SYSTEM.STRING"))
                    {
                        prop.SetValue(Objeto, ctr.Text);
                    }
                    else if (tipo.ToString().ToUpper().Equals("SYSTEM.DOUBLE"))
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
                    else if (tipo.ToString().ToUpper().Equals("SYSTEM.DECIMAL"))
                    {
                        if (ctr.Text.Contains("R$"))
                        {
                            prop.SetValue(Objeto, Convert.ToDecimal(ctr.Text.Substring(2)));
                        }
                        else
                        {
                            prop.SetValue(Objeto, Convert.ToDecimal(ctr.Text));
                        }
                    }
                    else if (tipo.ToString().ToUpper().Equals("SYSTEM.BOOLEAN"))
                    {
                        prop.SetValue(Objeto, ((CheckBox)ctr).Checked);
                    }
                    else if (tipo.ToString().ToUpper().Equals("SYSTEM.INTEGER") || tipo.ToString().ToUpper().Equals("SYSTEM.INT32"))
                    {
                        if (ctr is GroupBox)
                        {
                            for (int i = 0; i < ctr.Controls.Count; i++)
                            {
                                RadioButton radio = (RadioButton)ctr.Controls[i];
                                if (radio.Checked)
                                {
                                    prop.SetValue(Objeto, i);
                                }
                            }
                        }
                        else
                        {
                            prop.SetValue(Objeto, Convert.ToInt32(ctr.Text));
                        }
                    }
                    else if (tipo.ToString().ToUpper().Equals("SYSTEM.DATETIME"))
                    {
                        prop.SetValue(Objeto, ((DateTimePicker)ctr).Value);
                    }
                    else
                    {
                        if (ctr is Pesquisa)
                        {
                            prop.SetValue(Objeto, ((Pesquisa)ctr).Objeto);
                        }
                        else if (ctr is cmpEdicao)
                        {
                            ((cmpEdicao)ctr).Gravar();
                            prop.SetValue(Objeto, ((cmpEdicao)ctr).Objeto);
                        }
                    }
                }
            }
        }

        public static List<Controle> getControles(List<Campo> Campos, int screenWidth, IEdicao edicao)
        {
            List<Controle> Controles = new List<Controle>();

            int x = 13;
            int y = 0;
            int i = 0;

            foreach (Campo campo in Campos)
            {
                if (!campo.Edita)
                {
                    continue;
                }

                if ((edicao is cmpEdicao && (i % 3 == 0) && i > 0) || ((x + (int)(campo.Tamanho / 13) * 100) > screenWidth))
                {
                    x = 13;
                    y = Controles[Controles.Count - 1].control.Top + Controles[Controles.Count - 1].control.Height + 12;
                }
                Label lbl = new Label();
                lbl.Text = campo.Titulo;
                lbl.Name = "lbl" + campo.Nome;
                lbl.Location = new Point(x + 13, y + 13);
                lbl.AutoSize = true;
                lbl.Size = new Size(38, 13);
                Control ctr = null;

                if (campo.Tipo == TiposDeCampo.Model)
                {
                    lbl.Text = "";
                    Pesquisa pes = new Pesquisa();
                    pes.CRUD = Util.GetCRUD(campo.TabelaRel);
                    pes.Campo = campo.CampoRel;
                    pes.CampoDisplay = campo.DisplayRel;
                    pes.Titulo = campo.Titulo;
                    pes.Repo = Util.GetRepo(campo.TabelaRel);
                    pes.Name = "tbx" + campo.Nome;
                    pes.Location = new Point(x + 13, y + 10);
                    pes.TabIndex = i;
                    pes.Size = new Size((int)(campo.Tamanho / 13) * 100, 20);
                    ctr = pes;
                }
                else if (campo.Tipo == TiposDeCampo.ModelUnico)
                {
                    lbl.Text = "";
                    cmpEdicao edc = new cmpEdicao();
                    edc.Repo = Util.GetRepo(campo.TabelaRel);
                    edc.tabela = DB.GetInstance().GetTabela(campo.TabelaRel);
                    edc.Location = new Point(x + 13, y + 10);
                    edc.TabIndex = i;
                    edc.Size = new Size((int)(campo.Tamanho / 13) * 100, 20);
                    edc.cmpEdicao_Load(edicao, null);
                    ctr = edc;
                }
                else if (campo.Tipo == TiposDeCampo.IntegerRadio)
                {
                    GroupBox grupo = new GroupBox();
                    grupo.Name = "tbx" + campo.Nome;
                    grupo.Location = new Point(x + 13, y + 22);
                    grupo.TabIndex = i;
                    grupo.Size = new Size((int)((campo.Tamanho * 85) + 26), 40);
                    for (int r = 0; r < campo.Tamanho; r++)
                    {
                        RadioButton radio = new RadioButton();
                        if (r == 0)
                        {
                            radio.Checked = true;
                        }
                        radio.Name = r.ToString();
                        radio.Text = campo.Opcoes[r];
                        radio.Location = new Point((r * 85) + 13, y + 13);
                        radio.TabIndex = i + r;
                        radio.Size = new Size(85, 20);
                        grupo.Controls.Add(radio);
                    }
                    ctr = grupo;
                }
                else if (campo.Tipo == TiposDeCampo.DateTime)
                {
                    DateTimePicker dtp = new DateTimePicker();
                    dtp.Name = "tbx" + campo.Nome;
                    dtp.Location = new Point(x + 13, y + 28);
                    dtp.TabIndex = i;
                    dtp.Size = new Size(230, 20);
                    if (dtp.Width == 13)
                    {
                        dtp.Width = 70;
                    }

                    ctr = dtp;
                }
                else if (campo.Tipo == TiposDeCampo.Boolean)
                {
                    CheckBox cbx = new CheckBox();
                    cbx.Name = "tbx" + campo.Nome;
                    cbx.Location = new Point(x + 13, y + 28);
                    cbx.TabIndex = i;
                    cbx.Text = lbl.Text;
                    lbl.Text = "";

                    ctr = cbx;
                }
                else
                {
                    TextBox tbx = new TextBox();
                    tbx.Name = "tbx" + campo.Nome;
                    tbx.Location = new Point(x + 13, y + 28);
                    tbx.CharacterCasing = CharacterCasing.Upper;
                    tbx.TabIndex = i;
                    tbx.Size = new Size(((int)(campo.Tamanho / 13) * 100) + 13, 20);
                    if (tbx.Width == 13)
                    {
                        tbx.Width = 70;
                    }
                    if (campo.Tipo == TiposDeCampo.Integer || campo.Tipo == TiposDeCampo.Numeric)
                    {
                        tbx.Validating += edicao.tbx_Leave;
                    }

                    ctr = tbx;
                }


                Controles.Add(new Controle(lbl, ctr));

                //x += ((int)(campo.Tamanho / 13) * 100) + 18;
                x = Controles[Controles.Count - 1].control.Left + Controles[Controles.Count - 1].control.Width + 20;
                i++;
            }

            return Controles;
        }

    }
}
