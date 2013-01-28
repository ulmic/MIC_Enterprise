namespace EnterpriseMICApplicationDemo {
    partial class FormSettings {
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
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.label1 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxIP
			// 
			this.textBoxIP.Location = new System.Drawing.Point(199, 9);
			this.textBoxIP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(283, 31);
			this.textBoxIP.TabIndex = 0;
			this.textBoxIP.Text = "192.168.1.3";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "IP-адрес сервера";
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.Location = new System.Drawing.Point(172, 47);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(149, 55);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Ок";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(333, 47);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(153, 55);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "Отмена";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.Location = new System.Drawing.Point(19, 46);
			this.buttonApply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(141, 55);
			this.buttonApply.TabIndex = 4;
			this.buttonApply.Text = "Применить";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 107);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxIP);
			this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
			this.Name = "FormSettings";
			this.Text = "FormSettings";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private EnterpriseMICApplicationDemo.OpacityLabel label1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonApply;
    }
}