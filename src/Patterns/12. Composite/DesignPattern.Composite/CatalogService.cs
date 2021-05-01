using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    public class CatalogService
    {
        #region 数据
        private static readonly List<Node> _nodes = new List<Node>
        {
            new Node{Id=1,Name="音乐",ParentId=0},
            new Node{Id=2,Name="知识",ParentId=0},
            new Node{Id=3,Name="生活",ParentId=0},

            new Node{Id=4,Name="科学科普",ParentId=2},
            new Node{Id=5,Name="社科人文",ParentId=2},
            new Node{Id=6,Name="职业职场",ParentId=2},
            new Node{Id=7,Name="野生技术协会",ParentId=2},

            new Node{Id=8,Name="搞笑",ParentId=3},
            new Node{Id=9,Name="日常",ParentId=3},

            new Node{Id=10,Name="摄影",ParentId=7},
            new Node{Id=11,Name="编程",ParentId=7},
            new Node{Id=12,Name="英语",ParentId=7},

            new Node{Id=13,Name="科学科普文章1",ParentId=4},
            new Node{Id=14,Name="科学科普文章2",ParentId=4},

            new Node{Id=15,Name="摄影文章1",ParentId=10},

            new Node{Id=16,Name="编程文章1",ParentId=11},
            new Node{Id=17,Name="编程文章2",ParentId=11}
        };
        #endregion
    }
}
