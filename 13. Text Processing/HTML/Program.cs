using System;
using System.Collections.Generic;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();

            List<string> comments = new List<string>();

            while (true)
            {
                string comment = Console.ReadLine();

                if (comment == "end of comments")
                {
                    break;
                }

                comments.Add(comment);
            }

            Print(articleTitle, articleContent, comments);
        }

        private static void Print(string title, string content, List<string>comments)
        {
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");

            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

            foreach (var comment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine("</div>");
            }
        }
    }
}
