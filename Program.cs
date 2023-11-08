
using System;
using System.IO;
class Program
{
    static void Main()
    {
        string image = "image/bobre.jpg";
        string myString = image.ToString();
        byte[] imageByt = File.ReadAllBytes(image);
        string outputImage = "image/bobre.jpg";
        File.WriteAllBytes(outputImage, imageByt);
        Console.WriteLine("Изображение успешно сохранено по пути: " + outputImage);
    }
} 
