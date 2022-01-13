using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    public abstract class Course
    {
        string id;
        string name;
        string duration;
        float fees;

        public double Total_Fees;
        public int seatsavaialble;

        public Course(string id, string name, string duration, float fees, int seatsavaialble)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
            this.seatsavaialble = seatsavaialble;
        }

        public string CourseId
        {
            get { return id; }
            set { id = value; }
        }

        public string CourseName
        {
            get { return name; }
            set { name = value; }
        }

        public string CourseDuration
        {
            get { return duration; }
            set { duration = value; }
        }

        public float Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        public abstract float calculateMonthlyFee();


    }

    class DegreeCourse : Course
    {
        public enum level{
            Bachelors,
            Masters
        }
        //public string level;
        public bool active;
        public bool isPlacementAvailable;
        level mylevel;
        public DegreeCourse(string id, string name, string duration, float fees, int seats,level mylevel, bool active, bool isPlacementAvailable) : base(id, name, duration, fees, seats)
        {
            this.mylevel = mylevel;
            this.active = active;
            this.isPlacementAvailable = isPlacementAvailable;
            calculateMonthlyFee();
        }

        public override float calculateMonthlyFee()
        {
            
            if(isPlacementAvailable)
            {
                this.Fees = this.Fees + ((this.Fees * 10) / 100);
            }
            else if(!isPlacementAvailable)
            {
                this.Fees = this.Fees;
            }
            return Fees;
        }

        public override string ToString()
        {
            return "\n" + CourseId + "\t" + CourseName + "\t" + CourseDuration + "\t" + mylevel+ "\t" + seatsavaialble + "\t" + Fees + "\n";
        }
        
    }
    class DiplomaCourse : Course
    {
        public enum type
        {
            professional,
            academic
        }
        type mytype;
        public DiplomaCourse(string id, string name, string duration, int seats, float fees, type mytype) : base(id, name, duration, fees, seats)
        {
            this.mytype = mytype;
            calculateMonthlyFee();
        }
        public override float calculateMonthlyFee()
        {
            if(mytype==type.professional)
            {
                this.Fees = this.Fees + ((this.Fees * 10 )/100);
            }
            else
            {
                this.Fees = this.Fees + ((this.Fees * 5 )/100);
            }
            return Fees;
        }

        public override string ToString()
        {
            return "\n" + CourseId + "\t" + CourseName + "\t" + CourseDuration + "\t" + mytype + "\t"+ seatsavaialble + "\t" + Fees + "\n";
        }
        

    }

}
