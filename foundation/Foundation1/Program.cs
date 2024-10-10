using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to programm in C#", "John Perkins", 10);
        Video video2 = new Video("Introduction to C#", "Bob Doe", 5);
        Video video3 = new Video("C# for beginners", "Emily Brown", 3.3);
        Video video4 = new Video("Using VS Code", "David Smith", 1.6);

        video1.AddComment(new Comment("Anna Johnson", "Very good tutorial, it helped me a lot."));
        video1.AddComment(new Comment("Charles Beckman", "Thank you for sharing this information."));
        video1.AddComment(new Comment("Laura Schmidt", "Excellent explanation!\n"));

        video2.AddComment(new Comment("David Smith", "I love this video!"));
        video2.AddComment(new Comment("John Doe", "I'm so happy to be learning with this video."));
        video2.AddComment(new Comment("Emily Brown", "I can't wait to try this out!\n"));

        video3.AddComment(new Comment("Sarah Thompson", "I'm so jealous of this tutorial!"));
        video3.AddComment(new Comment("Michael Johnson", "I'm so excited for this new feature!"));
        video3.AddComment(new Comment("George Williams", "It's a great video!\n"));

        video4.AddComment(new Comment("Jacob Christensen", "What a fantastic tutorial!"));
        video4.AddComment(new Comment("Louis Wright", "Fantastic video!"));
        video4.AddComment(new Comment("Frankie Gardner", "Great tutorial!"));

        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
        video4.DisplayVideoInfo();
    }
}