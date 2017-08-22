using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;


    class Syntax
    {
        static void Main(string[] args)
        {

        //-----------Creating a datetime object-----------------//

        var birthay = new DateTime(1987, 07, 05);

        var nowday = DateTime.Now;

        TimeSpan howAmIOld = nowday - birthay;
        Console.WriteLine("{0:  d  -  M  -  yy}", nowday);
        Console.WriteLine(birthay.ToString("dd yyyy"));
        Console.WriteLine(birthay.Day);
        Console.WriteLine(howAmIOld);

        //-----------Class Random Example------------------------//

        var words = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var randomiser = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            var randomNumber = randomiser.Next(0, words.Length);
            var currentWord = words[i];

            var temporaryWord = words[randomNumber];
            words[randomNumber] = currentWord;
            words[i] = temporaryWord;
        }

        //---------------------Start A File-------------------------//

        Process.Start("C:/gittrial/BeginnerExams/AlgorithmsExersises/ArrayAndListAlgorithms/AllTasksInOne.App.config");

        //--------------------Download A File-------------------------//

        var client = new WebClient();

        client.DownloadFile("https://softuni.bg/downloads/svn/soft-tech/May-2017/Programming-Fundamentals-May-2017/09.%20Programming-Fundamentals-Objects-and-Classes/09.%20Programming-Fundamentals-Objects-and-Classes-Lab.docx"
            , "trial.docx");
    }
    }

