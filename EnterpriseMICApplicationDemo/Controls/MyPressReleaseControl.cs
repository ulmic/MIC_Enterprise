using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using CG.FontCombo;
using mshtml;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Special control to impose posts
	/// </summary>
	public class MyPressReleaseControl : Control {

		/// <summary>
		/// Controls to Impose
		/// </summary>
		private ToolStrip menu = new ToolStrip();
		private ToolStripComboBox comboFontSize = new ToolStripComboBox();
		private ToolStripButton buttonBold = new ToolStripButton();
		private ToolStripButton buttonItalic = new ToolStripButton();
		private ToolStripButton buttonUnderlined = new ToolStripButton();
		private ToolStripButton buttonStrike = new ToolStripButton();
		private ToolStripButton buttonParagraph = new ToolStripButton();
		private ToolStripButton buttonH1 = new ToolStripButton();
		private ToolStripButton buttonAHref = new ToolStripButton();
		private ToolStripButton buttonImg = new ToolStripButton();
		private ToolStripButton buttonUpIndex = new ToolStripButton();
		private ToolStripButton buttonLowIndex = new ToolStripButton();
		private ToolStripButton buttJustifyCenter = new ToolStripButton();
		private ToolStripButton buttJustifyLeft = new ToolStripButton();
		private ToolStripButton buttJustifyRight = new ToolStripButton();
		private ToolStripButton buttJustifyNone = new ToolStripButton();
		private ToolStripButton buttonTable = new ToolStripButton();
		private ToolStripButton buttColorText = new ToolStripButton();
		private ToolStripButton buttColorBackground = new ToolStripButton();
		private ToolStripButton buttonList = new ToolStripButton();
		private ToolStripButton buttNumericList = new ToolStripButton();
		private ToolStripButton buttDelLink = new ToolStripButton();
		private ToolStripButton buttRemoveFormat = new ToolStripButton();
		private WebBrowser webBrowser = new WebBrowser();
		//private CGFontCombo comboBoxFont = new CGFontCombo();//этот элемент не работает в текущей сборке

		private Font fontButton = new Font("Microsoft Sans Serif", 8.5F);
		private Font fontText = new Font("Microsoft Sans Serif", 12F);
		private IHTMLDocument2 htmlDocument = null;

		public MyPressReleaseControl() {
			#region Components

			#region buttonBold
			buttonBold.Text = "B";
			buttonBold.Font = new Font(fontButton, FontStyle.Bold);
			#endregion

			#region buttonItalic
			buttonItalic.Text = "I";
			buttonItalic.Font = new Font(fontButton, FontStyle.Italic);
			#endregion

			#region buttonUnderlined
			buttonUnderlined.Text = "U";
			buttonUnderlined.Font = new Font(fontButton, FontStyle.Underline);
			#endregion

			#region buttonStrike
			buttonStrike.Text = "S";
			buttonStrike.Font = new Font(fontButton, FontStyle.Strikeout);
			#endregion

			#region buttonParagraph
			buttonParagraph.Text = "<p>";
			buttonParagraph.Font = fontButton;
			#endregion

			#region buttonH1
			buttonH1.Text = "<h1>";
			buttonH1.Font = fontButton;
			#endregion

			#region buttonAHref
			buttonAHref.Text = "link";
			buttonAHref.Font = new Font(fontButton, FontStyle.Underline);
			buttonAHref.ForeColor = Color.Blue;

			#endregion

			#region buttonImg
			buttonImg.Text = "img";
			buttonImg.Font = fontButton;
			#endregion

			#region buttonUpIndex
			buttonUpIndex.Text = "sup";
			buttonUpIndex.TextAlign = ContentAlignment.TopCenter;

			buttonUpIndex.Width = buttonImg.Width;
			buttonUpIndex.Height = buttonImg.Height;
			buttonUpIndex.Font = fontButton;
			#endregion

			#region buttonLowIndex
			buttonLowIndex.Text = "sub";
			buttonLowIndex.TextAlign = ContentAlignment.BottomCenter;

			buttonLowIndex.Width = buttonImg.Width;
			buttonLowIndex.Height = buttonImg.Height;
			buttonLowIndex.Font = fontButton;
			#endregion

			#region buttJustifyCenter
			buttJustifyCenter.Text = "center";
			buttJustifyCenter.Font = fontButton;
			#endregion

			#region buttJustifyLeft
			buttJustifyLeft.Text = "left";
			buttJustifyLeft.Font = fontButton;
			#endregion

			#region buttJustifyRigth
			buttJustifyRight.Text = "right";
			buttJustifyRight.Font = fontButton;
			#endregion

			#region buttJustifyNone
			buttJustifyNone.Text = "none";
			buttJustifyNone.Font = fontButton;
			#endregion

			#region buttColorText
			buttColorText.Text = "colText";
			buttColorText.Font = fontButton;
			#endregion

			#region buttColorBackground
			buttColorBackground.Text = "colBack";
			buttColorBackground.Font = fontButton;
			#endregion

			#region buttonList
			buttonList.Text = "list";
			buttonList.Font = fontButton;
			#endregion

			#region buttNumericList
			buttNumericList.Text = "numList";
			buttNumericList.Font = fontButton;
			#endregion

			#region buttonTable
			buttonTable.Text = "table";
			buttonTable.Font = fontButton;
			#endregion

			#region buttDelLink
			buttDelLink.Text = "del link";
			buttDelLink.Font = fontButton;
			#endregion

			#region buttRemoveFormat
			buttRemoveFormat.Text = "remove format";
			buttRemoveFormat.Font = fontButton;
			#endregion

			#region webBrowser
			webBrowser.Height = 300;
			webBrowser.Width = 810;
			webBrowser.DocumentText = "";
			htmlDocument = (IHTMLDocument2)webBrowser.Document.DomDocument;
			htmlDocument.designMode = "On";

			#endregion
			/*

			#region comboBoxFont
			comboBoxFont.Size = new System.Drawing.Size(131, 23);
			#endregion
*/

			#region comboFontSize
			comboFontSize.AutoSize = false;
			comboFontSize.Width = 37;
			comboFontSize.Items.AddRange(new object[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 });
			comboFontSize.Text = fontText.Size.ToString();
			#endregion

			#region menu
			menu.Items.AddRange(new ToolStripItem[] {comboFontSize, buttonBold, buttonItalic, buttonUnderlined, buttonStrike, buttonParagraph, 
												   buttonH1, buttonAHref, buttonImg, buttonUpIndex, buttonLowIndex, buttJustifyCenter, buttJustifyLeft,
												   buttJustifyRight, buttJustifyNone, buttonList, buttNumericList, buttColorBackground,
												   buttColorText, buttonTable, buttDelLink, buttRemoveFormat});
			menu.LayoutStyle = ToolStripLayoutStyle.Flow;
			#endregion

			#endregion

			#region Parents
			this.Controls.AddRange(new Control[] { menu, webBrowser /*, comboBoxFont*/});

			#endregion

			#region Events
			this.SizeChanged += new EventHandler(MyPressReleaseControl_SizeChanged);
			buttonBold.Click += new EventHandler(buttonBold_MouseClick);
			buttonItalic.Click += new EventHandler(buttonItalic_MouseClick);
			buttonUnderlined.Click += new EventHandler(buttonUnderlined_MouseClick);
			buttonStrike.Click += new EventHandler(buttonStrike_MouseClick);
			buttonH1.Click += new EventHandler(buttonH1_MouseClick);
			buttonParagraph.Click += new EventHandler(buttonParagraph_MouseClick);
			buttonAHref.Click += new EventHandler(buttonAHref_MouseClick);
			buttonImg.Click += new EventHandler(buttonImg_MouseClick);
			buttonUpIndex.Click += new EventHandler(buttonUpIndex_MouseClick);
			buttonLowIndex.Click += new EventHandler(buttonLowIndex_MouseClick);
			buttJustifyLeft.Click += new EventHandler(buttJustifyLeft_MouseClick);
			buttJustifyNone.Click += new EventHandler(buttJustifyNone_MouseClick);
			buttJustifyCenter.Click += new EventHandler(buttJustifyCenter_MouseClick);
			buttJustifyRight.Click += new EventHandler(buttJustifyRight_MouseClick);
			buttonList.Click += new EventHandler(buttonList_MouseClick);
			buttNumericList.Click += new EventHandler(buttNumericList_MouseClick);
			buttColorBackground.Click += new EventHandler(buttColorBackground_MouseClick);
			buttColorText.Click += new EventHandler(buttColorText_MouseClick);
			buttonTable.Click += new EventHandler(buttonTable_MouseClick);
			buttDelLink.Click += new EventHandler(buttDelLink_MouseClick);
			buttRemoveFormat.Click += new EventHandler(buttRemoveFormat_MouseClick);
			comboFontSize.SelectedIndexChanged += new EventHandler(comboFontSize_SelectedIndexChanged);
			comboFontSize.KeyDown += new KeyEventHandler(comboFontSize_SelectedIndexChanged);
			//comboBoxFont.SelectedIndexChanged += new EventHandler(comboBoxFont_SelectedIndexChanged);
			webBrowser.DocumentTitleChanged += new EventHandler(webBrowser_DocumentTitleChanged);
			#endregion

			setLocation();

			/* Стандартный отступ у всех */
			Margin = new Padding(Const.CONTROL_INDENT_SMALL);

		}

		/// <summary>
		/// setLocation of WebBrowser
		/// </summary>
		private void setLocation() {
			int locationOnX = this.Location.X;
			int locationOnY = this.Location.Y;
			//comboBoxFont.Location = new Point(locationOnX + 5, locationOnY + 5);
			webBrowser.Location = new Point(menu.Location.X, menu.Location.Y + menu.Height + 5);
			webBrowser.Width = this.Width;
			webBrowser.Height = this.Height - menu.Height - 5;
		}

		private void MyPressReleaseControl_SizeChanged(object sender, EventArgs e) {
			setLocation();
		}

		private void webBrowser_DocumentTitleChanged(object sender, EventArgs e) {
			htmlDocument.body.style.fontFamily = fontText.Name;
			htmlDocument.body.style.fontSize = fontText.SizeInPoints + "pt";
			IHTMLStyleSheet css = htmlDocument.createStyleSheet("", 0);
			css.cssText = "p {margin-top: 0px; margin-bottom: 0px;}";
		}

		private void comboFontSize_SelectedIndexChanged(object send, EventArgs arg) {
			if (arg is KeyEventArgs) {
				if (((KeyEventArgs)arg).KeyCode != Keys.Enter) {
					return;
				}
			}
			IHTMLTxtRange range = htmlDocument.selection.type == "Text" ? (IHTMLTxtRange)htmlDocument.selection.createRange() : null;
			if (range == null) return;
			if (range.htmlText == null) return;
			string htmlCode = range.htmlText;
			int size = 12;
			try {
				size = Int32.Parse(comboFontSize.Text);
			} catch { }
			string tagName = "SPAN";
			removeFormatFromMiddle(ref tagName, range, tagName, "style=\"FONT-SIZE: " + size + "pt\"", "fontSize");
			if (tagName == "Success") return;
			if (htmlCode.Contains("<SPAN"))//при нахождении в выделении других тегов(т.е. других размеров шрифта)
			{
				try {
					htmlCode = deleteTag("SPAN", range, htmlCode);
					insertTag("SPAN", htmlCode, range, "style=\"FONT-SIZE: " + size + "pt\"");
				} catch { }
			} else //если размер шрифта изменяется первый раз
			{
				insertTag("SPAN", htmlCode, range, "style=\"FONT-SIZE: " + size + "pt\"");
			}
		}

		/// <returns>text o send</returns>
		public string textForSend() {
			return webBrowser.Document.Body.InnerHtml;
		}

		/// <returns>get text without tags</returns>
		public string getTextNoTags() {
			return webBrowser.Document.Body.InnerText;
		}

		/// <summary>
		/// Set text without tags
		/// </summary>
		/// <param name="newInnerText">new Text</param>
		public void setTextNoTags(string newInnerText) {
			webBrowser.Document.Body.InnerText = newInnerText;
		}

		private delegate string funct(string selectedText);

		private void insertTag(string tagName, string htmlCode, IHTMLTxtRange range, string attributes = "") {
			if (htmlDocument.selection.type != "None") htmlDocument.selection.clear();
			range.pasteHTML("<" + tagName + " " + attributes + ">" + htmlCode + "</" + tagName + ">");
		}

		private string deleteTag(string tagName, IHTMLTxtRange range = null, string formatStr = "") {
			string htmlCode = formatStr != "" ? formatStr : (range != null ? range.htmlText : "");

			try {
				htmlCode = htmlCode.Replace("</" + tagName + ">", "");
				htmlCode = htmlCode.Replace("\n", "");
				htmlCode = htmlCode.Replace("\r", "");
				while (true) {
					int startIndex = htmlCode.IndexOf("<" + tagName);
					if (startIndex == -1) break;
					int endIndex = htmlCode.IndexOf('>', startIndex);
					htmlCode = htmlCode.Remove(startIndex, endIndex - startIndex + 1);// +1 - для удаления '>'
				}
				if (formatStr == "" && range != null) {
					htmlDocument.selection.clear();
					range.pasteHTML(htmlCode);
				}
			} catch { }
			return htmlCode;
		}

		private void subSubInsertTag(IHTMLTxtRange range, string tagName, string antiTagName) {
			string htmlCode = range.htmlText;
			if (htmlCode.Contains(antiTagName) || htmlCode.Contains(tagName)) {
				htmlCode = htmlCode.Replace("<" + antiTagName + ">", "");
				htmlCode = htmlCode.Replace("</" + antiTagName + ">", "");
				htmlCode = htmlCode.Replace("<" + tagName + ">", "");
				htmlCode = htmlCode.Replace("</" + tagName + ">", "");
				htmlDocument.selection.clear();
			}
			insertTag(tagName, htmlCode, range);
		}

		//эта функция - на удаление форматирования текста из середины. Например, <s>testing</s> станет <s>te</s>sti<s>ng</s>. + плюшка для sub-sup тегов 
		private void removeFormatFromMiddle(ref string tagName, IHTMLTxtRange range, string antiTagName = "", string attributes = "", string antiAttributes = "") {
			IHTMLElement el = range.parentElement();
			bool need = false;
			while (el.tagName != "BODY") {
				if (el.tagName == antiTagName || el.tagName == tagName) {
					need = true;
					antiAttributes = antiAttributes == "fontSize" ? "style=\"FONT-SIZE: " + el.style.fontSize + "\"" : "";
					break;
				}
				el = el.parentElement;
			}
			if (range.htmlText[0] != '<' && need) {
				string htmlCode = range.htmlText;
				if (el.tagName == antiTagName) {
					range.pasteHTML("</" + antiTagName + "><" + tagName + " " + attributes + ">" + htmlCode + "</" + tagName + "><" + antiTagName + " " + antiAttributes + ">");
					tagName = antiTagName;
				} else if (el.tagName == tagName) {
					range.pasteHTML("</" + tagName + ">" + htmlCode + "<" + tagName + "/>");
				}
				string elemHtmlCode = el.outerHTML;
				int startIndex = elemHtmlCode.LastIndexOf("</" + tagName + ">", elemHtmlCode.Length - ("</" + tagName + ">").Length);//ищет с конца, не берет тег самого родительского элемента
				elemHtmlCode = elemHtmlCode.Remove(startIndex, ("</" + tagName + ">").Length);
				try {
					el.outerHTML = elemHtmlCode;
				} catch { }
				tagName = "Success";
			}
		}

		private void addOrDelete(string tagName, string antonimTagName = "") {

			IHTMLTxtRange range = htmlDocument.selection.type == "Text" || htmlDocument.selection.type == "None" ? (IHTMLTxtRange)htmlDocument.selection.createRange() : null;
			if (range == null) return;
			if (htmlDocument.selection.type == "None") {
				if (tagName == "H1") {
					range.pasteHTML("<H1></H1>");
					range.select();
				}
				return;
			}
			removeFormatFromMiddle(ref tagName, range);
			if (antonimTagName != "") removeFormatFromMiddle(ref tagName, range, antonimTagName);
			switch (tagName) {
				case "SUP":
					subSubInsertTag(range, tagName, "SUB");
					break;
				case "SUB":
					subSubInsertTag(range, tagName, "SUP");
					break;
				case "Success":
					break;
				default:
					if (range.htmlText.Contains("<" + tagName + ">")) {
						deleteTag(tagName, range);
					} else {
						string htmlCode = range.htmlText;
						insertTag(tagName, htmlCode, range);
					}
					break;
			}

		}

		private void execUserCommand(string command, bool window = false, object value = null) {
			htmlDocument.execCommand(command, window, value);
		}

		private void buttonBold_MouseClick(object sender, EventArgs e) {
			execUserCommand("Bold");
		}

		private void buttonItalic_MouseClick(object sender, EventArgs e) {
			execUserCommand("Italic");
		}

		private void buttonUnderlined_MouseClick(object sender, EventArgs e) {
			execUserCommand("Underline");
		}

		private void buttonStrike_MouseClick(object sender, EventArgs e) {
			addOrDelete("S");
		}

		private void buttonParagraph_MouseClick(object sender, EventArgs e) {
			addOrDelete("P");
		}

		private void buttonH1_MouseClick(object sender, EventArgs e) {
			addOrDelete("H1");
		}

		private void buttonAHref_MouseClick(object sender, EventArgs e) {
			execUserCommand("CreateLink");
		}

		private void buttonImg_MouseClick(object sender, EventArgs e) {
			SelectImage form = new SelectImage();
			form.Show();
			form.FormClosed += new FormClosedEventHandler(delegate(object send, FormClosedEventArgs arg) {

				if (form.address == null) return;
				if (htmlDocument.selection.type == "None") {
					execUserCommand("InsertImage", false, form.address);
				} else {
					HtmlElement img = webBrowser.Document.CreateElement("IMG");
					img.SetAttribute("src", form.address);
					webBrowser.Document.Body.AppendChild(img);
				}
			});



		}

		private void buttonUpIndex_MouseClick(object sender, EventArgs e) {
			addOrDelete("SUP", "SUB");
		}

		private void buttonLowIndex_MouseClick(object sender, EventArgs e) {
			addOrDelete("SUB", "SUP");
		}


		//этот элемент не включен в контрол
		/*private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
		{
			int idUser = comboBoxFont.SelectedIndex;
			try
			{
				comboBoxFont.Font = new Font(comboBoxFont.SelectedFontFamily.Name, 8.25F);
			}
			catch { }
			comboBoxFont.SelectedIndex = idUser;
			comboBoxFont.Focus();
		}*/
		//

		private void buttJustifyCenter_MouseClick(object sender, EventArgs e) {
			execUserCommand("JustifyCenter");
		}


		private void buttJustifyLeft_MouseClick(object sender, EventArgs e) {
			execUserCommand("JustifyLeft");
		}

		private void buttJustifyRight_MouseClick(object sender, EventArgs e) {
			execUserCommand("JustifyRight");
		}

		private void buttJustifyNone_MouseClick(object sender, EventArgs e) {
			execUserCommand("JustifyNone");
		}

		private void setColor(string colorFor) {
			ColorDialog cd = new ColorDialog();
			cd.ShowDialog();
			string color = cd.Color.Name;
			if (color[0] == 'f' && color[1] == 'f')
				color = cd.Color.Name.Substring(2);
			IHTMLTxtRange range = htmlDocument.selection.type == "Text" || htmlDocument.selection.type == "None" ? (IHTMLTxtRange)htmlDocument.selection.createRange() : null;
			if (range == null) return;
			IHTMLElement list = range.parentElement();

			switch (colorFor) {
				case "text":
					if (list.tagName == "OL" || list.tagName == "UL" || (list.tagName == "LI" && list.innerText == range.text)) {
						//list.style.color = color;
						/*foreach (IHTMLElement chil in list.children)
						{
							chil.style.color = color;
						}(*/
						if (range.htmlText.Contains("<FONT")) {
							execUserCommand("ForeColor", false, color);
						}
					} else if (list.parentElement.innerText == range.text && list.tagName == "FONT") {
						while (list.tagName != "BODY" && list.innerText == range.text) {
							if (list.tagName == "LI") {
								list.style.color = color;
								execUserCommand("ForeColor", false, color);
								return;
							}
							list = list.parentElement;
						}
					} else {
						execUserCommand("ForeColor", false, color);
					}
					break;
				case "background":
					execUserCommand("BackColor", false, color);
					break;
			}



		}

		private void buttColorText_MouseClick(object sender, EventArgs e) {
			setColor("text");
		}

		private void buttColorBackground_MouseClick(object sender, EventArgs e) {
			setColor("background");
		}

		private void buttonList_MouseClick(object sender, EventArgs e) {
			execUserCommand("InsertUnorderedList", true);
		}

		private void buttNumericList_MouseClick(object sender, EventArgs e) {
			execUserCommand("InsertOrderedList", true);
		}

		private void buttonTable_MouseClick(object sender, EventArgs e) {
			TableOption tform = new TableOption();
			dynamic tOption = new { rows = 0, columns = 0, border = 0 };
			tform.FormClosed += new FormClosedEventHandler(delegate(object send, FormClosedEventArgs ev) { tOption = tform.returnTableOption(); });
			tform.ShowDialog();

			var doc = webBrowser.Document;
			var body = webBrowser.Document.Body;
			var div = doc.CreateElement("DIV");
			var table = doc.CreateElement("TABLE");
			var tbody = doc.CreateElement("TBODY");
			//table.SetAttribute("border", tOption.border.ToString());

			/*for (int i = 0; i < tOption.rows; i++)
			{
				var row = doc.CreateElement("TR");
				for (int j = 0; j < tOption.columns; j++)
				{
					var cell = doc.CreateElement("TD");
					cell.InnerText = "  ";
					row.AppendChild(cell);
				}
				tbody.AppendChild(row);
			}*/

			table.AppendChild(tbody);
			div.AppendChild(table);
			body.AppendChild(div);

		}

		private void buttDelLink_MouseClick(object sender, EventArgs e) {
			execUserCommand("Unlink");
		}

		private void buttRemoveFormat_MouseClick(object sender, EventArgs e) {
			execUserCommand("RemoveFormat");
		}

		#region addingIndent
		public enum ControlIndent { None, Small, Middle, Big, VeryBig };

		private ControlIndent indent = ControlIndent.None;
		public ControlIndent Indent {
			get {
				return indent;
			}
			set {
				indent = value;
				if (indent == ControlIndent.None) {
					this.Margin = new Padding(0);
					return;
				}
				if (indent == ControlIndent.Small) {
					this.Margin = new Padding(Const.CONTROL_INDENT_SMALL);
					return;
				}
				if (indent == ControlIndent.Middle) {
					this.Margin = new Padding(Const.CONTROL_INDENT_MIDDLE);
					return;
				}
				if (indent == ControlIndent.Big) {
					this.Margin = new Padding(Const.CONTROL_INDENT_BIG);
				}
				if (indent == ControlIndent.VeryBig) {
					this.Margin = new Padding(Const.CONTROL_INDENT_VERY_BIG);
				}
			}
		}
		#endregion
	}
}
