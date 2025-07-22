using System;
using System.Collections.Generic;

class Program
{
    class Comment
    {
        public string name;
        public string text;
    }

    class Video
    {
        public string title;
        public string author;
        public int length;
        public List<Comment> comments = new List<Comment>();
    }

    static void Main()
    {
        // Create video 1
        Video v1 = new Video();
        v1.title = "Learn C# Basics";
        v1.author = "CodeTutor";
        v1.length = 300;
        v1.comments.Add(new Comment { name = "Alice", text = "Very helpful!" });
        v1.comments.Add(new Comment { name = "Bob", text = "Thanks for the tips!" });

        // Create video 2
        Video v2 = new Video();
        v2.title = "Top 5 Gadgets 2025";
        v2.author = "TechZone";
        v2.length = 420;
        v2.comments.Add(new Comment { name = "Cara", text = "Love the drone!" });
        v2.comments.Add(new Comment { name = "Dan", text = "Cool picks." });

        // Create video list
        List<Video> videos = new List<Video> { v1, v2 };

        // Display info
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.title}");
            Console.WriteLine($"Author: {v.author}");
            Console.WriteLine($"Length: {v.length} seconds");
            Console.WriteLine($"Comments: {v.comments.Count}");
            foreach (Comment c in v.comments)
            {
                Console.WriteLine($"- {c.name}: {c.text}");
            }
            Console.WriteLine();
        }
    }
}
