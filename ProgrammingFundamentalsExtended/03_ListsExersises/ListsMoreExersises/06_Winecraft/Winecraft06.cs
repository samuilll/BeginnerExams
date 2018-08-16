using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft06
{
    class Winecraft06
    {
        static void Main(string[] args)
        {
            var grapes = Console.ReadLine()
       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
       .Select(int.Parse).
       ToList();

            var N = int.Parse(Console.ReadLine());

            var separatedGrapes = new string[grapes.Count];

            SeparateGrapes(grapes, N, separatedGrapes);

            //          IncreaseDiscreaseGrapes(grapes, N, separatedGrapes);

            var i = 1;

            var check = true;

            while (check)
            {


                while (i <= N)
                {
                    PowerfulsBehaviour(grapes, N, separatedGrapes);

                    WeaksBehaviour(grapes, N, separatedGrapes);

                    NormalsBehaviour(grapes, N, separatedGrapes);

                    TooWeaksBehaviour(grapes, N, separatedGrapes);

                    SeparateGrapes(grapes, N, separatedGrapes);

                    i++;

               //    Console.WriteLine(string.Join(" ", grapes));
                }

           //     Console.WriteLine();
            //    Console.WriteLine();

                i = 1;

              check =  CheckTheGrapesCount(grapes, N);
            }

     //       Console.WriteLine();
     //       Console.WriteLine();

            for (int j = 0; j < grapes.Count; j++)
            {
                if (grapes[j] == 0)
                {
                    grapes.Remove(grapes[j]);

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", grapes));

        }

        private static bool CheckTheGrapesCount(List<int> grapes, int n)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i]<=n)
                {
                    grapes[i]=0;

                   
                }
            }

            var moreThanN = 0;

            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] > n)
                {
                    moreThanN += 1;

                    
                }
            }

            var check = (moreThanN >= n) == true;

            return check;
        }

        private static void TooWeaksBehaviour(List<int> grapes, int n, string[] separatedGrapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {

                if (separatedGrapes[i] == "veryweak" && grapes[i] > 0)

                    grapes[i] -= 2;
            }
        }

        private static void NormalsBehaviour(List<int> grapes, int n, string[] separatedGrapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {

                if (separatedGrapes[i] == "normal")

                    grapes[i] += 1;
            }
        }

        private static void WeaksBehaviour(List<int> grapes, int n, string[] separatedGrapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
               

                if (separatedGrapes[i] == "weak" && grapes[i]>0)

                    grapes[i] -= 1;

             
            }
        }

        private static void PowerfulsBehaviour(List<int> grapes, int n, string[] separatedGrapes)
        {
            for (int i = 1; i < grapes.Count-1; i++)
            {
                var check1 = ((grapes[i - 1] > 0) && (grapes[i + 1] > 0)) == true;

                var check2 = ((grapes[i - 1] == 0)) == true;

                var check3 = (grapes[i + 1] == 0) == true;

                var check4 = (check2 && !check3) || (check3 && !check2) == true;

                var check5 = check2 && check3;



                if (separatedGrapes[i] == "powerful" && check1)

                    grapes[i] += 3;


                else if (separatedGrapes[i] == "powerful" && check4)

                    grapes[i] += 2;

                else if (separatedGrapes[i] == "powerful" && check5)

                    grapes[i] += 1;
            }
        }

       
      

        private static void SeparateGrapes(List<int> grapes, int N, string[] separateGrapes)
        {
            for (int i = 0; i < separateGrapes.Length; i++)
            {
                separateGrapes[i] = null;
            }

            for (int j = 1; j < grapes.Count - 1; j++)
            {
                //var check1 = ((grapes[j - 1]) < grapes[j]) == true;

                //var check2 = (grapes[j + 1] < grapes[j]) == true;

                var check1 = (grapes[j] > grapes[j - 1] && grapes[j] > grapes[j + 1]) == true;
            
                if (check1)
                {
                    separateGrapes[j] = "powerful";

                    separateGrapes[j - 1] = "weak";

                    separateGrapes[j + 1] = "weak";
                }
            }

            for (int j = 1; j < grapes.Count-1; j++)
            {
                var check2 = (separateGrapes[j-1]=="powerful"&& separateGrapes[j + 1] == "powerful") == true;

                if (check2)
                {
                    separateGrapes[j] = "veryweak";
                }
            }
            for (int i = 0; i < grapes.Count; i++)
            {

                if (separateGrapes[i] != "powerful" && separateGrapes[i] != "weak" && separateGrapes[i] != "veryweak")
                {
                    separateGrapes[i] = "normal";
                }
            }

        }
    }
}
