class Video
{
    private string title;
    private string author;
    private double duration;
    private List<Comment> comments;

    public Video(string _title, string _author, double _duration)
    {
        title = _title;
        author = _author;
        duration = _duration;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Duration: {duration} minuts");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
    }
}