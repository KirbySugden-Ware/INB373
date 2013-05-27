using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data.SqlClient;

namespace Business {
    [System.ComponentModel.DataObject(true)]
    public class ClassList {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Class> getAllClasses() {
            List<Class> classList = new List<Class>();
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=PANDORASBOX\\PANDORASBOX; Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            //Select all columns for a given StaffID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT ClassCode, Day, Time, Semester, TutorID FROM dbo.ClassList", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                classList.Add(new Class {
                    ClassCode = rdr[0].ToString(),
                    Day = rdr[1].ToString(),
                    Time = rdr[2].ToString(),
                    Semester = rdr[3].ToString(),
                    TutorID = rdr[4].ToString()
                });
            }
            //Close the reader and the SQL connection
            if (rdr != null) {
                rdr.Close();
            }
            conn.Close();
            return classList;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Class> getClasses(string student) {
            List<Class> classList = new List<Class>();
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=PANDORASBOX\\PANDORASBOX; Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            ClassRoster roster = new ClassRoster(int.Parse(student));
            //Select all columns for a given StaffID as well as their password hash
            for (int i = 0; i <= roster.Roster.GetLength(0); i++) {
                SqlCommand cmd = new SqlCommand("SELECT ClassCode, Day, Time, Semester, TutorID FROM dbo.ClassList WHERE (ClassCode = " + roster.Roster[i, 0] + ")", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    classList.Add(new Class {
                        ClassCode = rdr[0].ToString(),
                        Day = rdr[1].ToString(),
                        Time = rdr[2].ToString(),
                        Semester = rdr[3].ToString(),
                        TutorID = rdr[4].ToString()
                    });
                }
                //Close the reader and the SQL connection
                if (rdr != null) {
                    rdr.Close();
                }
                conn.Close();
            }
            return classList;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Class> getClass(string tutor) {
            List<Class> classList = new List<Class>();
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=PANDORASBOX\\PANDORASBOX; Database=WebDevelopmentDB; Integrated Security=SSPI");
            conn.Open();
            ClassRoster roster = new ClassRoster(int.Parse(tutor));
            //Select all columns for a given StaffID as well as their password hash
            for (int i = 0; i <= roster.Roster.GetLength(0); i++) {
                SqlCommand cmd = new SqlCommand("SELECT ClassCode, Day, Time, Semester, TutorID FROM dbo.ClassList WHERE (ClassCode = " + roster.Roster[i, 0] + ")", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    classList.Add(new Class {
                        ClassCode = rdr[0].ToString(),
                        Day = rdr[1].ToString(),
                        Time = rdr[2].ToString(),
                        Semester = rdr[3].ToString(),
                        TutorID = rdr[4].ToString()
                    });
                }
                //Close the reader and the SQL connection
                if (rdr != null) {
                    rdr.Close();
                }
                conn.Close();
            }
            return classList;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public static void insertClassList(Class classList) {

            System.Diagnostics.Trace.WriteLine(classList, "Insert");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static void deleteClassList(Class classList) {

            System.Diagnostics.Trace.WriteLine(classList, "Delete");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public static void updateClassList(Class classList) {

            System.Diagnostics.Trace.WriteLine(classList, "Update");
        }
    }
}
