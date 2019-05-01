﻿using StragetyPattern.RealWord;
using System;

namespace StragetyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //要点: 定义一系列算法，把它们一个个封装起来，并且使它们可互相替换。该模式使得算法可独立于使用它的客户而变化。　　　　　　                             
            //                                                                          ——《设计模式》GoF

            //1.这里我们定义了一系列的路线算法，然后用一个路线接口约束，这样的话使用不同的实现就可以互相替换了，使得算法可以独立于使用它的客户而变化
            //2.其实策略模式算是比较简单的一个模式，没有过多的嵌套和抽象，非常直观。

            //使用距离最短策略
            Navigator navigator1 = new Navigator("郑州", "北京", new DistanceShortestRouter());
            navigator1.DisplayRoute();

            Console.WriteLine("==============================");

            //使用红绿灯最少策略
            Navigator navigator2 = new Navigator("郑州", "北京", new LightLeastRouter());
            navigator2.DisplayRoute();

            Console.WriteLine("==============================");

            //使用收费最少策略
            Navigator navigator3 = new Navigator("郑州", "北京", new FeeLeastRouter());
            navigator3.DisplayRoute();

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
