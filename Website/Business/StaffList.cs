using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business {
    [System.ComponentModel.DataObject]
    public class StaffList {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Staff> getAllStaff() {
            List<Staff> StaffsList = new List<Staff>();

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
