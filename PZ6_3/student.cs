using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ6_3
{
    public class Student
    {
        public string Group { get; set; }
        public string Surname { get; set; }
        public int Progress { get; set; }
        public int Rating { get; set; }

        public Student (string _Group, string _Surname, int _Progress, int _Rating)
        {
            Group = _Group;
            Surname = _Surname;
            Progress = _Progress;
            Rating = _Rating;
        }

    }
}
