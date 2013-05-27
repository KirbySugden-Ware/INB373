using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business {
    [System.ComponentModel.DataObject(true)]
    public class StaffList {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Staff> getAllStaff() {
            List<Staff> StaffsList = new List<Staff>();
            Staff sally = new Staff();
            sally.Address = "123 happy st";
            sally.Email = "e@mail.com";
            sally.GivenName = "sally";
            sally.Surname = "Staff";
            sally.Phone1 = "12345678";
            sally.Phone2 = "1234567890";
            StaffsList.Add(sally);
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
    }
}
