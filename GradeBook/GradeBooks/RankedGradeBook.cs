using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double avarageGrade)
        {
            if(Students.Count <5)
            {
                throw new InvalidOperationException();
            }
            if (avarageGrade >= 80)
                return 'A';
            else if (avarageGrade < 80 && avarageGrade >= 60)
                return 'B';
            else if (avarageGrade < 60 && avarageGrade >= 40)
                return 'C';
            else if (avarageGrade < 40 && avarageGrade >= 20)
                return 'D';
            else
                return 'F';
        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
           
        }
    }
}
