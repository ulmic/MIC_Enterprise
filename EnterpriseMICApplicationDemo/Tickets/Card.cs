using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
  public class Card : Panel {

    private Button button2;
    private Button button1;
    private ImprovedLabel titleLabel = new ImprovedLabel();
    private ImprovedLabel text = new ImprovedLabel();
    public event EventHandler CloseCard;
    public event EventHandler SaveText;

    public enum Action { View, Edit };
    private Action status = Action.View;
    public Action Status {
      get {
        return status;
      }
      set {
        status = value;
        if (status == Action.View) {
          text.Control = ImprovedLabel.OBJ.Label;
        }
        if (status == Action.Edit) {
          text.Control = ImprovedLabel.OBJ.Textbox;
        }
      }
    }

    public Card() {
      SaveText = new EventHandler(EmptyMethod);
      InitializeComponent();
      Text = "Новая карта";
    }

    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // AddButton
      // 
      resources.ApplyResources(this.button1, "AddButton");
      this.button1.Name = "AddButton";
      this.button1.Click += new EventHandler(button1_Click);
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Font = new System.Drawing.Font(this.button1.Font.FontFamily, 8F);
      // 
      // button2
      // 
      resources.ApplyResources(this.button2, "button2");
      this.button2.Name = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Font = new System.Drawing.Font(this.button2.Font.FontFamily, 8F);


      this.Size = new System.Drawing.Size(170, 170);
      this.text.Location = new System.Drawing.Point(10, 30);
      this.text.Size = new System.Drawing.Size(this.Width - 40, this.Height - 60);
      this.text.AutoSize = false;
      this.text.Text = "text";
      this.text.BorderStyle = BorderStyle.None;
      this.text.Multiline = true;
      this.text.SaveText(new System.EventHandler(saveClick));

      this.titleLabel.Location = new System.Drawing.Point(10, 5);
      this.titleLabel.Size = new System.Drawing.Size(this.button2.Location.X - 15, button1.Height + button1.Location.Y);
      this.titleLabel.AutoSize = false;
      this.titleLabel.Text = "title";
      this.titleLabel.Multiline = false;
      this.titleLabel.BorderStyle = BorderStyle.None;
      this.titleLabel.Font = new System.Drawing.Font(titleLabel.Font.FontFamily, 8F);
      // 
      // Card
      // 
      resources.ApplyResources(this, "$this");
      this.BorderStyle = BorderStyle.Fixed3D;
      
      this.MaximumSize = new System.Drawing.Size(150, 150);
      this.Padding = new Padding(10, 10, 10, 10);
      this.Controls.Add(this.button2);
      this.Controls.Add(text.Textbox);
      this.Controls.Add(text.Label);
      this.Controls.Add(titleLabel.Label);
      this.Controls.Add(titleLabel.Textbox);
      this.Controls.Add(this.button1);
      this.Name = "Card";
      this.ResumeLayout(false);
    }

    private void saveClick(object sender, EventArgs e) {
      SaveText.Invoke(this, new EventArgs());
    } 

    private void EmptyMethod(object sender, EventArgs e) { }

    private void button1_Click(object sender, EventArgs e) {
      Close = true;
    }

    private bool close = false;

    public bool Close {
      get {
        return close;
      }
      set {
        close = value;
        CloseCard.Invoke(this, new EventArgs());
      }
    }

    public string Text {
      get {
        return text.Text;
      }
      set {
        text.Text = value;
      }
    }

    public bool HaveDate {
      get {
        return button2.Visible;
      }
      set {
        button2.Visible = value;
      }
    }

    public string Title {
      get {
        return titleLabel.Text;
      }
      set {
        titleLabel.Text = value;
      }
    }

    public bool HaveTitle {
      get {
        return titleLabel.Visible;
      }
      set {
        titleLabel.Visible = value;
      }
    }
  }
}