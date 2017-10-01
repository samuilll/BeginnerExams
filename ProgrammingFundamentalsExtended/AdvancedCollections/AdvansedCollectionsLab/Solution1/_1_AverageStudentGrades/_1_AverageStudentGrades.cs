using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _1_AverageStudentGrades
{
    static void Main(string[] args)
    {

        var howManyTimes = int.Parse(Console.ReadLine());

        var gradesAndNamesList = new Dictionary<string, List<double>>();

        for (int i = 0; i < howManyTimes; i++)
        {
            var inputNameAndGrade = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = inputNameAndGrade[0];

            var grade = double.Parse(inputNameAndGrade[1]);

            AddTheGrade(gradesAndNamesList, name, grade);

        }

        foreach (var nameAndGrade in gradesAndNamesList)
        {
            var valueList = nameAndGrade.Value;

            var average = nameAndGrade.Value.Average();

        //    var numberString = CreateAFormatGradesList(valueList);

            Console.WriteLine("{0} -> {1:} (avg: {2:f2})",
                nameAndGrade.Key,
                string.Join(" ", valueList.Select(p => string.Format("{0:f2}",p))),
                average);


        }
    }

    private static List<string> CreateAFormatGradesList(List<double> valueList)
    {
        var numbers = new List<string>();

        foreach (var value in valueList)
        {
            numbers.Add($"{value:f2}");
        }

        return numbers;
    }

 //  private static double FigureOutAndPrintTheAverageGrade(List<double> valueList)
 //   {
 //       var sum = 0.0;

 //       var average = 0.0;

 //       var numberOfGrades = valueList.Count;

 //       foreach (var grade in valueList)
 //       {
 //           sum += grade;
 //       }

 //       average = sum / numberOfGrades;

 //       return average;
 //   }

    private static void AddTheGrade(Dictionary<string, List<double>> gradesAndNamesList, string name, double grade)
    {
        if (!gradesAndNamesList.ContainsKey(name))
        {
            gradesAndNamesList[name] = new List<double>();
        }

        gradesAndNamesList[name].Add(grade);
    }
}