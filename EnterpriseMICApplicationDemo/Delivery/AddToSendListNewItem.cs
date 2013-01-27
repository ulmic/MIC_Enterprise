using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Add to send list new item form
	/// </summary>
	public partial class AddToSendListNewItem : EnterpriseMICApplicationMiniForm {
		private const string TYPE_ADD_FROM_DATA_BASE = "Из базы данных";
		private const string TYPE_ADD_NEW_EMAIL = "Новый Email";

		private const string MESSAGE_ERROR = "Не все поля заполнены";

		private enum typeAdd { fromDataBase, newEmail };
		private typeAdd typeAddStatus {
			get {
				if (EmailTextBox.Enabled) {
					return typeAdd.newEmail;
				}
				return typeAdd.fromDataBase;
			}
			set {
				if (value == typeAdd.fromDataBase) {
					EmailTextBox.Enabled = false;
				} else {
					EmailTextBox.Enabled = true;
				}
			}
		}

		public AddToSendListNewItem() {
			InitializeComponent();
			NameTextBox.DisText = "ФИО";
			EmailTextBox.DisText = "E-mail";
			chooseComboBox.DisText = "Выбрать список";
			chooseComboBox.Items.AddRange(Program.Data.GetAllSendLists());
			typeAddDisComboBox.Items.AddRange(new string[] { TYPE_ADD_FROM_DATA_BASE, TYPE_ADD_NEW_EMAIL });
			typeAddDisComboBox.DisText = "Тип добавления";
			typeAddDisComboBox.SelectedValueChanged += new EventHandler(typeAddDisComboBox_SelectedValueChanged);
		}

		private void typeAddDisComboBox_SelectedValueChanged(object sender, EventArgs e) {
			if (typeAddDisComboBox.SelectedItem.ToString() == TYPE_ADD_FROM_DATA_BASE) {
				typeAddStatus = typeAdd.fromDataBase;
				return;
			}
			typeAddStatus = typeAdd.newEmail;
		}

		private void AddButton_Click(object sender, EventArgs e) {
			if ((NameTextBox.TextWasChanged == false) || (chooseComboBox.SelectedIndex == Const.THEREISNOT) || 
				(typeAddDisComboBox.SelectedIndex == Const.THEREISNOT)) {
				MessageBox.Show(MESSAGE_ERROR);
				return;
			}
			if ((typeAddStatus == typeAdd.newEmail) && (EmailTextBox.TextWasChanged == false)) {
				MessageBox.Show(MESSAGE_ERROR);				
				return;
			}
			if (typeAddStatus == typeAdd.fromDataBase) {
				AddNewItemFromDataBase();
				this.Close();
			}
			AddNewEmailToDataBase();
			this.Close();
		}

		private void AddNewItemFromDataBase() {
			if (Member_DB.FindUserByFIO(chooseComboBox.SelectedItem.ToString(), NameTextBox.Text) == false) {
				MessageBox.Show("Такого пользователя не существует");
				return;
			}
		}

		private void AddNewEmailToDataBase() {
			
		}
	}
}