using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseMICApplicationDemo.Models
{
    public class DBMapper
    {
        public List<string> listDB = new List<string>() { "str1", "str2", "str3" };

        public string nhb = @"SELECT t1.id_user, t1.id_attr, t1.value
                            FROM uservalues AS t1
                            INNER JOIN uservalues AS t2 ON t1.id_user = t2.id_user
                            WHERE (
                            t2.value =  'Ульяновское городское отделение'
                            AND t2.id_attr = 1
                            )
                            AND (
                            t1.id_attr = 2
                            OR t1.id_attr = 3
                            OR t1.id_attr = 4
                            )
                            ORDER BY id_user";//где t2.id_attr=1 - local, t1.id_attr=2 - family ,t1.id_attr=3 - firstName ,t1.id_attr=4 - lastName 
    }
}
