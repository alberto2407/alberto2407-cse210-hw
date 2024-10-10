class Video
{
    private string title;
    private string author;
    private int duration;
    private List<Comment> comments;

    public Video(string _title, string _author, int _duration)
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
        Console.WriteLine($"Título: {title}, Autor: {author}, Duración: {duration} segundos");
        Console.WriteLine($"Cantidad de comentarios: {GetCommentCount()}");
        foreach (var comment in comments)
        {
            comment.DisplayComment();
        }
    }
}