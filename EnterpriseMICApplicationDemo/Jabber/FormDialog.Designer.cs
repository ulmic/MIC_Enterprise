namespace EnterpriseMICApplicationDemo
{
    partial class FormDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьВкладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlDialogs = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьВкладкуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 26);
            // 
            // удалитьВкладкуToolStripMenuItem
            // 
            this.удалитьВкладкуToolStripMenuItem.Name = "удалитьВкладкуToolStripMenuItem";
            this.удалитьВкладкуToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.удалитьВкладкуToolStripMenuItem.Text = "Удалить вкладку";
            // 
            // tabControlDialogs
            // 
            this.tabControlDialogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlDialogs.Location = new System.Drawing.Point(0, 0);
            this.tabControlDialogs.Name = "tabControlDialogs";
            this.tabControlDialogs.SelectedIndex = 0;
            this.tabControlDialogs.Size = new System.Drawing.Size(470, 397);
            this.tabControlDialogs.TabIndex = 0;
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 397);
            this.Controls.Add(this.tabControlDialogs);
            this.Name = "FormDialog";
            this.Text = "FormDialog";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьВкладкуToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlDialogs;


    }
}