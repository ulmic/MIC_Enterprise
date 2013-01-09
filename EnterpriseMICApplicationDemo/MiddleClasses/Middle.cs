using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseMICApplicationDemo {
  public class Middle {
    public User MainUser;
    private Idea ideas;
    private Task tasks;
    private DBHelper help;
    private SendingLists lists;

    public Middle() { 
    }

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

    public void InitUser(int userIndex) {
      MainUser = new User(userIndex);
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
      m.EnterMark = thereIsNotData(m.EnterMark);
      m.Family = thereIsNotData(m.Family);
      m.FirstName = thereIsNotData(m.FirstName);
      m.HomeAdress = thereIsNotData(m.HomeAdress);
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
      return help.GetMember(member.GodFather);
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

    public string[] GetAllSendLists() {
      lists = new SendingLists();
      return lists.getTitles().ToArray<string>();
    }

    public string[] GetSendList(string title) {
      /* ХУЙНЯ */
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
      lists = new SendingLists();
      return lists.getNameAndEmails(title).ToArray<string>();
    }
  }
}