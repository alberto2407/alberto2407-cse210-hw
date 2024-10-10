class Comment
{
    private string author;
    private string comment;

    public Comment(string _author, string _comment)
    {
        author = _author;
        comment = _comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Author: {author}, Comment: {comment}");
    }
}