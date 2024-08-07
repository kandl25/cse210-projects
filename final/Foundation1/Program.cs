using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Transformed Through the Love of Jesus Christ", "Dieter F. Uchtdorf", 146);
        Video video2 = new Video("Savior of My Soul", "Ellie Barry", 223);
        Video video3 = new Video("Swan Lake", "Royal Ballet and Opera", 519);

        video1.AddComment(new Comment("Luke", "Awesome video!"));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));
        video1.AddComment(new Comment("Ashlan", "Love this message."));

        video2.AddComment(new Comment("Branson", "Loved this video!"));
        video2.AddComment(new Comment("Jacob", "Great content!"));
        video2.AddComment(new Comment("Nici", "Helped a lot."));

        video3.AddComment(new Comment("Victor", "Well explained."));
        video3.AddComment(new Comment("Darrell", "Really enjoyable"));
        video3.AddComment(new Comment("Alicia", "Good Job."));

        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}