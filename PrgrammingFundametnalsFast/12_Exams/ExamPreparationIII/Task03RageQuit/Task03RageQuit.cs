using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task03RageQuit
{
    class Task03RageQuit
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            Regex reg = new Regex(@"(?<text>[^0-9]+)(?<number>[0-9]+)");

            var matches = reg.Matches(input).Cast<Match>().ToList();

            var built = new StringBuilder();

           var tempString =  Regex.Replace(input,"[0-9]",string.Empty).ToUpper();

         //   tempString = Regex.Replace(tempString, "\\s*", " "); 


          
            foreach (var match in matches)
            {
                var text = match.Groups["text"].Value.ToUpper();

                var number = int.Parse(match.Groups["number"].Value);

                for (int i = 0; i < number; i++)
                {
                    built.Append(text);
                }
            }

           var uniqueLength = built.ToString().Distinct().Count();

               Console.WriteLine($"Unique symbols used: {uniqueLength}");

              Console.WriteLine(built.ToString());

        }
    }
}

 //  e-!btI17z=E:DMJ19U1Tvg VQ>11P"qCmo.-0YHYu~o%/%b.}a[=d15fz^"{0^/pg.Ft{W12`aD<l&$W&)*yF1WLV9_GmTf(d0($!$`e/{D'xi]
 //  -~17 *%p"%|N>zq@ %xBD18<Y(fHh`@gu#Z#p"Z<v13fI]':\Iz.17* W:\mwV`z-15g @hUYE { _$~}+X%* nytkW15

 