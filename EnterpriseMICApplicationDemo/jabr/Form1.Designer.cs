namespace serializ2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
          this.textBoxStatus = new System.Windows.Forms.TextBox();
          this.createConference = new System.Windows.Forms.Button();
          this.checkBox1 = new System.Windows.Forms.CheckBox();
          this.listBox2 = new System.Windows.Forms.ListBox();
          this.label2 = new System.Windows.Forms.Label();
          this.button4 = new System.Windows.Forms.Button();
          this.login = new System.Windows.Forms.TextBox();
          this.password = new System.Windows.Forms.TextBox();
          this.Login_Button = new System.Windows.Forms.Button();
          this.Add_Users = new System.Windows.Forms.Button();
          this.Exit = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // textBoxStatus
          // 
          this.textBoxStatus.Location = new System.Drawing.Point(12, 25);
          this.textBoxStatus.Name = "textBoxStatus";
          this.textBoxStatus.Size = new System.Drawing.Size(161, 21);
          this.textBoxStatus.TabIndex = 3;
          // 
          // createConference
          // 
          this.createConference.Location = new System.Drawing.Point(190, 67);
          this.createConference.Name = "createConference";
          this.createConference.Size = new System.Drawing.Size(101, 24);
          this.createConference.TabIndex = 8;
          this.createConference.Text = "Конференция";
          this.createConference.UseVisualStyleBackColor = true;
          this.createConference.Click += new System.EventHandler(this.createConference_Click);
          // 
          // checkBox1
          // 
          this.checkBox1.AutoSize = true;
          this.checkBox1.Location = new System.Drawing.Point(199, 110);
          this.checkBox1.Name = "checkBox1";
          this.checkBox1.Size = new System.Drawing.Size(67, 17);
          this.checkBox1.TabIndex = 9;
          this.checkBox1.Text = "Онлайн";
          this.checkBox1.UseVisualStyleBackColor = true;
          // 
          // listBox2
          // 
          this.listBox2.FormattingEnabled = true;
          this.listBox2.Location = new System.Drawing.Point(12, 79);
          this.listBox2.Name = "listBox2";
          this.listBox2.Size = new System.Drawing.Size(161, 251);
          this.listBox2.TabIndex = 10;
          this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(12, 9);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(40, 13);
          this.label2.TabIndex = 12;
          this.label2.Text = "Статус";
          // 
          // button4
          // 
          this.button4.Location = new System.Drawing.Point(12, 52);
          this.button4.Name = "button4";
          this.button4.Size = new System.Drawing.Size(161, 23);
          this.button4.TabIndex = 13;
          this.button4.Text = "Применить статус";
          this.button4.UseVisualStyleBackColor = true;
          this.button4.Click += new System.EventHandler(this.button4_Click);
          // 
          // login
          // 
          this.login.Location = new System.Drawing.Point(189, 253);
          this.login.Name = "login";
          this.login.Size = new System.Drawing.Size(101, 21);
          this.login.TabIndex = 14;
          this.login.Text = "Логин";
          this.login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.login_MouseClick);
          // 
          // password
          // 
          this.password.Location = new System.Drawing.Point(189, 279);
          this.password.Name = "password";
          this.password.PasswordChar = '*';
          this.password.Size = new System.Drawing.Size(101, 21);
          this.password.TabIndex = 15;
          this.password.Text = "Пароль";
          this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_MouseClick);
          // 
          // Login_Button
          // 
          this.Login_Button.Location = new System.Drawing.Point(189, 305);
          this.Login_Button.Name = "Login_Button";
          this.Login_Button.Size = new System.Drawing.Size(100, 22);
          this.Login_Button.TabIndex = 16;
          this.Login_Button.Text = "Войти";
          this.Login_Button.UseVisualStyleBackColor = true;
          this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
          // 
          // Add_Users
          // 
          this.Add_Users.Location = new System.Drawing.Point(190, 25);
          this.Add_Users.Name = "Add_Users";
          this.Add_Users.Size = new System.Drawing.Size(100, 36);
          this.Add_Users.TabIndex = 17;
          this.Add_Users.Text = "Добавить контакт";
          this.Add_Users.UseVisualStyleBackColor = true;
          this.Add_Users.Click += new System.EventHandler(this.Add_Users_Click);
          // 
          // Exit
          // 
          this.Exit.Location = new System.Drawing.Point(190, 306);
          this.Exit.Name = "Exit";
          this.Exit.Size = new System.Drawing.Size(101, 24);
          this.Exit.TabIndex = 18;
          this.Exit.Text = "Выйти";
          this.Exit.UseVisualStyleBackColor = true;
          this.Exit.Visible = false;
          this.Exit.Click += new System.EventHandler(this.Exit_Click);
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(305, 339);
          this.Controls.Add(this.Exit);
          this.Controls.Add(this.Add_Users);
          this.Controls.Add(this.Login_Button);
          this.Controls.Add(this.password);
          this.Controls.Add(this.login);
          this.Controls.Add(this.button4);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.listBox2);
          this.Controls.Add(this.checkBox1);
          this.Controls.Add(this.createConference);
          this.Controls.Add(this.textBoxStatus);
          this.Font = new System.Drawing.Font("PF BeauSans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "Form1";
          this.Text = "Онлайн-конференция";
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button createConference;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Add_Users;
        private System.Windows.Forms.Button Exit;
    }
}

