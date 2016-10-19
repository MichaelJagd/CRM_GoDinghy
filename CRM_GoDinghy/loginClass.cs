using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRM_GoDinghy
{
    class loginClass
    {
        private SqlConnection conn = new SqlConnection("Data Source=(Local);Initial Catalog=GoDinghyDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlDataReader sqlReader;
        userClass userObj = new userClass();

        public string loginCheck(string intital, string password)
        {
            conn.Open();
            string Message = null;
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = "EXEC dbo.spLogin N'" + intital + "',N'" + password + "'";
            sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();
            if (sqlReader.HasRows)
            {
                Message = sqlReader["Message"].ToString();
                if (string.IsNullOrEmpty(sqlReader["Id"].ToString()))
                {
                    conn.Close();
                    return Message;
                }
                userObj.ID = int.Parse(sqlReader["Id"].ToString());
            }
            conn.Close();
            loginUserData();
            return Message;
        }
        private void loginUserData()
        {
            conn.Open();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = "Select * from UsersTable";
            sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();
            if (sqlReader.HasRows)
            {
                userObj.FirstName = sqlReader["FirstName"].ToString();
                userObj.LastName = sqlReader["LastName"].ToString();
                userObj.Initials = sqlReader["Initials"].ToString();
                userObj.IsAdminUser = (bool)sqlReader["IsAdmin"];
                userObj.IsNormalUser = (bool)sqlReader["IsNormal"];
                userObj.IsLoggedIn = true;
            }
            conn.Close();
        }
    }
}
