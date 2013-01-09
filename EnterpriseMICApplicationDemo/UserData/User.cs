using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnterpriseMICApplicationDemo {
  public class User {
    public int Index;
    public string Login;
    public string Password;
    public string Email;
    public string EmailPassword;
    public string Name;
    public string Post;
    public string FullName;

    public bool[] Functions = new bool[Const.FUNCTIONS_COUNT];

    public string[] Params;

    private Distribution.Level userLevel;

    public User() {
      Params = new string[] { Login, Password, Email, EmailPassword, Name, Post, FullName };
    }

    public User(string param) {
      if (param.Contains('@')) {
        getUserByIndex(getIndexByParam(param, Const.EMAIL));
      }
    }

    public User(int userIndex) {
      getUserByIndex(userIndex);
    }

    private void getUserByIndex(int index) {
      Index = index;
      Login = AnyCatches.ReadAllLines("login.txt", System.Text.Encoding.Default)[index];
      Password = AnyCatches.ReadAllLines("password.txt", System.Text.Encoding.Default)[index];
      Email = AnyCatches.ReadAllLines("email.txt", System.Text.Encoding.Default)[index];
      Name = AnyCatches.ReadAllLines("user.txt", System.Text.Encoding.Default)[index];
      Post = AnyCatches.ReadAllLines("post.txt", System.Text.Encoding.Default)[index];
      FullName = AnyCatches.ReadAllLines("fullName.txt", System.Text.Encoding.Default)[index];
      if ((AnyCatches.IfThereIsNot(Login)) || (AnyCatches.IfThereIsNot(Password)) || (AnyCatches.IfThereIsNot(Email)) ||
          (AnyCatches.IfThereIsNot(Name)) || (AnyCatches.IfThereIsNot(Post)) || (AnyCatches.IfThereIsNot(FullName))) {
        return;
      }
      for (int i = 0; i < Functions.Length; i++) {
        Functions[i] = false;
      }
      Distribution.SetLevel(ref userLevel, Int32.Parse(AnyCatches.ReadAllLines("level.txt", System.Text.Encoding.Default)[index]));
      Distribution.SetFunctions(userLevel, ref Functions);
    }

    private int getIndexByParam(string param, int paramType) {
      string[] parametrs = null;
      if (paramType == Const.EMAIL) {
        parametrs = AnyCatches.ReadAllLines(@"email.txt", System.Text.Encoding.Default);
      }
      if (AnyCatches.IfThereIsNot(parametrs)) {
        return Const.THEREISNOT;
      }
      for (int i = 0; i < parametrs.Length; i++) {
        if (parametrs[i] == param) {
          return i;
        }
      }
      return Const.THEREISNOT;
    }
  }
}