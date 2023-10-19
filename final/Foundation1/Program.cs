using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._author = "John Lee";
        video1._title = "Shades of life";
        video1._length = 56;
        video1._comments = new List<Comment>();

        Comment video1Comment1 = new Comment();
        video1Comment1._commentorName = "Bruce Wayne";
        video1Comment1._comment = "Interesting video";

        Comment video1Comment2 = new Comment();
        video1Comment2._commentorName = "Alex Jones";
        video1Comment2._comment = "It was quite the take on life";

        Comment video1Comment3 = new Comment();
        video1Comment3._commentorName = "Russel Reed";
        video1Comment3._comment = "Wow, absolute nonsense!";

        video1._comments.Add(video1Comment1);
        video1._comments.Add(video1Comment2);
        video1._comments.Add(video1Comment3);


        Video video2 = new Video();
        video2._author = "Alex Mac";
        video2._title = "How to build a tiny house";
        video2._length = 3042;
        video2._comments = new List<Comment>();

        Comment video2Comment1 = new Comment();
        video2Comment1._commentorName = "Gaby Jonstone";
        video2Comment1._comment = "I will definetly be sharing this";

        Comment video2Comment2 = new Comment();
        video2Comment2._commentorName = "Sakhile Mamba";
        video2Comment2._comment = "Tiny house are fun";

        Comment video2Comment3 = new Comment();
        video2Comment3._commentorName = "Mfundo Dlamini";
        video2Comment3._comment = "I can't wait to start building my own tiny house.";

        video2._comments.Add(video2Comment1);
        video2._comments.Add(video2Comment2);
        video2._comments.Add(video2Comment3);


        Video video3 = new Video();
        video3._author = "Sandy Whitweather";
        video3._title = "Arm wrestling for girls";
        video3._length = 1530;
        video3._comments = new List<Comment>();

        Comment video3Comment1 = new Comment();
        video3Comment1._commentorName = "April James";
        video3Comment1._comment = "I'd like to try it out'";

        Comment video3Comment2 = new Comment();
        video3Comment2._commentorName = "Alexis Jones";
        video3Comment2._comment = "Is this a professional sport now?";

        Comment video3Comment3 = new Comment();
        video3Comment3._commentorName = "Branden Shoulder";
        video3Comment3._comment = "These girls are strong!";

        video3._comments.Add(video3Comment1);
        video3._comments.Add(video3Comment2);
        video3._comments.Add(video3Comment3);

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        Console.Clear();
        for (int i = 0; i < videos.Count; i++)
        {

            Console.WriteLine($"Title: {videos[i]._title}");
            Console.WriteLine($"Author: {videos[i]._author}");
            Console.WriteLine($"Length (Seconds): {videos[i]._length}");
            Console.WriteLine($"Number of Comments: {videos[i].NumberOfComments()}");

            Console.WriteLine();
            Console.WriteLine("Video Comments:");

            foreach (Comment comment in videos[i]._comments)
            {
                Console.WriteLine($"{comment._commentorName} - '{comment._comment}'");
            }

            Console.WriteLine();
            if (i < videos.Count - 1)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}