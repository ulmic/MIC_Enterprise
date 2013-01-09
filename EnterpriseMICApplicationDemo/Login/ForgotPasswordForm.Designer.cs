namespace EnterpriseMICApplicationDemo {
  partial class ForgotPasswordForm {
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
      this.mailLabel = new System.Windows.Forms.Label();
      this.mailTextBox = new System.Windows.Forms.TextBox();
      this.sendButton = new System.Windows.Forms.Button();
      this.iWillNeverCheckBox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // mailLabel
      // 
      this.mailLabel.AutoSize = true;
      this.mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.mailLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.mailLabel.Location = new System.Drawing.Point(12, 8);
      this.mailLabel.Name = "mailLabel";
      this.mailLabel.Size = new System.Drawing.Size(280, 20);
      this.mailLabel.TabIndex = 4;
      this.mailLabel.Text = "Введите адрес электронной почты";
      // 
      // mailTextBox
      // 
      this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
      this.mailTextBox.Location = new System.Drawing.Point(12, 31);
      this.mailTextBox.Name = "mailTextBox";
      this.mailTextBox.Size = new System.Drawing.Size(280, 30);
      this.mailTextBox.TabIndex = 3;
      // 
      // sendButton
      // 
      this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
      this.sendButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.sendButton.Location = new System.Drawing.Point(167, 67);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(125, 33);
      this.sendButton.TabIndex = 5;
      this.sendButton.Tag = "15";
      this.sendButton.Text = "Отправить";
      this.sendButton.UseVisualStyleBackColor = true;
      this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
      // 
      // iWillNeverCheckBox
      // 
      this.iWillNeverCheckBox.AutoSize = true;
      this.iWillNeverCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Red;
      this.iWillNeverCheckBox.FlatAppearance.BorderSize = 5;
      this.iWillNeverCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.iWillNeverCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.iWillNeverCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.iWillNeverCheckBox.Location = new System.Drawing.Point(12, 77);
      this.iWillNeverCheckBox.Name = "iWillNeverCheckBox";
      this.iWillNeverCheckBox.Size = new System.Drawing.Size(149, 19);
      this.iWillNeverCheckBox.TabIndex = 6;
      this.iWillNeverCheckBox.Text = "Я больше так не буду";
      this.iWillNeverCheckBox.UseVisualStyleBackColor = true;
      this.iWillNeverCheckBox.CheckedChanged += new System.EventHandler(this.rememberCheckBox_CheckedChanged);
      // 
      // ForgotPasswordForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(300, 111);
      this.Controls.Add(this.iWillNeverCheckBox);
      this.Controls.Add(this.sendButton);
      this.Controls.Add(this.mailLabel);
      this.Controls.Add(this.mailTextBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ForgotPasswordForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ForgotPasswordForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label mailLabel;
    private System.Windows.Forms.TextBox mailTextBox;
    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.CheckBox iWillNeverCheckBox;
  }
}