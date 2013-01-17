using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Stylized buttons
	/// </summary>
	public class AppButton : Button {
		public AppButton() {
			this.Dock = DockStyle.Fill;
		}
	}
}