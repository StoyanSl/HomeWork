using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<string,double>> goodStudents=new List<Tuple<string, double>>();
            student student=new student();
            int n=int.Parse(Console.ReadLine());
            student[] students=new student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = StudentInput();
            }
            for (int i = 0; i < n; i++)
            {
                DictionaryFilling(goodStudents,students[i]);
            }
         
            foreach (var item in goodStudents.OrderBy(x => x.Item1).ThenByDescending(x => x.Item2))
            {
                Console.WriteLine("{0} -> {1:F2}", item.Item1, item.Item2);
            }
        }
        
        static void DictionaryFilling(List<Tuple<string,double>> list, student student)
        {
            if (student.averageGrade>=5.00)
            {
                list.Add(Tuple.Create(student.name, student.averageGrade));
            }
              
            
        }
        static student StudentInput()
        {
            List<string> inputList = Console.ReadLine().Split(' ').ToList();
            student studentN=new student();
            studentN.name = inputList[0];
           
            for (int i = 1; i < inputList.Count; i++)
            {
                studentN.grades.Add(double.Parse(inputList[i]));
            }
            return studentN;
        }
        class student
        {
            public student()
            {
                grades = new List<double>();
            }
            public string name { get; set; }
            public List<double> grades { get; set; }
            public double averageGrade
            {
                get { return (double)grades.Average(); }
            }
        }
    }
}
