using System;
using System.IO;

namespace DesignPattern.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("目录");

            Component music = new Composite("音乐");
            Component knowledge = new Composite("知识");
            Component life = new Composite("生活");
            root.Add(music);
            root.Add(knowledge);
            root.Add(life);

            Component science = new Composite("科学科普");
            Component tech = new Composite("野生技术协会");
            knowledge.Add(science);
            knowledge.Add(tech);

            Component scienceArticle1 = new Leaf("科学科普文章1");
            Component scienceArticle2 = new Leaf("科学科普文章2");
            science.Add(scienceArticle1);
            science.Add(scienceArticle2);

            Component shoot = new Composite("摄影");
            Component program = new Composite("编程");
            Component english = new Composite("英语");
            tech.Add(shoot);
            tech.Add(program);
            tech.Add(english);

            Component shootArticle1 = new Leaf("摄影文章1");
            Component lifeArticle1 = new Leaf("生活文章1");
            Component lifeArticle2 = new Leaf("生活文章2");
            shoot.Add(shootArticle1);
            life.Add(lifeArticle1);
            life.Add(lifeArticle2);

            tech.Remove(program);
            knowledge.Display(0);
            Console.WriteLine("文章数："+ knowledge.SumArticleCount());
        }
    }
}
