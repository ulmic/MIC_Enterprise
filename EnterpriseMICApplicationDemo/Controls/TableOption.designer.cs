namespace EnterpriseMICApplicationDemo {
	partial class TableOption {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new OpacityLabel();
			this.label2 = new OpacityLabel();
			this.button = new System.Windows.Forms.Button();
			this.textBoxRow = new System.Windows.Forms.TextBox();
			this.textBoxColumn = new System.Windows.Forms.TextBox();
			this.label3 = new OpacityLabel();
			this.numericBorder = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericBorder)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите количество строк";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 70);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(292, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Введите количество столбцов";
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(247, 156);
			this.button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(202, 50);
			this.button.TabIndex = 2;
			this.button.Text = "Вывести таблицу";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxRow
			// 
			this.textBoxRow.Location = new System.Drawing.Point(329, 29);
			this.textBoxRow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBoxRow.Name = "textBoxRow";
			this.textBoxRow.Size = new System.Drawing.Size(109, 31);
			this.textBoxRow.TabIndex = 3;
			// 
			// textBoxColumn
			// 
			this.textBoxColumn.Location = new System.Drawing.Point(329, 70);
			this.textBoxColumn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBoxColumn.Name = "textBoxColumn";
			this.textBoxColumn.Size = new System.Drawing.Size(109, 31);
			this.textBoxColumn.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 113);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(247, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Выберите ширину границ";
			// 
			// numericBorder
			// 
			this.numericBorder.Location = new System.Drawing.Point(329, 113);
			this.numericBorder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.numericBorder.Maximum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericBorder.Name = "numericBorder";
			this.numericBorder.Size = new System.Drawing.Size(112, 31);
			this.numericBorder.TabIndex = 7;
			this.numericBorder.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// TableOption
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 218);
			this.Controls.Add(this.numericBorder);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxColumn);
			this.Controls.Add(this.textBoxRow);
			this.Controls.Add(this.button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
			this.Name = "TableOption";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление таблицы";
			((System.ComponentModel.ISupportInitialize)(this.numericBorder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button;
		private System.Windows.Forms.TextBox textBoxRow;
		private System.Windows.Forms.TextBox textBoxColumn;
		private System.Windows.Forms.NumericUpDown numericBorder;
		private OpacityLabel label1;
		private OpacityLabel label2;
		private OpacityLabel label3;
	}
}