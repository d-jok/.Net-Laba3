using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3
{
    class main
    {
        static void Main(string[] args)
        {
            StudentCollection S = new StudentCollection();
            //TestCollections T = new TestCollections(3);

            for(int i = 0; i < 5; i++)
                S.AddDefaults(i);
                S.ToString();

            //SORT
            //S.SortSurname();
            //S.ToString();

            //S.SortDate();
            //S.ToString();

            //S.SortMark();
            //S.ToString();

            //OPERATION
            //Console.WriteLine(S.MaxMark);
            //S.EducationForm();
            //S.ToString();
            //S.AverageMarkGroup(4.5);
            //S.ToString();

            //TEST COLLECTION
            //Dictionary<string, int> J;
            //J = T.GetTime(S.StudentInfo[3]);

            //foreach(KeyValuePair<string, int> v in J)
            //{
            //    Console.WriteLine("{0}, \tTime is {1}", v.Key, v.Value);
            //}

            Console.ReadKey();
        }
    }
}
