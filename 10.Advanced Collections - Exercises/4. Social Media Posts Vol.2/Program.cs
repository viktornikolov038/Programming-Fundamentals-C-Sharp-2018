using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Social_Media_Posts_Vol._2
{
    class Program
    {
        public static void Main()
        {                              //post         like/dislike/com  /count
            var posts = new Dictionary<string, Dictionary<string, List<string>>>();
            var line = Console.ReadLine();
            while (line != "drop the media")
            {

                var inputParams = line.Split();
                var command = inputParams[0];
                var postName = inputParams[1];
                if (!posts.ContainsKey(postName))
                {
                    posts[postName] = new Dictionary<string, List<string>>();
                }
                if (command == "like")
                {
                    
                    
                        if (!posts[postName].ContainsKey(command))
                        {
                            posts[postName][command] = new List<string>();
                        }
                        posts[postName][command].Add("like");
                    
                }
                else if (command == "dislike")
                {
                    
                    
                        if (!posts[postName].ContainsKey(command))
                        {
                            posts[postName][command] = new List<string>();
                        }
                        posts[postName][command].Add("dislike");
                    
                }
                else if (command == "comment")
                {
                    
                    var commentatorName = inputParams[2];
                    
                    int length = command.Length + postName.Length + commentatorName.Length + 3;
                    var comment = line.Substring(length);
                    if (!posts[postName].ContainsKey(command))
                        {
                            posts[postName][command] = new List<string>();
                        }
                        posts[postName][command].Add($"*  {commentatorName}: {comment}");
                    
                }

                line = Console.ReadLine();

            }

            foreach (var post in posts)
            {
                var likes = 0;
                var dislikes = 0;
                var comments = post.Value;
                foreach (var item in post.Value)
                {
                    if (item.Key == "like")
                    {
                        likes += item.Value.Count;
                    }
                    else if (item.Key == "dislike")
                    {
                        dislikes += item.Value.Count;
                    }
                    
                    
                }
                Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");
                var noComments = true;
                foreach (var comment in comments)
                {
                    if (comment.Key == "comment" && comment.Value.Count > 0)
                    {
                        Console.WriteLine(string.Join(Environment.NewLine,comment.Value));
                        noComments = false;
                    }
                    
                }
                if (noComments)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
