using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Label with opacity background
	/// </summary>
	public class OpacityLabel : Label {
		public OpacityLabel() {
			this.BackColor = System.Drawing.Color.FromArgb(0, 255, 15, 0);
			this.ForeColor = Color.Black;
			this.Image = null;
		}

		#region Indention Control

		public enum ControlIndent { None, Small, Middle, Big };

		private ControlIndent indent = ControlIndent.None;
		public ControlIndent Indent {
			get {
				return indent;
			}
			set {
				indent = value;
				if (indent == ControlIndent.None) {
					this.Margin = new Padding(0);
					return;
				}
				if (indent == ControlIndent.Small) {
					this.Margin = new Padding(Const.CONTROL_INDENT_SMALL);
					return;
				}
				if (indent == ControlIndent.Middle) {
					this.Margin = new Padding(Const.CONTROL_INDENT_MIDDLE);
					return;
				}
				if (indent == ControlIndent.Big) {
					this.Margin = new Padding(Const.CONTROL_INDENT_BIG);
				}
			}
		}

		#endregion
	}
}