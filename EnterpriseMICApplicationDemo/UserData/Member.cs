using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
			Member m = Member_DB.GetMemberAttrWithOneQuery(userId);
		}

		public Member(int userId, string userLogin, string userPassword) {
			Id = userId;
			Login = userLogin;
			Password = userPassword;
			Functions = new bool[Const.FUNCTIONS_COUNT];
			giveFunctions();
			Member m = Member_DB.GetMemberAttrWithOneQuery(userId);
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
			Family = Member_DB.GetFamily(Id);
			FirstName = Member_DB.GetFirstName(Id);
			LastName = Member_DB.GetLastName(Id);
			Number = Member_DB.GetNumber(Id);
			Local = Member_DB.GetLocal(Id);
			BDate = Member_DB.GetBDate(Id);
			Education = Member_DB.GetEducation(Id);
			Job = Member_DB.GetJob(Id);
			EnterDate = Member_DB.GetEnterDate(Id);
			Index_Adress = Member_DB.GetIndexAdress(Id);
			State = Member_DB.GetState(Id);
			City = Member_DB.GetCity(Id);
			Home_Adress = Member_DB.GetHomeAdress(Id);
			Contacts = Member_DB.GetContacts(Id);
			Enter_Mark = Member_DB.GetEnterMark(Id);
			Change_Date = Member_DB.GetChangeDate(Id);
			God_Father = Member_DB.GetGodFather(Id);
			Post = Member_DB.GetPost(Id);
			Email = Member_DB.GetEmail(Id);
		}
	}
}