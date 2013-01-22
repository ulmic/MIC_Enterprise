namespace EnterpriseMICApplicationDemo {
  partial class SetMembersToList {
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
      this.fillPanel = new FunctionPanel();
      this.SuspendLayout();
      // 
      // fillPanel
      // 
      this.fillPanel.Location = new System.Drawing.Point(46, 43);
      this.fillPanel.Name = "fillPanel";
      this.fillPanel.Size = new System.Drawing.Size(200, 100);
      this.fillPanel.TabIndex = 0;
      // 
      // SetMembersToList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(521, 484);
      this.Controls.Add(this.fillPanel);
      this.Name = "SetMembersToList";
      this.Text = "SetMembersToList";
      this.ResumeLayout(false);

    }

    #endregion

    private FunctionPanel fillPanel;
  }
}