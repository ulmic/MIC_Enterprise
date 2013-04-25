using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EnterpriseMICApplicationDemo.Models.Global.Infrastructure;
using EnterpriseMICApplicationDemo.Models.Global.UserData;

namespace EnterpriseMICApplicationDemo.Models.Main.UsersLists {
    class Organization {
        public string NameLocalBranch;
        private List<Member> members;

        public List<Member> Members {
            get {
                if (members == null) {
                    members = new List<Member>();//getMembers();
                }
                return members;
            }
            set {
                members = value;
            }
        }

        public List<Member> getMembers() {
            DBRequest db = new DBRequest();
            List<Member> members = new List<Member>();
            List<Dictionary<int, string>> membersInfos = db.getMembersBy(NameLocalBranch);
            foreach (var memberInfo in membersInfos) {
                members.Add(new Member(memberInfo));
            }
            return members;
        }

        public Organization() {
        }

        public Organization(string nameOrg) {
            NameLocalBranch = nameOrg;
        }

        public override string ToString() {
            return NameLocalBranch;
        }
    }
}
