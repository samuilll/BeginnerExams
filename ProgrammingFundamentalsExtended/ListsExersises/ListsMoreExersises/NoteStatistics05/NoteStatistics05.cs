using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics05
{
    class NoteStatistics05
    {
        static void Main(string[] args)
        {
            var inputfrequencies = Console.ReadLine()
         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Select(double.Parse).
         ToList();

            var Signs = "C   C#   D   D#   E   F   F#   G   G#   A   A# B "
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var Frequencies = "261.63   277.18  293.66   311.13   329.63   349.23   369.99   392.00   415.30   440.00   466.16  493.88"
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(double.Parse)
                  .ToList();

            var AllNotes = new List<string>();

            var naturalNotes = new List<string>();

            var sharpNotes = new List<string>();

            var naturalsSum = 0.0;

            var sharpsSum = 0.0;

            foreach (var frequency in inputfrequencies)

            {
                var indexer = Frequencies.IndexOf(frequency);

                AllNotes.Add(Signs[indexer]);

                if (Signs[indexer].Contains("#"))
                {
                    sharpNotes.Add(Signs[indexer]);

                    sharpsSum += Frequencies[indexer];

                }
                else
                {
                    naturalNotes.Add(Signs[indexer]);

                    naturalsSum += Frequencies[indexer];
                }


            }



            Console.WriteLine("Notes: {0}", string.Join(" ", AllNotes));

            Console.WriteLine("Naturals: {0}", string.Join(", ", naturalNotes));

            Console.WriteLine("Sharps: {0}", string.Join(", ", sharpNotes));

            Console.WriteLine("Naturals sum: {0}", naturalsSum);

            Console.WriteLine("Sharps sum: {0}", sharpsSum);

        }
    }
}
