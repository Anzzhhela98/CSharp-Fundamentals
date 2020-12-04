using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Article> myListArticle = new List<Article>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console
                          .ReadLine()
                          .Split(", ")
                          .ToArray();
                Article article = new Article(input[0], input[1], input[2]);
                myListArticle.Add(article);
            }
            string type = Console.ReadLine();
            if (type == "title")
            {
                myListArticle = myListArticle.OrderBy(x => x.Title).ToList();

            }
            else if (type == "author")
            {
                myListArticle = myListArticle.OrderBy(x => x.Author).ToList();
            }
            else
            {
                myListArticle = myListArticle.OrderBy(x => x.Content).ToList();
            }
            myListArticle.ForEach(x => Console.WriteLine(x));
            //foreach (var info in myListArticle)
            //{

            //    Console.WriteLine(info.ToString());
            //}
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
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
