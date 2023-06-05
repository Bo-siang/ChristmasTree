using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //記錄使用者輸入的聖誕樹層數
                int layer;
                //記錄使用者輸入的聖誕樹風格
                string style;
                
                //重設字體顏色
                Console.ResetColor(); 
                
                //限定使用者輸入的層數範圍
                do
                { 
                    Console.Write("請輸入聖誕樹層數(1-3): ");
                    string test = Console.ReadLine();
                    bool isNum =  int.TryParse(test, out layer); //預防使用者輸入非數值以致程式停止
                    if (isNum == false)
                    {
                        Console.WriteLine("只接受數值型態!");
                    }
                } while (layer > 3 || layer < 1);

                //限定使用者輸入的風格選項
                do
                {
                    Console.Write("請選擇聖誕樹風格(A)傳統紅綠 (B)北歐寧靜 (C)輕奢都會 *大小寫不拘*: ");
                    style = Console.ReadLine();
                } while (!(style.ToUpper() == "A" || style.ToUpper() == "B" || style.ToUpper() == "C"));

                Console.WriteLine();
                //將獲得的引數帶入函式
                printLeaves(layer, style); //印出樹葉部分
                printTrunk(layer); //印出樹幹部分
                Console.WriteLine();
            }
        }


        static void printLeaves(int layer, string style)
        {
            //依據使用者所輸入的層數與風格，繪製聖誕樹葉子部分
            switch (style)
            {
                case "A":
                case "a":
                    //t控制層數，i控制列數，j控制每層列數的留白數量，k控制每層列數的葉子數量
                    for (int t = 1; t <= layer; t++)
                    {
                        //第1層從第1列開始列印
                        if (t == 1)
                        {
                            int i, j, k;
                            for (i = 1; i <= 10; i++)
                            {
                                for (j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (j == 20) //樹頂鈴鐺裝飾
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("@");
                                    }
                                    else
                                    {
                                        if (i % 3 == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.Write("^");
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.Write("^");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        //第2層從第5列開始列印
                        else if (t == 2)
                        {
                            for (int i = 1 + 5; i <= 10 + 5; i++)
                            {

                                for (int j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (i % 3 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("^");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("^");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        //第3層從第10列開始列印
                        else
                        {
                            for (int i = 1 + 5 + 5; i <= 10 + 5 + 5; i++)
                            {

                                for (int j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (i % 3 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("^");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.Write("^");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    break;
                case "B":
                case "b":
                    //t控制層數，i控制列數，j控制每層列數的留白數量，k控制每層列數的葉子數量
                    for (int t = 1; t <= layer; t++)
                    {
                        //第1層從第1列開始列印
                        if (t == 1)
                        {
                            int i, j, k;
                            for (i = 1; i <= 10; i++)
                            {
                                for (j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (j == 20) //樹頂鈴鐺裝飾
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("@");
                                    }
                                    else
                                    {
                                        if (i % 3 == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.Write("^");
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.Write("^");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        //第2層從第5列開始列印
                        else if (t == 2)
                        {
                            for (int i = 1 + 5; i <= 10 + 5; i++)
                            {

                                for (int j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (i % 3 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.Write("^");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.Write("^");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        //第3層從第10列開始列印
                        else
                        {
                            for (int i = 1 + 5 + 5; i <= 10 + 5 + 5; i++)
                            {

                                for (int j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (i % 3 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.Write("^");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.Write("^");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    break;
                case "C":
                case "c":
                    //t控制層數，i控制列數，j控制每層列數的留白數量，k控制每層列數的葉子數量
                    for (int t = 1; t <= layer; t++)
                    {
                        //第1層從第1列開始列印
                        if (t == 1)
                        {
                            int i, j, k;
                            for (i = 1; i <= 10; i++)
                            {
                                for (j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (j == 20)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("@");
                                    }
                                    else
                                    {
                                        if (i % 3 == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.Write("^");
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write("^");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        //第2層從第5列開始列印
                        else if (t == 2)
                        {
                            for (int i = 1 + 5; i <= 10 + 5; i++)
                            {

                                for (int j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (i % 3 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("^");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("^");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                        //第3層從第10列開始列印
                        else
                        {
                            for (int i = 1 + 5 + 5; i <= 10 + 5 + 5; i++)
                            {

                                for (int j = 1; j <= 20 - i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int k = 1; k <= i * 2 - 1; k++)
                                {
                                    if (i % 3 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.Write("^");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.Write("^");
                                    }
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                    break;
            }

        }


        static void printTrunk(int layer)
        {
            if (layer == 1)
            {
                //i控制樹幹列數，j控制每列留白數量，k控制每列樹幹圖示數量
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 17; j++) //第十列空白數量為 20 - 10 = 10 
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 5; k++) //第十列葉子數量為 10 * 2 - 1 = 19
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
            }
            else if (layer == 2)
            {
                //i控制樹幹列數，j控制每列留白數量，k控制每列樹幹圖示數量
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 15; j++) //第十五列空白數量為 20 - 15 = 5 
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 9; k++) //第十五列葉子數量為 15 * 2 - 1 = 29
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                //i控制樹幹列數，j控制每列留白數量，k控制每列樹幹圖示數量
                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 13; j++) //第二十列空白數量為 20 - 20 = 0
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 13; k++) //第二十列葉子數量為 20 * 2 - 1 = 39
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}