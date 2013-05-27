using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data {
    public class Student {
        private int StudentID { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PassHash { get; set; }

        //<<<<<<< HEAD
        public void StudentSearch(int StudentID) {
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from student where StudentID = " + StudentID, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {

            }
        }

        //=======
        public Student() {
            GivenName = "";
            Surname = "";
            Address = "";
            Email = "";
            Phone1 = "";
            Phone2 = "";

        }

        public Student(int StudentID) {
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all columns for a given StudentID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT dbo.Students.GivenName, dbo.Students.Surname, dbo.Students.Address, dbo.Students.Email, dbo.Students.PhoneNumber1, dbo.Students.PhoneNumber2, dbo.Accounts.PassHash FROM dbo.Students INNER JOIN dbo.Accounts ON dbo.Students.StudentID = dbo.Accounts.AccID where (dbo.Accounts.AccID = " + StudentID + ")", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                //Fill out class variables with returned data...
                GivenName = rdr[0].ToString();
                Surname = rdr[1].ToString();
                Address = rdr[2].ToString();
                Email = rdr[3].ToString();
                Phone1 = rdr[4].ToString();
                Phone2 = rdr[5].ToString();
                PassHash = rdr[6].ToString();
            }
            //Close the reader and the SQL connection
            if (rdr != null) {
                rdr.Close();
            }
            conn.Close();
            //>>>>>>> Added Constructors for Data Classes
        }
    }

    public class Staff {
        private int StaffID { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Role { get; set; }
        public string PassHash { get; set; }

        public Staff() {
            GivenName = "";
            Surname = "";
            Address = "";
            Email = "";
            Phone1 = "";
            Phone2 = "";
            Role = "";
        }

        public Staff(int StaffID) {
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all columns for a given StaffID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT dbo.Staff.GivenName, dbo.Staff.Surname, dbo.Staff.Email, dbo.Staff.PhoneNumber1, dbo.Staff.PhoneNumber2, dbo.Staff.Role, dbo.Accounts.PassHash FROM dbo.Staff INNER JOIN dbo.Accounts ON dbo.Staff.StaffID = dbo.Accounts.AccID WHERE (StaffID = " + StaffID + ")", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                //Fill out class variables with returned data...
                GivenName = rdr[0].ToString();
                Surname = rdr[1].ToString();
                Email = rdr[2].ToString();
                Phone1 = rdr[3].ToString();
                Phone2 = rdr[4].ToString();
                Role = rdr[5].ToString();
                PassHash = rdr[6].ToString();
            }
            //Close the reader and the SQL connection
            if (rdr != null) {
                rdr.Close();
            }
            conn.Close();
        }

        public List<Student> StudentList(int StaffID) {
            List<Student> Roster = new List<Student>();

            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all distinct Student ID's that occur in a specified Tutors classes
            SqlCommand cmd = new SqlCommand("SELECT Distinct StudentID FROM [WebDevelopmentDB].[dbo].[ClassRoster] where ClassID in (Select ClassID from[WebDevelopmentDB].[dbo].ClassList where TutorID = " + StaffID + ")", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            string StudentID;
            while (rdr.NextResult()) {
                StudentID = rdr[0].ToString();
                Student tmp = new Student(Convert.ToInt32(StudentID));
                Roster.Add(tmp);
            }
            //Close the reader and the SQL connection
            if (rdr != null) {
                rdr.Close();
            }
            conn.Close();
            return Roster;

        }
    }


    public class Class {
        public int ClassID { get; set; }
        public string ClassCode { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Semester { get; set; }
        public string TutorID { get; set; }

        public Class() {
            ClassCode = "";
            Day = "";
            Time = "";
            Semester = "";
            TutorID = "";
        }

        public Class(int ClassID) {
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all columns for a given StaffID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT ClassCode, Day, Time, Semester, TutorID FROM dbo.ClassList where ClassID = " + ClassID + ")", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                //Fill out class variables with returned data...
                ClassCode = rdr[0].ToString();
                Day = rdr[1].ToString();
                Time = rdr[2].ToString();
                Semester = rdr[3].ToString();
                TutorID = rdr[4].ToString();
            }
            //Close the reader and the SQL connection
            if (rdr != null) {
                rdr.Close();
            }
            conn.Close();
        }

    }
    //<<<<<<< HEAD

    public class ClassRoster {
        public string[,] Roster { get; set; }

        public ClassRoster() {
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all columns for a given StaffID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT * FROM [WebDevelopmentDB].[dbo].[ClassRoster]", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            Roster.Initialize();
            int i = 0;
            while (rdr.NextResult()) {
                Roster[i, 0] = rdr[0].ToString();
                Roster[i, 1] = rdr[1].ToString();
                i++;
            } if (rdr != null) {
                rdr.Close();
            }
            conn.Close();

        }
        //=======

        public class ClassRoster {
            public string[,] Roster { get; set; }

            public ClassRoster() {
                //Connect to SQL Server
                SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
                conn.Open();
                //Select all columns for a given StaffID as well as their password hash
                SqlCommand cmd = new SqlCommand("SELECT * FROM [WebDevelopmentDB].[dbo].[ClassRoster]", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                Roster.Initialize();
                int i = 0;
                while (rdr.NextResult()) {
                    Roster[i, 0] = rdr[0].ToString();
                    Roster[i, 1] = rdr[1].ToString();
                    i++;
                } if (rdr != null) {
                    rdr.Close();
                }
                conn.Close();

            }

            public ClassRoster(int StudentID) {
                //Connect to SQL Server
                SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
                conn.Open();
                //Select all columns for a given StaffID as well as their password hash
                SqlCommand cmd = new SqlCommand("SELECT * FROM [WebDevelopmentDB].[dbo].[ClassRoster] where StudentID = " + StudentID, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                Roster.Initialize();
                int i = 0;
                while (rdr.NextResult()) {
                    Roster[i, 0] = rdr[0].ToString();
                    Roster[i, 1] = rdr[1].ToString();
                    i++;
                } if (rdr != null) {
                    rdr.Close();
                }
                conn.Close();

            }
            //>>>>>>> Updated Staff Class

            public ClassRoster(int StudentID) {
                //Connect to SQL Server
                SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
                conn.Open();
                //Select all columns for a given StaffID as well as their password hash
                SqlCommand cmd = new SqlCommand("SELECT * FROM [WebDevelopmentDB].[dbo].[ClassRoster] where StudentID = " + StudentID, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                Roster.Initialize();
                int i = 0;
                while (rdr.NextResult()) {
                    Roster[i, 0] = rdr[0].ToString();
                    Roster[i, 1] = rdr[1].ToString();
                    i++;
                } if (rdr != null) {
                    rdr.Close();
                }
                conn.Close();

            }
        }
    }
}
