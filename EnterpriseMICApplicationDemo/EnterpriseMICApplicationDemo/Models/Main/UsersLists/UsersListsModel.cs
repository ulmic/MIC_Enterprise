using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseMICApplicationDemo.Models.Main.UsersLists {
    class UsersListsModel {

        public UsersListsModel() { }

        public List<Organization> getOrganizations() {
            DBRequest db = new DBRequest();
            List<Organization> organizations = new List<Organization>(from organizationName in db.getOrganizations()
                                                                      let organization = new Organization(organizationName)
                                                                      select organization);
            return organizations;
        }
    }
}
