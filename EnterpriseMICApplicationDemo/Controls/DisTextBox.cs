using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// This combobox has text that explains to the user that it is necessary to write. 
	/// When you click on the combobox the text disappears.
	/// There is a monitoring system for indentation of control.
	/// This textbox is to inherit from IndentionControlTextBox.
	/// </summary>
	public class DisTextBox : IndentionControlTextBox {
		/// <summary>
		/// Dissapering text
		/// </summary>
		private string disText;
		public string DisText {
			get {
				return disText;
			}
			set {
				disText = value;
				Text = value;
			}
		}

		public DisTextBox() {
			Click += new EventHandler(DisTextBox_Click);
			Leave += new EventHandler(DisTextBox_Leave);
			ForeColor = System.Drawing.Color.Gray;
		}

		private void DisTextBox_Leave(object sender, EventArgs e) {
			if (Text == "") {
				Text = disText;
				ForeColor = System.Drawing.Color.Gray;
			}
		}

		private void DisTextBox_Click(object sender, EventArgs e) {
			if (ForeColor == System.Drawing.Color.Gray) {
				Clear();
				ForeColor = System.Drawing.Color.Black;
			}
		}

		/// <summary>
		/// Check whether the text was changed in textbox
		/// </summary>
		public bool TextWasChanged {
			get {
				return (Text != disText);
			}
		}
	}
}