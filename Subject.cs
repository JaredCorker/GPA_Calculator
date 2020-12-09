using System;

public enum SubjectType
{
    Core,
    Major,
    Minor,
    Elective
}

public enum TeachingPeriod
{
    SemesterOne,
    SemesterTwo,
    Summer,
    Winter
}

namespace GPA_Calculator
{
    public class Subject
    {
        public string name;
        public SubjectType subjectType;
        public double score;
        public TeachingPeriod teachingPeriod;
        public ushort year;

        public Subject(string name, SubjectType subjectType, double score, TeachingPeriod teachingPeriod, ushort year)
        {
            this.name = name;
            this.subjectType = subjectType;
            this.score = score;
            this.teachingPeriod = teachingPeriod;
            this.year = year;
        }

        public void printOut()
        {
            Console.Write("{0}, {1}, {2}", name, subjectType, score);
        }
    }
}
