using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
 
            int articlesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < articlesCount; i++)
            {
                string[] articleArgs = Console.ReadLine()
                            .Split(", ")
                            .ToArray();

                string title = articleArgs[0];
                string content = articleArgs[1];
                string author = articleArgs[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string filterOption = Console.ReadLine();

            articles = filterOption switch
            {
                "title" => articles.OrderBy(a => a.Title).ToList(),
                "content" => articles.OrderBy(a => a.Content).ToList(),
                "author" => articles.OrderBy(a => a.Author).ToList()
            };

            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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



        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
