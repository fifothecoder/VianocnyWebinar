using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDebugging
{
    /// <summary>
    /// Partial Elizabeth's definition of the Student class
    /// </summary>
    partial class Student
    {
        private float _average;
        private bool _changed = false;
        private List<int> _grades = new List<int>();

        /// <summary>
        /// Calculate student's average based on his grades
        /// </summary>
        private float Average
        {
            get
            {
                if (_changed)
                {
                    RecalculateAverage();
                    _changed = false;
                }

                return _average;
            } 
        }

        /// <summary>
        /// Constructs student and sets his default average
        /// </summary>
        /// <param name="defaultAverage">Student's default average (if not set, default average is -1)</param>
        public Student(float defaultAverage = -1)
        {
            _average = defaultAverage;
        }

        private void RecalculateAverage()
        {
            float sum = 0f;
            foreach (var note in _grades) sum += note;
            _average = sum / _grades.Count;
        }

        public void AddGrade(int grade)
        {
            if(grade <= 5 && grade >= 1) _grades.Add(grade);
            else throw new ArgumentException();
            _changed = true;
        }

        public void ClearGrades() => _grades.Clear();

        public void PrintAverage()
        {
            Console.WriteLine($"{"Average", 10} : {Average:F2} GPA");
        }
    }
}
