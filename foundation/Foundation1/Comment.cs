class Comment
{
    private string author;
    private string text;

    public Comment(string _author, string _text)
    {
        author = _author;
        text = _text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Autor: {author}, Comentario: {text}");
    }
}