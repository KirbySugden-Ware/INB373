using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data.SqlClient;

namespace Business {
    [System.ComponentModel.DataObject(true)]
    public class Students {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Student> getAllStudents() {
            List<Student> StudentsList = new List<Student>();

            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all columns for a given StudentID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT dbo.Students.GivenName, dbo.Students.Surname, dbo.Students.Address, dbo.Students.Email, dbo.Students.PhoneNumber1, dbo.Students.PhoneNumber2, dbo.Accounts.PassHash FROM dbo.Students INNER JOIN dbo.Accounts ON dbo.Students.StudentID = dbo.Accounts.AccID", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                //Fill out class variables with returned data...
                StudentsList.Add(new Student{
                    GivenName = rdr[0].ToString(),
                    Surname = rdr[1].ToString(),
                    Address = rdr[2].ToString(),
                    Email = rdr[3].ToString(),
                    Phone1 = rdr[4].ToString(),
                    Phone2 = rdr[5].ToString(),
                    PassHash = rdr[6].ToString()});
            }
            //Close the reader and the SQL connection
            if (rdr != null) {
                rdr.Close();
            }
            conn.Close();
            return StudentsList;
        }

        public static Student getAStudent(int idNumber) {
            return new Student(idNumber);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public static void insertStudent(Student student) {

            System.Diagnostics.Trace.WriteLine(student, "Insert");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static void deleteStudent(Student student) {

            System.Diagnostics.Trace.WriteLine(student, "Delete");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public static void updateStudent(Student student) {

            System.Diagnostics.Trace.WriteLine(student, "Update");
        }
    }
}
