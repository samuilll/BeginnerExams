using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        var command = Console.ReadLine().Split();

        var likesList = new Dictionary<string, int[]>();

        var commentList = new Dictionary<string, Dictionary<string,string>>();

        while (command[0] != "drop")
        {
            switch (command[0])
            {
                case "post":
                    {
                        ImplementThePostFunction(likesList, commentList, command); break;
                    }
                case "like":
                    {
                        ImplementTheLikeFunction(likesList, command);
                        break;
                    }
                case "dislike":
                    {
                        ImplementTheDisLikeFunction(likesList, command);
                        break;
                    }
                case "comment":
                    {
                        ImplementTheCommentFunction(likesList, commentList, command);
                        break;
                    }
            }

            command = Console.ReadLine().Split();
        }

        PrintTheResult(likesList, commentList);
    }

    private static void PrintTheResult(Dictionary<string, int[]> likesList, Dictionary<string, Dictionary<string,string>> commentList)
    {
        foreach (var post in likesList.Keys)
        {
            Console.WriteLine($"Post: {post} | Likes: {likesList[post][0]} | Dislikes: {likesList[post][1]}");

            Console.WriteLine("Comments:");

            if (commentList.ContainsKey(post))
            {

                foreach (var person in commentList[post].Keys)
                {
                    Console.WriteLine($"*  {person}: {commentList[post][person]}");
                }
            }
            else 
            {
                Console.WriteLine("None");
            }
        }
    }

    private static void ImplementTheCommentFunction(Dictionary<string, int[]> likesList, 
        Dictionary<string, Dictionary<string,string>> commentList, string[] command)
    {
        var postName = command[1];

        var person = command[2];

        var comment = string.Join(" ", command,3,command.Length-3);

        

        if (likesList.ContainsKey(postName))
        {
            if (!commentList.ContainsKey(postName))
            {
                commentList[postName] = new Dictionary<string, string>();

            }

            commentList[postName][person] = comment;
        }
    }

    private static void ImplementTheDisLikeFunction(Dictionary<string, int[]> likesList, string[] command)
    {
        var postName = command[1];

        if (likesList.ContainsKey(postName))
        {
            likesList[postName][1]++;
        }
    }

    private static void ImplementTheLikeFunction(Dictionary<string, int[]> likesList, string[] command)
    {
        var postName = command[1];

        if (likesList.ContainsKey(postName))
        {
            likesList[postName][0]++;
        }
    }

    private static void ImplementThePostFunction(Dictionary<string, int[]> likesList, Dictionary<string, Dictionary<string, string>> commentList, string[] command)
    {
        var postName = command[1];
        if (!likesList.ContainsKey(postName))
        {
            likesList[postName] = new int[] { 0, 0 };
        }
       
    }
}

