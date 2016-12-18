using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckDraw
{
    class Program
    {
        public static void GetAreaChance(Random rnd, out bool outResult)
        {
            outResult = false;
            var list = new[] {
                new {chance=0.4999f,changceName="钢笔"},
                new {chance=0.40f,changceName="1000元加油券"},
                new {chance=0.10f,changceName="苹果ipad"},
                new {chance=0.0001f,changceName="苹果7"},
            };
            var test = list.Select(t => t.chance).ToList();
            if (test.Sum() != 1) {
                outResult = true;
                Console.WriteLine("中奖率应该等于1");
                return;
            }
            //各个概率区域
            //float[] area = { 0.49f, 0.40f, 0.10f, 0.01f };
            var area = test;
            int multiple = 1000000;
            //总和
            int totalChance = (int)area.Sum() * multiple;
            //倍数

            //概率总和
            var x = (float)rnd.Next(0, totalChance) / multiple;//生成的随机数

            var result = 0;
            var winningDomnLimit = 0f;
            var winningUpperLimit = 0f;
            var prize = "";
            for (int i = 0; i < area.Count(); i++)
            {
                //下限
                var domnLimit = area.Take(i).Sum();
                //上限(取下线到上限的和)
                var upperLimit = area.Take(i + 1).Sum();
                if (x >= domnLimit && x < upperLimit)
                {
                    result = i;
                    winningDomnLimit = domnLimit;
                    winningUpperLimit = upperLimit;
                    prize = list[i].changceName;
                    Console.WriteLine("随机数" + x + " 区域：" + result + "中奖率区域：" + winningDomnLimit + "~" + winningUpperLimit + " 奖品： " + prize);
                    if (result == 3)
                    {
                        outResult = true;
                        return;
                    }

                }
            }
            
            System.Threading.Thread.Sleep(1);
        }
        static void Main(string[] args)
        {

            TestCount();
            Console.ReadKey();
        }

        public static void TestCount()
        {
            Random rnd = new Random();
            int count = 0;
            bool outResult = false;
            for (int i = 0; i < 1000000; i++)
            {
                GetAreaChance(rnd, out outResult);
                count = i;
                if (outResult == true)
                {
                    Console.WriteLine("第:" + count + "次中奖");
                    return;
                }
            }
        }

        //private static Random rnd = new Random();
        ///// <summary>
        ///// 获取抽奖结果
        ///// </summary>
        ///// <param name="prob">各物品的抽中概率</param>
        ///// <returns>返回抽中的物品所在数组的位置</returns>
        //private static int Get(float[] prob)
        //{
        //    int result = 0;
        //    int n = (int)(prob.Sum() * 1000);           //计算概率总和，放大1000倍
        //    Random r = rnd;
        //    Console.WriteLine("随机数" + r);
        //    float x = (float)r.Next(0, n) / 1000;       //随机生成0~概率总和的数字
        //    Console.WriteLine(" x：" + x);
        //    for (int i = 0; i < prob.Count(); i++)
        //    {
        //        float pre = prob.Take(i).Sum();         //区间下界
        //        float next = prob.Take(i + 1).Sum();    //区间上界
        //        if (x >= pre && x < next)               //如果在该区间范围内，就返回结果退出循环
        //        {
        //            result = i;
        //            break;
        //        }
        //    }
        //    return result;
        //}
    }
}
