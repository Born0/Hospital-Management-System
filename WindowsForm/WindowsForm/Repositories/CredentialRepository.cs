using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Interfaces;

namespace WindowsForm.Repositories
{
     public class CredentialRepository
    {
        DataAccess dataAccess;
        public CredentialRepository()
        {
            dataAccess = new DataAccess();
        }

        public Login Validation(Login log)
        {
            string sql = "SELECT * FROM Login WHERE UserName='" +log.UserName  + "' And Password='" + log.Passsword + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            try
            {
                reader.Read();
                int userType = (int)reader["UserType"];
                log.UserType = userType;
                return log;

                
            }
            catch(Exception e)
            {
                log.UserType = 0;
                Console.WriteLine(e);
                return log; 
            }

        }

    }
}
