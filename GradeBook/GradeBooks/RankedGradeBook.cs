﻿using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int numberOfStudents = this.Students.Count;

            if (numberOfStudents < 5)
            {
                throw new InvalidOperationException();
            }

            double[] averageGradeList = new double[numberOfStudents];

            // add the list of averagegrade

            for (int i = 0; i < numberOfStudents; ++i)
            {
                averageGradeList[i] = this.Students[i].AverageGrade;
            }

            // sort
            Array.Sort(averageGradeList);
            Array.Reverse(averageGradeList);

            // calculate 20, 40, 60, 80
            int first20 = numberOfStudents * 20 / 100 -1;
            int first40 = numberOfStudents * 40 / 100 -1;
            int first60 = numberOfStudents * 60 / 100 -1;
            int first80 = numberOfStudents * 80 / 100 -1;


            if (averageGrade >= averageGradeList[first20])
                return 'A';
            else if (averageGrade >= averageGradeList[first40])
                return 'B';
            else if (averageGrade >= averageGradeList[first60])
                return 'C';
            else if (averageGrade >= averageGradeList[first80])
                return 'D';

            return 'F';
        }
    }
}
