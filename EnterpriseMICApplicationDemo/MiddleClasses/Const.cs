using System;
using System.Collections.Generic;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Const class. 
	/// There are many const values, which is used in the application.
	/// </summary>
	static public class Const {

		#region UI_Constants

		/// <summary>
		/// Языки
		/// </summary>
		public const int ENGLISH_LANGUAGE = 1;

		public const int LOCALS = 0;
		public const int MEMBERS = 1;

		public const int LISTS = 0;
		public const int MEMBERS_LIST = 1;

		public const float WIDTH_LEFT_FUNCTION_PANEL = 230F;

		public const int FUNCTION_PANEL_INDENT = 20;
		public const int CONTROL_INDENT_SMALL = 5;
		public const int CONTROL_INDENT_MIDDLE = 10;
		public const int CONTROL_INDENT_BIG = 15;
		public const int CONTROL_INDENT_VERY_BIG = 30;

		public const int MEMBERCARD_SIZE = 500;

		public const int TITLE_LISTBOX_SENDLISTS = 0;
		public const int TITLE_LISTBOX_MEMBERS_SENDLIST = 1;

		public const int LIST_DELIVERY = 0;
		public const int ONCE_MAIL = 1;

		public const int IDEA = 0;
		public const int TASK = 1;
		public const string BOTTOM_BUTTON_ADD_TASK = "Добавить задачу";
		#endregion

		#region AUTH_DATAS_LENGTH

		/// <summary>
		/// Длины вводимых данных
		/// </summary>
		public const int LOGIN_LENGHT = 3;
		public const int PASSWORD_LENGHT = 3;

		#endregion

		#region Message Types

		/// <summary>
		/// Типы сообщений интерфейса
		/// </summary>
		public const int BAD_MESSAGE = 0;
		public const int GOOD_MESSAGE = 1;

		#endregion

		#region App Files

		public const string adressRememberUserFile = "userRemember.txt";

		#endregion

		#region App Constants

		/// <summary>
		/// Рабочая переменная.
		/// </summary>
		public const int THEREISNOT = -1;

		public const bool YES = true;
		public const bool NO = false;

		#endregion

		#region App Main Functions

		/// <summary>
		/// Функции.
		/// </summary>
		public const int VIEW_USER_DATA = 0;
		public const int CREATE_NEW_DELIVERY = 1;
		public const int ONLINE_CONFERENCE = 2;

		/// <summary>
		/// Количество фукнций в приложении
		/// </summary>
		public const int FUNCTIONS_COUNT = 3;

		/// <summary>
		/// Функция: VIEW_USER_DATA
		/// </summary>
		public const string BOTTOM_BUTTON_VIEW = "Сменить пользователя";
		public const int FULL_NAME_VIEW = 0;
		public const int POST_VIEW = 1;
		public const int TITLE_LISTBOX_LOCALS = 2;
		public const int TITLE_LISTBOX_MEMBERS = 3;
		public const int TITLE_MEMBERCARD = 4;

		/// <summary>
		/// Функция: CREATE_NEW_DELIVERY
		/// </summary>
		public const string BOTTOM_BUTTON_CREATE_NEW_DELIVERY = "Сделать рассылку";

		#endregion

		#region Corporate

		/// <summary>
		/// Названия МИЦ в разных падежах
		/// </summary>
		public const string FULL_MIC_GENITIVE = "УОМОО \"МИЦ\"";

		#endregion

		#region Users

		/// <summary>
		/// Имеет или не имеет пользователь функцию
		/// </summary>
		public const bool GOT = true;
		public const bool NOT_GOT = false;

		#endregion

		#region DB

		/// <summary>
		/// DB Attributes
		/// </summary>
		public const string DB_NAME = "mic_enterprise";
		public const string DB_USER = "root";
		public const string DB_USER_PASSWORD = "";
		public const string DATA_SOURCE = "localhost";
		public const string ALL_ATTRS = "*";

		/// <summary>
		/// DB Tables
		/// </summary>
		public const string USERS_TABLE = "users";
		public const string USER_VALUES_TABLE = "uservalues";
		public const string ATTRIBUTES_TABLE = "attributes";

		/// <summary>
		/// User Attributes
		/// </summary>
		public const string FAMILY = "family";
		public const string FIRST_NAME = "firstName";
		public const string LAST_NAME = "lastName";
		public const string NUMBER = "number";
		public const string LOCAL = "local";
		public const string B_DATE = "b_day,b_month,b_year";
		public const string EDUCATION = "education";
		public const string JOB = "job";
		public const string ENTER_DATE = "enter_day,enter_month,enter_year";
		public const string INDEX_ADRESS = "index_adress";
		public const string STATE = "state";
		public const string CITY = "city";
		public const string HOME_ADRESS = "home_adress";
		public const string CONTACTS = "contacts";
		public const string ENTER_MARK = "enter_mark";
		public const string CHANGE_DATE = "change_date";
		public const string GOD_FATHER = "god_father";
		public const string POST = "post";
		public const string USER_LEVEL = "userId";
		public const string EMAIL = "email";

		public const string ID_USER_COLUMN = "id_user";

		#endregion
	}
}