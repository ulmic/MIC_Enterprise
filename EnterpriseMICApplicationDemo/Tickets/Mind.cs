using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnterpriseMICApplicationDemo {
  public class Mind {

    private string[] minds;
    private DateTime[] dates;

    protected string path = "";

    protected bool Date = Const.YES;

    public Mind() {
    }

    public Mind(int count) {
      InitEmptyMinds(count);
    }

    private void InitEmptyMinds(int count) {
      minds = new string[count];
    }

    protected void getAllMinds() {
      string[] datas = File.ReadAllLines(@path, Encoding.Default);
      for (int i = 0; i < datas.Length; i++) {
        datas[i] = ParseMindsToRead(datas[i]);
      }
      if (Date) {
        string[] temp = datas;
        minds = new string[temp.Length];
        dates = new DateTime[temp.Length];
        for (int i = 0; i < temp.Length; i++) {
          minds[i] = temp[i].Split('>')[0];
          string date = temp[i].Split('>')[1];
          if (date.Length > 0) {
            dates[i] = new DateTime(Int32.Parse(date.Split(':')[0]), Int32.Parse(date.Split(':')[1]), Int32.Parse(date.Split(':')[2]),
                                    Int32.Parse(date.Split(':')[3]), Int32.Parse(date.Split(':')[4]), Int32.Parse(date.Split(':')[5]));
          }
        }
        return;
      }
      minds = datas;
    }

    public string this[int i] {
      get {
        return minds[i];
      }
      set {
        minds[i] = value;
      }
    }

    public int Length {
      get {
        return minds.Length;
      }
    }

    protected void RemoveMind(int index, string path) {
      List<string> temp = minds.ToList<string>();
      temp.RemoveAt(index);
      minds = temp.ToArray();
      File.WriteAllLines(@path, minds, Encoding.Default);
    }

    protected void AddMind(string newMind, string path) {
      List<string> temp = minds.ToList<string>();
      temp.Add(newMind);
      minds = temp.ToArray();
      File.WriteAllLines(@path, minds, Encoding.Default);
    }

    protected void Clear() {
      minds = new string[0];
    }

    protected void SaveMinds() {
      File.WriteAllLines(@path, minds, Encoding.Default);
    }

    protected void SaveMinds(string[] text) {
      if (text == null) {
        return;
      }
      File.WriteAllLines(@path, text, Encoding.Default);
    }

    public bool AnyEqual(string text) {
      return minds.Any(p => p == text);
    }

    protected string ParseMindsToWrite(string mind) {
      return mind.Replace('\n', '\t');
    }

    protected string ParseMindsToRead(string mind) {
      return mind.Replace('\t', '\n');
    }
  }
  
  public class Idea : Mind {
    public Idea() {
      path = "ideas.txt";
      Date = Const.NO;
      getAllMinds();
    }

    public void RemoveIdea(int index) {
      RemoveMind(index, path);
    }

    public void AddIdea(string newIdea) {
      AddMind(newIdea, path);
    }
    
    public void SaveIdeas() {
      SaveMinds();
    }

    public void SaveIdeas(string[] cardsText) {
      SaveMinds(cardsText);
    }

    public string ParseIdeaToWrite(string idea) {
      return ParseMindsToWrite(idea);
    }

    public string ParseIdeaToRead(string idea) {
      return ParseMindsToRead(idea);
    }
  }

  public class Task : Mind {
    public Task() {
      path = "tasks.txt";
      getAllMinds();
    }

    public void RemoveTask(int index) {
      RemoveMind(index, path);
    }

    public void AddTask(string newTask) {
      AddMind(newTask, path);
    }

    public void SaveTasks() {
      SaveMinds();
    }

    public void SaveTasks(string[] cardsText) {
      /*
       * bad code
       */
      if (cardsText != null) {
        for (int i = 0; i < cardsText.Length; i++) {
          cardsText[i] += ">";
        }
      }
      SaveMinds(cardsText);
    }

    public string ParseTaskToWrite(string task) {
      return ParseMindsToWrite(task);
    }

    public string ParseTaskToRead(string task) {
      return ParseMindsToRead(task);
    }
  }
}