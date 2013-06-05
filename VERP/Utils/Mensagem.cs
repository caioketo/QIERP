using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERP.Utils
{
    public class Mensagem
    {
        public static DialogResult MostrarMsg(int codigo, string param1 = "", string param2 = "")
        {
            MessageBoxButtons botoes = MessageBoxButtons.OK;
            MessageBoxIcon icone = MessageBoxIcon.Asterisk;
            if (codigo >= 0 && codigo < 10000)
            {
                icone = MessageBoxIcon.Stop;
                botoes = MessageBoxButtons.OK;
            }
            else if (codigo >= 10000 && codigo < 20000)
            {
                icone = MessageBoxIcon.Information;
                botoes = MessageBoxButtons.OK;
            }
            else if (codigo >= 20000 && codigo < 30000)
            {
                icone = MessageBoxIcon.Warning;
                botoes = MessageBoxButtons.OK;
            }
            else if (codigo >= 30000 && codigo < 40000)
            {
                icone = MessageBoxIcon.Question;
                botoes = MessageBoxButtons.YesNo;
            }
            else if (codigo >= 40000 && codigo < 50000)
            {
                icone = MessageBoxIcon.Error;
                botoes = MessageBoxButtons.OK;
            }

            return MessageBox.Show(BuscarMensagem(codigo, param1, param2), "VERP", botoes, icone);
        }

        protected static string BuscarMensagem(int codigo, string param1 = "", string param2 = "")
        {
            string mensagem = codigo.ToString() + ": ";

            switch (codigo)
            {
                case 10000:
                    mensagem += "Sucesso!";
                    break;
                case 10001:
                    mensagem += "Venda Concluída!";
                    break;
                case 30000:
                    mensagem += "Tem certeza que deseja fechar a janela?";
                    break;
                case 30001:
                    mensagem += "Deseja cancelar a venda?";
                    break;
                case 30002:
                    mensagem += "Tem certeza que deseja excluir o registro?";
                    break;
                case 40000:
                    mensagem += "Campo %1 é obrigatório!";
                    break;
                case 40001:
                    mensagem += "Campo %1 tem que ser único!";
                    break;
                case 40002:
                    mensagem += "%1";
                    break;
                case 40003:
                    mensagem += "O valor deve ser superior à 0!";
                    break;
                case 40004:
                    mensagem += "Quantidade inválida!";
                    break;
                case 40005:
                    mensagem += "Produto já adicionado!";
                    break;
            }


            mensagem = mensagem.Replace("%1", param1);
            mensagem = mensagem.Replace("%2", param2);
            return mensagem;
        }
    }
}
