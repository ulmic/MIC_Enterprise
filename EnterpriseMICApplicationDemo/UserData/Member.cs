using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseMICApplicationDemo {

  class Short {
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

  public class Member {
    public string Family { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
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
    public string ChangeDate { get; set; }
    public int GodFather { get; set; }
    public string Post { get; set; }
    public string Email { get; set; }

    public override string ToString() {
      return Family + " " + FirstName + " " + LastName + "\n" + BDate + "\n" + Number + "\n" + Local + "\n" + Education
        + "\n" + Job + "\n" + EnterDate + "\n" + IndexAdress + State + City + Area + HomeAdress + "\n" +
        Contacts + "\n" + EnterMark + "\n" + ChangeDate + "\n" + GodFather + "\n" + Post + "\n" + Email;
    }
  }
}