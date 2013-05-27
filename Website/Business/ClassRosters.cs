using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business {

    [System.ComponentModel.DataObject(true)]
    public class ClassRosters {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<ClassRoster> getAllClassRoster() {
            List<ClassRoster> ClassRosterList = new List<ClassRoster>();

            return ClassRosterList;
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public static void insertClassRoster(ClassRoster classRoster) {

            System.Diagnostics.Trace.WriteLine(classRoster, "Insert");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static void deleteClassRoster(ClassRoster classRoster) {

            System.Diagnostics.Trace.WriteLine(classRoster, "Delete");
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public static void updateClassRoster(ClassRoster classRoster) {

            System.Diagnostics.Trace.WriteLine(classRoster, "Update");
        }
    }
}
