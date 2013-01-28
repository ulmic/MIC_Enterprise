namespace EnterpriseMICApplicationDemo {
    partial class FormJoinConferention {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
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
			this.label2 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.textBoxConfName = new System.Windows.Forms.TextBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.label1 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.label2.Location = new System.Drawing.Point(22, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(285, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "Идентификатор конференции";
			// 
			// textBoxConfName
			// 
			this.textBoxConfName.Location = new System.Drawing.Point(22, 42);
			this.textBoxConfName.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxConfName.Name = "textBoxConfName";
			this.textBoxConfName.Size = new System.Drawing.Size(428, 31);
			this.textBoxConfName.TabIndex = 10;
			this.textBoxConfName.Text = "mclient";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(282, 152);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(171, 63);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(21, 152);
			this.buttonCreate.Margin = new System.Windows.Forms.Padding(6);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(249, 65);
			this.buttonCreate.TabIndex = 6;
			this.buttonCreate.Text = "Присоединиться к конференции";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.label1.Location = new System.Drawing.Point(22, 79);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 24);
			this.label1.TabIndex = 13;
			this.label1.Text = "Пароль";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(22, 109);
			this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(428, 31);
			this.textBoxPassword.TabIndex = 12;
			this.textBoxPassword.Text = "MCLIENT";
			// 
			// textBoxPass
			// 
			this.textBoxPass.Location = new System.Drawing.Point(22, 124);
			this.textBoxPass.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(428, 20);
			this.textBoxPass.TabIndex = 12;
			this.textBoxPass.Text = "MCLIENT";
			// 
			// FormJoinConferention
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 234);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxConfName);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonCreate);
			this.Margin = new System.Windows.Forms.Padding(9);
			this.Name = "FormJoinConferention";
			this.Text = "FormJoinConferention";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private EnterpriseMICApplicationDemo.OpacityLabel label2;
        private System.Windows.Forms.TextBox textBoxConfName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
		private EnterpriseMICApplicationDemo.OpacityLabel label1;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxPass;
    }
}