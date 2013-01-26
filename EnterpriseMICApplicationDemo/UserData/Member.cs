using System;
using System.Collections.Generic;

namespace EnterpriseMICApplicationDemo {
	public class Short : User {
		public string Family { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Number { get; set; }
		public string Email { get; set; }

		public Short(string _family, string _firstName, string _lastName, int _number, string _email) {
			Family = _family;
			FirstName = _firstName;
			LastName = _lastName;
			Number = _number;
			Email = _email;
		}

		public override string ToString() {
			return Number + " " + Family + " " + FirstName + " " + LastName + " " + Email;
		}
	}

	/// <summary>
	/// Member of MIC class
	/// </summary>
	public class Member : User {
		#region Member Attrs

		public string Family;
		public string FirstName;
		public string LastName;
		public string FullName {
			get {
				return Family + " " + FirstName + " " + LastName;
			}
		}
		public string Appeal {
			get {
				return FirstName + " " + Family;
			}
		}
		public int Number;
		public string Local;
		public DateTime BDate { get; set; }
		public string Education;
		public string Job;
		public DateTime EnterDate { get; set; }
		public int Index_Adress;
		public string State;
		public string City;
		public string Area;
		public string Home_Adress;
		public string Contacts;
		public string Enter_Mark;
		public DateTime Change_Date;
		public int God_Father;
		public string Post;
		public string Email;

		#endregion

		public Member() { }

		public Member(int userId) {
			Id = userId;
			Login = Login_DB.GetUserById(userId).Login;
			Password = Login_DB.GetUserById(userId).Password;
			getMemberByUserId();
		}

		public Member(int userId, string userLogin, string userPassword) {
			Id = userId;
			Login = userLogin;
			Password = userPassword;
			Functions = new bool[Const.FUNCTIONS_COUNT];
			giveFunctions();
			getMemberByUserId();
		}
		
		public override string ToString() {
			return Family + " " + FirstName + " " + LastName + "\n" + BDate + "\n" + Number + "\n" + Local + "\n" + Education
			  + "\n" + Job + "\n" + EnterDate + "\n" + Index_Adress + State + City + Area + Home_Adress + "\n" +
			  Contacts + "\n" + Enter_Mark + "\n" + Change_Date + "\n" + God_Father + "\n" + Post + "\n" + Email;
		}

		private void giveFunctions() {
			for (int i = 0; i < Functions.Length; i++) {
				Functions[i] = false;
			}
			Distribution.SetLevel(ref userLevel, Member_DB.GetUserLevel(Id));
			Distribution.SetFunctions(userLevel, ref Functions);
		}

		private void getMemberByUserId() {
			Member m = Member_DB.GetMemberAttrWithOneQuery(Id);
			Family = m.Family;
			FirstName = m.FirstName;
			LastName = m.LastName;
			Number = m.Number;
			Local = m.Local;
			BDate = m.BDate;
			Education = m.Education;
			Job = m.Job;
			EnterDate = m.EnterDate;
			Index_Adress = m.Index_Adress;
			State = m.State;
			City = m.City;
			Home_Adress = m.Home_Adress;
			Contacts = m.Contacts;
			Enter_Mark = m.Enter_Mark;
			Change_Date = m.Change_Date;
			God_Father = m.God_Father;
			Post = m.Post;
			Email = m.Email;
		}
	}
}