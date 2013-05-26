using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business {
    [System.ComponentModel.DataObject(true)]
    public class ClassList {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Class> getAllClasses() {
            List<Class> classList = new List<Class>();

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
