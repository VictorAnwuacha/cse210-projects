using System;
using System.Collections.Generic;

// Comment class to store commenter's name and the comment text
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    // Constructor to initialize a comment with the name and text
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

    // Override ToString method to display comment in a readable format
    public override string ToString()
    {
        return $"{CommenterName}: {Text}";
    }
}

// Video class to store video details and the list of comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Video length in seconds
    private List<Comment> Comments { get; set; } // List to store comments

    // Constructor to initialize video with title, author, and length
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>(); // Initialize the comment list
    }

    // Method to add a comment to the video
    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    // Method to get the total number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display video information including its comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"  - {comment}"); 
        }
        Console.WriteLine("--------------------------------------");
    }
}

// Main program to create videos and display their information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Videos Project");

        List<Video> videos = new List<Video>(); // List to store video objects

        // Create video objects
        Video video1 = new Video("Exploring New Tech Gadgets", "Sophia Lee", 320);
        video1.AddComment("Ethan", "This is a great review, I love the tech gadgets shown!");
        video1.AddComment("Olivia", "I’m thinking of buying that gadget, it looks cool.");
        video1.AddComment("Liam", "Thanks for the review, it really helped me decide.");

        Video video2 = new Video("Samsung Galaxy S22 Unboxing", "Lucas Smith", 380);
        video2.AddComment("Mia", "Can’t wait to try this phone, looks amazing!");
        video2.AddComment("James", "Is the camera really that good? I’m curious.");
        video2.AddComment("Chloe", "I think this is the phone I’ll buy next!");

        Video video3 = new Video("Understanding Artificial Intelligence", "Aiden Brown", 500);
        video3.AddComment("Amelia", "This is so informative! I love tech videos like this.");
        video3.AddComment("Benjamin", "AI is going to change everything, I’m so excited!");
        video3.AddComment("Isabella", "Do you think AI will become more advanced than humans?");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video in the list
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
