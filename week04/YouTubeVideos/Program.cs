using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Introduction to C#", "John Smith", 600);

        video1.AddComment(new Comment("Michael", "Great tutorial!"));
        video1.AddComment(new Comment("Sarah", "Very helpful."));
        video1.AddComment(new Comment("David", "Thanks for sharing!"));

        Video video2 = new Video(
            "Mountain Biking in Utah", "James Wilson", 850);

        video2.AddComment(new Comment("Daniel", "Amazing trails!"));
        video2.AddComment(new Comment("Emily", "Beautiful scenery."));
        video2.AddComment(new Comment("Lucas", "I want to visit Utah!"));

        Video video3 = new Video(
            "Healthy Meal Prep", "Anna Brown", 720);

        video3.AddComment(new Comment("Robert", "Great recipes!"));
        video3.AddComment(new Comment("Jessica", "Very practical tips."));
        video3.AddComment(new Comment("Peter", "I will try this."));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}