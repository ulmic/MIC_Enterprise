namespace EnterpriseMICApplicationDemo {
    partial class FormHistoryView {
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
            this.textBoxView = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxView
            // 
            this.textBoxView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxView.Location = new System.Drawing.Point(12, 12);
            this.textBoxView.Multiline = true;
            this.textBoxView.Name = "textBoxView";
            this.textBoxView.ReadOnly = true;
            this.textBoxView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxView.Size = new System.Drawing.Size(297, 313);
            this.textBoxView.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(115, 331);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 366);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxView);
            this.Name = "FormHistoryView";
            this.Text = "FormHistoryView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxView;
        private System.Windows.Forms.Button buttonOk;
    }
}