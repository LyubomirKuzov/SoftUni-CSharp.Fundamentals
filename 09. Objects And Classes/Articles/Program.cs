using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleArgs = Console.ReadLine()
                .Split(", ")
                .ToArray();

            string title = articleArgs[0];
            string content = articleArgs[1];
            string author = articleArgs[2];

            Article article = new Article(title, content, author);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ")
                    .ToArray();

                string commandType = command[0];
                string newValue = command[1];

                switch (commandType)
                {
                    case "Edit":
                        article.Edit(newValue);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(newValue);
                        break;

                    case "Rename":
                        article.Rename(newValue);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }



        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }



        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
