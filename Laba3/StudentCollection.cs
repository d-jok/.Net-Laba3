using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3
{
    class StudentCollection
    {
        public List<Student> StudentInfo = new List<Student>();

        public void AddDefaults(int n)
        {
            StudentInfo.Add(TestCollections.GenerateInfo(n));
        }

        public void AddStudents(params Student[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                StudentInfo.Add(input[i]);
            }
        }

        public void SortSurname()
        {
            StudentInfo.Sort();// (a, b) => a.CompareTo(b)); //need to think
        }

        public void SortDate()
        {
            StudentInfo.Sort((a, b) => a.Compare(a, b));    //need to think
        }

        public void SortMark()
        {
            Student.Support U = new Student.Support();
            StudentInfo.Sort((a, b) => U.Compare(a, b));    //need to think
        }

        public double MaxMark  //Find Max MediumMark in List
        {
            get
            {
                return StudentInfo.Max(a => a.MediumMark);
            }
        }

        public IEnumerable<Student> EducationForm()
        {
            return StudentInfo.Where(x => x.FormInfo == Person.Education.Master);
        }

        public List<Student> AverageMarkGroup(double value)
        {
            return StudentInfo.GroupBy(p => p.MediumMark == 4.5).Where(p => p.Key).First().ToList();
        }

        public override string ToString()
        {
            //return base.ToString();
            foreach (Student v in StudentInfo)
                Console.WriteLine(v + Environment.NewLine);
            return "";
        }

        public string ToShortString()
        {
            foreach (Student v in StudentInfo)
                Console.WriteLine(v.ToShortString() + Environment.NewLine);
            return "";
        }
    }
}
