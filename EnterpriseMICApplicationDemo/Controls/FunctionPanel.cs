using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Stylized TableLaayoutPanel.
	/// Colored gradient.
	/// Helps to work with Controls Collection
	/// </summary>
	public class FunctionPanel : TableLayoutPanel {

        public bool needPaint = true;

		public FunctionPanel() {
			this.BorderStyle = BorderStyle.Fixed3D;
			this.Paint += new PaintEventHandler(FunctionGroupBox_Paint);
			this.Dock = DockStyle.Top;
		}

		#region Inherited Attributes

		public BorderStyle TableBorderStyle {
			get {
				return this.BorderStyle;
			}
			set {
				this.BorderStyle = value;
			}
		}

		#endregion

		#region Color Attributes

		/// <summary>
		/// Rotate the gradient
		/// </summary>
		private bool reverseGradient = false;
		public bool ReverseGradient {
			get {
				return reverseGradient;
			}
			set {
				reverseGradient = value;
				this.Invalidate();
			}
		}

		private void FunctionGroupBox_Paint(object sender, PaintEventArgs e) {
            if ( needPaint ) {
                Graphics g = e.Graphics;
                DrawRectangle(g, 0, 0, this.Width, this.Height);
                needPaint = false;
            }
		}

		/// <summary>
		/// Draws a rectangle painted
		/// </summary>
		/// <param name="g">Graphics variable</param>
		/// <param name="x">X - coordinate</param>
		/// <param name="y">Y - coordinate</param>
		/// <param name="widht">Widht of rectangle</param>
		/// <param name="height">Height of rectangle</param>
		private void DrawRectangle(Graphics g, int x, int y, int widht, int height) {
			Rectangle rec = new Rectangle(x, y, widht, height);
			if ((widht != 0) && (height != 0)) {
				System.Drawing.Drawing2D.LinearGradientBrush gradient;
				if (reverseGradient == false) {
					gradient = new System.Drawing.Drawing2D.LinearGradientBrush(rec, Color.FromArgb(251, 188, 59), Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
				} else {
					gradient = new System.Drawing.Drawing2D.LinearGradientBrush(rec, Color.White, Color.FromArgb(251, 188, 59), System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
				}
                Bitmap bmp = new Bitmap(this.Width, this.Height);

                Graphics gr = Graphics.FromImage(bmp);
                gr.FillRectangle(gradient, rec);
                this.BackgroundImage = bmp;
                this.BackgroundImageLayout = ImageLayout.Stretch;
				return;
			}
			Brush brush = new SolidBrush(Color.FromArgb(251, 188, 59));
			g.FillRectangle(brush, rec);            
		}

		#endregion

		#region TableFunctions

		/// <summary>
		/// Initialize cells by column and rowcount
		/// </summary>
		public void InitializeCellsCount(int columnCount, int rowCount) {
			this.RowCount = rowCount;
			this.ColumnCount = columnCount;
		}

		/// <summary>
		/// Reverse Controls in Collection
		/// </summary>
		public void ReverseControls() {
			Control[] con = new Control[this.Controls.Count];
			this.Controls.CopyTo(con, 0);
			con = con.Reverse<Control>().ToArray<Control>();
			while (this.Controls.Count > 0) {
				this.Controls.RemoveAt(Controls.Count - 1);
			}
			for (int i = 0; i < con.Length; i++) {
				this.Controls.Add(con[i]);
			}
		}

		#endregion
	}
}