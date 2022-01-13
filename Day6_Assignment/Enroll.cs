using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{

    public class Enroll:AppEngine
    {
        public Student student;
        public Course course;
        public DateTime enrollmentDate;
        public int count;
        public int coursecount;
        public int enrollmentcount;
        public List<Course> CourseArr = new List<Course>();
        public List<Student> StudentArr = new List<Student>();
        public List<Enroll> EnrollArr = new List<Enroll>();


        public Enroll()
        {
            count = 0;
            coursecount = 0;
            enrollmentcount = 0;
        }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        public DateTime EnrollmentDate
        {
            get { return enrollmentDate; }
            set { enrollmentDate = value; }
        }

        public void introduce(Course course)
        {
            CourseArr.Add(course);

        }

        public List<Course> listOfCourses()
        {

            return CourseArr;
        }

        public void register(Student student)
        {
            StudentArr.Add(student);

        }

        public List<Student> listOfStudent()
        {
            
            return StudentArr;
        }

        public void enroll(Student student, Course course, DateTime enrollmentdate)
        {
            EnrollArr.Add(new Enroll(student,course,enrollmentdate));
            
           }

        public List<Enroll> listOfEnrollments()
        {
            return EnrollArr;
        }

        public int getCourseByIdLength(int id)
        {
            int a = 0;

            Enroll e = new Enroll();
            for (int i = 0; i < EnrollArr.Count(); i++)
            {

                if (int.Parse(EnrollArr[i].course.CourseId) != id)
                {
                    continue;
                }
                a++;
            }

            return a;
        }

        public int getId(int id)
        {
            int ccid = 0;
            for (int i = 0; i < EnrollArr.Count(); i++)
            {
                if (int.Parse(EnrollArr[i].student.Id) == id)
                {
                    ccid = int.Parse(EnrollArr[i].course.CourseId);
                }
            }
            return ccid;
        }
        public override string ToString()
        {
            return "\t" + student.Name + "\t" + course.CourseName + "\t" + EnrollmentDate + "\n";
        }

        

    }

}
