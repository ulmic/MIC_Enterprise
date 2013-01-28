namespace EnterpriseMICApplicationDemo {
  partial class LoginForm {
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
		this.loginTextBox = new System.Windows.Forms.TextBox();
		this.passwordTextBox = new System.Windows.Forms.TextBox();
		this.loginLabel = new System.Windows.Forms.Label();
		this.passwordLabel2 = new System.Windows.Forms.Label();
		this.enterButton = new System.Windows.Forms.Button();
		this.rememberCheckBox = new System.Windows.Forms.CheckBox();
		this.forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
		this.MessageLabel = new EnterpriseMICApplicationDemo.MessageLabel();
		this.SuspendLayout();
		// 
		// loginTextBox
		// 
		resources.ApplyResources(this.loginTextBox, "loginTextBox");
		this.loginTextBox.Name = "loginTextBox";
		// 
		// passwordTextBox
		// 
		resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
		this.passwordTextBox.Name = "passwordTextBox";
		this.passwordTextBox.UseSystemPasswordChar = true;
		// 
		// loginLabel
		// 
		resources.ApplyResources(this.loginLabel, "loginLabel");
		this.loginLabel.Name = "loginLabel";
		// 
		// passwordLabel2
		// 
		resources.ApplyResources(this.passwordLabel2, "passwordLabel2");
		this.passwordLabel2.Name = "passwordLabel2";
		// 
		// enterButton
		// 
		resources.ApplyResources(this.enterButton, "enterButton");
		this.enterButton.Name = "enterButton";
		this.enterButton.UseVisualStyleBackColor = true;
		this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
		// 
		// rememberCheckBox
		// 
		resources.ApplyResources(this.rememberCheckBox, "rememberCheckBox");
		this.rememberCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Red;
		this.rememberCheckBox.FlatAppearance.BorderSize = 5;
		this.rememberCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		this.rememberCheckBox.Name = "rememberCheckBox";
		this.rememberCheckBox.UseVisualStyleBackColor = true;
		// 
		// forgotPasswordLinkLabel
		// 
		resources.ApplyResources(this.forgotPasswordLinkLabel, "forgotPasswordLinkLabel");
		this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
		this.forgotPasswordLinkLabel.TabStop = true;
		// 
		// MessageLabel
		// 
		this.MessageLabel.AutoEllipsis = true;
		this.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		resources.ApplyResources(this.MessageLabel, "MessageLabel");
		this.MessageLabel.Image = global::EnterpriseMICApplicationDemo.Properties.Resources.bitmap1;
		this.MessageLabel.Name = "MessageLabel";
		// 
		// LoginForm
		// 
		resources.ApplyResources(this, "$this");
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.Controls.Add(this.forgotPasswordLinkLabel);
		this.Controls.Add(this.MessageLabel);
		this.Controls.Add(this.rememberCheckBox);
		this.Controls.Add(this.enterButton);
		this.Controls.Add(this.passwordLabel2);
		this.Controls.Add(this.loginLabel);
		this.Controls.Add(this.passwordTextBox);
		this.Controls.Add(this.loginTextBox);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "LoginForm";
		this.ResumeLayout(false);
		this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox loginTextBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Label loginLabel;
    private System.Windows.Forms.Label passwordLabel2;
    private System.Windows.Forms.Button enterButton;
    private System.Windows.Forms.CheckBox rememberCheckBox;
    public MessageLabel MessageLabel;
    private System.Windows.Forms.LinkLabel forgotPasswordLinkLabel;
  }
}