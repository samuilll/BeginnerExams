using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task16ComparingFloats
{
    static void Main(string[] args)
    {

        string firstNumber = Console.ReadLine();

        string secondNumber = Console.ReadLine();

        var check = true;

        int firstPointIndex = firstNumber.IndexOf('.');

        int secondPointIndex = secondNumber.IndexOf('.');


        if (Math.Sign(Convert.ToDouble(firstNumber))!= Math.Sign(Convert.ToDouble(firstNumber)))
        {
            check = false;
        }

        else 
        {
            for (int i = firstPointIndex+1,j = secondPointIndex+1; i < firstNumber.Length && j<secondNumber.Length; i++,j++)
            {
                if (i == firstPointIndex+7)
                {
                    break;
                }
                if (firstNumber[i]!=secondNumber[j])
                {
                    check = false;
                    break;
                }             
            }
        }
       


        Console.WriteLine(check);
    }
}

// 123123.12349