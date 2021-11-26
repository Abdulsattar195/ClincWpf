using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Data.SqlClient;

namespace CLINICwpv0
{
    class Connect
    {
        public string sqlselect = "SELECT * FROM USER_TBL where USER_NAME=@uname  And USER_PASSWORD=@upass";
        

        public bool  check(string name,string password)
        {
            var ConnectionString = "Server=ABDULSATTAR-PC\\ABDULSATAR95;Database=CLINIC_DB;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (var con = new SqlConnection(ConnectionString))
            {
                var user = con.Query(sqlselect,new { uname = name ,upass=password}).ToList();
                if (user.Count > 0)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
