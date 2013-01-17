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
			this.SuspendLayout();
			// 
			// NameTextBox
			// 
			this.NameTextBox.DisText = null;
			this.NameTextBox.Font = new System.Drawing.Font("PF BeauSans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameTextBox.ForeColor = System.Drawing.Color.Gray;
			this.NameTextBox.Location = new System.Drawing.Point(12, 12);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(431, 33);
			this.NameTextBox.TabIndex = 0;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.DisText = null;
			this.EmailTextBox.Font = new System.Drawing.Font("PF BeauSans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EmailTextBox.ForeColor = System.Drawing.Color.Gray;
			this.EmailTextBox.Location = new System.Drawing.Point(12, 50);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(431, 33);
			this.EmailTextBox.TabIndex = 1;
			// 
			// AddButton
			// 
			this.AddButton.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddButton.Location = new System.Drawing.Point(318, 94);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(124, 34);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			// 
			// chooseComboBox
			// 
			this.chooseComboBox.DisText = null;
			this.chooseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chooseComboBox.ForeColor = System.Drawing.Color.Gray;
			this.chooseComboBox.FormattingEnabled = true;
			this.chooseComboBox.Location = new System.Drawing.Point(12, 94);
			this.chooseComboBox.Name = "chooseComboBox";
			this.chooseComboBox.Size = new System.Drawing.Size(300, 33);
			this.chooseComboBox.TabIndex = 3;
			// 
			// AddToSendListNewItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 138);
			this.Controls.Add(this.chooseComboBox);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.NameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
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
	}
}