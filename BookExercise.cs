BookExercise.cs


using System;

namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book B = new Book("Sciences", "Abdo", 10.5);
            Book B2 = new Book("Math", "Ahmed", 11.5);
            Console.WriteLine(B.DisplayInfo());
            Console.Write("***************************\n");
            Console.WriteLine(B2.DisplayInfo());
            Console.ReadKey();
        }
    } 

    public class Book
    {
        public string Tital;
        public string Author;
        public double price;

        public Book(string Tital, string Author, double price)
        {
            this.Tital = Tital;
            this.Author = Author;
            this.price = price;
        }

        public string DisplayInfo()
        {
            return $"Title : {Tital}\nAuthor : {Author}\nPrice : {price}";
        }
    }
}