using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un video de ejemplo
        Video video1 = new Video("Cómo programar en C#", "Juan Pérez", 600);

        // Agregar algunos comentarios al video
        video1.AddComment(new Comment("Ana García", "Muy buen tutorial, me ayudó mucho."));
        video1.AddComment(new Comment("Carlos López", "Gracias por compartir esta información."));
        video1.AddComment(new Comment("Laura Gómez", "¡Excelente explicación!"));

        // Mostrar la información del video y los comentarios
        video1.DisplayVideoInfo();

        Console.ReadLine();
    }
}