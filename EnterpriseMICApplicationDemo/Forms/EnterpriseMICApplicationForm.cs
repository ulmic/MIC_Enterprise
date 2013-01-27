using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Stylized Form with gradient background
	/// </summary>
	public partial class EnterpriseMICApplicationMiniForm : Form {
		public EnterpriseMICApplicationMiniForm() {
			InitializeComponent();
			this.Paint += new PaintEventHandler(EnterpriseMICApplicationMiniForm_Paint);
		}

		#region Color Attributes

		private void EnterpriseMICApplicationMiniForm_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;
			DrawRectangle(g, 0, 0, this.Width, this.Height);
		}

		private void DrawRectangle(Graphics g, int x, int y, int widht, int height) {
			Rectangle rec = new Rectangle(x, y, widht, height);
			if ((widht != 0) && (height != 0)) {
				System.Drawing.Drawing2D.LinearGradientBrush gradient = new System.Drawing.Drawing2D.LinearGradientBrush(rec, Color.FromArgb(251, 188, 59), Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
				g.FillRectangle(gradient, rec);
				return;
			}
			Brush brush = new SolidBrush(Color.FromArgb(251, 188, 59));
			g.FillRectangle(brush, rec);
		}

		#endregion		
	}
}