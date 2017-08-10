using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _5_ForumTopics
{
    static void Main(string[] args)
    {

        var input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        var topicsList = new Dictionary<string, HashSet<string>>();

        while (input[0] != "filter")
        {
            var topic = input[0];

            var tagsList = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            AddTheTopic(topicsList, topic, tagsList);

            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }

        var searchedTags = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        PrintTheSearchedTopics(topicsList, searchedTags);
    }

    private static void PrintTheSearchedTopics(Dictionary<string, HashSet<string>> topicsList, string[] searchedTags)
    {
        foreach (var topic  in topicsList.Keys)
        {
            var check = true;
            foreach (var tag in searchedTags)
            {              
                if (!topicsList[topic].Contains(tag))
                {
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine("{0} | {1}",topic,string.Join(", ",topicsList[topic].Select(a => string.Format("#{0}",a))));
            }
        }
    }

    private static void AddTheTopic(Dictionary<string, HashSet<string>> topicsList, string topic, string[] tagsList)
    {
        if (!topicsList.ContainsKey(topic))
        {
            topicsList[topic] = new HashSet<string>();
        }

        for (int i = 0; i < tagsList.Length; i++)
        {
            topicsList[topic].Add(tagsList[i]);
        }
    }
}

