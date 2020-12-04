using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console
                          .ReadLine()
                          .Split(", ")
                          .ToArray();
            int count = int.Parse(Console.ReadLine());
            Article article = new Article(input[0], input[1], input[2] );
            for (int i = 0; i < count; i++)
            {
                string[] cmdArg = Console
                          .ReadLine()
                          .Split(": ")
                          .ToArray();
                if (cmdArg[0] == "Edit")
                {
                    article.Edit(cmdArg[1]);
                }
                else if (cmdArg[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(cmdArg[1]);
                }
                else
                {
                    article.Rename(cmdArg[1]);
                }
            }
            Console.WriteLine(article);

        }
        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string
                content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public void Edit(string content)
            {
                this.Content = content;
            }
            public void ChangeAuthor(string author)
            {
                this.Author = author;
            }
            public void Rename(string title)
            {
                this.Title = title;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
