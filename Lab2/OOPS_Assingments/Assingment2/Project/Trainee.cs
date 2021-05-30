using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Trainee
    {
        int EmployeeID;
        string Name, ProjectName;
        int DatabaseMarks, FETMarks, DotNetMarks, TotalMarks, MarksScored;
        int Percentage;
        
        public Trainee()
        {
            EmployeeID = 0;
            Name = "null";
            ProjectName = "FrTP";
            DatabaseMarks = 0;
            FETMarks = 0;
            DotNetMarks = 0;
            TotalMarks = 300;
            MarksScored = 0;
            Percentage = 0;
        }
        public Trainee(int eid, string name,  int databmarks, int fetmarks, int dotmarks, int totalmarks = 300)
        {
            EmployeeID = eid;
            Name = name;
            ProjectName = "FrTP";
            DatabaseMarks = databmarks;
            FETMarks = fetmarks;
            DotNetMarks = dotmarks;
            TotalMarks = totalmarks;
            MarksScored = (DatabaseMarks + FETMarks + DotNetMarks);
            Percentage = ((MarksScored*100) / TotalMarks);
        }

        public void SetData(int eid, string name, int databmarks, int fetmarks, int dotmarks, int totalmarks = 300)
        {
            EmployeeID = eid;
            Name = name;
            ProjectName = "FrTP";
            DatabaseMarks = databmarks;
            FETMarks = fetmarks;
            DotNetMarks = dotmarks;
            TotalMarks = totalmarks;
            MarksScored = (DatabaseMarks + FETMarks + DotNetMarks);
            Percentage = (MarksScored / TotalMarks);
        }
        public void MarksScoredByStudent()
        {
            Console.WriteLine("Total Score marks = " + MarksScored);
        }

        public void PercentageOfStudent()
        {
            Console.WriteLine("Percentage of Student = " + Percentage);
        }
        
    }
    
}
