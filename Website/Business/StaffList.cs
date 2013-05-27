using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data.SqlClient;

namespace Business {
    [System.ComponentModel.DataObject(true)]
    public class StaffList {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Staff> getAllStaff() {
            List<Staff> StaffsList = new List<Staff>();
            //Connect to SQL Server
            SqlConnection conn = new SqlConnection("Data Source=(local); Database=WebDevelopmentDB; Integrated Security=SSPI");
            //Select all columns for a given StaffID as well as their password hash
            SqlCommand cmd = new SqlCommand("SELECT dbo.Staff.GivenName, dbo.Staff.Surname, dbo.Staff.Email, dbo.Staff.PhoneNumber1, dbo.Staff.PhoneNumber2, dbo.Staff.Role, dbo.Accounts.PassHash FROM dbo.Staff INNER JOIN dbo.Accounts ON dbo.Staff.StaffID = dbo.Accounts.AccID)", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                StaffsList.Add(new Staff{
                GivenName = rdr[0].ToString(),
                Surname = rdr[1].ToString(),
                Address = rdr[2].ToString(),
                Email = rdr[3].ToString(),
                Phone1 = rdr[4].ToString(),
                Phone2 = rdr[5].ToString(),
                Role = rdr[6].ToString(),
                PassHash = rdr[7].ToString()});
            }
            //Close the reader and the SQL connection
            if (rdr != null) {
                rdr.Close();
            }
            conn.Close();
            return StaffsList;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public static void insertStaff(Staff staff) {

            System.Diagnostics.Trace.WriteLine(staff, "Insert");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static void deleteStaff(Staff staff) {

            System.Diagnostics.Trace.WriteLine(staff, "Delete");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public static void updateStaff(Staff staff) {

            System.Diagnostics.Trace.WriteLine(staff, "Update");
        }

<<<<<<< HEAD
        public static Staff getAStaff(int userId) {
            return new Staff(userId);
        }
=======
>>>>>>> Updated Staff Class
    }
}
