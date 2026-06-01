using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Learn C# in 30 Minutes",
            "Code Academy",
            1800);

        video1.AddComment(
            new Comment("John", "Great tutorial!")
        );

        video1.AddComment(
            new Comment("Sarah", "Very easy to understand.")
        );

        video1.AddComment(
            new Comment("Mike", "Helped me finish my assignment.")
        );

        videos.Add(video1);

        Video video2 = new Video(
            "Top 10 Travel Destinations",
            "Travel World",
            1200);

        video2.AddComment(
            new Comment("Emma", "I want to visit Japan.")
        );

        video2.AddComment(
            new Comment("David", "Amazing video quality.")
        );

        video2.AddComment(
            new Comment("Sophia", "Adding these places to my bucket list.")
        );

        videos.Add(video2);

        Video video3 = new Video(
            "Healthy Meal Prep",
            "Fit Kitchen",
            900);

        video3.AddComment(
            new Comment("Chris", "Looks delicious!")
        );

        video3.AddComment(
            new Comment("Lisa", "Trying this tonight.")
        );

        video3.AddComment(
            new Comment("Brian", "Very helpful tips.")
        );

        videos.Add(video3);

        Video video4 = new Video(
            "Gaming Highlights 2026",
            "Game Zone",
            1500);

        video4.AddComment(
            new Comment("Alex", "Awesome gameplay!")
        );

        video4.AddComment(
            new Comment("Ryan", "That ending was crazy.")
        );

        video4.AddComment(
            new Comment("Kevin", "Can't wait for the next video.")
        );

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetName()}: {comment.GetText()}"
                );
            }

            Console.WriteLine();
        }
    }
}

