using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseMICApplicationDemo {
	/// <summary>
	/// Middle Class of Appliction
	/// Only global application object
	/// </summary>
	public class Middle {
		public Member MainUser;
		private Idea ideas;
		private Task tasks;
		private DBHelper help;
		private SendingLists lists;

		public Middle() {
		}

		#region Idea and Tasks Functions

		public void InitIdeas() {
			ideas = new Idea();
		}

		public void InitTasks() {
			tasks = new Task();
		}

		public void InitMinds() {
			InitIdeas();
			InitTasks();
		}

		public bool AnyMindEqual(string mind, int type) {
			if (type == Const.IDEA) {
				return ideas.AnyEqual(mind);
			}
			return false;
		}
		/*
		 * Написать защиту от Enter '\n'
		 */
		public void AddMind(string mind, int type) {
			if (type == Const.IDEA) {
				ideas = new Idea();
				ideas.AddIdea(ideas.ParseIdeaToWrite(mind));
			}
			if (type == Const.TASK) {
				tasks = new Task();
				tasks.AddTask(tasks.ParseTaskToWrite(mind));
			}
		}

		public int IdeasCount {
			get {
				return ideas.Length;
			}
		}

		public int TasksCount {
			get {
				return tasks.Length;
			}
		}

		public string IdeaTextAt(int index) {
			return ideas[index];
		}

		public string TasksTextAt(int index) {
			return tasks[index];
		}

		public void RemoveIdeaAt(int index) {
			ideas.RemoveIdea(index);
		}

		public void SaveTasks(string[] cardsText) {
			//tasks.SaveTasks(cardsText);
		}

		public void SaveIdeas(string[] cardsText) {
			//ideas.SaveIdeas(cardsText);
		}

		#endregion

		#region Corporate Functions

		public void SetMainUser(int userIndex, string userLogin, string userPassword) {
			MainUser = new Member(userIndex, userLogin, userPassword);
		}

		public string[] GetMICLocals() {
			help = new DBHelper();
			return help.GetLocals().ToArray<string>();
		}

		public string[] GetMICMembersByLocal(string local) {
			return help.GetShort(local).ToArray<string>();
		}

		private string thereIsNotData(string data) {
			if (data == "") {
				return "Нет данных";
			}
			return data;
		}

		private Member checkDataInMember(Member m) {
			m.Area = thereIsNotData(m.Area);
			m.City = thereIsNotData(m.City);
			m.Contacts = thereIsNotData(m.Education);
			m.Enter_Mark = thereIsNotData(m.Enter_Mark);
			m.Family = thereIsNotData(m.Family);
			m.FirstName = thereIsNotData(m.FirstName);
			m.Home_Adress = thereIsNotData(m.Home_Adress);
			m.Job = thereIsNotData(m.Job);
			m.LastName = thereIsNotData(m.LastName);
			m.Local = thereIsNotData(m.Local);
			m.Post = thereIsNotData(m.Post);
			m.State = thereIsNotData(m.State);
			m.Email = thereIsNotData(m.Email);
			return m;
		}

		public Member GetMICGodFather(Member member) {
			help = new DBHelper();
			return help.GetMember(member.God_Father);
		}

		public Member GetMICMember(int numberMember) {
			help = new DBHelper();
			return checkDataInMember(help.GetMember(numberMember));
		}

		public void PutInSameCityMembers(string city) {
			help = new DBHelper();
			Program.MainWindow.PutInMemberListBoxSameCityMembers(help.GetSameCityPeople(city));
		}

		public void PutInSameBDayMembers(DateTime date) {
			help = new DBHelper();
			Program.MainWindow.PutInMembersListBoxSameBDateMembers(help.GetSameBDayShorts(date));
		}

		public void PutInSameEnterDateMembers(DateTime date) {
			help = new DBHelper();
			Program.MainWindow.PutInMembersListBoxSameEnterDateMembers(help.GetSameEnterDayShorts(date));
		}

		public void PutInGodFather(Member member) {
			help = new DBHelper();
			Program.MainWindow.PutInMemberCardGodFather(GetMICGodFather(member));
		}

		#endregion

		#region SendList Functions

		public string[] GetAllSendLists() {
			lists = new SendingLists();
			return lists.getTitles().ToArray<string>();
		}

		public string[] GetSendList(string title) {
			throw new NotImplementedException();
		}

		public int GetNumberOfSendLists() {
			lists = new SendingLists();
			return lists.getTitles().Count;
		}

		public string[] PutInSendLists() {
			lists = new SendingLists();
			return lists.getTitles().ToArray<string>();
		}

		public string[] PutInMembersLists(string title) {
			return SendingList.GetFromDataBase(title).ToArray<string>();
		}

		#endregion
	}
}