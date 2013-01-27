using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// LinkLabel with opcaity background & control for indention
	/// </summary>
	public class OpacityLinkLabel : LinkLabel {
		
		public OpacityLinkLabel() {
			this.BackColor = System.Drawing.Color.FromArgb(0);
		}

		#region Indention Control

		public enum ControlIndent { None, Small, Middle, Big, MemberOfList, FirstOfList, LastOfList };

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
					return;
				}
				if (indent == ControlIndent.MemberOfList) {
					this.Margin = new Padding(Const.CONTROL_INDENT_SMALL, 0, 0, 0);
					return;
				}
				if (indent == ControlIndent.FirstOfList) {
					this.Margin = new Padding(Const.CONTROL_INDENT_SMALL, Const.CONTROL_INDENT_SMALL, 0, 0);
					return;
				}
				if (indent == ControlIndent.LastOfList) {
					this.Margin = new Padding(Const.CONTROL_INDENT_SMALL, 0, 0, Const.CONTROL_INDENT_SMALL);
					return;
				}
			}
		}

		#endregion
	}
}