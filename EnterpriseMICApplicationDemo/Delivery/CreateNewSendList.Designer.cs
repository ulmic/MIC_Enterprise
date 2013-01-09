namespace EnterpriseMICApplicationDemo {
  partial class CreateNewSendListForm {
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
      this.textBox1 = new EnterpriseMICApplicationDemo.DisTextBox();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.createNewListButton = new System.Windows.Forms.Button();
      this.label1 = new OpacityLabel();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.DisText = null;
      this.textBox1.ForeColor = System.Drawing.Color.Gray;
      this.textBox1.Indent = EnterpriseMICApplicationDemo.OpacityTextBox.ControlIndent.None;
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Margin = new System.Windows.Forms.Padding(5);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(260, 31);
      this.textBox1.TabIndex = 0;
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(12, 62);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(70, 31);
      this.numericUpDown1.TabIndex = 1;
      // 
      // createNewListButton
      // 
      this.createNewListButton.Location = new System.Drawing.Point(122, 51);
      this.createNewListButton.Name = "createNewListButton";
      this.createNewListButton.Size = new System.Drawing.Size(150, 42);
      this.createNewListButton.TabIndex = 2;
      this.createNewListButton.Text = "Создать";
      this.createNewListButton.UseVisualStyleBackColor = true;
      this.createNewListButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("PF BeauSans Pro", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Размер списка";
      // 
      // CreateNewSendListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(290, 105);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.createNewListButton);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.textBox1);
      this.Font = new System.Drawing.Font("PF BeauSans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CreateNewSendListForm";
      this.Text = "Создать новый список рассылки";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DisTextBox textBox1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Button createNewListButton;
    private OpacityLabel label1;
  }
}