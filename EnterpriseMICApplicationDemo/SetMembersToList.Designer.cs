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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMembersToList));
            this.fillPanel = new EnterpriseMICApplicationDemo.FunctionPanel();
            this.SuspendLayout();
            // 
            // fillPanel
            // 
            this.fillPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillPanel.BackgroundImage")));
            this.fillPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fillPanel.Location = new System.Drawing.Point(0, 0);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.ReverseGradient = false;
            this.fillPanel.Size = new System.Drawing.Size(568, 104);
            this.fillPanel.TabIndex = 0;
            this.fillPanel.TableBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            // 
            // SetMembersToList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.fillPanel);
            this.Name = "SetMembersToList";
            this.Text = "SetMembersToList";
            this.ResumeLayout(false);

    }

    #endregion

    private FunctionPanel fillPanel;
  }
}