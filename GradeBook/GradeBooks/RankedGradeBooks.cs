using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBooks : BaseGradeBook
    {
        public RankedGradeBooks(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }
    }
}
