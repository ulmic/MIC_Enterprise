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

		public string Family { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName {
			get {
				return Family + FirstName + LastName;
			}
		}
		public string Appeal {
			get {
				return Family + FirstName;
			}
		}
		public int Number { get; set; }
		public string Local { get; set; }
		public DateTime BDate { get; set; }
		public string Education { get; set; }
		public string Job { get; set; }
		public DateTime EnterDate { get; set; }
		public int IndexAdress { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public string Area { get; set; }
		public string HomeAdress { get; set; }
		public string Contacts { get; set; }
		public string EnterMark { get; set; }
		public DateTime ChangeDate { get; set; }
		public int GodFather { get; set; }
		public string Post { get; set; }
		public string Email { get; set; }

		#endregion

		public Member() { }

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
			  + "\n" + Job + "\n" + EnterDate + "\n" + IndexAdress + State + City + Area + HomeAdress + "\n" +
			  Contacts + "\n" + EnterMark + "\n" + ChangeDate + "\n" + GodFather + "\n" + Post + "\n" + Email;
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
			IndexAdress = Member_DB.GetIndexAdress(Id);
			State = Member_DB.GetState(Id);
			City = Member_DB.GetCity(Id);
			HomeAdress = Member_DB.GetHomeAdress(Id);
			Contacts = Member_DB.GetContacts(Id);
			EnterMark = Member_DB.GetEnterMark(Id);
			ChangeDate = Member_DB.GetChangeDate(Id);
			GodFather = Member_DB.GetGodFather(Id);
			Post = Member_DB.GetPost(Id);
			Email = Member_DB.GetEmail(Id);
		}
	}
}