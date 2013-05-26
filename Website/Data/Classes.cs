using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Student
    {
        private int StudentID { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public void StudentSearch(int StudentID){
        //Connect to SQL Server
        SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand("SELECT * from student where StudentID = " + StudentID, conn);
        SqlDataReader rdr = cmd.ExecuteReader();
        while(rdr.Read()){
            
        }

    }

    public class Staff
    {
        private int StaffID { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Role { get; set; }
    }

    public class Class
    {
        public int ClassID { get; set; }
        public string ClassCode { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Semester { get; set; }
        public string TutorID { get; set; }
    }
}
