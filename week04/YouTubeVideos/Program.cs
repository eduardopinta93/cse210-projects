using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Video Video1 = new Video("Exploring the Amazon Rainforest", "NatureChannel", 720);
        Video Video2 = new Video("Top 10 Programming Tips", "CodeMaster", 600);
        Video Video3 = new Video("The History of Ancient Rome", "HistoryHub", 900);

        Video1.AddComment(new Comment("Andres", "Wow, the rainforest is so beautiful! Thanks for sharing this."));
        Video1.AddComment(new Comment("Carlos", "I learned so much about animals I did not know existed."));
        Video1.AddComment(new Comment("Manuel", "This makes me want to visit the Amazon someday."));

        Video2.AddComment(new Comment("Andreina", "Tip #3 really helped me write cleaner code. Thanks!"));
        Video2.AddComment(new Comment("Carla", "Could you make a follow-up video about debugging?"));
        Video2.AddComment(new Comment("Manuela", "I am a beginner and this was super easy to understand."));

        Video3.AddComment(new Comment("Josefa", "Great video! I love how you explained Roman architecture."));
        Video3.AddComment(new Comment("Martina", "I did not know about the daily life of Roman citizens, fascinating!"));
        Video3.AddComment(new Comment("Chrsitina", "Please make a part two about the Roman Empire."));

        List<Video> videos = new List<Video>();
        videos.Add(Video1);
        videos.Add(Video2);
        videos.Add(Video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}


class Video
{
    string Title;
    string Author;
    int LengthInSeconds;
    List<Comment> Comments = new List<Comment>();
    public Video(string title, string author, int seconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = seconds;
    }
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
    }
}
class Comment
{
    public string CommenterName;
    public string Text;
    public Comment(string commenter, string text)
    {
        CommenterName = commenter;
        Text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"Author: {CommenterName}, Comment: {Text}");
    }
}




