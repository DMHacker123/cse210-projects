using System;
using System.Collections.Generic;

//
// CLASS: Comment
// RESPONSIBILITY: Store the name and text of a comment.
//
class Comment
{
    // --- Attributes (Member Variables) ---
    public string Name;   // Commenter's name
    public string Text;   // Comment text

    // --- Constructor ---
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

//
// CLASS: Video
// RESPONSIBILITY: Store video info and a list of comments.
//
class Video
{
    // --- Attributes (Member Variables) ---
    public string Title;             // Video title
    public string Author;            // Author/uploader
    public int LengthInSeconds;      // Length in seconds
    private List<Comment> comments;  // List of Comment objects

    // --- Constructor ---
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        LengthInSeconds = length;
        comments = new List<Comment>();
    }

    // --- Behavior: Add a new comment ---
    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    // --- Behavior: Get number of comments ---
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // --- Behavior: Get the list of comments ---
    public List<Comment> GetComments()
    {
        return comments;
    }
}

//
// CLASS: Program
// RESPONSIBILITY: Run the app and demonstrate object interactions.
//
class Program
{
    static void Main()
    {
        // --- Create 3 Video objects ---
        Video v1 = new Video("Learn C# Basics", "CodeTutor", 300);
        Video v2 = new Video("Top 5 Gadgets 2025", "TechZone", 420);
        Video v3 = new Video("Travel Vlog: Italy", "WanderLust", 500);

        // --- Add 3 Comments per Video ---
        v1.AddComment("Alice", "Very helpful!");
        v1.AddComment("Bob", "Thanks for the tips!");
        v1.AddComment("Cara", "Easy to follow!");

        v2.AddComment("Dan", "Cool picks.");
        v2.AddComment("Eva", "Love the drone!");
        v2.AddComment("Finn", "Great editing!");

        v3.AddComment("Grace", "Beautiful views!");
        v3.AddComment("Henry", "I want to go now!");
        v3.AddComment("Isla", "This is so relaxing.");

        // --- Store videos in a list ---
        List<Video> videos = new List<Video> { v1, v2, v3 };

        // --- Display video info and comments ---
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
