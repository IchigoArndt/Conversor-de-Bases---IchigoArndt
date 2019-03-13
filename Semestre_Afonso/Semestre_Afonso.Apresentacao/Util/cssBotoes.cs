using Infragistics.Win;
using Infragistics.Win.UltraMessageBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestre_Afonso.Apresentacao.Util
{
    public static class cssBotoes
    {
        //Metodó que retorna um mensage box com o texto configurado no padrão de erro
        public static UltraMessageBoxInfo cssBotaoErro(string mensagem)
        {
            #region Aparencia do Botão
            //Definição do Botão
            UltraMessageBoxInfo messageInfo = new UltraMessageBoxInfo();
            messageInfo.Style = MessageBoxStyle.Standard;
            messageInfo.Buttons = MessageBoxButtons.OK;
            messageInfo.Icon = MessageBoxIcon.Error;
            //Aparecia dos botões
            messageInfo.DefaultButton = MessageBoxDefaultButton.Button2;
            messageInfo.ButtonAppearance.FontData.Bold = DefaultableBoolean.True;
            messageInfo.ButtonAreaAppearance.BackColor = Color.DarkRed;
            //Inclusão da mensagem
            //Titulo da mesagem box
            string captionmsg = "Erro na validação";
            messageInfo.Caption = captionmsg;
            //Corpo da mensagem
            string contentmsg = " <span style='font-weight:bold;'>Mensagem do Erro</span> <br/>" + mensagem;
            messageInfo.TextFormatted = contentmsg;
            #endregion
            return messageInfo;
        }
    }
}
