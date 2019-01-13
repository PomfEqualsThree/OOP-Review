using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Language.Review
{
    // the name space plus the class name is whats called
    // a fully qualified class name
    // the fully qualified class name for program is 
    // CSharp.Language.Review.Program

    //the body of the Main() method
    //acts as the driver of ,y application
    //Program app = new Program(args);

    class Program
    {
        //a static field initialized to a new Random
        private static Random rnd = new Random();

        // Main() is the entry point
        public static void Main(string[] args)
        {
            Program app = new Program(args);

            app.AssignMarks(30, 80);

            foreach (Student person in app.Students)
            {
                System.Console.WriteLine("Name: " + person.Name);
                foreach (EarnedMark item in person.Marks)
                    System.Console.WriteLine("\t" + item);
            }
        }

        //this field is acting as a backing store
        // for the students property
        private List<Student> _students = new List<Student>();

       

        // this property provides controlled access
        // to the data in the backing store (the field)
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        //this is a constructor
        // the job of a constructor is to ensure
        // that all the fields/properties
        // have meaninful values
        public Program(string[] studentNames)
        {
            WeightedMark[] CourseMarks = new WeightedMark[4];
            CourseMarks[0] = new WeightedMark("Quiz 1", 20);
            CourseMarks[1] = new WeightedMark("Quiz 2", 20);
            CourseMarks[2] = new WeightedMark("Exercises", 25);
            CourseMarks[3] = new WeightedMark("Lab", 35);
            int[] possibleMarks = new int[4] { 25, 50, 12, 35 };

            foreach (string name in studentNames)
            {
                EarnedMark[] marks = new EarnedMark[4];
                for (int i = 0; i < possibleMarks.Length; i++)
                    marks[i] = new EarnedMark(CourseMarks[i], possibleMarks[i], 0);
                Students.Add(new Student(name, marks));
            }
        }

        public void AssignMarks(int min, int max)
        {
            foreach (Student person in Students)
                foreach (EarnedMark item in person.Marks)
                    item.Earned = (rnd.Next(min, max) / 100.0) * item.Possible;
        }
    }
}

