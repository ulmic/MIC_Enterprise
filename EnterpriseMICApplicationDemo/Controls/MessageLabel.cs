using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
  public class MessageLabel : Label {

    public enum FormSize { Small, Normal, Big };

    public FormSize formSize = FormSize.Small;

    private const int smallFormSizeText = 45;
    private const int normalFormSizeText = 100;
    private const int bigFormSizeText = 500;

    private const float FontSize1 = 8F;
    private const float FontSize2 = 10F;
    private const float FontSize3 = 12F;

    public MessageLabel() {
      this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    }

    private void puttingMessage(string message, int typeMessage) {
      int sizeText = smallFormSizeText;
      float smallFont = FontSize1;
      float bigFont = FontSize2;
      if (formSize == FormSize.Normal) {
        sizeText = normalFormSizeText;
        smallFont = FontSize2;
        bigFont = FontSize2;
      }
      if (formSize == FormSize.Big) {
        sizeText = bigFormSizeText;
        smallFont = FontSize2;
        bigFont = FontSize3;
      }
      if (message.Length >= sizeText) {
        this.Font = new System.Drawing.Font(this.Font.FontFamily, smallFont);
      } else {
        this.Font = new System.Drawing.Font(this.Font.FontFamily, bigFont);
      }
      if (typeMessage == Const.BAD_MESSAGE) {
        this.ForeColor = System.Drawing.Color.Red;
      }
      if (typeMessage == Const.GOOD_MESSAGE) {
        this.ForeColor = System.Drawing.Color.Green;
      }
      this.Text = message;
    }

    public void PutMessage(string message) {
      puttingMessage(message, Const.GOOD_MESSAGE);
    }

    public void PutMessage(string message, int typeMessage) {
      puttingMessage(message, typeMessage);
    }
  }
}
