using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EnterpriseMICApplicationDemo.Models.Global.Infrastructure;

namespace EnterpriseMICApplicationDemo.Models.Global.UserData
{
    public class Member
    {
        #region Member Attrs
        public int Id;
        public string LastName;
        public string FirstName;
        public string Patronymic;
        public string FullName
        {
            get
            {
                return LastName + " " + FirstName + " " + Patronymic;
            }
        }
        public string Appeal
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int Number;
        public string Local;
        public DateTime BDate { get; set; }
        public string Education;
        public string Job;
        public DateTime EnterDate { get; set; }
        public int IndexAdress;
        public string State;
        public string City;
        public string Area;
        public string HomeAdress;
        public string Contacts;
        public string EnterMark;
        public string ChangeDate;
        public int GodFather;
        public string Post;
        public string Email;
        #endregion

        public Member() { }

        public Member(Dictionary<int, string> memberInfo)
        {            
            Id = Int32.Parse(memberInfo[0]);
            LastName = memberInfo[DBAttributes.LastName];
            FirstName = memberInfo[DBAttributes.FirstName];
            Patronymic = memberInfo[DBAttributes.Patronymic];
            Number = Int32.Parse(memberInfo[DBAttributes.Number]);
            Local = memberInfo[DBAttributes.Local];
            try {
                BDate = new DateTime(Int32.Parse(memberInfo[DBAttributes.BYear]),
                                        Int32.Parse(memberInfo[DBAttributes.BMonth]),
                                        Int32.Parse(memberInfo[DBAttributes.BDay]));
            } catch (Exception ex) {}
            Education = memberInfo[DBAttributes.Education];
            Job = memberInfo[DBAttributes.Job];
            try {
                EnterDate = new DateTime(Int32.Parse(memberInfo[DBAttributes.EnterYear]),
                                        Int32.Parse(memberInfo[DBAttributes.EnterMonth]),
                                        Int32.Parse(memberInfo[DBAttributes.EnterDay]));
            } catch (Exception ex) {}
            IndexAdress = Int32.Parse(memberInfo[DBAttributes.IndexAdress]);
            State = memberInfo[DBAttributes.State];
            City = memberInfo[DBAttributes.City];
            Area = memberInfo[DBAttributes.Area];
            HomeAdress = memberInfo[DBAttributes.HomeAdress];
            Contacts = memberInfo[DBAttributes.Contacts];
            EnterMark = memberInfo[DBAttributes.EnterMark];
            ChangeDate = memberInfo[DBAttributes.ChangeDate];
            GodFather = Int32.Parse(memberInfo[DBAttributes.GodFather]);
            Post = memberInfo[DBAttributes.Post];
            Email = memberInfo[DBAttributes.Email];
        }
    }
}
