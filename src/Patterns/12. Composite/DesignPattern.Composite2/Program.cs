using System;

namespace DesignPattern.Composite2
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("目录");

            Composite music = new Composite("音乐");
            Composite knowledge = new Composite("知识");
            Composite life = new Composite("生活");
            root.Add(music);
            root.Add(knowledge);
            root.Add(life);

            Composite science = new Composite("科学科普");
            Composite tech = new Composite("野生技术协会");
            knowledge.Add(science);
            knowledge.Add(tech);

            Component scienceArticle1 = new Leaf("科学科普文章1");
            Component scienceArticle2 = new Leaf("科学科普文章2");
            science.Add(scienceArticle1);
            science.Add(scienceArticle2);

            Composite shoot = new Composite("摄影");
            Composite program = new Composite("编程");
            Composite english = new Composite("英语");
            tech.Add(shoot);
            tech.Add(program);
            tech.Add(english);

            Component shootArticle1 = new Leaf("摄影文章1");
            Component lifeArticle1 = new Leaf("生活文章1");
            Component lifeArticle2 = new Leaf("生活文章2");
            shoot.Add(shootArticle1);
            life.Add(lifeArticle1);
            life.Add(lifeArticle2);

            root.Display(0);
            Console.WriteLine("文章数：" + root.SumArticleCount());
        }
    }
}
