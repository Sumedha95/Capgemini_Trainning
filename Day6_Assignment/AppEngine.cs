using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    interface AppEngine
    {
        public void introduce(Course course);
        public void register(Student student);
        public List<Student> listOfStudent();
        public void enroll(Student student, Course course,DateTime enrollmentdate);
        public List<Enroll> listOfEnrollments();
    }
}
    