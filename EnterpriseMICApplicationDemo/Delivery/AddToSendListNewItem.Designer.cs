namespace EnterpriseMICApplicationDemo {
	partial class AddToSendListNewItem {
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
			this.NameTextBox = new EnterpriseMICApplicationDemo.DisTextBox();
			this.EmailTextBox = new EnterpriseMICApplicationDemo.DisTextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.chooseComboBox = new EnterpriseMICApplicationDemo.DisComboBox();
			this.typeAddDisComboBox = new EnterpriseMICApplicationDemo.DisComboBox();
			this.SuspendLayout();
			// 
			// NameTextBox
			// 
			this.NameTextBox.DisText = null;
			this.NameTextBox.Font = new System.Drawing.Font("PF BeauSans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameTextBox.ForeColor = System.Drawing.Color.Gray;
			this.NameTextBox.Indent = EnterpriseMICApplicationDemo.IndentionControlTextBox.ControlIndent.None;
			this.NameTextBox.Location = new System.Drawing.Point(18, 18);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(9);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(787, 33);
			this.NameTextBox.TabIndex = 0;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.DisText = null;
			this.EmailTextBox.Font = new System.Drawing.Font("PF BeauSans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailTextBox.ForeColor = System.Drawing.Color.Gray;
			this.EmailTextBox.Indent = EnterpriseMICApplicationDemo.IndentionControlTextBox.ControlIndent.None;
			this.EmailTextBox.Location = new System.Drawing.Point(18, 69);
			this.EmailTextBox.Margin = new System.Windows.Forms.Padding(9);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(787, 33);
			this.EmailTextBox.TabIndex = 1;
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddButton.Location = new System.Drawing.Point(583, 174);
			this.AddButton.Margin = new System.Windows.Forms.Padding(6);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(227, 39);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// chooseComboBox
			// 
			this.chooseComboBox.DisText = null;
			this.chooseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chooseComboBox.ForeColor = System.Drawing.Color.Gray;
			this.chooseComboBox.FormattingEnabled = true;
			this.chooseComboBox.Indent = EnterpriseMICApplicationDemo.DisComboBox.ControlIndent.None;
			this.chooseComboBox.Location = new System.Drawing.Point(18, 120);
			this.chooseComboBox.Margin = new System.Windows.Forms.Padding(9);
			this.chooseComboBox.Name = "chooseComboBox";
			this.chooseComboBox.Size = new System.Drawing.Size(557, 33);
			this.chooseComboBox.TabIndex = 3;
			// 
			// typeAddDisComboBox
			// 
			this.typeAddDisComboBox.DisText = null;
			this.typeAddDisComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.typeAddDisComboBox.ForeColor = System.Drawing.Color.Gray;
			this.typeAddDisComboBox.FormattingEnabled = true;
			this.typeAddDisComboBox.Indent = EnterpriseMICApplicationDemo.DisComboBox.ControlIndent.None;
			this.typeAddDisComboBox.Location = new System.Drawing.Point(583, 120);
			this.typeAddDisComboBox.Margin = new System.Windows.Forms.Padding(9);
			this.typeAddDisComboBox.Name = "typeAddDisComboBox";
			this.typeAddDisComboBox.Size = new System.Drawing.Size(227, 33);
			this.typeAddDisComboBox.TabIndex = 4;
			// 
			// AddToSendListNewItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 226);
			this.Controls.Add(this.typeAddDisComboBox);
			this.Controls.Add(this.chooseComboBox);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Margin = new System.Windows.Forms.Padding(9);
			this.Name = "AddToSendListNewItem";
			this.Text = "Добавить в список";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DisTextBox NameTextBox;
		private DisTextBox EmailTextBox;
		private System.Windows.Forms.Button AddButton;
		private DisComboBox chooseComboBox;
		private DisComboBox typeAddDisComboBox;
	}
}