    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Task04
    {
        class Task04
        {
            static void Main(string[] args)
            {

                var dataBase = new Dictionary<string, Dictionary<string, long>>();

                var casheBase = new Dictionary<string, Dictionary<string, long>>();

                while (true)
                {
                    var input = Console.ReadLine()
                        .Split(new char[] {'|', '>','-',' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    if (input[0]== "thetinggoesskrra")
                    {
                        break;
                    }
                    if (input.Length==1)
                    {
                        var dataSet = input[0];

                        if (!dataBase.ContainsKey(dataSet))
                        {
                            dataBase[dataSet] = new Dictionary<string, long>();

                            if (casheBase.ContainsKey(dataSet))
                            {
                                foreach (var pair in casheBase[dataSet])
                                {
                                    dataBase[dataSet] = casheBase[dataSet];
                                }
                            }
                        }

                    }
                    if (input.Length>1)
                    {
                        var datakey = input[0];

                        var dataSize = int.Parse(input[1]);

                        var dataSet = input[2];

                        if (!dataBase.ContainsKey(dataSet))
                        {
                            if (!casheBase.ContainsKey(dataSet))
                            {
                                casheBase[dataSet] = new Dictionary<string, long>();
                            }
                            casheBase[dataSet][datakey] = dataSize;
                        }
                        else
                        {
                            dataBase[dataSet][datakey] = dataSize;
                        }
                    }
                }

                foreach (var pair in dataBase.OrderByDescending(n=>n.Value.Values.Sum()))
                {
                    Console.WriteLine($"Data Set: {pair.Key}, Total Size: {pair.Value.Values.Sum()}");

                    foreach (var set in pair.Value)
                    {
                        Console.WriteLine($"$.{set.Key}");
                    }
                    break;
                }
            }
        }
    }
