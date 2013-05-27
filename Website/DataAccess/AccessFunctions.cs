using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    class AccessFunctions
    {
        private List<string> RetrieveAllStudents(){
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all columns for a given StaffID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT StudentID FROM [WebDevelopmentDB].[dbo].[ClassRoster]", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            List<string> Students = new List<string>();
            String tmp;
            while (rdr.NextResult())
            {
                tmp = rdr[0].ToString();
                Students.Add(tmp);
            } if (rdr != null)
            {
                rdr.Close();
            }
            conn.Close();
            return Students;
           
        }

    }
}
