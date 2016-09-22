using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleGradeCompute
{
    class Program
    {
        static void Main(string[] args)
        {
            var quizRate = new List<int> { 10, 7, 8, 9 }; //score of the four quizzes
            var MinorA = 90; //Minor A Exam
            var CS = 80; //Class standing
            var ME = 85; //Midterm exam

            //Quiz Average
            var QA = 0;
            foreach (var q in quizRate)
            {
                QA += q;
            }
            QA = QA / 4;

            //Getting midterm grade
            //20% of Quiz average + 20% of Minor A Exam + 10% of Class Standing + 50% of Midterm grde
            var MG1 = QA * .2 + MinorA * .2 + CS * .1 + ME * .5;
            var MG2 = (QA * .2) + (MinorA * .2) + (CS * .1) + (ME * .5);

            Console.WriteLine($"Midterm Grade1 : {MG1}");
            Console.WriteLine($"Midterm Grade1 : {MG2}");
            
            Console.ReadLine();
        }
    }
}
