using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SyntexDirectories
{
    class SyntexDirectories
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("test");
           File.Create("test/output.txt");
            // Directory.CreateDirectory("test/innerTest");
            // Directory.Delete("test/innerTest");
            //   Directory.Delete("test");
            //   Directory.CreateDirectory("first/second/third");
            //   Directory.Move("first", "test");
        var get =    Directory.GetFiles("test");

            Console.WriteLine(get.Length);

            var files = new List<string>();

            foreach (var path in get)
            {
                var separatedFile = path.Split('\\').Last().Split('.').Reverse().Skip(1).Reverse()          ;

                var joinedFile = string.Join(".", separatedFile);

                Console.WriteLine(joinedFile);
            }

              
                
            
                
        }
    }
}
