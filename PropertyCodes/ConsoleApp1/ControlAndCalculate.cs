using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ControlAndCalculate
    {
        private double _examscore1 = 0.0d;
        private double _examscore2 = 0.0d;
        public double TotalExamScore = 0.0d;

        public double _ExamScore1
        {
            get
            {
                if (_examscore1 < 0)
                {
                    return 0;
                }

                else
                {
                    return _examscore1;
                }
            }

            set
            {
                _examscore1 = value;

                TotalExamScore += _examscore1;
            }
        }

        public double _ExamScore2
        {
            get
            {
                if (_examscore2 < 0)
                {
                    return 0;
                }

                else
                {
                    return _examscore2;
                }
            }

            set
            {
                _examscore2 = value;

                TotalExamScore += _examscore2;
            }
        }

        public void AvverageExam()
        {
            Console.WriteLine($"\nAvverage of Exam: {TotalExamScore / 2}");
        }
    }
}
