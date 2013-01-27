using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Select Image Form for MyPressReleaseControl
	/// </summary>
	public partial class SelectImage : EnterpriseMICApplicationMiniForm {
		const string IMGUR_API_KEY = "3d5907509d22a3130787a91bbb3c9189";

		private string _address;

		public string address {
			get { return _address; }
			set { }
		}

		public SelectImage() {
			InitializeComponent();
		}

		private void buttonOpenFile_Click(object sender, EventArgs e) {
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName.Trim() != "")
				addressBox.Text = openFileDialog1.FileName;
		}

		private void buttonClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void changeValueEnabled() {
			progressBar.Visible = !progressBar.Visible;
			buttonInsertImg.Visible = !buttonInsertImg.Visible;
			buttonOpenFile.Enabled = !buttonOpenFile.Enabled;
			addressBox.Enabled = !addressBox.Enabled;
		}

		public void PostToImgur(string filename) {
			changeValueEnabled();
			Bitmap bitmap = new Bitmap(filename);
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Jpeg);
			using (var w = new WebClient()) {
				w.UploadProgressChanged += new UploadProgressChangedEventHandler(delegate(object send, UploadProgressChangedEventArgs arg) {
						int percent = arg.ProgressPercentage;
						progressBar.Value = percent > 0 ? (percent < 45 ? percent * 2 : (percent >= 90 ? percent : 90)) : 0;
					});
				this.FormClosing += new FormClosingEventHandler(delegate(object send, FormClosingEventArgs arg) {
						w.CancelAsync();
					});
				var values = new NameValueCollection
				{
					{ "key", IMGUR_API_KEY },
					{ "image", Convert.ToBase64String(memoryStream.ToArray()) }
				};
				string debug = values.ToString();
				byte[] response = new byte[0];
				w.UploadValuesCompleted += new UploadValuesCompletedEventHandler(delegate(object send, UploadValuesCompletedEventArgs arg) {
					if (arg.Cancelled) return;
					response = arg.Result;
					XDocument xDocument = XDocument.Load(new MemoryStream(response).ToString());
					bitmap.Dispose();
					_address = (string)xDocument.Root.Element("original_image");
					this.Close();
				});
				w.UploadValuesAsync(new Uri("http://imgur.com/api/upload.xml"), values);
				buttonClose.Click -= buttonClose_Click;
				buttonClose.Click += new EventHandler(delegate(object send, EventArgs arg) {
						w.CancelAsync();
						changeValueEnabled();
						buttonClose.Click += buttonClose_Click;
					});
			}

		}

		private void buttonInsertImg_Click(object sender, EventArgs e) {
			string testAddress = addressBox.Text.Trim();
			if (testAddress.Length > 1)
				if (testAddress[1] == ':' && Regex.IsMatch(testAddress, @"^[a-zA-Z]:\\([^\/:*""\^?<>,].(jpg|png|bmp|gif|JPG|BMP|PNG|GIF))|([^\/:*""\^?<>,]+.(jpg|png|bmp|gif|JPG|BMP|PNG|GIF))$")) {
					if (File.Exists(testAddress)) {
						try {
							PostToImgur(testAddress);
						} catch (System.Exception ex) {
							MessageBox.Show("При добавлении изображения произошла ошибка. Подробнее:\n" + ex.ToString());
							changeValueEnabled();
						}
					}
				} else {
					MessageBox.Show("Адрес изображения введен некорректно");
					return;
				} else {
				_address = testAddress;
				this.Close();
			}
		}

		private void addressBox_DoubleClick(object sender, EventArgs e) {
			addressBox.SelectAll();
		}
	}
}