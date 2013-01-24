namespace EnterpriseMICApplicationDemo {
	partial class MainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.deliveryNewButton = new System.Windows.Forms.Button();
			this.bottomButton = new System.Windows.Forms.Button();
			this.newIdeaButton = new System.Windows.Forms.Button();
			this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.messageLabel = new EnterpriseMICApplicationDemo.MessageLabel();
			this.workSpaceTableLayoutPanel = new EnterpriseMICApplicationDemo.FunctionPanel();
			this.newLab = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.leftFunctionPanel = new EnterpriseMICApplicationDemo.FunctionPanel();
			this.onlineConferenceButton = new System.Windows.Forms.Button();
			this.deliveryListLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.deliveryLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.postLabel = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.nameLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.deliveryNumberLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.deliveryNumberListLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.ideasLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.taskLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.taskListLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.eventLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.eventListLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.ideasListLinkLabel = new EnterpriseMICApplicationDemo.OpacityLinkLabel();
			this.newIdeaTextBox = new EnterpriseMICApplicationDemo.DisTextBox();
			this.newIdeaLabel = new EnterpriseMICApplicationDemo.OpacityLabel();
			this.rightFunctionPanel = new System.Windows.Forms.TableLayoutPanel();
			this.fillFunctionPanel = new EnterpriseMICApplicationDemo.FunctionPanel();
			this.bottomTableLayoutPanel.SuspendLayout();
			this.workSpaceTableLayoutPanel.SuspendLayout();
			this.leftFunctionPanel.SuspendLayout();
			this.rightFunctionPanel.SuspendLayout();
			this.fillFunctionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// deliveryNewButton
			// 
			this.deliveryNewButton.Location = new System.Drawing.Point(14, 52);
			this.deliveryNewButton.Name = "deliveryNewButton";
			this.deliveryNewButton.Size = new System.Drawing.Size(134, 32);
			this.deliveryNewButton.TabIndex = 2;
			this.deliveryNewButton.Text = "Создать рассылку";
			this.deliveryNewButton.UseVisualStyleBackColor = true;
			this.deliveryNewButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// bottomButton
			// 
			this.bottomButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottomButton.Location = new System.Drawing.Point(404, 357);
			this.bottomButton.Name = "bottomButton";
			this.bottomButton.Size = new System.Drawing.Size(122, 50);
			this.bottomButton.TabIndex = 0;
			this.bottomButton.Text = "AddButton";
			this.bottomButton.UseVisualStyleBackColor = true;
			// 
			// newIdeaButton
			// 
			this.newIdeaButton.Font = new System.Drawing.Font("PF BeauSans Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.newIdeaButton.Location = new System.Drawing.Point(122, 75);
			this.newIdeaButton.Name = "newIdeaButton";
			this.newIdeaButton.Size = new System.Drawing.Size(75, 21);
			this.newIdeaButton.TabIndex = 8;
			this.newIdeaButton.Text = ">>>";
			this.newIdeaButton.UseVisualStyleBackColor = true;
			// 
			// bottomTableLayoutPanel
			// 
			this.bottomTableLayoutPanel.ColumnCount = 3;
			this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.bottomTableLayoutPanel.Controls.Add(this.messageLabel, 0, 0);
			this.bottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomTableLayoutPanel.Location = new System.Drawing.Point(3, 349);
			this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
			this.bottomTableLayoutPanel.RowCount = 1;
			this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bottomTableLayoutPanel.Size = new System.Drawing.Size(583, 44);
			this.bottomTableLayoutPanel.TabIndex = 2;
			// 
			// messageLabel
			// 
			this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messageLabel.Location = new System.Drawing.Point(3, 0);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(407, 44);
			this.messageLabel.TabIndex = 1;
			this.messageLabel.Text = "MessageLabel";
			this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// workSpaceTableLayoutPanel
			// 
			this.workSpaceTableLayoutPanel.AutoScroll = true;
			this.workSpaceTableLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("workSpaceTableLayoutPanel.BackgroundImage")));
			this.workSpaceTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.workSpaceTableLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.workSpaceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 585F));
			this.workSpaceTableLayoutPanel.Controls.Add(this.newLab, 0, 0);
			this.workSpaceTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.workSpaceTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.workSpaceTableLayoutPanel.Name = "workSpaceTableLayoutPanel";
			this.workSpaceTableLayoutPanel.ReverseGradient = false;
			this.workSpaceTableLayoutPanel.RowCount = 6;
			this.workSpaceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.workSpaceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.workSpaceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.workSpaceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.workSpaceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.workSpaceTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.workSpaceTableLayoutPanel.Size = new System.Drawing.Size(583, 340);
			this.workSpaceTableLayoutPanel.TabIndex = 1;
			this.workSpaceTableLayoutPanel.TableBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			// 
			// newLab
			// 
			this.newLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.newLab.ForeColor = System.Drawing.Color.Black;
			this.newLab.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.newLab.Location = new System.Drawing.Point(0, 0);
			this.newLab.Margin = new System.Windows.Forms.Padding(0);
			this.newLab.Name = "newLab";
			this.newLab.Size = new System.Drawing.Size(100, 20);
			this.newLab.TabIndex = 0;
			// 
			// leftFunctionPanel
			// 
			this.leftFunctionPanel.AutoScroll = true;
			this.leftFunctionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftFunctionPanel.BackgroundImage")));
			this.leftFunctionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.leftFunctionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.leftFunctionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
			this.leftFunctionPanel.Controls.Add(this.onlineConferenceButton, 0, 0);
			this.leftFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftFunctionPanel.Location = new System.Drawing.Point(3, 3);
			this.leftFunctionPanel.Name = "leftFunctionPanel";
			this.leftFunctionPanel.ReverseGradient = false;
			this.leftFunctionPanel.Size = new System.Drawing.Size(224, 396);
			this.leftFunctionPanel.TabIndex = 0;
			this.leftFunctionPanel.TableBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			// 
			// onlineConferenceButton
			// 
			this.onlineConferenceButton.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.onlineConferenceButton.Location = new System.Drawing.Point(3, 3);
			this.onlineConferenceButton.Name = "onlineConferenceButton";
			this.onlineConferenceButton.Size = new System.Drawing.Size(203, 41);
			this.onlineConferenceButton.TabIndex = 0;
			this.onlineConferenceButton.Text = "Открыть конференцию";
			this.onlineConferenceButton.UseVisualStyleBackColor = true;
			this.onlineConferenceButton.Click += new System.EventHandler(this.button1_Click_1);
			this.onlineConferenceButton.MouseEnter += new System.EventHandler(this.onlineConferenceLabel_MouseEnter);
			// 
			// deliveryListLinkLabel
			// 
			this.deliveryListLinkLabel.AutoSize = true;
			this.deliveryListLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.deliveryListLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deliveryListLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.deliveryListLinkLabel.Location = new System.Drawing.Point(12, 30);
			this.deliveryListLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.deliveryListLinkLabel.Name = "deliveryListLinkLabel";
			this.deliveryListLinkLabel.Size = new System.Drawing.Size(62, 19);
			this.deliveryListLinkLabel.TabIndex = 1;
			this.deliveryListLinkLabel.TabStop = true;
			this.deliveryListLinkLabel.Text = "Списки";
			// 
			// deliveryLinkLabel
			// 
			this.deliveryLinkLabel.AutoSize = true;
			this.deliveryLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.deliveryLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deliveryLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.deliveryLinkLabel.Location = new System.Drawing.Point(12, 11);
			this.deliveryLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.deliveryLinkLabel.Name = "deliveryLinkLabel";
			this.deliveryLinkLabel.Size = new System.Drawing.Size(80, 19);
			this.deliveryLinkLabel.TabIndex = 0;
			this.deliveryLinkLabel.TabStop = true;
			this.deliveryLinkLabel.Text = "Рассылки";
			// 
			// postLabel
			// 
			this.postLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.postLabel.ForeColor = System.Drawing.Color.Black;
			this.postLabel.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.postLabel.Location = new System.Drawing.Point(11, 32);
			this.postLabel.Margin = new System.Windows.Forms.Padding(0);
			this.postLabel.Name = "postLabel";
			this.postLabel.Size = new System.Drawing.Size(197, 40);
			this.postLabel.TabIndex = 1;
			this.postLabel.Text = "Post";
			// 
			// nameLinkLabel
			// 
			this.nameLinkLabel.AutoSize = true;
			this.nameLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.nameLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.nameLinkLabel.Location = new System.Drawing.Point(10, 7);
			this.nameLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.nameLinkLabel.Name = "nameLinkLabel";
			this.nameLinkLabel.Size = new System.Drawing.Size(50, 19);
			this.nameLinkLabel.TabIndex = 0;
			this.nameLinkLabel.TabStop = true;
			this.nameLinkLabel.Text = "Name";
			this.nameLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nameLinkLabel_LinkClicked);
			// 
			// deliveryNumberLinkLabel
			// 
			this.deliveryNumberLinkLabel.AutoSize = true;
			this.deliveryNumberLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.deliveryNumberLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deliveryNumberLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.deliveryNumberLinkLabel.Location = new System.Drawing.Point(172, 11);
			this.deliveryNumberLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.deliveryNumberLinkLabel.Name = "deliveryNumberLinkLabel";
			this.deliveryNumberLinkLabel.Size = new System.Drawing.Size(19, 19);
			this.deliveryNumberLinkLabel.TabIndex = 3;
			this.deliveryNumberLinkLabel.TabStop = true;
			this.deliveryNumberLinkLabel.Text = "0";
			// 
			// deliveryNumberListLinkLabel
			// 
			this.deliveryNumberListLinkLabel.AutoSize = true;
			this.deliveryNumberListLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.deliveryNumberListLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deliveryNumberListLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.deliveryNumberListLinkLabel.Location = new System.Drawing.Point(172, 30);
			this.deliveryNumberListLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.deliveryNumberListLinkLabel.Name = "deliveryNumberListLinkLabel";
			this.deliveryNumberListLinkLabel.Size = new System.Drawing.Size(19, 19);
			this.deliveryNumberListLinkLabel.TabIndex = 4;
			this.deliveryNumberListLinkLabel.TabStop = true;
			this.deliveryNumberListLinkLabel.Text = "0";
			// 
			// ideasLinkLabel
			// 
			this.ideasLinkLabel.AutoSize = true;
			this.ideasLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.ideasLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ideasLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.ideasLinkLabel.Location = new System.Drawing.Point(15, 53);
			this.ideasLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.ideasLinkLabel.Name = "ideasLinkLabel";
			this.ideasLinkLabel.Size = new System.Drawing.Size(46, 19);
			this.ideasLinkLabel.TabIndex = 0;
			this.ideasLinkLabel.TabStop = true;
			this.ideasLinkLabel.Text = "Идеи";
			// 
			// taskLinkLabel
			// 
			this.taskLinkLabel.AutoSize = true;
			this.taskLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.taskLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.taskLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.taskLinkLabel.Location = new System.Drawing.Point(15, 9);
			this.taskLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.taskLinkLabel.Name = "taskLinkLabel";
			this.taskLinkLabel.Size = new System.Drawing.Size(60, 19);
			this.taskLinkLabel.TabIndex = 1;
			this.taskLinkLabel.TabStop = true;
			this.taskLinkLabel.Text = "Задачи";
			// 
			// taskListLinkLabel
			// 
			this.taskListLinkLabel.AutoSize = true;
			this.taskListLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.taskListLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.taskListLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.taskListLinkLabel.Location = new System.Drawing.Point(167, 9);
			this.taskListLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.taskListLinkLabel.Name = "taskListLinkLabel";
			this.taskListLinkLabel.Size = new System.Drawing.Size(19, 19);
			this.taskListLinkLabel.TabIndex = 2;
			this.taskListLinkLabel.TabStop = true;
			this.taskListLinkLabel.Text = "0";
			// 
			// eventLinkLabel
			// 
			this.eventLinkLabel.AutoSize = true;
			this.eventLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.eventLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.eventLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.eventLinkLabel.Location = new System.Drawing.Point(15, 31);
			this.eventLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.eventLinkLabel.Name = "eventLinkLabel";
			this.eventLinkLabel.Size = new System.Drawing.Size(107, 19);
			this.eventLinkLabel.TabIndex = 3;
			this.eventLinkLabel.TabStop = true;
			this.eventLinkLabel.Text = "Мероприятия";
			// 
			// eventListLinkLabel
			// 
			this.eventListLinkLabel.AutoSize = true;
			this.eventListLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.eventListLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.eventListLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.eventListLinkLabel.Location = new System.Drawing.Point(167, 31);
			this.eventListLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.eventListLinkLabel.Name = "eventListLinkLabel";
			this.eventListLinkLabel.Size = new System.Drawing.Size(19, 19);
			this.eventListLinkLabel.TabIndex = 4;
			this.eventListLinkLabel.TabStop = true;
			this.eventListLinkLabel.Text = "0";
			// 
			// ideasListLinkLabel
			// 
			this.ideasListLinkLabel.AutoSize = true;
			this.ideasListLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.ideasListLinkLabel.Font = new System.Drawing.Font("PF BeauSans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ideasListLinkLabel.Indent = EnterpriseMICApplicationDemo.OpacityLinkLabel.ControlIndent.None;
			this.ideasListLinkLabel.Location = new System.Drawing.Point(167, 53);
			this.ideasListLinkLabel.Margin = new System.Windows.Forms.Padding(0);
			this.ideasListLinkLabel.Name = "ideasListLinkLabel";
			this.ideasListLinkLabel.Size = new System.Drawing.Size(19, 19);
			this.ideasListLinkLabel.TabIndex = 5;
			this.ideasListLinkLabel.TabStop = true;
			this.ideasListLinkLabel.Text = "0";
			// 
			// newIdeaTextBox
			// 
			this.newIdeaTextBox.DisText = "Запишите новую идею";
			this.newIdeaTextBox.ForeColor = System.Drawing.Color.Gray;
			this.newIdeaTextBox.Indent = EnterpriseMICApplicationDemo.IndentionControlTextBox.ControlIndent.None;
			this.newIdeaTextBox.Location = new System.Drawing.Point(17, 97);
			this.newIdeaTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.newIdeaTextBox.Multiline = true;
			this.newIdeaTextBox.Name = "newIdeaTextBox";
			this.newIdeaTextBox.Size = new System.Drawing.Size(180, 93);
			this.newIdeaTextBox.TabIndex = 6;
			this.newIdeaTextBox.Text = "Запишите новую идею";
			// 
			// newIdeaLabel
			// 
			this.newIdeaLabel.AutoSize = true;
			this.newIdeaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
			this.newIdeaLabel.ForeColor = System.Drawing.Color.Black;
			this.newIdeaLabel.Indent = EnterpriseMICApplicationDemo.OpacityLabel.ControlIndent.None;
			this.newIdeaLabel.Location = new System.Drawing.Point(19, 78);
			this.newIdeaLabel.Margin = new System.Windows.Forms.Padding(0);
			this.newIdeaLabel.Name = "newIdeaLabel";
			this.newIdeaLabel.Size = new System.Drawing.Size(92, 13);
			this.newIdeaLabel.TabIndex = 7;
			this.newIdeaLabel.Text = "Добавить идею";
			// 
			// rightFunctionPanel
			// 
			this.rightFunctionPanel.ColumnCount = 1;
			this.rightFunctionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 589F));
			this.rightFunctionPanel.Controls.Add(this.workSpaceTableLayoutPanel, 0, 0);
			this.rightFunctionPanel.Controls.Add(this.bottomTableLayoutPanel, 0, 1);
			this.rightFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightFunctionPanel.Location = new System.Drawing.Point(233, 3);
			this.rightFunctionPanel.Name = "rightFunctionPanel";
			this.rightFunctionPanel.RowCount = 2;
			this.rightFunctionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.rightFunctionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.rightFunctionPanel.Size = new System.Drawing.Size(589, 396);
			this.rightFunctionPanel.TabIndex = 3;
			// 
			// fillFunctionPanel
			// 
			this.fillFunctionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillFunctionPanel.BackgroundImage")));
			this.fillFunctionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.fillFunctionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fillFunctionPanel.ColumnCount = 2;
			this.fillFunctionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
			this.fillFunctionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.fillFunctionPanel.Controls.Add(this.leftFunctionPanel);
			this.fillFunctionPanel.Controls.Add(this.rightFunctionPanel);
			this.fillFunctionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fillFunctionPanel.Location = new System.Drawing.Point(0, 0);
			this.fillFunctionPanel.Name = "fillFunctionPanel";
			this.fillFunctionPanel.ReverseGradient = false;
			this.fillFunctionPanel.RowCount = 1;
			this.fillFunctionPanel.Size = new System.Drawing.Size(800, 406);
			this.fillFunctionPanel.TabIndex = 0;
			this.fillFunctionPanel.TableBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 406);
			this.Controls.Add(this.fillFunctionPanel);
			this.Font = new System.Drawing.Font("PF BeauSans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(763, 444);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Корпорация МИЦ";
			this.bottomTableLayoutPanel.ResumeLayout(false);
			this.workSpaceTableLayoutPanel.ResumeLayout(false);
			this.leftFunctionPanel.ResumeLayout(false);
			this.rightFunctionPanel.ResumeLayout(false);
			this.fillFunctionPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private FunctionPanel leftFunctionPanel;
		private OpacityLinkLabel nameLinkLabel;
		private OpacityLabel postLabel;
		private FunctionPanel workSpaceTableLayoutPanel;
		private System.Windows.Forms.Button bottomButton;
		private MessageLabel messageLabel;
		private OpacityLinkLabel deliveryListLinkLabel;
		private OpacityLinkLabel deliveryLinkLabel;
		private System.Windows.Forms.Button deliveryNewButton;
		private OpacityLinkLabel deliveryNumberLinkLabel;
		private OpacityLinkLabel deliveryNumberListLinkLabel;
		private OpacityLinkLabel ideasLinkLabel;
		private OpacityLinkLabel taskListLinkLabel;
		private OpacityLinkLabel taskLinkLabel;
		private OpacityLinkLabel eventListLinkLabel;
		private OpacityLinkLabel eventLinkLabel;
		private OpacityLinkLabel ideasListLinkLabel;
		private System.Windows.Forms.Button newIdeaButton;
		private OpacityLabel newIdeaLabel;
		private DisTextBox newIdeaTextBox;
		private FunctionPanel fillFunctionPanel;

		private OpacityLabel newLab;
		private System.Windows.Forms.Button onlineConferenceButton;
		private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel rightFunctionPanel;
	}
}