// identifies the namespaces containing the data types
// that we want to use or reference in the code in this file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// delcares an area or named-space in which we can 
// place our programmer-defined data types
namespace CSharp.Language.Review
{
    // the name space plus the class name is whats called
    // a fully qualified class name
    // the fully qualified class name for program is 
    // CSharp.Language.Review.Program

        //a static field initialized to a new Random
      //-private static Random rnd = new Random();

        // Main() is the entry point
     //public static void Main(string[] args)
        
        //this field is acting as a backing store
        // for the students property
    //private list<Student>

       // this property provides controlled access
       // to the data in the backing store (the field)
    //public list<Student>

        //this is a constructor
        // the job of a constructor is to ensure
        // that all the fields/properties
        // have meaninful values
    //public Program(string[] studentNames)
     
        //the body of the Main() method
        //acts as the driver of ,y application
    //Program app = new Program(args);
    
    public class EarnedMark : WeightedMark
    {
        public int Possible { get; private set; }
        private double _Earned;
        public double Earned
        {
            get { return _Earned; }
            set
            {
                if (value < 0 || value > Possible)
                    throw new Exception("Invalid earned mark assigned");
                _Earned = value;
            }
        }
        public double Percent
        { get { return (Earned / Possible) * 100; } }

        public double WeightedPercent
        { get { return Percent * Weight / 100; } }

        public EarnedMark(WeightedMark markableItem, int possible, double earned)
            : this(markableItem.Name, markableItem.Weight, possible, earned)
        {
        }
        public EarnedMark(string name, int weight, int possible, double earned)
            : base(name, weight)
        {
            if (possible <= 0)
                throw
        }
    }
}
