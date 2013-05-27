using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business {

    [System.ComponentModel.DataObject(true)]
    public class ClassRoster {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<ClassRoster> getAllClassRosters() {
            List<ClassRoster> ClassRostersList = new List<ClassRoster>();

            return ClassRostersList;
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
