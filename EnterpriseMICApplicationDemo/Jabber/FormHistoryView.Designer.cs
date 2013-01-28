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
			this.buttonOk = new System.Windows.Forms.Button();
			this.comboBoxDay = new System.Windows.Forms.ComboBox();
			this.comboBoxMonth = new System.Windows.Forms.ComboBox();
			this.comboBoxYear = new System.Windows.Forms.ComboBox();
			this.label1 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.label2 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.label3 = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.buttonSee = new System.Windows.Forms.Button();
			this.controlView = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonOk.Location = new System.Drawing.Point(13, 446);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(156, 42);
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "Выйти";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// comboBoxDay
			// 
			this.comboBoxDay.FormattingEnabled = true;
			this.comboBoxDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
			this.comboBoxDay.Location = new System.Drawing.Point(75, 25);
			this.comboBoxDay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.comboBoxDay.Name = "comboBoxDay";
			this.comboBoxDay.Size = new System.Drawing.Size(60, 32);
			this.comboBoxDay.TabIndex = 3;
			// 
			// comboBoxMonth
			// 
			this.comboBoxMonth.FormattingEnabled = true;
			this.comboBoxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
			this.comboBoxMonth.Location = new System.Drawing.Point(223, 24);
			this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.comboBoxMonth.Name = "comboBoxMonth";
			this.comboBoxMonth.Size = new System.Drawing.Size(60, 32);
			this.comboBoxMonth.TabIndex = 4;
			// 
			// comboBoxYear
			// 
			this.comboBoxYear.FormattingEnabled = true;
			this.comboBoxYear.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015"});
			this.comboBoxYear.Location = new System.Drawing.Point(351, 25);
			this.comboBoxYear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.comboBoxYear.Name = "comboBoxYear";
			this.comboBoxYear.Size = new System.Drawing.Size(79, 32);
			this.comboBoxYear.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(295, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Год";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(147, 28);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 24);
			this.label2.TabIndex = 7;
			this.label2.Text = "Месяц";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 28);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "День";
			// 
			// buttonSee
			// 
			this.buttonSee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSee.Location = new System.Drawing.Point(244, 446);
			this.buttonSee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.buttonSee.Name = "buttonSee";
			this.buttonSee.Size = new System.Drawing.Size(186, 42);
			this.buttonSee.TabIndex = 9;
			this.buttonSee.Text = "Просмотреть";
			this.buttonSee.UseVisualStyleBackColor = true;
			this.buttonSee.Click += new System.EventHandler(this.buttonSee_Click);
			// 
			// controlView
			// 
			this.controlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.controlView.Location = new System.Drawing.Point(15, 72);
			this.controlView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.controlView.MinimumSize = new System.Drawing.Size(37, 37);
			this.controlView.Name = "controlView";
			this.controlView.Size = new System.Drawing.Size(415, 353);
			this.controlView.TabIndex = 10;
			// 
			// FormHistoryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 503);
			this.Controls.Add(this.controlView);
			this.Controls.Add(this.buttonSee);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxYear);
			this.Controls.Add(this.comboBoxMonth);
			this.Controls.Add(this.comboBoxDay);
			this.Controls.Add(this.buttonOk);
			this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
			this.Name = "FormHistoryView";
			this.Text = "FormHistoryView";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private EnterpriseMICApplicationDemo.OpacityLabel label1;
        private EnterpriseMICApplicationDemo.OpacityLabel label2;
        private EnterpriseMICApplicationDemo.OpacityLabel label3;
        private System.Windows.Forms.Button buttonSee;
        private System.Windows.Forms.WebBrowser controlView;
    }
}