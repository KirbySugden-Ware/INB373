﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    [System.ComponentModel.DataObject]
    public class StudentList
    {
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<Student> getAllStudents() {
            List<Student> StudentsList = new List<Student>();

            return StudentsList;
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