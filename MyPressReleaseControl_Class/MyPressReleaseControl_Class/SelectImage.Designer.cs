namespace EnterpriseMICApplicationDemo
{
    partial class SelectImage
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
            this.addressBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsertImg = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(15, 41);
            this.addressBox.MaxLength = 10000;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(290, 20);
            this.addressBox.TabIndex = 1;
            this.addressBox.Text = "http://os.colta.ru/m/photo/2010/09/27/smile_b_0.jpg";
            this.addressBox.DoubleClick += new System.EventHandler(this.addressBox_DoubleClick);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(311, 39);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(67, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Обзор";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Источник изображения:";
            // 
            // buttonInsertImg
            // 
            this.buttonInsertImg.Location = new System.Drawing.Point(15, 68);
            this.buttonInsertImg.Name = "buttonInsertImg";
            this.buttonInsertImg.Size = new System.Drawing.Size(281, 23);
            this.buttonInsertImg.TabIndex = 6;
            this.buttonInsertImg.Text = "Добавить изображение";
            this.buttonInsertImg.UseVisualStyleBackColor = true;
            this.buttonInsertImg.Click += new System.EventHandler(this.buttonInsertImg_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(302, 68);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(76, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вставьте сетевой адрес изображения или выберите его на компьютере";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 68);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(281, 23);
            this.progressBar.TabIndex = 9;
            this.progressBar.Visible = false;
            // 
            // SelectImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 103);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonInsertImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.addressBox);
            this.Name = "SelectImage";
            this.Text = "Добавление изображения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsertImg;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}