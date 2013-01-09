using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
  public partial class AddToSendListNewItem : EnterpriseMICApplicationMiniForm {
    public AddToSendListNewItem() {
      InitializeComponent();
      NameTextBox.DisText = "Имя";
      EmailTextBox.DisText = "E-mail";
      chooseComboBox.DisText = "Выбрать список";
      chooseComboBox.Items.AddRange(Program.Data.GetAllSendLists());
    }
  }
}